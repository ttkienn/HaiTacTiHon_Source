package core;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.Dimension;
import java.nio.file.Files;
import java.nio.file.Path;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.function.Consumer;
import java.util.regex.Pattern;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.SwingWorker;
import javax.swing.RowFilter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableRowSorter;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.JSONValue;
import template.Level;

/** Offline character edits and queued in-game gifts for the local admin panel. */
final class AdminCharacterPanel {
    private record CharacterData(String level, String potential, String money, String skills,
                                 String quests, String questTitle, int coin, boolean online,
                                 List<Object[]> skillRows) {}
    private interface Change { void run(Connection db, int accountId, int playerId,
                                         CharacterData current) throws Exception; }

    private final AdminPanel.DbConfig config;
    private final JFrame frame;
    private final JPanel root = new JPanel(new BorderLayout(12, 12));
    private final JTextField account = new JTextField(16);
    private final JTextField character = new JTextField(16);
    private final JTextField level = new JTextField(10);
    private final JTextField exp = new JTextField(10);
    private final JTextField freePoints = new JTextField(10);
    private final JTextField beri = new JTextField(10);
    private final JTextField ruby = new JTextField(10);
    private final JTextField extol = new JTextField(10);
    private final JTextField coin = new JTextField(10);
    private final JTextField targetSkillLevel = new JTextField(4);
    private final JTextField itemType = new JTextField("4", 3);
    private final JTextField itemId = new JTextField(5);
    private final JTextField itemQuantity = new JTextField("1", 5);
    private final JLabel chosenItem = new JLabel("Chưa chọn item");
    private final JLabel currentQuest = new JLabel("Quest hiện tại: chưa tải nhân vật");
    private final JLabel chosenQuest = new JLabel("Chưa chọn quest mới");
    private final JLabel state = new JLabel("Chọn tài khoản rồi nhấn Chi tiết nhân vật.");
    private final DefaultTableModel skillModel = new DefaultTableModel(
            new String[]{"ID", "Kỹ năng", "Cấp", "EXP"}, 0) {
        @Override public boolean isCellEditable(int row, int column) { return false; }
    };
    private final JTable skills = new JTable(skillModel);
    private CharacterData loaded;
    private String loadedUser;
    private String loadedName;
    private Integer selectedQuestId;

    AdminCharacterPanel(AdminPanel.DbConfig config, JFrame frame) {
        this.config = config;
        this.frame = frame;
        build();
    }

    JPanel panel() { return root; }

    void open(String user, String name) {
        account.setText(user);
        character.setText(name);
        load();
    }

