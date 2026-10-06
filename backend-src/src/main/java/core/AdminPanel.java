package core;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.nio.charset.StandardCharsets;
import java.nio.CharBuffer;
import java.nio.file.Files;
import java.nio.file.Path;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;
import javax.swing.SwingWorker;
import javax.swing.Timer;
import javax.swing.UIManager;
import javax.swing.table.DefaultTableModel;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;

/** Desktop admin panel for the local private server; no browser or HTTP required. */
public final class AdminPanel {
    record DbConfig(String database, String user, String password) {}
    private record Snapshot(int accounts, int online, int locked, List<Object[]> players, List<Object[]> commands) {}
    private interface DbAction { int run(Connection db) throws Exception; }

    private final DbConfig config;
    private final JFrame frame = new JFrame("Hải Tặc Tí Hon — Admin Panel");
    private final JLabel summary = new JLabel("Đang tải dữ liệu...");
    private final JLabel status = new JLabel("Sẵn sàng");
    private final JTextField search = new JTextField(26);
    private final JTextField kickName = new JTextField(24);
    private final JTextArea notice = new JTextArea(5, 32);
    private final DefaultTableModel accounts = model("Tài khoản", "Nhân vật", "Online", "Khóa", "VIP", "Coin", "Quyền");
    private final DefaultTableModel commands = model("Thời gian", "Lệnh", "Đích", "Trạng thái");
    private final JTable accountTable = new JTable(accounts);
    private final JTabbedPane tabs = new JTabbedPane();
    private final AdminCharacterPanel characterPanel;
    private boolean refreshing;

    private AdminPanel(DbConfig config) {
        this.config = config;
        this.characterPanel = new AdminCharacterPanel(config, frame);
        buildWindow();
        refresh();
        new Timer(15000, event -> refresh()).start();
    }

    public static void main(String[] args) throws Exception {
        DbConfig config = readConfig();
        Class.forName("com.mysql.cj.jdbc.Driver");
        try (Connection db = connect(config);
             PreparedStatement ps = db.prepareStatement("SELECT COUNT(*) FROM accounts");
             ResultSet result = ps.executeQuery()) {
            result.next();
            System.out.println("Admin panel DB OK: " + result.getInt(1) + " accounts");
            try (PreparedStatement queue = db.prepareStatement("SELECT COUNT(*) FROM web_admin_commands");
                 ResultSet ignored = queue.executeQuery()) {
                ignored.next();
            }
        }
        if (args.length > 0 && "--check".equals(args[0])) return;
        if (args.length > 0 && "--self-test".equals(args[0])) { selfTest(config); return; }
        UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        SwingUtilities.invokeLater(() -> new AdminPanel(config).frame.setVisible(true));
    }

    private static DbConfig readConfig() throws Exception {
        Map<String, String> values = new HashMap<>();
        for (String line : Files.readAllLines(Path.of("htth.conf"), StandardCharsets.UTF_8)) {
            int colon = line.indexOf(':');
            if (colon > 0 && !line.trim().startsWith("#"))
                values.put(line.substring(0, colon).trim(), line.substring(colon + 1).trim());
        }
        String host = values.getOrDefault("mysql-host", "127.0.0.1");
        if (!("127.0.0.1".equals(host) || "localhost".equalsIgnoreCase(host)))
            throw new IllegalArgumentException("Admin panel chỉ kết nối MariaDB trên máy này.");
        String database = values.getOrDefault("mysql-database", "htth");
        if (!database.matches("[A-Za-z0-9_]+")) throw new IllegalArgumentException("Tên database không hợp lệ.");
        return new DbConfig(database, values.getOrDefault("mysql-user", "root"),
            values.getOrDefault("mysql-password", ""));
    }

    static Connection connect(DbConfig config) throws SQLException {
        return DriverManager.getConnection("jdbc:mysql://127.0.0.1:3306/" + config.database()
            + "?useUnicode=true&characterEncoding=UTF-8&connectTimeout=3000&socketTimeout=5000",
            config.user(), config.password());
    }

    private static DefaultTableModel model(String... columns) {
        return new DefaultTableModel(columns, 0) {
            @Override public boolean isCellEditable(int row, int column) { return false; }
        };
    }

