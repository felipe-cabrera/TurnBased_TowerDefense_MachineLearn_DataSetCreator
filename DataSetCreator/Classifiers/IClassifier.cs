using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos.Classifiers
{
    public interface IClassifier
    {
        EnemyTypes Classify(Enemy enemy);
    }
}
