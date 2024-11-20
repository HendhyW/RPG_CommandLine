using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class EnemySpawner
{
    EnemyBuilder enemyBuilder = new EnemyBuilder();
    public Enemy spawnCommonPhysical()
    {
        enemyBuilder.setHealth(100);
        enemyBuilder.setBaseDef(10);
        enemyBuilder.setBaseATK(10);
        enemyBuilder.setSpeed(10);
        enemyBuilder.setEnemyType(EnemyType.COMMON);
        enemyBuilder.setWeakness(Element.PHYSICAL);
        enemyBuilder.setToughness(1);
        return enemyBuilder.build();
    }
}
