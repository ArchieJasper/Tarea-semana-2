using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Espada: Armas&Munición
    {
        private string Nombre;
        private float CostoEspada;
        private int DañoEspada;
        private float Velocidad_Ataque_Espada;
        public Espada(string Nombre, float CostoEspada, int DañoEspada,float Velocidad_Ataque_Espada)
        {
            this.Nombre = Nombre;
            this.CostoEspada = CostoEspada;
            this.Velocidad_Ataque_Espada = Velocidad_Ataque_Espada;
            this.DañoEspada = DañoEspada;
        }
        public override void data()
        {
            Console.WriteLine("Nombre " + Nombre);
            Console.WriteLine("Precio " + CostoEspada);
            Console.WriteLine("Daño " + DañoEspada);
            Console.WriteLine("Velocidad de ataque " + Velocidad_Ataque_Espada);

            int DañoPorSec = Convert.ToInt32(DañoEspada / Velocidad_Ataque_Espada);
            Console.WriteLine("Daño por segundo: " + DañoPorSec);
        }
    }
}
