using System;
public class Entity {
    private int health; // Nyawa dari entity
    private int baseDef; // Stats defense dasar dari entity
    private int baseATK; // Stats attack dasar dari entity
    private int speed; // stats speed untuk penentuan giliran
    private StatusEffect statusEffect; // status effect yang diterima entity
    // Constructor untuk entity
    public Entity(int health, int baseDef, int baseATK, int speed, StatusEffect statusEffect) {
        this.health = health;
        this.baseDef = baseDef;
        this.baseATK = baseATK;
        this.speed = speed;
        this.statusEffect = statusEffect;
    }
    // method-method untuk mengakses dan mengubah atribut-atribut di atas
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
    public StatusEffect getStatusEffect() {
        return statusEffect;
    }
    public void setStatusEffect(StatusEffect input) {
        statusEffect = input;
    }
}