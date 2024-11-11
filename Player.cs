using System;

// Player hanya akan memiliki 1 instance saja
// Class tidak akan diinherit oleh class lain apapun
public class Player {
    public static Player instance = null;

    // Base stat untuk player;
    string playerName;
    int playerHealth;
    int playerLevel;
    int playerPower;
    PlayerInventory playerInventory;


    private Player() {
        playerInventory = new PlayerInventory();
        playerName = null;
    }

    public static Player Instance() {
        if (instance == null) {
            return new Player();
        } else {
            return this.instance;
        }
    }


}