using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitemas_de_Armas_jijija
{
    class Espada: Inventario
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

            int eldaño = Convert.ToInt32(DañoEspada / Velocidad_Ataque_Espada);      //float a int.

            Console.WriteLine("Daño x segundo " + eldaño);
            Console.WriteLine("-----------------------------");
            //Console.WriteLine("No requiere municion, porque es un arma cuerpo a cuerpo");
        }
    }
}
