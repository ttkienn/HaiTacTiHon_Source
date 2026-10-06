package core;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import database.SQL;
import java.io.IOException;
import java.net.URLDecoder;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardOpenOption;
import java.security.MessageDigest;
import java.security.SecureRandom;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.HexFormat;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;

/** Local-only admin UI. The key is generated once in private-server/admin.key. */
public final class AdminWeb implements HttpHandler {
    private static final SecureRandom RANDOM = new SecureRandom();
    private final Map<String, AdminSession> sessions = new ConcurrentHashMap<>();
    private final byte[] adminKey;

    private record AdminSession(String csrf, long expiresAt) {}

    public AdminWeb() throws IOException {
        Path keyFile = Path.of("admin.key");
        if (!Files.exists(keyFile)) {
            byte[] random = new byte[32];
            RANDOM.nextBytes(random);
            try {
                Files.writeString(keyFile, HexFormat.of().formatHex(random) + System.lineSeparator(),
                    StandardCharsets.US_ASCII, StandardOpenOption.CREATE_NEW);
            } catch (java.nio.file.FileAlreadyExistsException ignored) {
                // Another process created the key first.
            }
        }
        String key = Files.readString(keyFile, StandardCharsets.US_ASCII).trim();
        if (!key.matches("[0-9a-f]{64}")) throw new IOException("Invalid admin.key");
        adminKey = key.getBytes(StandardCharsets.US_ASCII);
    }

    @Override
    public void handle(HttpExchange ex) throws IOException {
        try {
            String path = ex.getRequestURI().getPath();
            String method = ex.getRequestMethod();
            String host = ex.getRequestHeaders().getFirst("Host");
            if (!("127.0.0.1:2237".equalsIgnoreCase(host) || "localhost:2237".equalsIgnoreCase(host))
                || !ex.getRemoteAddress().getAddress().isLoopbackAddress()) {
                send(ex, 403, "Chỉ truy cập từ máy này tại http://127.0.0.1:2237/admin");
                return;
            }
            ex.getResponseHeaders().set("Cache-Control", "no-store");
            ex.getResponseHeaders().set("X-Content-Type-Options", "nosniff");
            ex.getResponseHeaders().set("Referrer-Policy", "no-referrer");
            ex.getResponseHeaders().set("Content-Security-Policy",
                "default-src 'none'; style-src 'unsafe-inline'; form-action 'self'; base-uri 'none'; frame-ancestors 'none'");
            if ("GET".equals(method) && ("/admin".equals(path) || "/admin/".equals(path))) {
                AdminSession session = session(ex);
                send(ex, 200, session == null ? loginPage("") : dashboard(session, query(ex, "q"), query(ex, "ok")));
                return;
            }
            if (!"POST".equals(method) || !path.startsWith("/admin/")) {
                send(ex, 404, "Not found");
                return;
            }
            if (!("http://" + host).equalsIgnoreCase(ex.getRequestHeaders().getFirst("Origin"))
                || !String.valueOf(ex.getRequestHeaders().getFirst("Content-Type")).startsWith("application/x-www-form-urlencoded")) {
                send(ex, 403, "Forbidden");
                return;
            }
            Map<String, String> form = form(ex);
            if ("/admin/login".equals(path)) {
                String supplied = form.getOrDefault("key", "");
                if (supplied.length() == 64 && MessageDigest.isEqual(adminKey, supplied.getBytes(StandardCharsets.US_ASCII))) {
                    String token = randomHex();
                    sessions.put(token, new AdminSession(randomHex(), System.currentTimeMillis() + 8 * 60 * 60 * 1000L));
                    ex.getResponseHeaders().add("Set-Cookie", "htth_admin=" + token + "; HttpOnly; SameSite=Strict; Path=/admin");
                    redirect(ex, "/admin");
                } else {
                    send(ex, 401, loginPage("Khóa quản trị không đúng."));
                }
                return;
            }
            AdminSession session = session(ex);
            if (session == null || !session.csrf().equals(form.get("csrf"))) {
                send(ex, 403, "Phiên đăng nhập không hợp lệ.");
                return;
            }
            if ("/admin/logout".equals(path)) {
                sessions.remove(cookie(ex));
                ex.getResponseHeaders().add("Set-Cookie", "htth_admin=; Max-Age=0; HttpOnly; SameSite=Strict; Path=/admin");
                redirect(ex, "/admin");
            } else if ("/admin/notice".equals(path)) {
                String message = form.getOrDefault("message", "").trim();
                if (message.isEmpty() || message.length() > 200) { send(ex, 400, "Thông báo phải dài 1–200 ký tự."); return; }
                JSONObject data = new JSONObject();
                data.put("message", message);
                data.put("type", 0);
                data.put("color", 5);
                queue("SEND_NOTICE", null, data.toJSONString());
                redirect(ex, "/admin?ok=notice");
            } else if ("/admin/kick".equals(path)) {
                String character = form.getOrDefault("character", "").trim();
                if (character.isEmpty() || character.length() > 50) { send(ex, 400, "Tên nhân vật không hợp lệ."); return; }
                queue("KICK", character, "{}");
                redirect(ex, "/admin?ok=kick");
            } else if ("/admin/lock".equals(path)) {
                String username = form.getOrDefault("username", "").trim();
                String value = form.getOrDefault("value", "");
                if (username.isEmpty() || username.length() > 255 || !("0".equals(value) || "1".equals(value))) {
                    send(ex, 400, "Yêu cầu không hợp lệ."); return;
                }
                try (Connection db = SQL.gI().getCon();
                     PreparedStatement ps = db.prepareStatement(
                         "UPDATE accounts SET `lock`=? WHERE BINARY `user`=? AND admin=0 AND note IS NULL")) {
                    ps.setInt(1, Integer.parseInt(value));
                    ps.setString(2, username);
                    if (ps.executeUpdate() != 1) { send(ex, 404, "Không tìm thấy tài khoản thường."); return; }
                }
                redirect(ex, "/admin?ok=lock");
            } else {
                send(ex, 404, "Not found");
            }
        } catch (IllegalArgumentException e) {
            send(ex, 400, "Yêu cầu không hợp lệ.");
        } catch (Exception e) {
            e.printStackTrace();
            send(ex, 500, "Lỗi máy chủ. Xem logs/server-error.log.");
        } finally {
            ex.close();
        }
    }

