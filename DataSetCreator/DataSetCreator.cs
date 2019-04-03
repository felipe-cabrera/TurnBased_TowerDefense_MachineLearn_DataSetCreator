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
    /// <summary>
    /// The main class
    /// </summary>
    class DataSetCreator
    {
        /// <summary>
        /// The main method (this will create the dataset)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>(); // Will store all the created enemies
            int dataSetAmount = 100; // Amount of dataset enemies


            for(int i = 0; i < dataSetAmount; i++)
            {
                // For random use: enemies.Add(EnemyGenerator.Generate(randomGeneration: true));
                // For a specific class use, for example: enemies.Add(EnemyGenerator.Generate(enemyType: EnemyTypes.Blue)); 
                enemies.Add(EnemyGenerator.Generate(randomGeneration: true));
            }

            // Classify the enemies
            foreach (Enemy enemy in enemies)
            {
                enemy.Classify(new DefaultClassifier()); // You can choose the type of Classifier
            }

            // Convert to json
            string json = JsonConvert.SerializeObject(enemies,Formatting.Indented);

            // Export to the file (You can rename the file by changing the value of the first parameter)
            File.WriteAllText("enemiesDataSet.json", json);

            // Just a friendly user info :)
            Console.WriteLine("Dataset created.\nPress any key to continue...");
            Console.Read();
        }
    }
}
