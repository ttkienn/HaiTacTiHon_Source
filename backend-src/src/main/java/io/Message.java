/*
 * Decompiled with CFR 0.152.
 */
package io;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;

public class Message {
    public byte cmd;
    private ByteArrayOutputStream os;
    private DataOutputStream dos;
    private ByteArrayInputStream is;
    private DataInputStream dis;

    public Message(int cmd) {
        this.cmd = (byte)cmd;
        this.os = new ByteArrayOutputStream();
        this.dos = new DataOutputStream(this.os);
    }

    public Message(byte cmd, byte[] data) {
        this.cmd = cmd;
        this.is = new ByteArrayInputStream(data);
        this.dis = new DataInputStream(this.is);
    }

    public DataOutputStream writer() {
        return this.dos;
    }

    public DataInputStream reader() {
        return this.dis;
    }

    public byte[] getData() {
        return this.os.toByteArray();
    }

    public void cleanup() throws IOException {
        if (this.os != null) {
            this.os.close();
        }
        if (this.is != null) {
            this.is.close();
        }
        if (this.dis != null) {
            this.dis.close();
        }
        if (this.dos != null) {
            this.dos.close();
        }
    }
}