    private void build() {
        root.setBorder(BorderFactory.createEmptyBorder(14, 16, 14, 16));
        JPanel top = new JPanel(new FlowLayout(FlowLayout.LEFT));
        top.add(new JLabel("Tài khoản:")); top.add(account);
        top.add(new JLabel("Nhân vật:")); top.add(character);
        JButton loadButton = new JButton("Tải chi tiết");
        loadButton.addActionListener(event -> load());
        top.add(loadButton); top.add(state);
        root.add(top, BorderLayout.NORTH);

        JPanel center = new JPanel(new GridLayout(1, 2, 14, 0));
        JPanel profile = new JPanel(new BorderLayout(6, 6));
        profile.setBorder(BorderFactory.createTitledBorder("Cấp, điểm và tiền (nhân vật phải offline)"));
        JPanel fields = new JPanel(new GridLayout(7, 2, 8, 7));
        field(fields, "Level (1–100)", level);
        field(fields, "EXP trong level", exp);
        field(fields, "Điểm tiềm năng chưa dùng", freePoints);
        field(fields, "Beri", beri);
        field(fields, "Ruby", ruby);
        field(fields, "Extol", extol);
        field(fields, "Coin tài khoản", coin);
        profile.add(fields, BorderLayout.CENTER);
        JPanel questActions = new JPanel(new GridLayout(2, 1));
        questActions.add(currentQuest);
        JPanel questButtons = new JPanel(new FlowLayout(FlowLayout.LEFT, 4, 0));
        JButton chooseQuest = new JButton("Danh sách quest");
        chooseQuest.addActionListener(event -> chooseQuest());
        questButtons.add(chooseQuest);
        JButton saveQuest = new JButton("Mở khóa / chuyển quest");
        saveQuest.addActionListener(event -> saveQuest());
        questButtons.add(saveQuest); questButtons.add(chosenQuest);
        questActions.add(questButtons);
        profile.add(questActions, BorderLayout.NORTH);
        JButton save = new JButton("Lưu cấp, điểm và tiền");
        save.addActionListener(event -> saveProfile());
        profile.add(save, BorderLayout.SOUTH);
        center.add(profile);

        JPanel skillPanel = new JPanel(new BorderLayout(6, 6));
        skillPanel.setBorder(BorderFactory.createTitledBorder("Kỹ năng của nhân vật (offline)"));
        skills.setRowHeight(24);
        skills.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        skills.getSelectionModel().addListSelectionListener(event -> {
            int row = skills.getSelectedRow();
            if (row >= 0) targetSkillLevel.setText(String.valueOf(skillModel.getValueAt(row, 2)));
        });
        skillPanel.add(new JScrollPane(skills), BorderLayout.CENTER);
        JPanel skillActions = new JPanel(new FlowLayout(FlowLayout.LEFT));
        skillActions.add(new JLabel("Cấp mới (0 = chưa học):"));
        skillActions.add(targetSkillLevel);
        JButton saveSkill = new JButton("Lưu kỹ năng đã chọn");
        saveSkill.addActionListener(event -> saveSkill());
        skillActions.add(saveSkill);
        skillPanel.add(skillActions, BorderLayout.SOUTH);
        center.add(skillPanel);
        root.add(center, BorderLayout.CENTER);

        JPanel gift = new JPanel(new FlowLayout(FlowLayout.LEFT, 8, 8));
        gift.setBorder(BorderFactory.createTitledBorder("Gửi item — nhận khi nhân vật online"));
        JButton chooseItem = new JButton("Chọn từ danh sách item");
        chooseItem.addActionListener(event -> chooseItem());
        gift.add(chooseItem);
        gift.add(new JLabel("Loại 3=trang bị, 4=vật phẩm, 7=nguyên liệu:"));
        gift.add(itemType); gift.add(new JLabel("ID:")); gift.add(itemId);
        gift.add(new JLabel("Số lượng:")); gift.add(itemQuantity);
        JButton send = new JButton("Gửi item");
        send.addActionListener(event -> sendItem());
        gift.add(send); gift.add(chosenItem);
        root.add(gift, BorderLayout.SOUTH);
    }

    private static void field(JPanel panel, String label, JTextField input) {
        panel.add(new JLabel(label)); panel.add(input);
    }

    private void load() {
        String user = account.getText().trim();
        String name = character.getText().trim();
        loaded = null;
        selectedQuestId = null;
        if (user.isEmpty() || name.isEmpty()) { message("Nhập tài khoản và tên nhân vật."); return; }
        state.setText("Đang tải...");
        new SwingWorker<CharacterData, Void>() {
            @Override protected CharacterData doInBackground() throws Exception {
                try (Connection db = AdminPanel.connect(config)) { return read(db, user, name, false); }
            }
            @Override protected void done() {
                try {
                    CharacterData data = get();
                    loaded = data; loadedUser = user; loadedName = name;
                    JSONArray levels = array(data.level(), 3);
                    JSONArray points = array(data.potential(), 8);
                    JSONArray money = array(data.money(), 3);
                    level.setText(levels.get(0).toString());
                    exp.setText(levels.get(1).toString());
                    freePoints.setText(points.get(0).toString());
                    beri.setText(money.get(0).toString());
                    ruby.setText(money.get(1).toString());
                    extol.setText(money.get(2).toString());
                    coin.setText(String.valueOf(data.coin()));
                    skillModel.setRowCount(0);
                    for (Object[] row : data.skillRows()) skillModel.addRow(row);
                    currentQuest.setText("Quest hiện tại: " + data.questTitle());
                    chosenQuest.setText("Chưa chọn quest mới");
                    state.setText(data.online() ? "ONLINE — chỉ gửi item" : "OFFLINE — có thể chỉnh sửa");
                } catch (Exception error) { fail(error); }
            }
        }.execute();
    }