    private static void queue(String command, String target, String data) throws SQLException {
        try (Connection db = SQL.gI().getCon();
             PreparedStatement ps = db.prepareStatement(
                 "INSERT INTO web_admin_commands (command,target_user,data,status) VALUES (?,?,?,0)")) {
            ps.setString(1, command);
            ps.setString(2, target);
            ps.setString(3, data);
            ps.executeUpdate();
        }
    }

    private static Map<String, String> form(HttpExchange ex) throws IOException {
        byte[] bytes = ex.getRequestBody().readNBytes(4097);
        if (bytes.length > 4096) throw new IllegalArgumentException("Form too large");
        return decode(new String(bytes, StandardCharsets.UTF_8));
    }

    private static String query(HttpExchange ex, String key) {
        return decode(ex.getRequestURI().getRawQuery()).getOrDefault(key, "");
    }

    private static Map<String, String> decode(String raw) {
        Map<String, String> result = new HashMap<>();
        if (raw == null) return result;
        for (String part : raw.split("&")) {
            int equals = part.indexOf('=');
            if (equals < 0) continue;
            result.put(URLDecoder.decode(part.substring(0, equals), StandardCharsets.UTF_8),
                URLDecoder.decode(part.substring(equals + 1), StandardCharsets.UTF_8));
        }
        return result;
    }

    private AdminSession session(HttpExchange ex) {
        String token = cookie(ex);
        AdminSession session = sessions.get(token);
        if (session != null && session.expiresAt() <= System.currentTimeMillis()) {
            sessions.remove(token);
            return null;
        }
        return session;
    }

