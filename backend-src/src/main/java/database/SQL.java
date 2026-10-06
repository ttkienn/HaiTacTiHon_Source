/*
 * Decompiled with CFR 0.152.
 */
package database;

import com.zaxxer.hikari.HikariDataSource;
import core.Manager;
import java.sql.Connection;
import java.sql.SQLException;

public class SQL {
    private static SQL instance = null;
    private HikariDataSource dataSource;
    private final String url;
    private final String user;
    private final String pass;

    public SQL() {
        this.url = "jdbc:mysql://" + Manager.gI().mysql_host + ":3306/" + Manager.gI().mysql_database + "?autoReconnect=true&useUnicode=yes&characterEncoding=UTF-8";
        this.user = Manager.gI().mysql_user;
        this.pass = Manager.gI().mysql_pass;
        HikariDataSource config = new HikariDataSource();
        config.setDriverClassName("com.mysql.cj.jdbc.Driver");
        config.setJdbcUrl(this.url);
        config.setUsername(this.user);
        config.setPassword(this.pass);
        config.setConnectionTimeout(30000L);
        config.setIdleTimeout(600000L);
        config.setMaximumPoolSize(21);
        config.setPoolName("HTTH_pool");
        this.dataSource = new HikariDataSource(config);
        System.out.println("OPEN DataBase connect");
    }

    public static SQL gI() {
        if (instance == null) {
            instance = new SQL();
        }
        return instance;
    }

    public synchronized Connection getCon() {
        Connection conn = null;
        try {
            conn = this.dataSource.getConnection();
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        return conn;
    }

    public void close() {
        this.dataSource.close();
    }
}

