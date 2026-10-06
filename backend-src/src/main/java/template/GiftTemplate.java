/*
 * Decompiled with CFR 0.152.
 */
package template;

import database.SQL;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import org.json.simple.JSONArray;
import org.json.simple.JSONValue;

public class GiftTemplate {
    public String giftname;
    public int luotnhap;
    public int gioihan;
    public String notice;
    public int beri;
    public int ruby;
    public byte[] type;
    public short[] id;
    public short[] quant;
    public String used;
    public String special;

    public GiftTemplate(String giftname, int luotnhap, int gioihan, String notice, int beri, int ruby, String item, String used, String special) {
        this.giftname = giftname;
        this.luotnhap = luotnhap;
        this.gioihan = gioihan;
        this.notice = notice != null ? notice : "";
        this.beri = beri;
        this.ruby = ruby;
        JSONArray js = (JSONArray)JSONValue.parse(item);
        if (js.size() > 0) {
            this.type = new byte[js.size()];
            this.id = new short[js.size()];
            this.quant = new short[js.size()];
            for (int i = 0; i < this.id.length; ++i) {
                JSONArray js2 = (JSONArray)JSONValue.parse(js.get(i).toString());
                this.type[i] = Byte.parseByte(js2.get(0).toString());
                this.id[i] = Short.parseShort(js2.get(1).toString());
                this.quant[i] = Short.parseShort(js2.get(2).toString());
            }
        }
        this.used = used != null ? used : "";
        this.special = special != null ? special : "";
        this.used = this.used.replace(" ", "");
        this.special = this.special.replace(" ", "");
    }

    /*
     * WARNING - Removed try catching itself - possible behaviour change.
     */
    public static synchronized void update_used(GiftTemplate temp, String name) {
        Connection conn = null;
        Statement st = null;
        try {
            conn = SQL.gI().getCon();
            st = conn.createStatement();
            temp.used = temp.used + name + ",";
            ++temp.luotnhap;
            st.executeUpdate("UPDATE `giftcode` SET `used` = '" + temp.used + "', `luotnhap` = " + temp.luotnhap + " WHERE `giftname` = '" + temp.giftname + "' LIMIT 1;");
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (st != null) {
                    st.close();
                }
                if (conn != null) {
                    conn.close();
                }
            }
            catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }
}

