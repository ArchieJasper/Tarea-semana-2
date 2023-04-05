using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Arco : ArmasMunicion
    {
        public string NombreArco;
        public float PrecioArco;
        public float Vel_AtkArco;
        public int DmgArco;

        public Arco(string NombreArco, float PrecioArco, float Vel_AtkArco, int DmgArco)
        {
            this.NombreArco = NombreArco;
            this.PrecioArco = PrecioArco;
            this.Vel_AtkArco = Vel_AtkArco;
            this.DmgArco = DmgArco;
        }
        public override void Data()
        {
            Console.WriteLine("Nombre: " + NombreArco);
            Console.WriteLine("Precio: " + PrecioArco);
            Console.WriteLine("Velocidad de ataque: " + Vel_AtkArco);
            Console.WriteLine("Daño: " + DmgArco);
            Console.WriteLine("Daño por segundo: " + DmgArco / Vel_AtkArco);
        }
    }
}
