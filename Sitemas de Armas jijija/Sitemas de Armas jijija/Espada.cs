using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Espada: ArmasMunicion
    {
        public string Nombre;
        public float Precio;
        public float Vel_Atk;
        public int Dmg;
        public Espada(string Nombre, float Precio, float Vel_Atk, int Dmg)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Vel_Atk = Vel_Atk;
            this.Dmg = Dmg;
        }
        public override void Data()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Velocidad de ataque: " + Vel_Atk);
            Console.WriteLine("Daño: " + Dmg);
            Console.WriteLine("Daño por segundo: "+ Dmg / Vel_Atk);
        }
    }
}