    private void buildWindow() {
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setMinimumSize(new Dimension(820, 560));
        frame.setSize(1080, 700);
        frame.setLocationRelativeTo(null);
        frame.setLayout(new BorderLayout());

        JPanel header = new JPanel(new BorderLayout(12, 6));
        header.setBackground(new Color(12, 39, 62));
        header.setBorder(BorderFactory.createEmptyBorder(20, 24, 20, 24));
        JLabel title = new JLabel("⚓  HẢI TẶC TÍ HON  /  ADMIN PANEL");
        title.setForeground(Color.WHITE);
        title.setFont(title.getFont().deriveFont(Font.BOLD, 22f));
        summary.setForeground(new Color(173, 222, 244));
        summary.setFont(summary.getFont().deriveFont(14f));
        header.add(title, BorderLayout.NORTH);
        header.add(summary, BorderLayout.SOUTH);
        frame.add(header, BorderLayout.NORTH);

        tabs.addTab("Tài khoản", accountTab());
        tabs.addTab("Nhân vật", characterPanel.panel());
        tabs.addTab("Điều hành", operationsTab());
        tabs.addTab("Lệnh gần đây", commandsTab());
        frame.add(tabs, BorderLayout.CENTER);

        JPanel footer = new JPanel(new BorderLayout());
        footer.setBorder(BorderFactory.createEmptyBorder(8, 18, 8, 18));
        footer.add(status, BorderLayout.CENTER);
        frame.add(footer, BorderLayout.SOUTH);
    }

