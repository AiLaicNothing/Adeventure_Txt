using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura_Texto
{
    internal abstract class Item
    {
        protected string name;
        protected string description;

        public string Name => name;
        public string Description => description;

        protected abstract void Fuction(Entity target);
        public void Use(Entity target)
        {
            Fuction(target);
        }
    }
}
