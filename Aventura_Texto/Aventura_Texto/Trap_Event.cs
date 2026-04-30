using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura_Texto
{
    internal class Trap_Event: Event
    {
        public Trap_Event()
        {
            eventName = "[Encontraste un camino sospechoso]";
        }

        public override void Execute(GameManager manager)
        {
            Console.WriteLine(eventName);
            Console.WriteLine("");
            Console.WriteLine("[Escoge tu desición]");
            Console.WriteLine("[1] Ir por la izquierda");
            Console.WriteLine("[2] Ir por la derecha");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("[Caíste en una trampa]");
                Console.WriteLine("[Reciviste daño]");
                manager.player.ReciveDamage(5);

            }
            else if (choice == "2")
            {
                Console.WriteLine("Esuchaste sonidos del otro camnino");
                Console.WriteLine("Tal vez fue la desición correcta");
            }
        }
    }
}
