using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendizadoMaquinaInimigos
{
    /// <summary>
    /// All the available types of enemies
    /// </summary>
    public enum EnemyTypes
    {
        // When we convert it to JSON we have only an Integer Value (by the index of the Type)
        Blue, // JSON Value: 0 
        Yellow, // JSON Value: 1
        Green, // JSON Value: 2
        Purple, // JSON Value: 3
        Orange // JSON Value: 4
    }
}