    private static JSONArray array(String json, int minLength) {
        Object parsed = JSONValue.parse(json);
        if (!(parsed instanceof JSONArray value) || value.size() < minLength)
            throw new IllegalArgumentException("Dữ liệu nhân vật không đúng định dạng.");
        return value;
    }

    private static int number(String text, String label, int min, int max) {
        int value = Integer.parseInt(text.trim());
        if (value < min || value > max) throw new IllegalArgumentException(label + " phải từ " + min + " đến " + max);
        return value;
    }

    private static long amount(String text, String label, long max) {
        long value = Long.parseLong(text.trim());
        if (value < 0 || value > max) throw new IllegalArgumentException(label + " phải từ 0 đến " + max);
        return value;
    }

    private CharacterData read(Connection db, String user, String name, boolean lock) throws Exception {
        String suffix = lock ? " FOR UPDATE" : "";
        int accountId, accountCoin;
        boolean online;
        try (PreparedStatement ps = db.prepareStatement(
                "SELECT id,`char`,onl,coin FROM accounts WHERE BINARY `user`=? AND note IS NULL" + suffix)) {
            ps.setString(1, user);
            try (ResultSet rs = ps.executeQuery()) {
                if (!rs.next() || !array(rs.getString("char"), 0).contains(name))
                    throw new IllegalArgumentException("Tài khoản không sở hữu nhân vật này.");
                accountId = rs.getInt("id"); accountCoin = rs.getInt("coin"); online = rs.getInt("onl") != 0;
            }
        }
        String rawLevel, rawPotential, rawMoney, rawSkills, rawQuests;
        try (PreparedStatement ps = db.prepareStatement(
                "SELECT `level`,potential,point_inven,skill,quest FROM players WHERE BINARY name=?" + suffix)) {
            ps.setString(1, name);
            try (ResultSet rs = ps.executeQuery()) {
                if (!rs.next()) throw new IllegalArgumentException("Không tìm thấy nhân vật.");
                rawLevel = rs.getString(1); rawPotential = rs.getString(2);
                rawMoney = rs.getString(3); rawSkills = rs.getString(4); rawQuests = rs.getString(5);
            }
        }
        List<Object[]> rows = new ArrayList<>();
        try (PreparedStatement ps = db.prepareStatement(
                "SELECT name,MAX(Lv_RQ) FROM skill WHERE id_index=? GROUP BY name LIMIT 1")) {
            for (Object entry : array(rawSkills, 0)) {
                JSONArray skill = (JSONArray)entry;
                int index = Integer.parseInt(skill.get(0).toString());
                ps.setInt(1, index);
                String skillName = "Kỹ năng #" + index;
                int skillLevel = Long.parseLong(skill.get(1).toString()) < 0 ? 0 : 1;
                try (ResultSet rs = ps.executeQuery()) {
                    if (rs.next()) { skillName = rs.getString(1); if (skillLevel != 0) skillLevel = rs.getInt(2); }
                }
                rows.add(new Object[]{index, skillName, skillLevel, skill.get(1)});
            }
        }
        String questTitle = "Chưa có";
        JSONArray quests = array(rawQuests, 0);
        if (!quests.isEmpty()) {
            int questId = Integer.parseInt(((JSONArray)quests.get(0)).get(0).toString());
            questTitle = "#" + questId;
            try (PreparedStatement ps = db.prepareStatement("SELECT name,statusQuest FROM quests WHERE id=?")) {
                ps.setInt(1, questId);
                try (ResultSet rs = ps.executeQuery()) {
                    if (rs.next()) questTitle += " — " + rs.getString(1) + " (" + questStage(rs.getInt(2)) + ")";
                }
            }
        }
        return new CharacterData(rawLevel, rawPotential, rawMoney, rawSkills,
            rawQuests, questTitle, accountCoin, online, rows);
    }

