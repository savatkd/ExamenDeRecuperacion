using System;
using System.Collections.Generic;
using System.Text;

namespace _Recuperacion.Net
{
    class Cliente
    {


        public int cedula_de_identidad { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string MostrarDatos()
        {

            return Nombre + " " + Apellido + " " + cedula_de_identidad + " ";

        }

    }


}

