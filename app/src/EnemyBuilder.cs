using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EnemyBuilder
{
    private EnemyType? enemyType;
    private Element? weakness;
    private int toughness;
    private int health;
    private int baseDef;
    private int baseATK;
    private int speed;

    public void setHealth(int input)
    {
        health = input;
    }
    public void setBaseDef(int input)
    {
        baseDef = input;
    }
    public void setBaseATK(int input)
    {
        baseATK = input;
    }
    public void setSpeed(int input)
    {
        speed = input;
    }


    public void setEnemyType(EnemyType input)
    {
        enemyType = input;
    }
    public void setWeakness(Element input)
    {
        weakness = input;
    }
    public void setToughness(int input)
    {
        toughness = input;
    }

    public void reset()
    {
        enemyType = null;
        weakness = null;
        toughness = 0;
        health = 0;
        baseDef = 0;
        baseATK = 0;
        speed = 0;
    }

    public Enemy build()
    {
        return new Enemy(health, baseDef, baseATK, speed, StatusEffect.STUN, enemyType, weakness);
    }
}
