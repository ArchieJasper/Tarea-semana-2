using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Bala : ArmasMunicion
    {
        public string NombreBala;
        public float PrecioBala;
        public int DañoBala;

        public Bala(string NombreBala, float PrecioBala, int DañoBala)
        {
            this.NombreBala = NombreBala;
            this.PrecioBala = PrecioBala;
            this.DañoBala = DañoBala;
        }
        public override void Data()
        {
            Console.WriteLine("Nombre " + NombreBala);
            Console.WriteLine("Precio " + PrecioBala);
            Console.WriteLine("Daño " + DañoBala);
        }
    }
}
