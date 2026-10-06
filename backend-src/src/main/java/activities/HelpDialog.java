/*
 * Decompiled with CFR 0.152.
 */
package activities;

import client.Player;
import core.Service;
import java.io.IOException;

public class HelpDialog {
    public static void show_LangCoiXayGio(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "\u0110\u0103ng k\u00fd t\u00e0i kho\u1ea3n\r\nN\u1ebfu b\u1ea1n l\u00e0 t\u00e0i kho\u1ea3n ch\u01a1i m\u1edbi, h\u00e3y luy\u1ec7n \u0111\u1ebfn Level 4 v\u00e0 \u0111\u1ebfn g\u1eb7p Tr\u01b0\u1edfng l\u00e0ng \u0111\u1ec3 \u0111\u0103ng k\u00fd t\u00e0i kho\u1ea3n.\bNh\u1eadp v\u00e0o T\u00ean t\u00e0i kho\u1ea3n ( Email ho\u1eb7c l\u00e0 s\u1ed1 \u0111i\u1ec7n tho\u1ea1i) v\u00e0 m\u1eadt kh\u1ea9u t\u1eeb 6 \u0111\u1ebfn 12 k\u00fd t\u1ef1.\bCh\u00fang t\u00f4i s\u1ebd tr\u1ea3 v\u1ec1 th\u00f4ng b\u00e1o x\u00e1c nh\u1eadn vi\u1ec7c \u0111\u0103ng k\u00fd c\u1ee7a b\u1ea1n \u0111\u00e3 ho\u00e0n t\u1ea5t hay ch\u01b0a.";
                break;
            }
            case 1: {
                text = "L\u00e0m nhi\u1ec7m v\u1ee5 t\u00e2n th\u1ee7\r\n\u0110\u1ebfn g\u1eb7p Tr\u01b0\u1edfng l\u00e0ng \u0111\u1ec3 l\u00e0m nhi\u1ec7m v\u1ee5 t\u00e2n th\u1ee7. Sau \u0111\u00f3 h\u00e3y \u0111\u1ebfn g\u1eb7p t\u1eebng ng\u01b0\u1eddi trong l\u00e0ng \u0111\u1ec3 xem h\u1ecd c\u1ea7n gi\u00fap \u0111\u1ee1 g\u00ec kh\u00f4ng.\bNh\u1eefng ng\u01b0\u1eddi c\u00f3 d\u1ea5u ! Tr\u00ean \u0111\u1ea7u ngh\u0129a l\u00e0 h\u1ecd \u0111ang c\u1ea7n b\u1ea1n gi\u00fap \u0111\u1ee1 \u0111\u1ea5y.\bHo\u00e0n th\u00e0nh nhi\u1ec7m v\u1ee5 l\u00e0 c\u00e1ch nhanh nh\u1ea5t gi\u00fap b\u1ea1n th\u0103ng ti\u1ebfn s\u1ee9c m\u1ea1nh.";
                break;
            }
            case 2: {
                text = "C\u1eeda h\u00e0ng th\u1ef1c ph\u1ea9m\r\nH\u00e3y \u0111\u1ebfn g\u1eb7p Machiko \u0111\u1ec3 mua HP, MP, c\u00e1c lo\u1ea1i R\u01b0\u01a1ng B\u00e1u v\u00e0 c\u00e1c v\u1eadt ph\u1ea9m c\u1ea7n thi\u1ebft.\bShop th\u1ef1c ph\u1ea9m c\u00f3 m\u1eb7t h\u1ea7u h\u1ebft t\u1ea5t c\u1ea3 c\u00e1c l\u00e0ng h\u00e3y ch\u00fa \u00fd \u0111\u1ebfn bi\u1ec3u t\u01b0\u1ee3ng tr\u00ean \u0111\u1ea7u c\u1ee7a Machiko \u0111\u00f3 l\u00e0 d\u1ea5u hi\u1ec7u nh\u1eadn ra ng\u01b0\u1eddi b\u00e1n th\u1ef1c ph\u1ea9m.\bNh\u1edb l\u00e0 ph\u1ea3i lu\u00f4n chu\u1ea9n b\u1ecb \u0111\u1ee7 HP v\u00e0 MP trong m\u1ecdi chuy\u1ebfn phi\u00eau l\u01b0u. R\u01b0\u01a1ng b\u00e1u l\u00e0 c\u00e1ch d\u1ec5 nh\u1ea5t gi\u00fap b\u1ea1n c\u00f3 \u0111\u01b0\u1ee3cc\u00e1c trang b\u1ecb t\u1ed1t h\u00e3y nh\u1edb l\u1ea5y.";
                break;
            }
            case 3: {
                text = "V\u1eadn chuy\u1ec3n h\u00e0ng\r\nB\u1ea1n mu\u1ed1n c\u00f3 nhi\u1ec1u Beri, h\u00e3y \u0111\u1ebfn g\u1eb7p Machiko v\u00e0 gi\u00fap c\u00f4 \u1ea5y v\u1eadn chuy\u1ec3n h\u00e0ng khi \u0111\u1ea1t c\u1ea5p 15.\bB\u1ea1n c\u1ea7n \u0111\u0103ng k\u00fd ch\u1ee9c n\u0103ng L\u00e1i bu\u00f4n \u0111\u1ec3 v\u1eadn chuy\u1ec3n h\u00e0ng. Sau khi \u0111\u0103ng k\u00fd, h\u00e3y L\u1ea5y h\u00e0ng v\u00e0 d\u1eabnL\u1ea1c \u0111\u00e0 \u0111i qua c\u00e1c L\u00e0ng kh\u00e1c.\bB\u1ea1n c\u00e0ng \u0111i qua nhi\u1ec1u L\u00e0ng th\u00ec s\u1ed1 ti\u1ec1n nh\u1eadn \u0111\u01b0\u1ee3c s\u1ebd nhi\u1ec1u h\u01a1n. H\u00e3y ch\u00fa \u00fd c\u00e1c H\u1ea3i t\u1eb7c lu\u00f4n s\u1eb5n s\u00e0ng c\u01b0\u1edbp h\u00e0ng c\u1ee7a b\u1ea1n.";
                break;
            }
            case 4: {
                text = "Trang b\u1ecb\r\nH\u00e3y \u0111\u1ebfn g\u1eb7p Guru \u0111\u1ec3 mua s\u1eafm trang b\u1ecb. C\u0169ng nh\u01b0 shop th\u1ef1c ph\u1ea9m th\u00ec c\u1eeda h\u00e0ng trang b\u1ecb c\u00f3 \u1edf h\u1ea7u h\u1ebft c\u00e1c l\u00e0ng b\u1ea1n \u0111i \u0111\u1ebfn.";
                break;
            }
            case 5: {
                text = "K\u1ef9 n\u0103ng \r\nH\u00e3y \u0111\u1ebfn g\u1eb7p Gap, \u00f4ng ta s\u1ebd d\u1ea1y cho b\u1ea1n th\u00eam nhi\u1ec1u k\u1ef9 n\u0103ng m\u1edbi v\u00e0 gi\u00fap b\u1ea1n t\u1ea9y \u0111i\u1ec3m ti\u1ec1m n\u0103ng.\bGap c\u0169ng s\u1ebd theo b\u1ea1n trong c\u00e1c chuy\u1ebfn phi\u00eau l\u01b0u v\u00e0 l\u01b0u \u1edf t\u1ea1i c\u00e1c l\u00e0ng b\u1ea1n \u0111\u1ebfn.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_ThiTranVoSo(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "B\u1ea3ng x\u1ebfp h\u1ea1ng\nC\u1eadu b\u00e9 Cobi \u0111ang gi\u1eef danh s\u00e1ch nh\u1eefng cao th\u1ee7, h\u00e3y \u0111\u1ebfn xem n\u1ebfu b\u1ea1n c\u00f3 h\u1ee9ng th\u00fa.\bNgo\u00e0i b\u1ea3ng x\u1ebfp h\u1ea1ng cao th\u1ee7 c\u00f2n c\u00f3 b\u1ea3ng x\u1ebfp h\u1ea1ng c\u1ee7a c\u00e1c b\u0103ng h\u1ea3i t\u1eb7c n\u1eefa \u0111\u1ea5y.";
                break;
            }
            case 1: {
                text = "Nhi\u1ec7m v\u1ee5 h\u00e0ng ng\u00e0y\nNamie lu\u00f4n c\u00f3 nh\u1eefng th\u1eed th\u00e1ch cho b\u1ea1n m\u1ed7i ng\u00e0y, h\u00e3y \u0111\u1ebfn g\u1eb7p c\u00f4 \u1ea5y \u0111\u1ec3 xem.\bTh\u00e0nh t\u00edch s\u1ebd lu\u00f4n \u0111\u01b0\u1ee3c t\u00ednh v\u00e0 b\u1ea1n ch\u1ec9 c\u1ea7n \u0111\u1ebfn g\u1eb7p c\u00f4 \u1ea5y \u0111\u1ec3 b\u00e1o khi \u0111\u00e3 ho\u00e0n th\u00e0nh th\u00f4i.\bPh\u1ea7n th\u01b0\u1edfng c\u0169ng v\u00f4 c\u00f9ng h\u1ea5p d\u1eabn, \u0111\u1eebng b\u1ecf l\u1ee1.";
                break;
            }
            case 2: {
                text = "C\u01b0\u1eddng ho\u00e1 trang b\u1ecb\nH\u00e3y \u0111\u1ebfn g\u1eb7p Johny, anh ta s\u1ebd d\u1ea1y b\u1ea1n c\u00e1ch th\u1ef1c hi\u1ec7n.\bTrang b\u1ecb sau khi c\u01b0\u1eddng ho\u00e1 s\u1ebd m\u1ea1nh h\u01a1n, c\u1ea5p c\u01b0\u1eddng ho\u00e1 c\u00e0ng cao th\u00ec s\u1ee9c m\u1ea1nh c\u1ee7a trang b\u1ecb c\u00e0ng cao.\b\u0110\u1ec3 c\u01b0\u1eddng ho\u00e1 b\u1ea1n c\u1ea7n c\u00f3 Nguy\u00ean li\u1ec7u, b\u1ea1n c\u00f3 th\u1ec3 mua t\u1ea1i C\u1eeda h\u00e0ng c\u1ee7a Johny ho\u1eb7c t\u00e1ch nh\u1eefng trang b\u1ecb kh\u00f4ng d\u00f9ng \u0111\u1ebfn \u0111\u1ec3 l\u1ea5y Nguy\u00ean li\u1ec7u.\bNg\u00f4i sao may m\u1eafn s\u1ebd t\u0103ng t\u1ec9 l\u1ec7 th\u00e0nh c\u00f4ng khi b\u1ea1n C\u01b0\u1eddng ho\u00e1. Mai r\u00f9a s\u1ebd gi\u00fap b\u1ea1n gi\u1eef nguy\u00ean c\u1ea5p C\u01b0\u1eddng ho\u00e1 n\u1ebfu nh\u01b0 b\u1ea1n C\u01b0\u1eddng ho\u00e1 th\u1ea5t b\u1ea1i.";
                break;
            }
            case 3: {
                text = "Kh\u1ea3m \u0111\u00e1\nJohny s\u1ebd d\u1ea1y b\u1ea1n c\u00e1ch Kh\u1ea3m \u0111\u00e1, h\u00e3y \u0111\u1ebfn g\u1eb7p anh ta n\u1ebfu nh\u01b0 b\u1ea1n mu\u1ed1n m\u1ea1nh h\u01a1n. \u0110\u00e1 kh\u1ea3m c\u00f3 nhi\u1ec1u lo\u1ea1i, m\u1ed7i lo\u1ea1i l\u1ea1i c\u00f3 nh\u1eefng \u0111\u1eb7c tr\u01b0ng ri\u00eang.\b\u0110\u1ec3 c\u00f3 \u0111\u00e1 kh\u1ea3m, b\u1ea1n c\u00f3 th\u1ec3 mua t\u1ea1i C\u1eeda h\u00e0ng c\u1ee7a Johny, l\u00e0m nhi\u1ec7m v\u1ee5 l\u1eb7p ho\u1eb7c m\u1edf R\u01b0\u01a1ng huy\u1ec1n b\u00ed.\b\u0110\u00e1 kh\u1ea3m c\u00f3 6 c\u1ea5p \u0111\u1ed9, c\u1ea7n 3 vi\u00ean c\u00f9ng lo\u1ea1i \u0111\u1ec3 gh\u00e9p th\u00e0nh 1 vi\u00ean c\u00f3 c\u1ea5p cao h\u01a1n. M\u1ed7i trang b\u1ecb s\u1ebd c\u00f3 t\u1ed1i \u0111a 4 l\u1ed7 kh\u1ea3m, h\u00e3y \u0111\u1ee5c th\u00eam l\u1ed7 kh\u1ea3m n\u1ebfu nh\u01b0 b\u1ea1n mu\u1ed1n kh\u1ea3m nhi\u1ec1u \u0111\u00e1 h\u01a1n v\u00e0o trang b\u1ecb.";
                break;
            }
            case 4: {
                text = "Chuy\u1ec3n ho\u00e1\nB\u1ea1n c\u00f3 nh\u1eefng trang b\u1ecb c\u00f3 c\u1ea5p c\u01b0\u1eddng ho\u00e1 cao, mu\u1ed1n chuy\u1ec3n c\u1ea5p c\u01b0\u1eddng ho\u00e1 cho nh\u1eefng trang b\u1ecb kh\u00e1c c\u00f3 Level cao h\u01a1n, h\u00e3y \u0111\u1ebfn g\u1eb7p Johny, anh \u1ea5y s\u1ebd gi\u00fap b\u1ea1n.\bTrang b\u1ecb mu\u1ed1n chuy\u1ec3n ph\u1ea3i c\u00f3 c\u1ea5p c\u01b0\u1eddng ho\u00e1 l\u1edbn h\u01a1n ho\u1eb7c b\u1eb1ng 6.\n Trang b\u1ecb nh\u1eadn ph\u1ea3i c\u00f3 c\u1ea5p c\u01b0\u1eddng ho\u00e1 nh\u1ecf h\u01a1n ho\u1eb7c b\u1eb1ng 5.\bKhi chuy\u1ec3n ho\u00e1 v\u1eabn s\u1ebd c\u00f3 t\u1ec9 l\u1ec7 r\u1edbt c\u1ea5p c\u01b0\u1eddng ho\u00e1, b\u1ea1n n\u00ean ch\u00fa \u00fd. Trang b\u1ecb sau khi chuy\u1ec3n ho\u00e1 s\u1ebd kh\u00f4ng b\u1ecb m\u1ea5t, ch\u1ec9 chuy\u1ec3n ho\u00e1 c\u1ea5p c\u01b0\u1eddng ho\u00e1 t\u1eeb trang b\u1ecb n\u00e0y sang trang b\u1ecb kh\u00e1c.";
                break;
            }
            case 5: {
                text = "Ph\u00f3 b\u1ea3n s\u0103n boss\nH\u00e3y \u0111\u1ebfn g\u1eb7p Zosaku, anh ta s\u1ebd \u0111\u01b0a b\u1ea1n \u0111\u1ebfn nh\u1eefng ph\u00f3 b\u1ea3n v\u00f4 c\u00f9ng cam go, tuy nhi\u00ean ph\u1ea7n th\u01b0\u1edfng nh\u1eadn \u0111\u01b0\u1ee3c c\u0169ng kh\u00f4ng h\u1ec1 nh\u1ecf.\b\u0110\u1ec3 c\u00f3 th\u1ec3 v\u00e0o Ph\u00f3 b\u1ea3n s\u0103n boss, b\u1ea1n c\u1ea7n t\u1ea1o nh\u00f3m \u00edt nh\u1ea5t 2 ng\u01b0\u1eddi. M\u1ed7i ng\u01b0\u1eddi c\u1ea7n c\u00f3 1 Chia kho\u00e1 ph\u00f3 b\u1ea3n.\bSau khi t\u1ea1o nh\u00f3m, b\u1ea1n h\u00e3y ch\u1ecdn cho m\u00ecnh 1 Boss v\u1eeba s\u1ee9c v\u00e0 \u0111\u00e1nh b\u1ea1i n\u00f3. Khi h\u1ea1 \u0111\u01b0\u1ee3c Boss, b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c ph\u1ea7n th\u01b0\u1edfng h\u1ea5p d\u1eabn.";
                break;
            }
            case 6: {
                text = "\u0110\u1ea5u Boss li\u00ean t\u1ea7ng\n\u0110\u1ec3 c\u00f3 th\u1ec3 v\u00e0o \u0110\u1ea5u Boss li\u00ean t\u1ea7ng, b\u1ea1n c\u1ea7n t\u1ea1o nh\u00f3m \u00edt nh\u1ea5t 2 ng\u01b0\u1eddi. M\u1ed7i ng\u01b0\u1eddi c\u1ea7n c\u00f3 2 Ch\u00eca kho\u00e1 ph\u00f3 b\u1ea3n.\bSau khi t\u1ea1o nh\u00f3m, h\u00e3y \u0111\u1ebfn g\u1eb7p Zosaku, anh ta s\u1ebd \u0111\u01b0a b\u1ea1n v\u00e0 \u0111\u1ed3ng \u0111\u1ed9i v\u00e0o.\bT\u1ea1i \u0111\u00e2y s\u1ebd c\u00f3 7 t\u1ea7ng, m\u1ed7i t\u1ea7ng s\u1ebd c\u00f3 2 ph\u00fat \u0111\u1ec3 chinh ph\u1ee5c, b\u1ea1n c\u1ea7n \u0111\u00e1nh ch\u1ebft h\u1ebft qu\u00e1i v\u00e0 Boss \u0111\u1ec3 c\u00f3 th\u1ec3 l\u00ean t\u1ea7ng ti\u1ebfp theo. Sau khi qua m\u1ed7i t\u1ea7ng \u0111\u1ec1u c\u00f3 ph\u1ea7n th\u01b0\u1edfng.";
                break;
            }
            case 7: {
                text = "PvP\nNh\u1eefng cu\u1ed9c chi\u1ebfn n\u00e3y l\u1eeda s\u1ebd di\u1ec5n ra t\u1ea1i \u0111\u1ea5u tr\u01b0\u1eddng PvP n\u00e0y. Zosaku s\u1ebd \u0111\u01b0a b\u1ea1n v\u00e0o. \u0110\u1ec3 c\u00f3 th\u1ec3 \u0111\u0103ng k\u00fd PvP b\u1ea1n c\u1ea7n t\u1ed1n 1 v\u00e9 PvP.\bC\u1ea3 2 s\u1ebd c\u00f3 3 ph\u00fat \u0111\u1ec3 ph\u00e2n th\u1eafng b\u1ea1i, ng\u01b0\u1eddi th\u1eafng tr\u01b0\u1edbc 5 hi\u1ec7p \u0111\u1ea5u s\u1ebd th\u1eafng. Sau 3 ph\u00fat, ai c\u00f3 s\u1ed1 b\u00e0n th\u1eafng nhi\u1ec1u h\u01a1n s\u1ebd th\u1eafng cu\u1ed9c.\bSau m\u1ed7i th\u00e1ng s\u1ebd t\u1ed5ng k\u1ebft ng\u01b0\u1eddi c\u00f3 s\u1ed1 \u0111i\u1ec3m PvP cao nh\u1ea5t \u0111\u1ec3 trao gi\u1ea3i v\u00e0 ph\u1ea7n th\u01b0\u1edfng th\u00ec c\u0169ng kh\u00f4ng h\u1ec1 nh\u1ecf \u0111\u00e2u.";
                break;
            }
            case 8: {
                text = "Kho\u00e1 b\u1ea3o v\u1ec7\n H\u00e3y \u0111\u1ea3m b\u1ea3o \u0111\u1ed3 \u0111\u1ea1c, trang b\u1ecb ... c\u1ee7a b\u1ea1n \u0111\u01b0\u1ee3c b\u1ea3o qu\u1ea3n an to\u00e0n b\u1eb1ng c\u00e1ch \u0111\u1ebfn g\u1eb7p c\u00e1c NPC B\u00e1n trang b\u1ecb trong c\u00e1c L\u00e0ng \u0111\u1ec3 ti\u1ebfn h\u00e0nh \u0111\u1eb7t Kho\u00e1 b\u1ea3o v\u1ec7\b Khi \u0111\u0103ng k\u00fd Kho\u00e1 b\u1ea3o v\u1ec7 b\u1ea1n c\u1ea7n nh\u1eadp m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7 t\u1eeb 4 \u0111\u1ebfn 6 k\u00ed t\u1ef1\bB\u01b0\u1edbc nh\u1eadp ng\u00e0y sinh r\u1ea5t quan tr\u1ecdng, b\u1ea1n n\u00ean nh\u1eadp \u0111\u00fang ng\u00e0y sinh c\u1ee7a m\u00ecnh \u0111\u1ec3 c\u00f3 th\u1ec3 l\u1ea5y l\u1ea1i m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7 trong tr\u01b0\u1eddng h\u1ee3p qu\u00ean m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7\b Trong tr\u01b0\u1eddng h\u1ee3p b\u1ea1n qu\u00ean m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7 v\u00e0 ng\u00e0y sinh th\u00ec h\u00e3y d\u00f9ng ch\u1ee9c n\u0103ng Xo\u00e1 m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7, h\u1ec7 th\u1ed1ng s\u1ebd xo\u00e1 m\u1eadt kh\u1ea9u b\u1ea3o v\u1ec7 sau 5 ng\u00e0y";
                break;
            }
            case 9: {
                text = "N\u1ea1p ti\u1ec1n\nKhi b\u1ea1n c\u1ea7n c\u00f3 th\u00eam nhi\u1ec1u Ruby, h\u00e3y \u0111\u1ebfn g\u1eb7p Namie, c\u00f4 \u1ea5y s\u1ebd gi\u00fap b\u1ea1n.\b Khi n\u1ea1p ti\u1ec1n b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c 1 ph\u1ea7n ruby \u0111\u1ec3 mua c\u00e1c v\u1eadt ph\u1ea9m trong tr\u00f2 ch\u01a1i\n 1 ph\u1ea7n Extol \u0111\u1ec3 mua b\u00e1n \u0111\u1ed3 trong ch\u1ee3.\b B\u1ea1n c\u00f3 th\u1ec3 \u0111\u1ed5i t\u1eeb Extol ra ruby t\u1ea1i Namie v\u1edbi t\u1ec9 gi\u00e1 l\u00e0 1000Extol = 1 Ruby.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_ThiTranOrange(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "Ch\u1ee3 mua b\u00e1n\nCh\u1ec9 duy nh\u1ea5t t\u1ea1i th\u1ecb tr\u1ea5n n\u00e0y s\u1ebd di\u1ec5n ra nh\u1eefng phi\u00ean ch\u1ee3 mua b\u00e1n v\u1eadt ph\u1ea9m.\b H\u00e3y \u0111\u1ebfn g\u1eb7p Namie, c\u00f4 \u1ea5y s\u1ebd \u0111\u01b0a b\u1ea1n \u0111\u1ebfn tham quan khu v\u1ef1c ch\u1ee3 v\u00e0 c\u00e1c v\u1eadt ph\u1ea9m \u0111\u01b0\u1ee3c b\u00e0y b\u00e1n. B\u1ea1n c\u00f3 th\u1ec3 b\u00e1n nh\u1eefng trang b\u1ecb kh\u00f4ng d\u00f9ng \u0111\u1ebfn \u0111\u1ec3 ki\u1ebfm th\u00eam thu nh\u1eadp.\b \u0110\u1ec3 c\u00f3 th\u1ec3 b\u00e0y b\u00e1n c\u0169ng nh\u01b0 mua c\u00e1c v\u1eadt ph\u1ea9m \u0111\u01b0\u1ee3c b\u00e0y b\u00e1n t\u1ea1i ch\u1ee3, b\u1ea1n c\u1ea7n c\u00f3 Extol. Extol ch\u1ec9 c\u00f3 \u0111\u01b0\u1ee3c khi b\u1ea1n n\u1ea1p v\u00e0o t\u1eeb th\u1ebb c\u00e0o v\u1edbi 1000vnd b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c 1000 Extol.\b C\u00e1c trang b\u1ecb sau khi m\u1eb7c l\u00ean ng\u01b0\u1eddi s\u1ebd b\u1ecb Kho\u00e1, v\u00e0 b\u1ea1n kh\u00f4ng th\u1ec3 \u0111\u0103ng b\u00e1n trang b\u1ecb kho\u00e1 .\b B\u1ea1n c\u0169ng c\u00f3 th\u1ec3 \u0111\u1ed5i Extol sang Ruby v\u1edbi gi\u00e1 tr\u1ecb quy \u0111\u1ed5i: 1000 Extol = 1 Ruby \u1edf ch\u1ed5 Namie \u0111\u1ec3 d\u00f9ng cho c\u00e1c ch\u1ee9c n\u0103ng kh\u00e1c.";
                break;
            }
            case 1: {
                text = "V\u00f2ng xoay kho b\u00e1u\n Kho b\u00e1u c\u1ee7a bi\u1ec3n \u0110\u00f4ng n\u00e0y ch\u1ec9 c\u00f3 m\u00ecnh Buggi l\u00e0 ng\u01b0\u1eddi c\u00f3 b\u1ea3n \u0111\u1ed3 th\u00f4i.\b H\u00e3y mua th\u1ebb v\u00f2ng quay t\u1ea1i c\u00e1c c\u1eeda h\u00e0ng b\u00e1n th\u1ef1c ph\u1ea9m \u0111\u1ec3 c\u00f3 th\u1ec3 tr\u1ea3i nghi\u1ec7m v\u00f2ng quay. Ngo\u00e0i ra b\u1ea1n c\u0169ng c\u00f3 th\u1ec3 mua v\u00e9 t\u1ea1i ch\u00ednh Buggi v\u1edbi g\u00f3i 3 v\u00e9.\b Khi tham gia v\u00f2ng xoay b\u1ea1n s\u1ebd ng\u1eabu nhi\u00ean nh\u1eadn \u0111\u01b0\u1ee3c c\u00e1c v\u1eadt ph\u1ea9m gi\u00e1 tr\u1ecb m\u00e0 kh\u00f4ng th\u1ec3 mua \u0111\u01b0\u01a1\u0323c \u1edf b\u1ea5t c\u1ee9 \u0111\u00e2u.\n\u0110\u00e1 h\u1ea3i th\u1ea1ch\n R\u01b0\u01a1ng si\u00eau ma thu\u1eadt\n R\u01b0\u01a1ng cam";
                break;
            }
            case 2: {
                text = "Ho\u00e0n m\u1ef9\n Trang b\u1ecb ch\u01b0a \u0111\u01b0\u1ee3c ho\u00e0n m\u1ef9 c\u0169ng gi\u1ed1ng nh\u01b0 ng\u1ecdc qu\u00fd ch\u01b0a qua m\u00e0i d\u0169a kh\u00f4ng th\u1ec3 s\u00e1ng b\u00f3ng \u0111\u01b0\u1ee3c.\b H\u00e3y \u0111\u1ebfn Buggi ch\u1ecdn v\u00e0o Ho\u00e0n m\u1ef9 - K\u00edch \u1ea8n \u0111\u1ec3 c\u00f3 th\u1ec3 ho\u00e0n m\u1ef9 m\u00f3n \u0111\u1ed3 b\u1ea1n c\u1ea7n. \u0110\u1ec3 c\u00f3 th\u1ec3 th\u1ef1c hi\u1ec7n thao t\u00e1c ho\u00e0n m\u1ef9 b\u1ea1n c\u1ea7n c\u00f3 \u0111a\u0301 H\u1ea3i th\u1ea1ch v\u00e0 m\u1ed7i c\u1ea5p \u0111\u00e1 l\u1ea1i c\u00f3 t\u1ec9 l\u1ec7 th\u00e0nh c\u00f4ng kh\u00e1c nhau.\b N\u1ebfu ho\u00e0n m\u1ef9 th\u00e0nh c\u00f4ng m\u00f3n \u0111\u1ed3 c\u1ee7a b\u1ea1n s\u1ebd t\u0103ng 10% gi\u00e1 tr\u1ecb g\u1ed1c. M\u1ed7i l\u1ea7n \u0111\u1eadp ho\u00e0n m\u1ef9 m\u00f3n \u0111\u1ed3 s\u1ebd m\u1ea5t \u0111i 1 s\u1ed1 \u0111i\u1ec3m ch\u1ebf t\u00e1c nh\u1ea5t \u0111\u1ecbnh ph\u1ee5 thu\u1ed9c v\u00e0o c\u1ea5p \u0111\u00e1 h\u1ea3i th\u1ea1ch b\u1ea1n b\u1ecf v\u00e0o.";
                break;
            }
            case 3: 
            case 4: 
            case 5: 
            case 6: {
                text = "K\u00edch \u1ea9n\n M\u1ed7i trang b\u1ecb \u0111i\u1ec1u \u1ea9n ch\u1ee9a trong m\u00ecnh m\u1ed9t thu\u1ed9c t\u00ednh \u1ea9n c\u1ea7n \u0111\u01b0\u1ee3c khai m\u1edf.\b H\u00e3y \u0111\u1ebfn  \u0111\u1ec3 \u00f4ng \u1ea5y gi\u00fap b\u1ea1n l\u00e0m vi\u1ec7c \u0111\u00f3. \u0110\u00e1 H\u1ea3i th\u1ea1ch l\u00e0 nguy\u00ean li\u1ec7u kh\u00f4ng th\u1ec3 thi\u1ebfu \u0111\u1ec3 k\u00edch \u1ea9n. \u1ee8ng v\u1edbi m\u1ed7i c\u1ea5p \u0111\u00e1 b\u1ea1n s\u1ebd c\u00f3 t\u1ec9 l\u1ec7 th\u00e0nh c\u00f4ng kh\u00e1c nhau c\u0169ng nh\u01b0 s\u1ed1 \u0111i\u1ec3m ch\u1ebf t\u00e1c hao t\u1ed3n m\u1ed7i l\u1ea7n k\u00edch c\u0169ng kh\u00e1c nhau.\b Khi k\u00edch \u1ea9n th\u00e0nh c\u00f4ng th\u00ec m\u00f3n trang b\u1ecb \u0111\u00f3 s\u1ebd m\u1ea1nh h\u01a1n r\u1ea5t nhi\u1ec1u \u0111\u1ea5y. C\u00e1c thu\u1ed9c t\u00ednh \u1ea9n khi th\u00e0nh c\u00f4ng b\u1ea1n h\u00e3y xem trong m\u1ee5c Thu\u1ed9c t\u00ednh k\u00edch \u1ea9n nha. M\u1ed7i thu\u1ed9c t\u00ednh ch\u1ec9 c\u1ed9ng d\u1ed3n t\u1ed1i \u0111a 3 l\u1ea7n trong t\u1ea5t c\u1ea3 trang b\u1ecb.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_LangSiRup(Player p, byte index) throws IOException {
        String text = "C\u01b0\u1eddng ho\u00e1 \u00e1c qu\u1ef7\n\u0110\u00e2y l\u00e0 ng\u00f4i l\u00e0ng duy nh\u1ea5t b\u1ea1n c\u00f3 th\u1ec3 C\u01b0\u1eddng ho\u00e1 \u00e1c qu\u1ef7.\b Khi b\u1ea1n \u0111\u1ea1t \u0111\u1ebfn Level 30, tham gia c\u00e1c ho\u1ea1t \u0111\u1ed9ng, ph\u00f3 b\u1ea3n tr\u00ean game s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c Tinh th\u1ec3 \u00e1c qu\u1ef7. B\u1ea1n c\u0169ng c\u00f3 th\u1ec3 mua \u0110\u00e1 \u00e1c qu\u1ef7 t\u1eeb Johny trong c\u1eeda h\u00e0ng c\u01b0\u1eddng ho\u00e1.\b B\u1ea1n c\u00f3 th\u1ec3 C\u01b0\u1eddng ho\u00e1 R\u01b0\u01a1ng \u00e1c qu\u1ef7 l\u00ean R\u01b0\u01a1ng \u0111\u1ea1i \u00e1c qu\u1ef7 \u0111\u1ec3 c\u00f3 c\u01a1 h\u1ed9i m\u1edf ra \u0111\u01b0\u1ee3c tr\u00e1i \u00e1c qu\u1ef7 cao c\u1ea5p.\b B\u1ea1n c\u00f3 th\u1ec3 C\u01b0\u1eddng ho\u00e1 chi\u00eau th\u1ee9c t\u1ea5n c\u00f4ng \u0111\u1ec3 m\u1ea1nh h\u01a1n, k\u1ec3 c\u1ea3 chi\u00eau th\u1ee9c t\u1eeb tr\u00e1i \u00e1c qu\u1ef7.";
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_ThuyenBarati(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "B\u0103ng h\u1ea3i t\u1eb7c\n Ra bi\u1ec3n m\u1ed9t m\u00ecnh t\u1ea5t s\u1ef1 kh\u00f4ng ph\u1ea3i l\u00e0 \u00fd hay v\u00e0 cu\u1ed9c phi\u00eau l\u01b0u s\u1ebd th\u00eam ph\u1ea7n th\u00fa v\u1ecb n\u1ebfu c\u00f3 b\u1ea1n b\u00e8 b\u00ean c\u1ea1nh.\b H\u00e3y \u0111\u1ebfn g\u1eb7p Mihao n\u1ebfu nh\u01b0 b\u1ea1n c\u00f3 d\u1ef1 \u0111\u1ecbnh th\u00e0nh l\u1eadp 1 B\u0103ng h\u1ea3i t\u1eb7c, l\u00e0m nhi\u1ec7m v\u1ee5 B\u0103ng hay tham gia ph\u00f3 b\u1ea3n B\u0103ng. \b Khi tham gia v\u00e0o B\u0103ng b\u1ea1n c\u00f3 th\u1ec3 nh\u1eadn nhi\u1ec7m v\u1ee5 B\u0103ng \u0111\u1ec3 gi\u00fap b\u1ea3n th\u00e2n v\u00e0 c\u00e1c \u0111\u1ed3ng \u0111\u1ed9i m\u1ea1nh h\u01a1n..\b C\u00f3 r\u1ea5t nhi\u1ec1u ph\u00f3 b\u1ea3ng m\u00e0 ch\u1ec9 d\u00e0nh ri\u00eang cho c\u00e1c B\u0103ng th\u1ee9 t\u00e0i v\u1edbi nhau. \u0110\u1ed3ng th\u1eddi B\u0103ng h\u1ea3i t\u1eb7c c\u00f2n gi\u00fap b\u1ea1n t\u0103ng th\u00eam di\u1ec3m ti\u1ec1m n\u0103ng c\u00f9ng r\u1ea5t nhi\u1ec1u v\u1eadt ph\u1ea9m h\u1ed5 tr\u1ee3 n\u1eefa.";
                break;
            }
            case 1: {
                text = "Ph\u00f3 b\u1ea3ng b\u0103ng\n N\u01a1i tranh t\u00e0i c\u1ee7a c\u00e1c b\u0103ng h\u1ea3i t\u1eafc \u0111\u1ec3 kh\u1eb3ng \u0111\u1ecbnh s\u1ee9c m\u1ea1nh \u0111\u1ed3ng \u0111\u1ed9i.\b H\u00e3y tham gia B\u0103ng r\u1ed3i sau \u0111\u00f3 c\u1ee7ng \u0111\u1ed3ng \u0111\u1ed9i m\u00ecnh tham gia ph\u00f3 b\u1ea3ng. V\u1edbi y\u00eau c\u1ea7u c\u00f3 \u00edt nh\u1ea5t 5 ng\u01b0\u1eddi trong b\u0103ng \u0111\u1ed3ng \u00fd tham gia. Th\u1eddi gian m\u1edf c\u1eeda l\u00e0 t\u1eeb 11h \u0111\u1ebfn 15h v\u00e0 19h \u0111\u1ebfn 23h h\u1eb1ng ng\u00e0y.\b S\u1ebd c\u00f3 nhi\u1ec1u ch\u1ebf \u0111\u1ed9 thi \u0111\u1ea5u kh\u00e1c nhau c\u0169ng nh\u01b0 nhi\u1ec1u khu v\u1ef1c thi \u0111\u1ea5u kh\u00e1c nhau thay \u0111\u1ed5i m\u1ed7i ng\u00e0y. \b H\u00e3y c\u00f9ng \u0111\u1ed3ng \u0111\u1ed9i m\u00ecnh tham gia th\u00f4i n\u00e0o.";
                break;
            }
            case 2: {
                text = "Ph\u00f3 b\u1ea3ng kh\u1ed5ng l\u1ed3 Lv 5x tr\u1edf xu\u1ed1ng\n Cu\u1ed9c phi\u00eau l\u01b0u n\u00e0o c\u0169ng c\u00f3 r\u1ea5t nhi\u1ec1u s\u1ef1 b\u1ea5t ng\u1edd.\b V\u00e0 cu\u1ed9c g\u1eb7p g\u1ee1 2 ng\u01b0\u1eddi kh\u1ed5ng l\u1ed3 s\u1ee9 Elbaf l\u00e0 1 \u0111i\u1ec1u b\u1ea5t ng\u1edd h\u01a1n c\u1ea3 nh\u1eefng b\u1ea5t ng\u1edd. \bCu\u1ed9c chi\u1ebfn gi\u1eefa 2 ng\u01b0\u1eddi b\u1ecdn h\u1ecd m\u00e3i kh\u00f4ng c\u00f3 h\u1ed3i k\u1ebft n\u00ean b\u1ea1n v\u00e0 c\u00e1c \u0111\u1ed3ng \u0111\u1ed9i c\u1ee7a m\u00ecnh h\u00e3y gi\u00fap 1 tay \u0111i n\u00e0o.\b C\u00f9ng \u00edt nh\u1ea5t 4 ng\u01b0\u1eddi \u0111\u1ed3ng \u0111\u1ed9i trong B\u0103ng tham gia ph\u00f3 b\u1ea3ng, h\u1ea1 g\u1ee5c c\u00e1c con qu\u00e1i \u0111\u1ec3 mang v\u1ec1 b\u00ecnh r\u01b0\u1ee3u ho\u1eb7c m\u1ea3ng th\u1ecbt cho c\u00e1c ng\u01b0\u1eddi kh\u1ed5ng l\u1ed3. \b C\u00f3 1 con qu\u00e1i \u0111\u1eb7t bi\u1ec7t mang tr\u00ean n\u00f3 1 v\u1eadt ph\u1ea9m \u0111\u1eb7t bi\u1ec7t kh\u00f4ng k\u00e9m m\u00e0 b\u1ea1n s\u1ebd c\u00f3 \u0111\u01b0\u1ee3c khi h\u1ea1 g\u1ee5c n\u00f3.  V\u1eady c\u00f2n ch\u1edd g\u00ec n\u1eefa m\u00e0 kh\u00f4ng c\u00f9ng tham gia n\u00e0o.";
                break;
            }
            case 3: {
                text = "B\u1ea3o v\u1ec7 ph\u00e1o \u0111\u00e0i\nThuy\u1ec1n tr\u01b0\u1edfng ho\u1eb7c Thuy\u1ec1n ph\u00f3 \u0111\u1ebfn g\u1eb7p NPC Mihao \u0111\u1ec3 ti\u1ebfn h\u00e0nh \u0111\u0103ng k\u00fd v\u00e0  h\u1ec7 th\u1ed1ng s\u1ebd t\u00ecm B\u0103ng \u0111\u1ed1i th\u1ee7 x\u1ee9ng t\u1ea7m trong ch\u00f3c l\u00e1t.\bV\u00e0o tr\u1eadn  t\u1ea5t c\u1ea3 th\u00e0nh vi\u00ean c\u1ee7a c\u1ea3 2 B\u0103ng s\u1ebd \u0111\u1ec1u t\u1eadp trung \u1edf khu c\u0103n c\u1ee9 ri\u00eang c\u1ee7a B\u0103ng \u0111\u00f3 (c\u00f2n \u0111\u01b0\u1ee3c g\u1ecdi l\u00e0 L\u00e0ng \u0111\u1ecf v\u00e0 L\u00e0ng xanh)\bH\u00e3y chu\u1ea9n b\u1ecb chi\u1ebfn thu\u1eadt h\u1ee3p l\u00fd \u0111\u1ec3 th\u00e0nh vi\u00ean trong B\u0103ng ti\u1ebfn h\u00e0nh di chuy\u1ec3n sang \u0110\u01b0\u1eddng tr\u00ean, \u0110\u01b0\u1eddng d\u01b0\u1edbi v\u00e0 \u0110\u01b0\u1eddng gi\u1eefa \u0111\u1ec3 ph\u00e1 hu\u1ef7 c\u00e1c Tr\u1ee5\bC\u1ee9 sau 2 ph\u00fat th\u00ec HP c\u1ee7a Tr\u1ee5 s\u1ebd gi\u1ea3m 20 HP\nKhi ph\u00e1 hu\u1ef7 tr\u1ee5 tr\u00ean s\u1ebd t\u0103ng 20% dame cho t\u1ea5t c\u1ea3 \u0111\u1ed3ng \u0111\u1ed9i\nKhi ph\u00e1 hu\u1ef7 tr\u1ee5 d\u01b0\u1edbi s\u1ebd t\u0103ng 10% h\u1ed3i m\u00e1u cho t\u1ea5t c\u1ea3 \u0111\u1ed3ng \u0111\u1ed9i\bL\u01b0u \u00fd: Khi c\u1ea3 2 Tr\u1ee5 th\u01b0\u1eddng \u0111\u1ec1u b\u1ecb ph\u00e1 hu\u1ef7 th\u00ec m\u1edbi c\u00f3 th\u1ec3 \u0111\u00e1nh Tr\u1ee5 ch\u00ednh\nTr\u1ee5 th\u01b0\u1eddng s\u1ebd h\u1ed3i sinh sau 2 ph\u00fat\b\u1ede ph\u00fat th\u1ee9 5 v\u00e0 th\u1ee9 10 s\u1ebd xu\u1ea5t hi\u1ec7n c\u00e1c Si\u00eau Boss \u1edf g\u1ea7n v\u1ecb tr\u00ed c\u00e1c Tr\u1ee5, h\u00e3y ti\u00eau di\u1ec7t ch\u00fang s\u1ebd nh\u1eadn th\u00eam h\u1ed7 tr\u1ee3 cho to\u00e0n \u0111\u1ed9i\bB\u0103ng n\u00e0o ph\u00e1 hu\u1ef7 \u0111\u01b0\u1ee3c Tr\u1ee5 ch\u00ednh c\u1ee7a \u0111\u1ed1i ph\u01b0\u01a1ng tr\u01b0\u1edbc s\u1ebd th\u1eafng cu\u1ed9c\nN\u1ebfu c\u1ea3 2 Tr\u1ee5 ch\u00ednh \u0111\u1ec1u kh\u00f4ng b\u1ecb ph\u00e1 hu\u1ef7 th\u00ec B\u0103ng n\u00e0o ph\u00e1 hu\u1ef7 \u0111\u01b0\u1ee3c nhi\u1ec1u Tr\u1ee5 th\u01b0\u1eddng nh\u1ea5t s\u1ebd th\u1eafng cu\u1ed9c .";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_LangHatDe(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "B\u1ea3o v\u1ec7 kho b\u00e1u Namie\n\u0110\u00e2y l\u00e0 ng\u00f4i l\u00e0ng m\u00e0 Namie \u0111\u00e3 sinh ra v\u00e0 l\u1edbn l\u00ean, t\u1ea1i \u0111\u00e2y c\u00f4 ta c\u00f3 c\u1ea5t gi\u1eef r\u1ea5t nhi\u1ec1u kho b\u00e1u, h\u00e3y gi\u00fap c\u00f4 \u1ea5y b\u1ea3o v\u1ec7 kho b\u00e1u c\u1ee7a m\u00ecnh kh\u1ecfi tay b\u1ecdn h\u1ea3i qu\u00e2n.\b H\u00e3y \u0111\u1ebfn g\u1eb7p Zosaku, anh ta s\u1ebd \u0111\u01b0a b\u1ea1n \u0111\u1ebfn Kho b\u00e1u Namie. Nh\u01b0ng nh\u1edb l\u00e0 h\u00e3y t\u1ea1o nh\u00f3m tr\u01b0\u1edbc khi v\u00e0o.\b Ph\u00f3 b\u1ea3n g\u1ed3m c\u00f3 20 t\u1ea7ng, \u0111\u1ed9 kh\u00f3 s\u1ebd t\u0103ng d\u1ea7n sau m\u1ed7i t\u1ea7ng. Nh\u1eefng ph\u1ea7n th\u01b0\u1edfng v\u00f4 c\u00f9ng h\u1ea5p d\u1eabn s\u1ebd thu\u1ed9c v\u1ec1 b\u1ea1n n\u1ebfu b\u1ea1n b\u1ea3o v\u1ec7 kho b\u00e1u th\u00e0nh c\u00f4ng.";
                break;
            }
            case 1: {
                text = "Si\u00eau Boss\nV\u00e0o l\u00fac 18h \u0111\u1ebfn 20h h\u1eb1ng ng\u00e0y s\u1ebd xu\u1ea5t hi\u1ec7n Si\u00eau Boss t\u1ea1i khu 5, map 6-1 Ch\u1ee3 d\u1eeba.\bH\u00e3y chung tay ti\u00eau di\u1ec7t Si\u00eau Boss \u0111\u1ec3 nh\u1eadn v\u1ec1 nh\u1eefng ph\u1ea7n th\u01b0\u1edfng c\u1ef1c k\u1ef3 gi\u00e1 tr\u1ecb.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_ThiTranKhoiDau(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "L\u1ec7nh truy n\u00e3\n\u0110\u00e2y l\u00e0 th\u1ecb tr\u1ea5n duy nh\u1ea5t b\u1ea1n c\u00f3 th\u1ec3 tham gia truy n\u00e3.\b H\u00e3y \u0111\u1ebfn g\u1eb7p Zosaku, anh ta s\u1ebd \u0111\u01b0a b\u1ea1n \u0111\u1ebfn \u0111\u1ea5u tr\u01b0\u1eddng truy n\u00e3. H\u00e3y th\u1eed t\u00ecm ki\u1ebfm v\u00e0 truy n\u00e3 m\u1ed9t ai \u0111\u00f3, n\u1ebfu th\u1eafng b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c 10.000 Beri truy n\u00e3 + 1% s\u1ed1 ti\u1ec1n truy n\u00e3 c\u1ee7a \u0111\u1ed1i ph\u01b0\u01a1ng.\b Ng\u01b0\u1ee3c l\u1ea1i, n\u1ebfu th\u1ea5t b\u1ea1i b\u1ea1n s\u1ebd b\u1ecb tr\u1eeb 5.000 Beri truy n\u00e3 + 1% s\u1ed1 ti\u1ec1n truy n\u00e3 c\u1ee7a b\u1ea3n th\u00e2n.\b Sau khi th\u1eafng li\u00ean ti\u1ebfp 3 tr\u1eadn ho\u1eb7c  sau khi thua 1 tr\u1eadn,,b\u1ea1n ph\u1ea3i ch\u1edd 20ph\u00fat \u0111\u1ec3 ti\u1ebfp t\u1ee5c Truy n\u00e3, c\u00f3 th\u1ec3 d\u00f9ng Ruby \u0111\u1ec3 hu\u1ef7 th\u1eddi gian ch\u1edd\b C\u1ee9 m\u1ed7i khi b\u1ea1n chi\u1ebfn th\u1eafng, b\u1ea1n s\u1ebd nh\u1eadn ng\u1eabu nhi\u00ean 1 R\u01b0\u01a1ng Truy n\u00e3. M\u1edf R\u01b0\u01a1ng Truy n\u00e3 s\u1ebd nh\u1eadn nhi\u1ec1u ph\u1ea7n th\u01b0\u1edfng v\u00f4 c\u00f9ng h\u1ea5p d\u1eabn.\b L\u01b0u \u00fd n\u1ebfu b\u1ea1n thu\u1ed9c top truy n\u00e3, nh\u00e2n v\u1eadt c\u1ee7a b\u1ea1n 3 ng\u00e0y kh\u00f4ng \u0111\u0103ng nh\u1eadp v\u00e0o game th\u00ec m\u1ed7i ng\u00e0y s\u1ebd b\u1ecb tr\u1eeb 1% s\u1ed1 \u0111i\u1ec3m Truy n\u00e3 \u0111\u1ebfn khi b\u1ea1n \u0111\u0103ng nh\u1eadp l\u1ea1i.";
                break;
            }
            case 1: {
                text = "Si\u00eau Boss\nV\u00e0o l\u00fac 18h \u0111\u1ebfn 20h h\u1eb1ng ng\u00e0y s\u1ebd xu\u1ea5t hi\u1ec7n Si\u00eau Boss t\u1ea1i khu 5, map 6-1 Ch\u1ee3 d\u1eeba.\bH\u00e3y chung tay ti\u00eau di\u1ec7t Si\u00eau Boss \u0111\u1ec3 nh\u1eadn v\u1ec1 nh\u1eefng ph\u1ea7n th\u01b0\u1edfng c\u1ef1c k\u1ef3 gi\u00e1 tr\u1ecb.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_MomSinhDoi(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "V\u01b0\u1ee3t Redline\nN\u00fai \u0111\u1ea3o ngh\u1ecbch n\u01a1i d\u00f2ng n\u01b0\u1edbc bi\u1ec3n ch\u1ea1y th\u1eb3ng l\u00ean n\u00fai th\u1eadt k\u00ec di\u1ec7u.\b Vi\u1ec7c c\u1ee7a b\u1ea1n c\u1ea7n l\u00e0m l\u00e0 v\u01b0\u1ee3t Redline 50 l\u1ea7n, sau khi ho\u00e0n th\u00e0nh b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c 1 tr\u00e1i \u00e1c qu\u1ef7\b H\u00e3y \u0111\u1ebfn g\u1eb7p Crocus \u0111\u1ec3 nh\u1eadn nhi\u1ec7m v\u1ee5. M\u1ed7i ng\u01b0\u1eddi ch\u1ec9 nh\u1eadn \u0111\u01b0\u1ee3c 1 l\u1ea7n th\u00f4i nh\u00e9.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_ThiTranWhiskey(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "Tr\u00e1i \u00e1c qu\u1ef7\nLo\u1ea1i qu\u1ea3 b\u00ed \u1ea9n nh\u1ea5t trong th\u1ebf gi\u1edbi h\u1ea3i t\u1eb7c. N\u00f3 \u0111\u01b0\u1ee3c xem l\u00e0 l\u1eddi nguy\u1ec1n c\u1ee7a bi\u1ec3n c\u1ea3. B\u1edfi n\u1ebfu ai \u0103n n\u00f3 r\u1ed3i s\u1ebd kh\u00f4ng th\u1ec3 b\u01a1i \u0111\u01b0\u1ee3c n\u1eefa.\b C\u0169ng nh\u01b0 m\u1ea5t h\u1ebft s\u1ee9c l\u1ef1c n\u1ebfu ch\u1ea1m \u0111\u1ebfn m\u1ecdi th\u1eed c\u1ee7a bi\u1ec3n. Nh\u01b0ng l\u1eddi nguy\u1ec1n hay ph\u00e9p m\u00e0u th\u00ec ch\u1ec9 c\u00f3 b\u1ea1n m\u1edbi c\u00f3 th\u1ec3 kh\u1eb3ng \u0111\u1ecbnh th\u00f4i.\bT\u1ea1i th\u1ecb tr\u1ea5n n\u00e0y c\u00f3 b\u00e1n nh\u1eefng R\u01b0\u01a1ng \u00e1c qu\u1ef7 v\u00f4 c\u00f9ng qu\u00fd b\u00e1u. H\u00e3y \u0111\u1ebfn g\u1eb7p Mr Acrobatic \u0111\u1ec3 mua nh\u1eefng R\u01b0\u01a1ng \u00e1c qu\u1ef7. M\u1edf r\u01b0\u01a1ng \u00e1c qu\u1ef7 b\u1ea1n s\u1ebd nh\u1eadn \u0111\u01b0\u1ee3c tr\u00e1i \u00e1c qu\u1ef7 ng\u1eabu nhi\u00ean. M\u1ed7i tr\u00e1i \u00e1c qu\u1ef7 \u0111\u1ec1u \u1ea9n ch\u1ee9a b\u00ean trong s\u1ee9c m\u1ea1nh v\u00f4 c\u00f9ng to l\u1edbn.";
                break;
            }
            case 1: {
                text = "\u0110\u1ea5u tr\u01b0\u1eddng t\u1ef1 do\n V\u00e0o l\u00fac 20h30 \u0111\u1ebfn 22h h\u1eb1ng ng\u00e0y, c\u00e1c khu luy\u1ec7n qu\u00e1i t\u1eeb khu 1 \u0111\u1ebfn khu 9 s\u1ebd tr\u1edf th\u00e0nh 1 \u0111\u1ea5u tr\u01b0\u1eddng th\u1ef1c th\u1ee5.\b Khi b\u1ea1n ra ngo\u00e0i c\u00e1c khu v\u1ef1c luy\u1ec7n qu\u00e1i s\u1ebd \u0111\u01b0\u1ee3c ch\u1ecdn ng\u1eabu nhi\u00ean 1 trong 2 m\u00e0u c\u1edd PK l\u00e0 xanh l\u1ee5c v\u00e0 \u0111\u1ecf. H\u00e3y h\u1ea1 th\u1eadt nhi\u1ec1u \u0111\u1ed1i th\u1ee7 \u0111\u1ec3 tr\u1edf th\u00e0nh ng\u01b0\u1eddi chi\u1ebfn th\u1eafng.";
                break;
            }
            case 2: {
                text = "Si\u00eau Boss\nV\u00e0o l\u00fac 18h \u0111\u1ebfn 20h h\u1eb1ng ng\u00e0y s\u1ebd xu\u1ea5t hi\u1ec7n Si\u00eau Boss t\u1ea1i khu 5, map 6-1 Ch\u1ee3 d\u1eeba.\bH\u00e3y chung tay ti\u00eau di\u1ec7t Si\u00eau Boss \u0111\u1ec3 nh\u1eadn v\u1ec1 nh\u1eefng ph\u1ea7n th\u01b0\u1edfng c\u1ef1c k\u1ef3 gi\u00e1 tr\u1ecb.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }

    public static void show_DaoLittleGrand(Player p, byte index) throws IOException {
        String text = "M\u1ee5c n\u00e0y ch\u01b0a c\u00f3 h\u01b0\u1edbng d\u1eabn, h\u00e3y h\u1ecfi admin nh\u00e9";
        switch (index) {
            case 0: {
                text = "Ph\u00f3 b\u1ea3n Mr Candle\nNh\u1eadn \u0111\u01b0\u1ee3c l\u1ec7nh c\u1ee7a Mr Sand, b\u1ed9 \u0111\u00f4i Mr Candle v\u00e0 Miss Paint \u0111\u00e3 \u0111\u1ebfn h\u00f2n \u0111\u1ea3o Little Garden. H\u00e3y c\u00f9ng nhau \u0111\u00e1nh b\u1ea1i h\u1ecd.\b H\u00e3y \u0111\u1ebfn g\u1eb7p Miss All Sunday, c\u00f4 ta s\u1ebd \u0111\u01b0a b\u1ea1n g\u1eb7p Mr Candle v\u00e0 Miss Paint. V\u1edbi s\u1ee9c m\u1ea1nh c\u1ee7a b\u1ed9 \u0111\u00f4i Mr Candle, b\u1ea1n c\u1ea7n ph\u1ea3i t\u1ea1o nh\u00f3m \u00edt nh\u1ea5t 3 ng\u01b0\u1eddi m\u1edbi c\u00f3 th\u1ec3 v\u00e0o tham chi\u1ebfn.\b R\u1ea5t nhi\u1ec1u \u0111i\u1ec3m kinh nghi\u1ec7m v\u00e0 Beri s\u1ebd \u0111\u01b0\u1ee3c t\u1eb7ng sau khi b\u1ea1n \u0111\u00e1nh b\u1ea1i c\u1ea3 2 ng\u01b0\u1eddi h\u1ecd.";
                break;
            }
            case 1: {
                text = "Ph\u00f3 b\u1ea3ng kh\u1ed5ng l\u1ed3 Lv 6x tr\u1edf l\u00ean\n Cu\u1ed9c phi\u00eau l\u01b0u n\u00e0o c\u0169ng c\u00f3 r\u1ea5t nhi\u1ec1u s\u1ef1 b\u1ea5t ng\u1edd.\b V\u00e0 cu\u1ed9c g\u1eb7p g\u1ee1 2 ng\u01b0\u1eddi kh\u1ed5ng l\u1ed3 s\u1ee9 Elbaf l\u00e0 1 \u0111i\u1ec1u b\u1ea5t ng\u1edd h\u01a1n c\u1ea3 nh\u1eefng b\u1ea5t ng\u1edd. \bCu\u1ed9c chi\u1ebfn gi\u1eefa 2 ng\u01b0\u1eddi b\u1ecdn h\u1ecd m\u00e3i kh\u00f4ng c\u00f3 h\u1ed3i k\u1ebft n\u00ean b\u1ea1n v\u00e0 c\u00e1c \u0111\u1ed3ng \u0111\u1ed9i c\u1ee7a m\u00ecnh h\u00e3y gi\u00fap 1 tay \u0111i n\u00e0o.\b C\u00f9ng \u00edt nh\u1ea5t 4 ng\u01b0\u1eddi \u0111\u1ed3ng \u0111\u1ed9i trong B\u0103ng tham gia ph\u00f3 b\u1ea3ng, h\u1ea1 g\u1ee5c c\u00e1c con qu\u00e1i \u0111\u1ec3 mang v\u1ec1 b\u00ecnh r\u01b0\u1ee3u ho\u1eb7c m\u1ea3ng th\u1ecbt cho c\u00e1c ng\u01b0\u1eddi kh\u1ed5ng l\u1ed3. \b C\u00f3 1 con qu\u00e1i \u0111\u1eb7t bi\u1ec7t mang tr\u00ean n\u00f3 1 v\u1eadt ph\u1ea9m \u0111\u1eb7t bi\u1ec7t kh\u00f4ng k\u00e9m m\u00e0 b\u1ea1n s\u1ebd c\u00f3 \u0111\u01b0\u1ee3c khi h\u1ea1 g\u1ee5c n\u00f3.  V\u1eady c\u00f2n ch\u1edd g\u00ec n\u1eefa m\u00e0 kh\u00f4ng c\u00f9ng tham gia n\u00e0o.";
            }
        }
        Service.Help_From_Server(p, -997, text);
    }
}

