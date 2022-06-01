using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOU4_Ejemplo1
{
    public class Casa : Inmuebles
    {
        private byte cantidadHabitaciones;
        private double metrosConstruidos;
        private byte numeroPisos;

        //Constructor
        public Casa() { }

        public Casa(byte cantidadHabitaciones, double metrosConstruidos, byte numeroPisos,
            string ubicacion, string escrituras, double metrosTerreno,
                        bool serviciosBasicos, byte cantidadBanos)
            :base(ubicacion,escrituras,metrosTerreno,serviciosBasicos,cantidadBanos)
        {
            this.cantidadHabitaciones = cantidadHabitaciones;
            this.metrosConstruidos = metrosConstruidos;
            this.numeroPisos = numeroPisos;
        
        }
    }
}