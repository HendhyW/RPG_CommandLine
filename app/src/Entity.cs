using System;
public class Entity {
    private int health; // Nyawa dari entity
    private int maxHealth; // Nyawa maksimum dari entity
    private int baseDef; // Stats defense dasar dari entity
    private int baseATK; // Stats attack dasar dari entity
    private int speed; // stats speed untuk penentuan giliran
    private StatusEffect? statusEffect; // status effect yang diterima entity
    // Constructor untuk entity
    public Entity(int maxHealth, int baseDef, int baseATK, int speed, StatusEffect? statusEffect) {
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.baseDef = baseDef;
        this.baseATK = baseATK;
        this.speed = speed;
        this.statusEffect = statusEffect;
    }
    // method-method untuk mengakses dan mengubah atribut-atribut di atas
    public int getMaxHealth() {
        return maxHealth;
    }
    public void setMaxHealth(int input) {
        maxHealth = input;
    }
    public int getHealth() {
        return health;
    }
    public void setHealth(int input) {
        health = input;
    }
    public int getDef() {
        return baseDef;
    }
    public void setDef(int input) {
        baseDef = input;
    }
    public int getBaseATK() {
        return baseATK;
    }
    public void setBaseATK(int input) {
        baseATK = input;
    }
    public int getSpeed() {
        return speed;
    }
    public void setSpeed(int input) {
        speed = input;
    }
    public StatusEffect? getStatusEffect() {
        return statusEffect;
    }
    public void setStatusEffect(StatusEffect input) {
        statusEffect = input;
    }

    // Method untuk print status
    public void printStats() 
    {
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Defense: " + baseDef);
        Console.WriteLine("Attack: " + baseATK);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Status Effect: " + statusEffect);
    }

    // Method untuk mengurangi health
    public void reduceHealth(int damage) {
        health -= damage;
    }
}