using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos.Classifiers
{
    class DefaultClassifier : IClassifier
    {
       
        public EnemyTypes Classify(Enemy enemy)
        {
            return enemy.EnemyType;
        }
    }
}
