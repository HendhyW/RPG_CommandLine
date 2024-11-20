using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Enemy : Entity
{
    // field khusus enemy
    private EnemyType? enemyType;
    private Element? weakness;
    private int toughness;
    public Enemy(int health, int baseDef, int baseATK, int speed, StatusEffect? statusEffect, EnemyType? enemyType, Element? weakness) : base(health, baseDef, baseATK, speed, statusEffect)
    {
        this.enemyType = enemyType;
        this.weakness = weakness;
    }

    public EnemyType? getEnemyType()
    {
        return enemyType;
    }
    public void setEnemyType(EnemyType input)
    {
        enemyType = input;
    }
    public Element? getWeakness()
    {
        return weakness;
    }
    public void setWeakness(Element input)
    {
        weakness = input;
    }
    public int getToughness()
    {
        return toughness;
    }
    public void setToughness(int input)
    {
        toughness = input;
    }
    public void EnemyStats()
    {
        Console.WriteLine("Enemy Type: " + enemyType);
        Console.WriteLine("Weakness: " + weakness);
        Console.WriteLine("Toughness: " + toughness);
    }
    public void Attack()
    {
        Player.Instance().setHealth(Player.Instance().getHealth() - getBaseATK());
    }
    public void Move()
    {
        if (getHealth() <= 0)
        {
            Console.WriteLine("Enemy is dead");
            return;
        }
        else
        {
            Console.WriteLine("Enemy is attacking");
            Attack();
        }
    }
}