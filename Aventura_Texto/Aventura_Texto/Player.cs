using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aventura_Texto
{
    internal class Player: Entity
    {
        public Player(string name)
        {
            this.name = name;
            health = 20;
            damage = 5;
        }
    }
}
