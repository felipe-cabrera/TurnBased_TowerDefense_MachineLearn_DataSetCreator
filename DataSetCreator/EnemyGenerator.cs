using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos
{
    /// <summary>
    /// Class responsable to generate new enemies
    /// </summary>
    class EnemyGenerator
    {
        #region Properties
        private static Random random = new Random((int)DateTime.Now.Ticks); // The random 'seed' to create random enemies
        private static int attack; // Enemy attack value
        private static int defense; // Enemy defense value
        #endregion

        /// <summary>
        /// The method responsable to control the generation type
        /// </summary>
        /// <param name="randomGeneration">If it's or it's not a random generation (random class)</param>
        /// <param name="enemyType">If it's a specific generation, you can choose the class</param>
        /// <returns>Generated enemy</returns>
        static public Enemy Generate(bool randomGeneration = false, EnemyTypes enemyType = EnemyTypes.Blue)
        {
            // Check if it's a random generation or not
            if (!randomGeneration)
                return EspecificEnemyGeneration(enemyType);
             else
                return RandomEnemyGeneration();
          
        }

        /// <summary>
        /// Create the Enemy by a specific 
        /// </summary>
        /// <param name="enemyType">The choosen type</param>
        /// <returns>Generated enemy</returns>
        static private Enemy EspecificEnemyGeneration(EnemyTypes enemyType)
        {
            // Get the class rules and use them to create a new Enemy
            Tuple<int[], int[]> intervals = EnemyRules.ClassRules(enemyType);
            attack = random.Next(intervals.Item1[0], intervals.Item1[1]);
            defense = random.Next(intervals.Item2[0], intervals.Item2[1]);
            return new Enemy(attack,defense,enemyType);
        }


        /// <summary>
        /// Create a random enemy
        /// </summary>
        /// <returns>Generated enemy</returns>
        static private Enemy RandomEnemyGeneration()
        {
            // Returns an enemy with a random class
            return EspecificEnemyGeneration((EnemyTypes)random.Next(0, 5));
        }

    }
}
