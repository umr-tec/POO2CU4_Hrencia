using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOU4_Ejemplo1
{
    public class Inmuebles
    {
        private string ubicacion;
        private string escrituras;
        private double metrosDeTerreno;
        private bool serviciosBasicos;
        private byte cantidadBanos;

        //Tipos dea cceso tenemos: public private protected
        //Agreagar un constructor
        //tipoDeAcceso  NombreCLase(params){}
        //"gonzalez ortega y catarino benavides, San Pedro", "Samuel", 100, true, 1
        public Inmuebles(string ubicacion, string escrituras, double metrosTerreno,
                        bool serviciosBasicos, byte cantidadBanos) {
            //Asignar las variables locales o parametros a las variables globales
            this.ubicacion = ubicacion;
            this.escrituras = escrituras;
            this.metrosDeTerreno = metrosTerreno;
            this.serviciosBasicos = serviciosBasicos;
            this.cantidadBanos = cantidadBanos;
        }

        public Inmuebles(string ubicacion, string escrituras, double metrosTerreno,
                        bool serviciosBasicos)
        {
            //Asignar las variables locales o parametros a las variables globales
            this.ubicacion = ubicacion;
            this.escrituras = escrituras;
            this.metrosDeTerreno = metrosTerreno;
            this.serviciosBasicos = serviciosBasicos;           
        }
        public Inmuebles() { }


        //Miembro de tipo metodo
        public void DetallesInmueble() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sistema VentasTEC");
            Console.WriteLine("Ubicacion: {0}", ubicacion);
            Console.WriteLine("Escrituras a nombre de: {0}", escrituras);
            Console.WriteLine("Metros de terreno: {0}", metrosDeTerreno);
        }

    }
}