    private JPanel accountTab() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(18, 18, 18, 18));
        JPanel top = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 0));
        top.add(new JLabel("Tìm tài khoản / nhân vật:"));
        top.add(search);
        JButton find = new JButton("Tìm");
        find.addActionListener(event -> refresh());
        search.addActionListener(event -> refresh());
        top.add(find);
        JButton reload = new JButton("Làm mới");
        reload.addActionListener(event -> refresh());
        top.add(reload);
        JButton create = new JButton("Tạo tài khoản");
        create.addActionListener(event -> createAccount());
        top.add(create);
        panel.add(top, BorderLayout.NORTH);

        accountTable.setRowHeight(28);
        accountTable.setAutoCreateRowSorter(true);
        accountTable.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        panel.add(new JScrollPane(accountTable), BorderLayout.CENTER);

        JPanel bottom = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 0));
        JButton lock = new JButton("Khóa tài khoản đã chọn");
        lock.addActionListener(event -> setLock(1));
        JButton unlock = new JButton("Mở khóa tài khoản đã chọn");
        unlock.addActionListener(event -> setLock(0));
        bottom.add(lock);
        bottom.add(unlock);
        JButton details = new JButton("Chi tiết nhân vật");
        details.addActionListener(event -> {
            int viewRow = accountTable.getSelectedRow();
            if (viewRow < 0) { info("Chọn một tài khoản trong bảng trước."); return; }
            int row = accountTable.convertRowIndexToModel(viewRow);
            String character = String.valueOf(accounts.getValueAt(row, 1));
            if ("—".equals(character)) { info("Tài khoản này chưa có nhân vật."); return; }
            characterPanel.open(String.valueOf(accounts.getValueAt(row, 0)), character);
            tabs.setSelectedIndex(1);
        });
        bottom.add(details);
        bottom.add(new JLabel("Khóa chỉ chặn lần đăng nhập tiếp theo; dùng Kick để ngắt phiên hiện tại."));
        panel.add(bottom, BorderLayout.SOUTH);
        return panel;
    }

    private JPanel operationsTab() {
        JPanel panel = new JPanel(new GridLayout(2, 1, 0, 14));
        panel.setBorder(BorderFactory.createEmptyBorder(18, 18, 18, 18));
        JPanel noticePanel = new JPanel(new BorderLayout(10, 10));
        noticePanel.setBorder(BorderFactory.createTitledBorder("Thông báo toàn server"));
        notice.setLineWrap(true);
        notice.setWrapStyleWord(true);
        noticePanel.add(new JScrollPane(notice), BorderLayout.CENTER);
        JPanel noticeBottom = new JPanel(new FlowLayout(FlowLayout.LEFT));
        noticeBottom.add(new JLabel("Tối đa 200 ký tự"));
        JButton sendNotice = new JButton("Gửi thông báo");
        sendNotice.addActionListener(event -> sendNotice());
        noticeBottom.add(sendNotice);
        noticePanel.add(noticeBottom, BorderLayout.SOUTH);
        panel.add(noticePanel);

        JPanel kickPanel = new JPanel(new BorderLayout(10, 10));
        kickPanel.setBorder(BorderFactory.createTitledBorder("Ngắt kết nối nhân vật"));
        JPanel kickForm = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 16));
        kickForm.add(new JLabel("Tên nhân vật đang online:"));
        kickForm.add(kickName);
        JButton kick = new JButton("Kick");
        kick.addActionListener(event -> kick());
        kickForm.add(kick);
        kickPanel.add(kickForm, BorderLayout.NORTH);
        kickPanel.add(new JLabel("Lệnh được server xử lý sau vài giây. Đây là tên nhân vật, không phải tên tài khoản."), BorderLayout.CENTER);
        panel.add(kickPanel);
        return panel;
    }

    private JPanel commandsTab() {
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(18, 18, 18, 18));
        JTable table = new JTable(commands);
        table.setRowHeight(28);
        panel.add(new JScrollPane(table), BorderLayout.CENTER);
        JButton reload = new JButton("Làm mới");
        reload.addActionListener(event -> refresh());
        JPanel bottom = new JPanel(new FlowLayout(FlowLayout.LEFT));
        bottom.add(reload);
        panel.add(bottom, BorderLayout.SOUTH);
        return panel;
    }

    private void refresh() {
        if (refreshing) return;
        refreshing = true;
        String filter = search.getText().trim();
        if (filter.length() > 60) filter = filter.substring(0, 60);
        final String term = filter;
        status.setText("Đang tải dữ liệu...");
        new SwingWorker<Snapshot, Void>() {
            @Override protected Snapshot doInBackground() throws Exception { return load(term); }
            @Override protected void done() {
                refreshing = false;
                try {
                    Snapshot data = get();
                    summary.setText(data.accounts() + " tài khoản  ·  " + data.online() + " online  ·  " + data.locked() + " bị khóa");
                    replace(accounts, data.players());
                    replace(commands, data.commands());
                    status.setText("Đã cập nhật dữ liệu.");
                } catch (Exception e) { error("Không tải được dữ liệu", e); }
            }
        }.execute();
    }

    private Snapshot load(String filter) throws Exception {
        List<Object[]> players = new ArrayList<>();
        List<Object[]> recent = new ArrayList<>();
        int total, online, locked;
        try (Connection db = connect(config)) {
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT COUNT(*),COALESCE(SUM(onl<>0),0),COALESCE(SUM(`lock`<>0),0) FROM accounts WHERE note IS NULL");
                 ResultSet rs = ps.executeQuery()) {
                rs.next(); total = rs.getInt(1); online = rs.getInt(2); locked = rs.getInt(3);
            }
            String sql = "SELECT `user`,`char`,onl,`lock`,vip,coin,admin FROM accounts WHERE note IS NULL "
                + (filter.isEmpty() ? "" : "AND (`user` LIKE ? OR `char` LIKE ?) ") + "ORDER BY id DESC LIMIT 100";
            try (PreparedStatement ps = db.prepareStatement(sql)) {
                if (!filter.isEmpty()) {
                    ps.setString(1, "%" + filter + "%");
                    ps.setString(2, "%" + filter + "%");
                }
                try (ResultSet rs = ps.executeQuery()) {
                    while (rs.next()) players.add(new Object[]{rs.getString(1), firstCharacter(rs.getString(2)),
                        rs.getInt(3) != 0 ? "Online" : "Offline", rs.getInt(4) != 0 ? "Khóa" : "Mở",
                        rs.getInt(5), rs.getInt(6), rs.getInt(7) != 0 ? "Admin" : "Người chơi"});
                }
            }
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT created_at,command,target_user,status FROM web_admin_commands ORDER BY id DESC LIMIT 30");
                 ResultSet rs = ps.executeQuery()) {
                while (rs.next()) recent.add(new Object[]{rs.getString(1), rs.getString(2), rs.getString(3),
                    rs.getInt(4) == 0 ? "Đang chờ" : "Đã xử lý"});
            }
        }
        return new Snapshot(total, online, locked, players, recent);
    }

    private static String firstCharacter(String json) {
        Object value = JSONValue.parse(json);
        return value instanceof JSONArray array && !array.isEmpty() ? String.valueOf(array.get(0)) : "—";
    }

    private static void replace(DefaultTableModel model, List<Object[]> rows) {
        model.setRowCount(0);
        for (Object[] row : rows) model.addRow(row);
    }

    private void setLock(int value) {
        int viewRow = accountTable.getSelectedRow();
        if (viewRow < 0) { info("Chọn một tài khoản trong bảng trước."); return; }
        int row = accountTable.convertRowIndexToModel(viewRow);
        String user = String.valueOf(accounts.getValueAt(row, 0));
        if ("Admin".equals(accounts.getValueAt(row, 6))) { info("Không thể khóa tài khoản admin."); return; }
        String action = value == 1 ? "khóa" : "mở khóa";
        if (JOptionPane.showConfirmDialog(frame, "Bạn chắc chắn muốn " + action + " tài khoản " + user + "?",
                "Xác nhận", JOptionPane.YES_NO_OPTION) != JOptionPane.YES_OPTION) return;
        execute("Đã " + action + " " + user, db -> {
            try (PreparedStatement ps = db.prepareStatement(
                    "UPDATE accounts SET `lock`=? WHERE BINARY `user`=? AND admin=0 AND note IS NULL")) {
                ps.setInt(1, value);
                ps.setString(2, user);
                return ps.executeUpdate();
            }
        });
    }

    private void createAccount() {
        JTextField username = new JTextField(20);
        JPasswordField password = new JPasswordField(20);
        JPasswordField confirmation = new JPasswordField(20);
        JPanel form = new JPanel(new GridLayout(3, 2, 8, 8));
        form.add(new JLabel("Tên đăng nhập:")); form.add(username);
        form.add(new JLabel("Mật khẩu:")); form.add(password);
        form.add(new JLabel("Nhập lại mật khẩu:")); form.add(confirmation);
        if (JOptionPane.showConfirmDialog(frame, form, "Tạo tài khoản người chơi",
                JOptionPane.OK_CANCEL_OPTION, JOptionPane.PLAIN_MESSAGE) != JOptionPane.OK_OPTION) {
            password.setText(""); confirmation.setText("");
            return;
        }
        String user = username.getText().trim();
        char[] secret = password.getPassword();
        char[] again = confirmation.getPassword();
        password.setText(""); confirmation.setText("");
        try {
            if (!validCredential(user) || !validCredential(CharBuffer.wrap(secret))) {
                Arrays.fill(secret, '\0');
                info("Tên đăng nhập và mật khẩu phải dài 1–30 ký tự, chỉ gồm chữ cái, số, @ hoặc dấu chấm.");
                return;
            }
            if (!Arrays.equals(secret, again)) {
                Arrays.fill(secret, '\0');
                info("Hai lần nhập mật khẩu không khớp.");
                return;
            }
            search.setText(user);
            execute("Đã tạo tài khoản " + user + ". Người chơi có thể đăng nhập và tạo nhân vật.", db -> {
                try { return insertAccount(db, user, secret); }
                finally { Arrays.fill(secret, '\0'); }
            });
        } finally { Arrays.fill(again, '\0'); }
    }

    private static boolean validCredential(CharSequence value) {
        if (value == null || value.length() < 1 || value.length() > 30) return false;
        for (int i = 0; i < value.length(); i++) {
            char c = value.charAt(i);
            if (!(c >= 'a' && c <= 'z') && !(c >= 'A' && c <= 'Z')
                    && !(c >= '0' && c <= '9') && c != '@' && c != '.') return false;
        }
        return true;
    }

    private static int insertAccount(Connection db, String user, char[] password) throws SQLException {
        if (!validCredential(user) || !validCredential(CharBuffer.wrap(password)))
            throw new IllegalArgumentException("Tên đăng nhập hoặc mật khẩu không hợp lệ.");
        try (PreparedStatement ps = db.prepareStatement(
                "INSERT INTO accounts (`user`,`pass`,vip) VALUES (?,?,0)")) {
            ps.setString(1, user);
            ps.setString(2, new String(password)); // The existing game login compares plaintext passwords.
            return ps.executeUpdate();
        }
    }

    private static void selfTest(DbConfig config) throws Exception {
        if (!validCredential("Player1@.") || validCredential("bad_name") || validCredential(""))
            throw new AssertionError("Credential validation failed.");
        String user = "CodexTest" + Long.toUnsignedString(System.nanoTime());
        char[] password = "Test12345".toCharArray();
        try (Connection db = connect(config)) {
            db.setAutoCommit(false);
            try {
                if (insertAccount(db, user, password) != 1) throw new AssertionError("Insert failed.");
                try (PreparedStatement ps = db.prepareStatement(
                        "SELECT `char`,onl,`lock`,vip,coin,admin,active FROM accounts "
                            + "WHERE BINARY `user`=? AND BINARY `pass`=?")) {
                    ps.setString(1, user); ps.setString(2, new String(password));
                    try (ResultSet rs = ps.executeQuery()) {
                        if (!rs.next() || !"[]".equals(rs.getString(1)) || rs.getInt(2) != 0
                                || rs.getInt(3) != 0 || rs.getInt(4) != 0 || rs.getInt(5) != 0
                                || rs.getInt(6) != 0 || rs.getInt(7) != 1)
                            throw new AssertionError("New account cannot log in or has incorrect defaults.");
                    }
                }
            } finally { db.rollback(); Arrays.fill(password, '\0'); }
        }
        try (Connection db = connect(config);
             PreparedStatement ps = db.prepareStatement("SELECT COUNT(*) FROM accounts WHERE BINARY `user`=?")) {
            ps.setString(1, user);
            try (ResultSet rs = ps.executeQuery()) {
                rs.next();
                if (rs.getInt(1) != 0) throw new AssertionError("Test account was not rolled back.");
            }
        }
        System.out.println("Admin account creation self-test OK");
    }

    private void sendNotice() {
        String message = notice.getText().trim();
        if (message.isEmpty() || message.length() > 200) { info("Thông báo phải dài 1–200 ký tự."); return; }
        if (JOptionPane.showConfirmDialog(frame, "Gửi thông báo này tới toàn server?",
                "Xác nhận", JOptionPane.YES_NO_OPTION) != JOptionPane.YES_OPTION) return;
        JSONObject data = new JSONObject();
        data.put("message", message);
        data.put("type", 0);
        data.put("color", 5);
        execute("Đã xếp thông báo vào hàng đợi.", db -> queue(db, "SEND_NOTICE", null, data.toJSONString()));
    }

    private void kick() {
        String character = kickName.getText().trim();
        if (character.isEmpty() || character.length() > 50) { info("Tên nhân vật không hợp lệ."); return; }
        if (JOptionPane.showConfirmDialog(frame, "Kick nhân vật " + character + "?",
                "Xác nhận", JOptionPane.YES_NO_OPTION) != JOptionPane.YES_OPTION) return;
        execute("Đã xếp lệnh kick cho " + character, db -> queue(db, "KICK", character, "{}"));
    }

    private static int queue(Connection db, String command, String target, String data) throws SQLException {
        try (PreparedStatement ps = db.prepareStatement(
                "INSERT INTO web_admin_commands (command,target_user,data,status) VALUES (?,?,?,0)")) {
            ps.setString(1, command);
            ps.setString(2, target);
            ps.setString(3, data);
            return ps.executeUpdate();
        }
    }

    private void execute(String success, DbAction action) {
        status.setText("Đang xử lý...");
        new SwingWorker<Integer, Void>() {
            @Override protected Integer doInBackground() throws Exception {
                try (Connection db = connect(config)) { return action.run(db); }
            }
            @Override protected void done() {
                try {
                    if (get() != 1) { info("Không tìm thấy tài khoản hoặc thao tác không có hiệu lực."); return; }
                    status.setText(success);
                    refresh();
                } catch (Exception e) { error("Không thực hiện được thao tác", e); }
            }
        }.execute();
    }

    private void info(String message) {
        status.setText(message);
        JOptionPane.showMessageDialog(frame, message, "Thông báo", JOptionPane.INFORMATION_MESSAGE);
    }

    private void error(String message, Exception error) {
        String detail = error.getCause() == null ? error.getMessage() : error.getCause().getMessage();
        status.setText(message);
        JOptionPane.showMessageDialog(frame, message + ": " + detail, "Lỗi", JOptionPane.ERROR_MESSAGE);
    }
}
