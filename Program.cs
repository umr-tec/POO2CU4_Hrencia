using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inmuebles inmuebles = new Inmuebles("gonzalez ortega y catarino benavides, San Pedro", "Samuel", 100, true, 1);

            Casa casa = new Casa(4,100,1,"gonzalez ortega y catarino benavides, San Pedro", "Samuel", 100, true, 1);
            casa.DetallesInmueble();

            Console.ReadKey();
        }
    }
}
