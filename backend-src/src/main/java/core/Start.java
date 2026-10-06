/*
 * Decompiled with CFR 0.152.
 */
package core;

import com.sun.net.httpserver.HttpServer;
import core.ServerManager;
import java.net.InetSocketAddress;
import java.nio.charset.StandardCharsets;

public class Start {
    public static void main(String[] args) throws Exception {
        byte[] response = "null".getBytes(StandardCharsets.UTF_8);
        HttpServer http = HttpServer.create(new InetSocketAddress("127.0.0.1", 2237), 0);
        http.createContext("/thongbao.txt", exchange -> {
            exchange.getResponseHeaders().set("Content-Type", "text/plain; charset=utf-8");
            exchange.sendResponseHeaders(200, response.length);
            exchange.getResponseBody().write(response);
            exchange.close();
        });
        http.createContext("/admin", new AdminWeb());
        http.start();
        ServerManager.gI().init();
    }
}
