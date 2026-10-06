/*
 * Decompiled with CFR 0.152.
 */
package template;

import java.util.List;
import template.PartImg;

public class Part {
    public static List<Part> ENTRY;
    public byte type;
    public PartImg[] pi;
    public short id;

    public Part(byte type) {
        this.type = type;
        switch (type) {
            case 0: {
                this.pi = new PartImg[5];
                break;
            }
            case 1: {
                this.pi = new PartImg[20];
                break;
            }
            case 2: {
                this.pi = new PartImg[15];
                break;
            }
            case 3: {
                this.pi = new PartImg[24];
                break;
            }
            case 4: {
                this.pi = new PartImg[2];
                break;
            }
            case 5: {
                this.pi = new PartImg[2];
            }
        }
    }

    public static Part get_part(short index) {
        for (int i = 0; i < ENTRY.size(); ++i) {
            if (Part.ENTRY.get((int)i).id != index) continue;
            return ENTRY.get(i);
        }
        return null;
    }
}

