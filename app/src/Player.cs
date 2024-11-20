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
    private int mana;
    private int maxMana;
    private Element? damageType;
    private int breakMeter;
    // PlayerInventory playerInventory;

    // Private constructor, diakses melalui metode Instance()
    private Player(string playerName, int playerLevel, int mana, int breakMeter, int maxHealth, int baseATK, int baseDef, int speed, StatusEffect? statusEffect, Element? damageType) : base(maxHealth, baseDef, baseATK, speed, statusEffect) {
        this.playerName = playerName;
        this.playerLevel = playerLevel;
        this.maxMana = mana;
        this.mana = mana;
        this.breakMeter = breakMeter;
        this.damageType = damageType;
    //     playerInventory = PlayerInventory.Instance();
    }

    // Implementasi singleton pada class Player
    public static Player Instance() 
    {
        if (instance == null)
        {
            instance = new Player("BetaTest", 1, 100, 20, 100, 30, 40, 100, null, Element.PHYSICAL);
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
    public int getMana() {
        return mana;
    }
    public void setMana(int input) {
        mana = input;
    }

    public int getMaxMana() {
        return maxMana;
    }
    public void setMaxMana(int input) {
        maxMana = input;
    }
    public int getBreakMeter() {
        return breakMeter;
    }
    public void setBreakMeter(int input) {
        breakMeter = input;
    }
    // method untuk melengkapi fitur player

    public new void printStats()
    {
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Player Level: " + playerLevel);
        base.printStats();
        Console.WriteLine("Break Meter: " + breakMeter);
    }

    public void battleStats()
    {
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Player Level: " + playerLevel);
        Console.WriteLine("Health: " + getHealth() + "/" + getMaxHealth());
        Console.WriteLine("Mana: " + mana + "/" + maxMana);
    }

    public void Attack(Enemy enemy)
    {
        enemy.setHealth(enemy.getHealth() - getBaseATK());
        if(enemy.getWeakness() == damageType)
        {
            enemy.setToughness(enemy.getToughness() - getBreakMeter());
        }
    }
}