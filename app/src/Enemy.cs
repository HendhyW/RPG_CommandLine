using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Enemy : Entity
{
    // field khusus enemy
    private EnemyType enemyType;
    private Element element;
    private int toughness;

    public Enemy(int health, int baseDef, int baseATK, int speed, StatusEffect statusEffect, EnemyType enemyType, Element element) : base(health, baseDef, baseATK, speed, statusEffect)
    {
        this.enemyType = enemyType;
        this.element = element;
    }
}