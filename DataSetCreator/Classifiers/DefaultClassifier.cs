using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos.Classifiers
{
    /// <summary>
    /// This default classifier will always be correct. It's just an example of Classifiers
    /// To create a classifier you will need to implement the IClassifier interface and create the method Classify
    /// </summary>
    class DefaultClassifier : IClassifier
    {
        /// <summary>
        /// Here we Classify the enemy :)
        /// You just need to develop your algorithm here and return the classified enemy type
        /// </summary>
        /// <param name="enemy">Our enemy to be classified</param>
        /// <returns>Classified enemy type</returns>
        public EnemyTypes Classify(Enemy enemy)
        {
            return enemy.EnemyType;
        }
    }
}
