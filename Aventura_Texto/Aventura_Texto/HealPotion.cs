using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura_Texto
{
    internal class HealPotion : Item
    {
        int heal = 15;

        public HealPotion()
        {
            name = "Poción de cura";
            description = $"Cura {heal} de vida";
        }

        protected override void Fuction(Entity target)
        {
            target.Heal(heal);
        }
    }
}
