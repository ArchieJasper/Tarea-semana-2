using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Pistola : ArmasMunicion
    {
        public string NombrePistola;
        public float PrecioPistola;
        public float Vel_AtkPistola;
        public int DmgPistola;

        public Pistola(string NombrePistola, float PrecioPistola, float Vel_AtkPistola, int DmgPistola)
        {
            this.NombrePistola = NombrePistola;
            this.PrecioPistola = PrecioPistola;
            this.Vel_AtkPistola = Vel_AtkPistola;
            this.DmgPistola = DmgPistola;
        }
        public override void Data()
        {
            Console.WriteLine("Nombre: " + NombrePistola);
            Console.WriteLine("Precio: " + PrecioPistola);
            Console.WriteLine("Velocidad de ataque: " + Vel_AtkPistola);
            Console.WriteLine("Daño: " + DmgPistola);
            Console.WriteLine("Daño por segundo: " + DmgPistola / Vel_AtkPistola);
        }
    }
}
