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
                string seleccionar;
                Console.WriteLine("1: Comprar arma");
                Console.WriteLine("2: Inventario");
                Console.WriteLine("3: Salida");

                seleccionar = Console.ReadLine();
                Console.Clear();

                switch (seleccionar)
                {

                  case "a":

                    Console.WriteLine("-> Escoge un arma de la tienda: ");
                    Console.WriteLine("- 1. Espada");
                    Console.WriteLine("- 2. Arco");
                    Console.WriteLine("- 3. Pistola");

                    Console.WriteLine("-> Escoge munición de la tienda: ");
                    Console.WriteLine("- 4. Flechas");
                    Console.WriteLine("- 5. Balas 9mm");
                    Console.Clear();


                    case "1":
                        Espada espada = new Espada("Espada Mediana: ",39.99f,20f,50);
                        espada.Data();
                        inv.Add(espada);
                        Console.ReadLine();
                        break;

                    case "2":
                        Arco arco = new Arco("Arco deportivo: ", 25.99f, 10f, 15);
                        arco.Data();
                        inv.Add(arco);
                        Console.ReadLine();
                        break;

                    case "3":
                        Pistola pistola = new Pistola("Glock-18: ", 29.99f, 5f, 35);
                        pistola.Data();
                        inv.Add(pistola);
                        Console.ReadLine();
                        break;
                    case "4":
                        Flecha flecha = new Flecha("Flecha de velocidad ", 10.99f, 10);
                        flecha.Data();
                        inv.Add(flecha);
                        Console.ReadLine();
                        break;

                    case "5":
                        Bala bala = new Bala("Bala ", 17.99f, 60);
                        bala.Data();
                        inv.Add(bala);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadLine();
                        break;
                }

                break;

              case "b": //inventario 

                if (inv.Count > 0)
                {
                    for (int i = 0; i < inv.Count; i++)
                    {
                        Console.WriteLine(inv[i].GetType().Name);
                    }


                    Console.WriteLine("1) Eliminar item ");
                    Console.WriteLine("2) Back ");
                    seleccionar = Console.ReadLine();
                    Console.Clear();

                    switch (seleccionar)
                    {
                        case "1":

                            Console.WriteLine("Escriba el numero al costado del item para eliminar el objeto");
                            Console.WriteLine("-----------------");
                            Console.WriteLine(" ");
                            for (int i = 0; i < inv.Count; i++)
                            {
                                Console.WriteLine(i + "] " + inv[i].GetType().Name);
                            }

                            int a = int.Parse(Console.ReadLine()); //convierte de texto a entero

                            inv.Remove(inv[a]); //elimina objeto

                            Console.Clear();

                            break;

                        case "2":



                            break;
                    }
                }

                else
                {
                    Console.WriteLine(" No hay nada ");
                    Console.ReadLine();
                    Console.Clear();
                }
                break;

                    case "3":
                        continuidad = false; //cerrar programa
                break;
            }
        }
    }
}
