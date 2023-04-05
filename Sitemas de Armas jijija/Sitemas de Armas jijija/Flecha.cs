using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Flecha : ArmasMunicion
    {
        public string NombreFlecha;
        public float PrecioFlecha;
        public int DañoFlecha;

        public Flecha(string NombreFlecha, float PrecioFlecha,int DañoFlecha)
        {
            this.NombreFlecha = NombreFlecha;
            this.PrecioFlecha = PrecioFlecha;
            this.DañoFlecha = DañoFlecha;
        }
        public override void Data()
        {
            Console.WriteLine("Nombre " + NombreFlecha);
            Console.WriteLine("Precio " + PrecioFlecha);
            Console.WriteLine("Daño " + DañoFlecha);
        }
    }
}
