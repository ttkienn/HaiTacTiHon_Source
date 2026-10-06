/*
 * Decompiled with CFR 0.152.
 */
package template;

import database.SQL;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.json.simple.JSONArray;

public class ShopTichLuy {
    public static List<ShopTichLuy> ENTRY = new ArrayList<ShopTichLuy>();
    public short id;
    public byte type;
    public int point;
    public String info;
    public int limit;
    public HashMap<String, Integer> limit_data;

    public static ShopTichLuy get_temp_id(int type, int id) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (ShopTichLuy.ENTRY.get((int)i).type != type || ShopTichLuy.ENTRY.get((int)i).id != id) continue;
            return ENTRY.get(i);
        }
        return null;
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public static void update() {
        Connection connection = null;
        PreparedStatement ps = null;
        try {
            connection = SQL.gI().getCon();
            ps = connection.prepareStatement("UPDATE `shoptichluy` SET `limit_data` = ? WHERE `id` = ?");
            for (int i = 0; i < ENTRY.size(); ++i) {
                ps.clearParameters();
                ShopTichLuy temp = ENTRY.get(i);
                JSONArray js = new JSONArray();
                for (Map.Entry<String, Integer> en : temp.limit_data.entrySet()) {
                    int value = en.getValue();
                    JSONArray js_in = new JSONArray();
                    js_in.add(en.getKey());
                    js_in.add(value);
                    js.add(js_in);
                }
                ps.setNString(1, js.toJSONString());
                ps.setInt(2, temp.id);
                ps.executeUpdate();
            }
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (ps != null) {
                    ps.close();
                }
                if (connection != null) {
                    connection.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }
}

