using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos
{
    public class EnemyRules
    {
        #region properties
        static private int[] AttackInterval; // Class attack interval
        static private int[] DefenseInterval; // Class defense interval
        #endregion

        /// <summary>
        /// Method to define the rules of each available enemy class
        /// </summary>
        /// <param name="enemyType">The enemy type</param>
        /// <returns>The enemy class rules</returns>
        static public Tuple<int[],int[]> ClassRules(EnemyTypes enemyType)
        {
            // Switch our current enemy type untill find what type is it
            // after that, we define the respective Attack and Defense invertal
            switch (enemyType)
            {
                case EnemyTypes.Blue:
                    AttackInterval = new int[] { 21, 30 };
                    DefenseInterval = new int[] { 1, 10 };
                    break;
                case EnemyTypes.Green:
                    AttackInterval = new int[] { 11, 20 };
                    DefenseInterval = new int[] { 11, 20 };
                    break;
                case EnemyTypes.Orange:
                    AttackInterval = new int[] { 1, 10 };
                    DefenseInterval = new int[] { 21, 30 };
                    break;
                case EnemyTypes.Purple:
                    AttackInterval = new int[] { 11, 20 };
                    DefenseInterval = new int[] { 1, 10 };
                    break;
                case EnemyTypes.Yellow:
                    AttackInterval = new int[] { 21, 30 };
                    DefenseInterval = new int[] { 11, 20 };
                    break;
            }

            // Return the rules of the current enemy class
            return Tuple.Create<int[], int[]>(AttackInterval,DefenseInterval);         
           
        }
    }
}
