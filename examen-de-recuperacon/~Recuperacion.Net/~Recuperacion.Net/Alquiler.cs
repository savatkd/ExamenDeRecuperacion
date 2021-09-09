using System;
using System.Collections.Generic;
using System.Text;

namespace _Recuperacion.Net
{
    class Alquiler : Cliente
    {

        public DateTime FechaInicial { get; set; }


        public DateTime fecha_final { get; set; }


        public int posicion_de_Amarre { get; set; }


        public string barco_que_ocupa { get; set; }


        public double precio { get; set; }


        public int DiaOcp { get; set; }


        public Alquiler(int cedula_de_identidad, string Nombre, string Apellido, DateTime fecha_incial_alquiler, DateTime fecha_final, int posicion_de_Amarre, string barco_que_ocupa, double precio = 1.8)
        {
            this.cedula_de_identidad = cedula_de_identidad;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaInicial = FechaInicial;
            this.fecha_final = fecha_final;
            this.posicion_de_Amarre = posicion_de_Amarre;
            this.barco_que_ocupa = barco_que_ocupa;
            this.precio = precio;
            this.DiaOcp = 100;
        }

        public Alquiler()
        {
        }

        public void calcular()
        {
            Console.WriteLine(this.Nombre + " " + this.barco_que_ocupa + "Deportivo" + (precio * DiaOcp) + " ");

        }
        public void mostrarDatos()
        {
            Console.WriteLine(MostrarDatos() + " Perecio de alquiler " + precio * DiaOcp + ", Dias Ocupados " + DiaOcp + ", Barco ocupado " + barco_que_ocupa + " desde la fecha " + fecha_final);
        }


    }


}
