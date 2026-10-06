package core;

public class MenuControllerTest {
    public static void main(String[] args) {
        assert MenuController.zosakuBossLevel(-1) == -1;
        assert MenuController.zosakuBossLevel(0) == 10;
        assert MenuController.zosakuBossLevel(9) == 100;
        assert MenuController.zosakuBossLevel(10) == -1;
        assert MenuController.zosakuBossChestId(0) == 19;
        assert MenuController.zosakuBossChestId(9) == 28;
        assert MenuController.zosakuDungeonMode(30) == 0;
        assert MenuController.zosakuDungeonMode(100) == 7;
    }
}
