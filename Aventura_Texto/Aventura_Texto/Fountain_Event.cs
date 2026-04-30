using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura_Texto
{
    internal class Fountain_Event: Event
    {
        public Fountain_Event()
        {
            eventName = "[Encontraste una sospechoa fuente]";
        }

        public override void Execute(GameManager manager)
        {
            Console.WriteLine(eventName);
            Console.WriteLine("");
            Console.WriteLine("[Escoge tu desición]");
            Console.WriteLine("[1] Tomar de fuente");
            Console.WriteLine("[2] Ignorar la fuente");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("[Tomas de la fuente]");
                Console.WriteLine("[Te siente menos agotado]");
                Console.WriteLine("[Te curas 10 de vida]");
                manager.player.Heal(5);

            }
            else if (choice == "2")
            {
                Console.WriteLine("Decides ignorar la fuente");
            }
        }
    }
}