    private void saveProfile() {
        if (!ready()) return;
        final int newLevel, newPoints, newRuby, newExtol, newCoin;
        final long newExp, newBeri;
        try {
            newLevel = number(level.getText(), "Level", 1, 100);
            newPoints = number(freePoints.getText(), "Điểm tiềm năng", 0, 32767);
            newBeri = amount(beri.getText(), "Beri", 2_000_000_000L);
            newRuby = number(ruby.getText(), "Ruby", 0, 2_000_000_000);
            newExtol = number(extol.getText(), "Extol", 0, 2_000_000_000);
            newCoin = number(coin.getText(), "Coin", 0, 2_000_000_000);
            newExp = amount(exp.getText(), "EXP", Long.MAX_VALUE);
            JSONArray oldLevel = array(loaded.level(), 3);
            int mastery = Integer.parseInt(oldLevel.get(2).toString());
            long threshold = newLevel == 100 ? Level.LEVEL_THONGTHAO[mastery] : Level.ENTRYS[newLevel - 1].exp;
            if (newExp >= threshold) throw new IllegalArgumentException("EXP phải nhỏ hơn " + threshold + " ở level này.");
        } catch (Exception error) { fail(error); return; }
        if (!confirm("Lưu level, EXP, điểm và tiền của " + loadedName + "?")) return;
        edit("Đã lưu nhân vật.", (db, accountId, playerId, current) -> {
            JSONArray levels = array(current.level(), 3);
            JSONArray points = array(current.potential(), 8);
            JSONArray money = array(current.money(), 3);
            levels.set(0, newLevel); levels.set(1, newExp);
            points.set(0, newPoints);
            money.set(0, newBeri); money.set(1, newRuby); money.set(2, newExtol);
            long totalExp = newExp;
            for (int i = 0; i < newLevel - 1; i++) totalExp = Math.addExact(totalExp, Level.ENTRYS[i].exp);
            int mastery = Integer.parseInt(levels.get(2).toString());
            for (int i = 0; i < mastery; i++) totalExp = Math.addExact(totalExp, Level.LEVEL_THONGTHAO[i]);
            try (PreparedStatement ps = db.prepareStatement(
                    "UPDATE players SET `level`=?,potential=?,point_inven=?,exp=? WHERE id=?")) {
                ps.setString(1, levels.toJSONString()); ps.setString(2, points.toJSONString());
                ps.setString(3, money.toJSONString()); ps.setLong(4, totalExp); ps.setInt(5, playerId);
                if (ps.executeUpdate() != 1) throw new IllegalStateException("Không lưu được nhân vật.");
            }
            try (PreparedStatement ps = db.prepareStatement("UPDATE accounts SET coin=? WHERE id=?")) {
                ps.setInt(1, newCoin); ps.setInt(2, accountId);
                if (ps.executeUpdate() != 1) throw new IllegalStateException("Không lưu được coin.");
            }
        });
    }

