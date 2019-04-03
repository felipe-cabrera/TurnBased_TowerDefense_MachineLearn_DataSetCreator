using AprendizadoMaquinaInimigos.Classifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AprendizadoMaquinaInimigos
{
    public class Enemy
    {

        
        [JsonIgnore]
        public EnemyTypes ClassifiedEnemyType { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public EnemyTypes EnemyType { get; set; }

        public Enemy(int attack, int defense, EnemyTypes enemyType)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.EnemyType = enemyType;
        }
        
        public void Classify(IClassifier classifier)
        {
            ClassifiedEnemyType = classifier.Classify(this);
        }
    }
}
