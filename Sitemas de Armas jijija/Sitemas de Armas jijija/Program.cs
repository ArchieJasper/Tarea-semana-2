using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                
                string selection;
                Console.WriteLine("Introduce un numero: ");
                Console.WriteLine("1. Espada");
                Console.WriteLine("2. Arco");
                Console.WriteLine("3. Pistola");
                selection = Console.ReadLine();

                switch(selection)
                {
                    case "1":
                        Console.WriteLine("Espada");
                        break;
                    case "2":
                        Console.WriteLine("2. Introduce el numero");
                        break;
                    case "3":
                        Console.WriteLine("2. Introduce el numero");

                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
