using System;
using System.Dynamic;

// Player hanya akan memiliki 1 instance saja
// Class tidak akan diinherit oleh class lain apapun
public class Player : Entity {
    // Instance dari player
    private static Player? instance = null;

    // Base stat khusus untuk player;
    private string playerName;
    private int playerLevel;
    private int breakEffect;
    PlayerInventory playerInventory;

    // Private constructor, diakses melalui metode Instance()
    private Player(string playerName, int playerLevel, int breakEffect, int health, int baseATK, int baseDef, int speed, StatusEffect statusEffect) : base(health, baseDef, baseATK, speed, statusEffect) {
        this.playerName = playerName;
        this.breakEffect = breakEffect;
        this.playerLevel = playerLevel;
        playerInventory = PlayerInventory.Instance();
    }

    // Implementasi singleton pada class Player
    public static Player Instance() 
    {
        if (instance == null)
        {
            instance = new Player("", 0, 0, 0, 0, 0, 0, StatusEffect.STUN);
        }
        return instance;
    }

    // method setter dan getter untuk atribut-atribut player
    public string getPlayerName() {
        return playerName;
    }
    public void setPlayerName(string input) {
        playerName = input;
    }
    public int getPlayerLevel() {
        return playerLevel;
    }
    public void setPlayerLevel(int input) {
        playerLevel = input;
    }
    public int getBreakEffect() {
        return breakEffect;
    }
    public void setBreakEffect(int input) {
        breakEffect = input;
    }

    public new void printStats()
    {
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Player Level: " + playerLevel);
        base.printStats();
        Console.WriteLine("Break Effect: " + breakEffect);
    }
}