    private void saveSkill() {
        if (!ready()) return;
        int row = skills.getSelectedRow();
        if (row < 0) { message("Chọn kỹ năng trong bảng trước."); return; }
        final int index = Integer.parseInt(skillModel.getValueAt(row, 0).toString());
        final int desired;
        try { desired = number(targetSkillLevel.getText(), "Cấp kỹ năng", 0, 25); }
        catch (Exception error) { fail(error); return; }
        if (!confirm("Đổi " + skillModel.getValueAt(row, 1) + " thành cấp " + desired + "?")) return;
        edit("Đã lưu kỹ năng.", (db, accountId, playerId, current) -> {
            JSONArray all = array(current.skills(), 0);
            JSONArray selected = null;
            for (Object entry : all) {
                JSONArray skill = (JSONArray)entry;
                if (Integer.parseInt(skill.get(0).toString()) == index) { selected = skill; break; }
            }
            if (selected == null) throw new IllegalArgumentException("Kỹ năng đã thay đổi; hãy tải lại.");
            int playerLevel = Integer.parseInt(array(current.level(), 3).get(0).toString());
            if (desired > playerLevel) throw new IllegalArgumentException("Cấp kỹ năng không thể cao hơn level nhân vật.");
            int family;
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT id_2 FROM skill WHERE id_index=? ORDER BY Lv_RQ DESC LIMIT 1")) {
                ps.setInt(1, index);
                try (ResultSet rs = ps.executeQuery()) {
                    if (!rs.next()) throw new IllegalArgumentException("Không tìm thấy mẫu kỹ năng.");
                    family = rs.getInt(1);
                }
            }
            int clazz;
            try (PreparedStatement ps = db.prepareStatement("SELECT clazz FROM players WHERE id=?")) {
                ps.setInt(1, playerId);
                try (ResultSet rs = ps.executeQuery()) { rs.next(); clazz = rs.getInt(1); }
            }
            if (clazz < 1 || clazz > 5) throw new IllegalArgumentException("Hệ nhân vật không hợp lệ.");
            // id_2 0..3 is shared by all five classes; constrain the target to this player's class.
            String sql = family <= 3
                ? "SELECT id_index FROM skill WHERE id_2=? AND Lv_RQ=? AND "
                    + "((id_index BETWEEN ? AND ?) OR (id_index BETWEEN ? AND ?)) ORDER BY id LIMIT 1"
                : "SELECT id_index FROM skill WHERE id_2=? AND Lv_RQ=? ORDER BY id LIMIT 1";
            int newIndex;
            try (PreparedStatement ps = db.prepareStatement(sql)) {
                ps.setInt(1, family); ps.setInt(2, desired == 0 ? -1 : desired);
                if (family <= 3) {
                    int[] range = classSkillRange(family, clazz);
                    ps.setInt(3, range[0]); ps.setInt(4, range[1]);
                    ps.setInt(5, range[2]); ps.setInt(6, range[3]);
                }
                try (ResultSet rs = ps.executeQuery()) {
                    if (!rs.next()) throw new IllegalArgumentException("Hệ nhân vật này không có kỹ năng cấp " + desired + ".");
                    newIndex = rs.getInt(1);
                }
            }
            selected.set(0, newIndex);
            selected.set(1, desired == 0 ? -1 : 0);
            try (PreparedStatement ps = db.prepareStatement("UPDATE players SET skill=? WHERE id=?")) {
                ps.setString(1, all.toJSONString()); ps.setInt(2, playerId);
                if (ps.executeUpdate() != 1) throw new IllegalStateException("Không lưu được kỹ năng.");
            }
        });
    }

    private static int[] classSkillRange(int family, int clazz) {
        int base = family == 3 ? 375 + (clazz - 1) * 20 : (clazz - 1) * 60;
        int high = family == 3 ? base : 566 + (clazz - 1) * 18;
        return new int[]{base, base + (family == 3 ? 19 : 59),
                         high, high + (family == 3 ? 19 : 17)};
    }

    private static String questStage(int status) {
        return switch (status) {
            case 0 -> "Nhận nhiệm vụ";
            case 1 -> "Đang làm";
            case 2 -> "Trả nhiệm vụ";
            default -> "Trạng thái " + status;
        };
    }

    private void chooseQuest() {
        pickFromCatalog("Chọn bước quest chính", new String[]{"ID", "Tên quest", "Bước", "Level yêu cầu"},
            "SELECT id,name,CASE statusQuest WHEN 0 THEN 'Nhận nhiệm vụ' "
                + "WHEN 1 THEN 'Đang làm' ELSE 'Trả nhiệm vụ' END,lvRequest "
                + "FROM quests WHERE id>=0 AND typeMainSub=0 ORDER BY id", row -> {
                selectedQuestId = ((Number)row[0]).intValue();
                chosenQuest.setText("#" + selectedQuestId + " " + row[1] + " — " + row[2]);
            });
    }

    private void saveQuest() {
        if (!ready()) return;
        if (selectedQuestId == null) { message("Chọn quest trong danh sách trước."); return; }
        int questId = selectedQuestId;
        if (!confirm("Chuyển quest chính của " + loadedName + " sang " + chosenQuest.getText()
                + "? Tiến độ quest hiện tại sẽ được thay thế; không nhận phần thưởng của các bước bỏ qua.")) return;
        edit("Đã chuyển quest chính.", (db, accountId, playerId, current) -> {
            JSONArray defaults;
            try (PreparedStatement ps = db.prepareStatement(
                    "SELECT data_quest FROM quests WHERE id=? AND id>=0 AND typeMainSub=0")) {
                ps.setInt(1, questId);
                try (ResultSet rs = ps.executeQuery()) {
                    if (!rs.next()) throw new IllegalArgumentException("Quest chính không tồn tại.");
                    defaults = array(rs.getString(1), 0);
                }
            }
            JSONArray quests = array(current.quests(), 0);
            replaceMainQuest(quests, questId, defaults);
            try (PreparedStatement ps = db.prepareStatement("UPDATE players SET quest=? WHERE id=?")) {
                ps.setString(1, quests.toJSONString()); ps.setInt(2, playerId);
                if (ps.executeUpdate() != 1) throw new IllegalStateException("Không lưu được quest.");
            }
        });
    }

    private static void replaceMainQuest(JSONArray quests, int id, JSONArray defaults) {
        JSONArray next = new JSONArray(); next.add(id); next.add(defaults);
        if (quests.isEmpty()) quests.add(next);
        else {
            JSONArray old = (JSONArray)quests.get(0);
            if (Integer.parseInt(old.get(0).toString()) < 0)
                throw new IllegalArgumentException("Dữ liệu quest chính không hợp lệ.");
            quests.set(0, next);
        }
    }

    private void chooseItem() {
        pickFromCatalog("Chọn item (loại 3/4/7)", new String[]{"Loại", "ID", "Tên item", "Level", "Hệ"},
            "SELECT 3 AS kind,id,name,level,clazz FROM item3 WHERE id BETWEEN 0 AND 32767 "
                + "UNION ALL SELECT 4,id,name,0,0 FROM item4 WHERE id BETWEEN 0 AND 32767 "
                + "UNION ALL SELECT 7,id,name,0,0 FROM item7 WHERE id BETWEEN 0 AND 32767 "
                + "ORDER BY kind,id", row -> {
                itemType.setText(row[0].toString());
                itemId.setText(row[1].toString());
                chosenItem.setText(row[2].toString());
            });
    }

    private void pickFromCatalog(String title, String[] columns, String sql, Consumer<Object[]> selected) {
        JDialog dialog = new JDialog(frame, title, true);
        dialog.setMinimumSize(new Dimension(560, 380));
        dialog.setSize(760, 520);
        dialog.setLocationRelativeTo(frame);
        DefaultTableModel catalog = new DefaultTableModel(columns, 0) {
            @Override public boolean isCellEditable(int row, int column) { return false; }
        };
        JTable table = new JTable(catalog);
        table.setRowHeight(25);
        table.setSelectionMode(javax.swing.ListSelectionModel.SINGLE_SELECTION);
        TableRowSorter<DefaultTableModel> sorter = new TableRowSorter<>(catalog);
        table.setRowSorter(sorter);
        JTextField filter = new JTextField(25);
        JButton find = new JButton("Tìm");
        Runnable search = () -> {
            String term = filter.getText().trim();
            sorter.setRowFilter(term.isEmpty() ? null : RowFilter.regexFilter("(?iu)" + Pattern.quote(term)));
        };
        find.addActionListener(event -> search.run());
        filter.addActionListener(event -> search.run());
        JPanel top = new JPanel(new FlowLayout(FlowLayout.LEFT));
        top.add(new JLabel("Tìm theo tên hoặc ID:")); top.add(filter); top.add(find);
        dialog.add(top, BorderLayout.NORTH);
        dialog.add(new JScrollPane(table), BorderLayout.CENTER);
        JPanel bottom = new JPanel(new FlowLayout(FlowLayout.LEFT));
        JLabel count = new JLabel("Đang tải danh sách...");
        bottom.add(count);
        JButton choose = new JButton("Chọn dòng đang đánh dấu");
        choose.addActionListener(event -> {
            int view = table.getSelectedRow();
            if (view < 0) { JOptionPane.showMessageDialog(dialog, "Chọn một dòng trong danh sách."); return; }
            int row = table.convertRowIndexToModel(view);
            Object[] values = new Object[catalog.getColumnCount()];
            for (int col = 0; col < values.length; col++) values[col] = catalog.getValueAt(row, col);
            selected.accept(values);
            dialog.dispose();
        });
        bottom.add(choose);
        dialog.add(bottom, BorderLayout.SOUTH);
        new SwingWorker<List<Object[]>, Void>() {
            @Override protected List<Object[]> doInBackground() throws Exception {
                List<Object[]> rows = new ArrayList<>();
                try (Connection db = AdminPanel.connect(config);
                     PreparedStatement ps = db.prepareStatement(sql);
                     ResultSet rs = ps.executeQuery()) {
                    while (rs.next()) {
                        Object[] row = new Object[columns.length];
                        for (int i = 0; i < row.length; i++) row[i] = rs.getObject(i + 1);
                        rows.add(row);
                    }
                }
                return rows;
            }
            @Override protected void done() {
                try {
                    for (Object[] row : get()) catalog.addRow(row);
                    count.setText(catalog.getRowCount() + " mục; nhập tên hoặc ID rồi bấm Tìm.");
                } catch (Exception error) { dialog.dispose(); fail(error); }
            }
        }.execute();
        dialog.setVisible(true);
    }

    private void sendItem() {
        if (!ready()) return;
        if (Files.exists(Path.of("backend-src", "build", "htth-server.next.jar"))) {
            message("Bản server mới chưa được kích hoạt. Hãy đóng game, chạy stop.ps1 rồi start.ps1 trước khi gửi item.");
            return;
        }
        final int type, id, quantity;
        try {
            type = number(itemType.getText(), "Loại item", 3, 7);
            if (type != 3 && type != 4 && type != 7) throw new IllegalArgumentException("Chỉ hỗ trợ loại 3, 4 hoặc 7.");
            id = number(itemId.getText(), "ID item", 0, 32767);
            quantity = number(itemQuantity.getText(), "Số lượng", 1, type == 3 ? 1 : 2000);
        } catch (Exception error) { fail(error); return; }
        String user = loadedUser, name = loadedName;
        new SwingWorker<String, Void>() {
            @Override protected String doInBackground() throws Exception {
                String table = type == 3 ? "item3" : type == 4 ? "item4" : "item7";
                try (Connection db = AdminPanel.connect(config)) {
                    read(db, user, name, false);
                    try (PreparedStatement ps = db.prepareStatement("SELECT name FROM " + table + " WHERE id=?")) {
                        ps.setInt(1, id);
                        try (ResultSet rs = ps.executeQuery()) {
                            if (!rs.next()) throw new IllegalArgumentException("ID item không tồn tại.");
                            return rs.getString(1);
                        }
                    }
                }
            }
            @Override protected void done() {
                try {
                    String itemName = get();
                    if (!confirm("Gửi " + quantity + " × " + itemName + " cho " + name + "?")) return;
                    queueGift(user, name, type, id, quantity);
                } catch (Exception error) { fail(error); }
            }
        }.execute();
    }

    private void queueGift(String user, String name, int type, int id, int quantity) {
        new SwingWorker<Void, Void>() {
            @Override protected Void doInBackground() throws Exception {
                try (Connection db = AdminPanel.connect(config)) {
                    read(db, user, name, false);
                    JSONArray gift = new JSONArray(); gift.add(type); gift.add(id); gift.add(quantity);
                    JSONArray items = new JSONArray(); items.add(gift);
                    JSONObject data = new JSONObject();
                    data.put("title", "Quà từ Admin"); data.put("notice", "Vật phẩm được gửi từ Admin Panel.");
                    data.put("items", items);
                    try (PreparedStatement ps = db.prepareStatement(
                            "INSERT INTO web_admin_commands (command,target_user,data,status) VALUES ('SEND_MAIL',?,?,0)")) {
                        ps.setString(1, name); ps.setString(2, data.toJSONString());
                        ps.executeUpdate();
                    }
                }
                return null;
            }
            @Override protected void done() {
                try { get(); message("Đã xếp quà vào hàng chờ. Nhân vật sẽ nhận khi online."); }
                catch (Exception error) { fail(error); }
            }
        }.execute();
    }

    private boolean ready() {
        if (loaded == null || !account.getText().trim().equals(loadedUser)
                || !character.getText().trim().equals(loadedName)) {
            message("Tải lại đúng nhân vật trước khi thao tác."); return false;
        }
        return true;
    }

    private void edit(String success, Change change) {
        String user = loadedUser, name = loadedName;
        CharacterData expected = loaded;
        state.setText("Đang lưu...");
        new SwingWorker<Void, Void>() {
            @Override protected Void doInBackground() throws Exception {
                try (Connection db = AdminPanel.connect(config)) {
                    db.setAutoCommit(false);
                    try {
                        CharacterData current = read(db, user, name, true);
                        if (current.online()) throw new IllegalStateException("Nhân vật đang online. Hãy đăng xuất rồi tải lại.");
                        if (!expected.level().equals(current.level()) || !expected.potential().equals(current.potential())
                                || !expected.money().equals(current.money()) || !expected.skills().equals(current.skills())
                                || !expected.quests().equals(current.quests())
                                || expected.coin() != current.coin())
                            throw new IllegalStateException("Dữ liệu đã thay đổi. Hãy tải lại trước khi lưu.");
                        int accountId, playerId;
                        try (PreparedStatement ps = db.prepareStatement(
                                "SELECT id FROM accounts WHERE BINARY `user`=?")) {
                            ps.setString(1, user);
                            try (ResultSet rs = ps.executeQuery()) { rs.next(); accountId = rs.getInt(1); }
                        }
                        try (PreparedStatement ps = db.prepareStatement(
                                "SELECT id FROM players WHERE BINARY name=?")) {
                            ps.setString(1, name);
                            try (ResultSet rs = ps.executeQuery()) { rs.next(); playerId = rs.getInt(1); }
                        }
                        change.run(db, accountId, playerId, current);
                        db.commit();
                    } catch (Exception error) { db.rollback(); throw error; }
                }
                return null;
            }
            @Override protected void done() {
                try { get(); state.setText(success); load(); }
                catch (Exception error) { fail(error); }
            }
        }.execute();
    }

    private boolean confirm(String question) {
        return JOptionPane.showConfirmDialog(frame, question, "Xác nhận", JOptionPane.YES_NO_OPTION)
            == JOptionPane.YES_OPTION;
    }

    private void message(String text) {
        state.setText(text);
        JOptionPane.showMessageDialog(frame, text, "Admin Panel", JOptionPane.INFORMATION_MESSAGE);
    }

    private void fail(Exception error) {
        Throwable cause = error;
        while (cause.getCause() != null) cause = cause.getCause();
        state.setText("Thao tác thất bại.");
        JOptionPane.showMessageDialog(frame, cause.getMessage(), "Lỗi", JOptionPane.ERROR_MESSAGE);
    }

    public static void main(String[] args) {
        if (args.length != 1 || !"--self-test".equals(args[0])) return;
        assert array("[1,2,3]", 3).size() == 3;
        assert number("100", "Level", 1, 100) == 100;
        assert amount("2000000000", "Beri", 2_000_000_000L) == 2_000_000_000L;
        int[] fighter = classSkillRange(0, 4);
        assert fighter[0] == 180 && fighter[1] == 239 && fighter[2] == 620 && fighter[3] == 637;
        assert classSkillRange(3, 4)[0] == 435;
        JSONArray quest = array("[[11,[]],[-1000,[]]]", 2);
        replaceMainQuest(quest, 12, array("[[2,0,20,0]]", 1));
        assert ((JSONArray)quest.get(0)).get(0).equals(12);
        assert ((JSONArray)quest.get(1)).get(0).equals(-1000L);
        try { number("101", "Level", 1, 100); throw new AssertionError(); }
        catch (IllegalArgumentException expected) { /* bound checked */ }
        System.out.println("Admin character editor self-test OK");
    }
}