    private static String cookie(HttpExchange ex) {
        String header = ex.getRequestHeaders().getFirst("Cookie");
        if (header == null) return "";
        for (String part : header.split(";")) {
            String item = part.trim();
            if (item.startsWith("htth_admin=")) return item.substring("htth_admin=".length());
        }
        return "";
    }

    private static String randomHex() {
        byte[] bytes = new byte[32];
        RANDOM.nextBytes(bytes);
        return HexFormat.of().formatHex(bytes);
    }

    private static String esc(String value) {
        if (value == null) return "";
        return value.replace("&", "&amp;").replace("<", "&lt;").replace(">", "&gt;")
            .replace("\"", "&quot;").replace("'", "&#39;");
    }

    private static void redirect(HttpExchange ex, String path) throws IOException {
        ex.getResponseHeaders().set("Location", path);
        ex.sendResponseHeaders(303, -1);
    }

    private static void send(HttpExchange ex, int status, String body) throws IOException {
        byte[] bytes = body.getBytes(StandardCharsets.UTF_8);
        ex.getResponseHeaders().set("Content-Type", "text/html; charset=utf-8");
        ex.sendResponseHeaders(status, bytes.length);
        ex.getResponseBody().write(bytes);
    }

    private static String shell(String title, String content) {
        return """
            <!doctype html><html lang="vi"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1">
            <title>HTTH Admin</title><style>
            :root{font-family:Segoe UI,Arial,sans-serif;color:#ecf4ff;background:#07111e}*{box-sizing:border-box}
            body{margin:0;background:radial-gradient(circle at 70% 0,#12395b 0,#07111e 46%);min-height:100vh}
            a{color:#8ddcff;text-decoration:none}a:hover{text-decoration:underline}header{border-bottom:1px solid #254662;background:#0a1b2ecc}
            .wrap{max-width:1180px;margin:auto;padding:24px}header .wrap{display:flex;align-items:center;justify-content:space-between;gap:16px}
            .brand{font-size:20px;font-weight:800;letter-spacing:.04em}.brand span{color:#6ed8ff}.muted{color:#9bb4ca}
            h1{font-size:28px;margin:8px 0 6px}h2{font-size:18px;margin:0 0 18px}.lead{color:#9bb4ca;margin:0 0 26px}
            .grid{display:grid;grid-template-columns:repeat(3,1fr);gap:16px;margin-bottom:18px}.two{grid-template-columns:repeat(2,1fr)}
            .card{background:#10243a;border:1px solid #24465e;border-radius:16px;padding:22px;box-shadow:0 12px 35px #0002}
            .metric{font-size:32px;font-weight:750;color:#78ddff;margin-top:8px}.label{font-size:13px;color:#a1bad0;text-transform:uppercase;letter-spacing:.08em}
            input,textarea{width:100%;border:1px solid #345c75;border-radius:9px;background:#091b2c;color:#fff;padding:11px 13px;font:inherit}
            input:focus,textarea:focus{outline:2px solid #63cafa;outline-offset:1px}textarea{min-height:96px;resize:vertical}
            label{display:block;margin:0 0 8px;color:#c7d8e6;font-size:14px}button{border:0;border-radius:9px;background:#58c9f3;color:#062037;font-weight:700;padding:11px 17px;cursor:pointer}
            button:hover{background:#91e0fb}.secondary{background:#203e56;color:#e7f5ff}.danger{background:#b8515b;color:#fff}.danger:hover{background:#d66a74}
            .formrow{display:flex;gap:10px}.formrow input{flex:1}.formrow button{white-space:nowrap}.stack>*+*{margin-top:12px}
            .notice{background:#123d42;border:1px solid #368d85;color:#c7fff1;padding:12px 16px;border-radius:10px;margin-bottom:18px}
            .error{background:#44232a;border:1px solid #a65060;color:#ffe2e2;padding:12px 16px;border-radius:10px;margin-bottom:18px}
            table{width:100%;border-collapse:collapse;font-size:14px}th,td{text-align:left;padding:11px 9px;border-bottom:1px solid #25445b}th{color:#9bb4ca;font-weight:600}
            .tablewrap{overflow:auto}.pill{display:inline-block;border-radius:99px;padding:4px 9px;background:#1b4d48;color:#b5ffdd;font-size:12px}
            .off{background:#403b3f;color:#c8bdc4}.locked{background:#613640;color:#ffd7dc}.inline{display:inline}.inline button{padding:6px 10px;font-size:12px}
            .login{max-width:460px;margin:9vh auto}.login .card{padding:32px}.actions{display:flex;align-items:center;gap:12px;flex-wrap:wrap}
            @media(max-width:760px){.grid,.grid.two{grid-template-columns:1fr}.wrap{padding:16px}.formrow{flex-direction:column}h1{font-size:24px}}
            </style></head><body><header><div class="wrap"><div class="brand">⚓ HTTH <span>ADMIN</span></div><div class="muted">Server nội bộ · 127.0.0.1:2228</div></div></header>
            <main class="wrap">""" + content + "</main></body></html>";
    }

