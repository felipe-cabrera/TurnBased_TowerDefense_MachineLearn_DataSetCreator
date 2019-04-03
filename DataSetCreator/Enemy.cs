using AprendizadoMaquinaInimigos.Classifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AprendizadoMaquinaInimigos
{
    /// <summary>
    /// Class responsable to define an enemy
    /// </summary>
    public class Enemy
    {

        // [JsonIgnore] is a attribute used to Hide the property in the output JSON

        #region Properties
        [JsonIgnore]

        public int Attack { get; set; } // Enemy Attack value
        public int Defense { get; set; } // Enemy Defense value
        public EnemyTypes EnemyType { get; set; } // The real type
        public EnemyTypes ClassifiedEnemyType { get; set; } // The classified type

        #endregion

        /// <summary>
        /// The enemy object constructor
        /// </summary>
        /// <param name="attack">attack value</param>
        /// <param name="defense">defense value</param>
        /// <param name="enemyType">enemy real type</param>
        public Enemy(int attack, int defense, EnemyTypes enemyType)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.EnemyType = enemyType;
        }
        
        /// <summary>
        /// The enemy classification
        /// </summary>
        /// <param name="classifier">The choosen Classifier</param>
        public void Classify(IClassifier classifier)
        {
            ClassifiedEnemyType = classifier.Classify(this);
        }
    }
}
