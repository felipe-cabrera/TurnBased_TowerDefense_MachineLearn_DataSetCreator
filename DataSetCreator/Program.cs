using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AprendizadoMaquinaInimigos.Classifiers;
using Newtonsoft.Json;

namespace AprendizadoMaquinaInimigos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>();
            int dataSetAmount = 100;

            for(int i = 0; i < dataSetAmount; i++)
            {
                enemies.Add(EnemyGenerator.Generate(randomGeneration: true));
            }

            //foreach(Enemy enemy in enemies)
            //{
            //    enemy.Classify(new DefaultClassifier());
            //}

            string json = JsonConvert.SerializeObject(enemies,Formatting.Indented);

            File.WriteAllText("enemiesDataSet.json", json);

            Console.WriteLine("Dataset created.\nPress any key to continue...");
            Console.Read();
        }
    }
}
