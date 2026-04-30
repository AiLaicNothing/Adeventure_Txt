using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura_Texto
{
    internal class FirePotion: Item
    {
        int damage = 15;

        public FirePotion()
        {
            name = "Poción de fuego";
            description = $"Inflige {damage} de daño";
        }

        protected override void Fuction(Entity target)
        {
            target.ReciveDamage(damage);
        }
    }
}
