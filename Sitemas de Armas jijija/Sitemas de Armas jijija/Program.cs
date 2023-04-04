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
                Console.WriteLine("-> Escoge un arma de la tienda: ");
                Console.WriteLine("-> 1. Espada");
                Console.WriteLine("-> 2. Arco");
                Console.WriteLine("-> 3. Pistola");
                selection = Console.ReadLine();

                switch(selection)
                {
                    case "1":
                        Console.WriteLine("Espada mediana: ");
                        float CostoEspada = 19.99f;
                        Console.WriteLine("Precio: $"+CostoEspada);
                        float DañoE = 50f;
                        Console.WriteLine("Daño: "+DañoE);
                        float VelocidadAtaqueE= 20f;
                        Console.WriteLine("Velocidad de ataque: "+VelocidadAtaqueE+"k/m");
                        break;
                    case "2":
                        Console.WriteLine("Arco deportivo: ");
                        float costoA = 12.99f;
                        Console.WriteLine("Precio: $"+costoA);
                        float DañoA = 15f;
                        Console.WriteLine("Daño: " + DañoA);
                        float VelocidadAtaqueA = 15f;
                        Console.WriteLine("Precio: $" + VelocidadAtaqueA);
                        float Flechas=10;
                        Console.WriteLine("Munición: Flechas "+Flechas);
                        break;
                    case "3":
                        float costoPistola = 14.99f;
                        Console.WriteLine("Pistola Glock-18: $"+costoPistola);
                        break;
                    default:
                        Console.WriteLine("Opción no válido");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