    private static String loginPage(String error) {
        return shell("Đăng nhập", "<div class='login'><div class='card'><div class='label'>Hải Tặc Tí Hon</div>"
            + "<h1>Quản trị máy chủ</h1><p class='lead'>Nhập khóa trong file <code>private-server/admin.key</code>. "
            + "Trang chỉ truy cập được trên máy này.</p>"
            + (error.isEmpty() ? "" : "<div class='error'>" + esc(error) + "</div>")
            + "<form class='stack' method='post' action='/admin/login'><label for='key'>Khóa quản trị</label>"
            + "<input id='key' name='key' type='password' required autocomplete='current-password' autofocus>"
            + "<button type='submit'>Vào trang quản trị</button></form></div></div>");
    }

    private static String dashboard(AdminSession session, String search, String ok) throws SQLException {
        String csrf = esc(session.csrf());
        StringBuilder body = new StringBuilder();
        body.append("<div class='actions'><div><div class='label'>Bảng điều khiển</div><h1>Quản trị máy chủ</h1></div>")
            .append("<form method='post' action='/admin/logout' style='margin-left:auto'><input type='hidden' name='csrf' value='")
            .append(csrf).append("'><button class='secondary'>Đăng xuất</button></form></div>")
            .append("<p class='lead'>Tài khoản, người chơi và lệnh điều hành theo thời gian thực.</p>");
        String success = switch (ok) {
            case "notice" -> "Đã xếp thông báo vào hàng đợi.";
            case "kick" -> "Đã xếp lệnh kick vào hàng đợi.";
            case "lock" -> "Đã cập nhật trạng thái khóa tài khoản.";
            default -> "";
        };
        if (!success.isEmpty()) body.append("<div class='notice'>").append(success).append("</div>");
        try (Connection db = SQL.gI().getCon()) {
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT COUNT(*),COALESCE(SUM(onl <> 0),0),COALESCE(SUM(`lock` <> 0),0) FROM accounts WHERE note IS NULL");
                 ResultSet rs = ps.executeQuery()) {
                rs.next();
                body.append("<div class='grid'><div class='card'><div class='label'>Tài khoản</div><div class='metric'>")
                    .append(rs.getInt(1)).append("</div></div><div class='card'><div class='label'>Đang online</div><div class='metric'>")
                    .append(rs.getInt(2)).append("</div></div><div class='card'><div class='label'>Đang khóa</div><div class='metric'>")
                    .append(rs.getInt(3)).append("</div></div></div>");
            }
            body.append("<div class='grid two'><section class='card'><h2>📣 Thông báo toàn server</h2>")
                .append("<form class='stack' method='post' action='/admin/notice'><input type='hidden' name='csrf' value='")
                .append(csrf).append("'><label for='message'>Nội dung (tối đa 200 ký tự)</label>")
                .append("<textarea id='message' name='message' maxlength='200' required></textarea><button>Gửi thông báo</button></form></section>")
                .append("<section class='card'><h2>👤 Kick nhân vật</h2><p class='muted'>Nhập tên nhân vật đang online, không phải tên tài khoản.</p>")
                .append("<form class='stack' method='post' action='/admin/kick'><input type='hidden' name='csrf' value='")
                .append(csrf).append("'><label for='character'>Tên nhân vật</label><input id='character' name='character' maxlength='50' required>")
                .append("<button class='danger'>Kick khỏi game</button></form></section></div>");
            if (search.length() > 60) search = search.substring(0, 60);
            body.append("<section class='card'><h2>Tài khoản người chơi</h2><form method='get' action='/admin' class='formrow'>")
                .append("<input name='q' aria-label='Tìm tài khoản hoặc nhân vật' placeholder='Tìm tài khoản hoặc nhân vật' value='")
                .append(esc(search)).append("'><button>Tìm kiếm</button></form><div class='tablewrap'><table><thead><tr>")
                .append("<th>Tài khoản</th><th>Nhân vật</th><th>Trạng thái</th><th>VIP</th><th>Coin</th><th>Thao tác</th>")
                .append("</tr></thead><tbody>");
            String sql = "SELECT `user`,`char`,onl,`lock`,vip,coin FROM accounts WHERE note IS NULL "
                + (search.isBlank() ? "" : "AND (`user` LIKE ? OR `char` LIKE ?) ") + "ORDER BY id DESC LIMIT 50";
            try (PreparedStatement ps = db.prepareStatement(sql)) {
                if (!search.isBlank()) {
                    ps.setString(1, "%" + search + "%");
                    ps.setString(2, "%" + search + "%");
                }
                try (ResultSet rs = ps.executeQuery()) {
                    while (rs.next()) {
                        String user = esc(rs.getString(1));
                        String character = esc(firstCharacter(rs.getString(2)));
                        boolean online = rs.getInt(3) != 0;
                        boolean locked = rs.getInt(4) != 0;
                        body.append("<tr><td>").append(user).append("</td><td>").append(character).append("</td><td><span class='pill ")
                            .append(online ? "" : "off").append("'>").append(online ? "Online" : "Offline").append("</span> ")
                            .append(locked ? "<span class='pill locked'>Bị khóa</span>" : "")
                            .append("</td><td>").append(rs.getInt(5)).append("</td><td>").append(rs.getInt(6)).append("</td><td>")
                            .append("<form class='inline' method='post' action='/admin/lock'><input type='hidden' name='csrf' value='")
                            .append(csrf).append("'><input type='hidden' name='username' value='").append(user)
                            .append("'><input type='hidden' name='value' value='").append(locked ? "0" : "1")
                            .append("'><button class='").append(locked ? "secondary" : "danger").append("'>")
                            .append(locked ? "Mở khóa" : "Khóa").append("</button></form></td></tr>");
                    }
                }
            }
            body.append("</tbody></table></div></section>");
            body.append("<section class='card' style='margin-top:18px'><h2>Lệnh gần đây</h2><div class='tablewrap'><table><thead><tr>")
                .append("<th>Thời gian</th><th>Lệnh</th><th>Đích</th><th>Trạng thái</th></tr></thead><tbody>");
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT created_at,command,target_user,status FROM web_admin_commands ORDER BY id DESC LIMIT 10");
                 ResultSet rs = ps.executeQuery()) {
                while (rs.next()) {
                    body.append("<tr><td>").append(esc(rs.getString(1))).append("</td><td>").append(esc(rs.getString(2)))
                        .append("</td><td>").append(esc(rs.getString(3))).append("</td><td>")
                        .append(rs.getInt(4) == 0 ? "Đang chờ" : "Đã xử lý").append("</td></tr>");
                }
            }
            body.append("</tbody></table></div></section>");
        }
        return shell("Quản trị", body.toString());
    }

    private static String firstCharacter(String json) {
        Object value = JSONValue.parse(json);
        if (value instanceof JSONArray array && !array.isEmpty()) return String.valueOf(array.get(0));
        return "—";
    }
}
