using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos
{
    class EnemyGenerator
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static int attack;
        private static int defense;

        static public Enemy Generate(bool randomGeneration = false, EnemyTypes enemyType = EnemyTypes.Blue)
        {
            if (!randomGeneration)
                return EspecificEnemyGeneration(enemyType);
             else
                return RandomEnemyGeneration();
          
        }

        static private Enemy EspecificEnemyGeneration(EnemyTypes enemyType)
        {
            
            Tuple<int[], int[]> intervals = EnemyRules.ClassRules(enemyType);
            attack = random.Next(intervals.Item1[0], intervals.Item1[1]);
            defense = random.Next(intervals.Item2[0], intervals.Item2[1]);
            return new Enemy(attack,defense,enemyType);
        }

        static private Enemy RandomEnemyGeneration()
        {
            return EspecificEnemyGeneration((EnemyTypes)random.Next(0, 5));
        }

    }
}
