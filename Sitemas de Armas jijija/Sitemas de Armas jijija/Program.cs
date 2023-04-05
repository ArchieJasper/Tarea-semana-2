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
            List<ArmasMunicion> inv = new List<ArmasMunicion>();

            while(continueFlag)
            {
                Console.WriteLine("-> Escoge un arma de la tienda: ");
                Console.WriteLine("- 1. Espada");
                Console.WriteLine("- 2. Arco");
                Console.WriteLine("- 3. Pistola");

                Console.WriteLine("-> Escoge munición de la tienda: ");
                Console.WriteLine("- 4. Flechas");
                Console.WriteLine("- 5. Balas 9mm");
                Console.Clear();

                string armas;
                armas = Console.ReadLine();
                string munición;
                munición = Console.ReadLine();

                switch (armas)
                {
                    case "1":
                        Espada espada = new Espada("Espada Mediana",19.99f,20f,50);
                        espada.Data();
                        inv.Add(espada);
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("-> Arco deportivo: ");
                        float CostoArco = 12.99f;
                        Console.WriteLine("- Precio: $" + CostoArco);
                        int DañoArco = 15;
                        Console.WriteLine("- Daño: " + DañoArco);
                        float Velocidad_Ataque_Arco = 10f;
                        Console.WriteLine("- Velocidad de ataque: " + Velocidad_Ataque_Arco + "s");
                        break;
                    case "3":
                        float CostoPistola = 14.99f;
                        Console.WriteLine("Pistola Glock-18: $" + CostoPistola);
                        int DañoPistola = 35;
                        Console.WriteLine("- Daño: " + DañoPistola);
                        float Velocidad_Ataque_Pistola = 5f;
                        Console.WriteLine("- Velocidad de ataque: " + Velocidad_Ataque_Pistola + "s");
                        break;
                    default:
                        Console.WriteLine("Opción no válido");
                        break;
                }

                switch (munición)
                {
                    case "4":
                        Flecha flecha = new flecha("Flecha ",10.99f,10);

                        Console.WriteLine("-> 10 Flechas: ");
                        float CostoFlechas = 10.99f;
                        Console.WriteLine("- Precio: $" + CostoFlechas);
                        int DañoFlechas = 10;
                        Console.WriteLine("- Daño: " + DañoFlechas);
                        break;
                    case "5":
                        Bala bala = new Bala("Bala ",17.99f,60);

                        Console.WriteLine("-> 1 paquete de Balas 9mm: ");
                        float CostoBalas = 17.99f;
                        Console.WriteLine("- Precio: $" + CostoBalas);
                        int DañoBalas = 60;
                        Console.WriteLine("- Daño: " + DañoBalas);
                        break;
                    default:
                        Console.WriteLine("Opción no válido");
                        break;
                }
                Console.ReadLine();



                if (ArmasMunicion.Count > 0)
                {
                    for (int i = 0; i < ArmasMunicion.Count; i++)
                    {
                        Console.WriteLine(inventario[i].GetType().Name);
                    }

                    Console.WriteLine("-> Eliminar item");
                    Console.WriteLine("-> Salir");
                    armas = Console.ReadLine();
                    munición = Console.ReadLine();
                    Console.Clear();

                    switch (armas)
                    {
                        Console.WriteLine("Escriba el numero para eliminar");
                         for (int i = 0; i < ArmasMunicion.Count; i++)
                         {

                         }
                    }
                 }
            }
        }
    }
}
