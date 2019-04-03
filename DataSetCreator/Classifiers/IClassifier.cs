using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos.Classifiers
{
    /// <summary>
    /// A interface to define what is a classifier and what it's have
    /// </summary>
    public interface IClassifier
    {
        /// <summary>
        /// The Classifier method to Classify datas
        /// </summary>
        /// <param name="enemy">Our enemy to be classified</param>
        /// <returns>Classified enemy type</returns>
        EnemyTypes Classify(Enemy enemy);
    }
}
