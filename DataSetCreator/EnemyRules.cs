using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos
{
    public class EnemyRules
    {
        static private int[] AttackInterval;
        static private int[] DefenseInterval;

        static public Tuple<int[],int[]> ClassRules(EnemyTypes enemyType)
        {
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

            return Tuple.Create<int[], int[]>(AttackInterval,DefenseInterval);         
           
        }
    }
}
