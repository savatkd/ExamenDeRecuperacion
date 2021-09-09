using System;
using System.Collections.Generic;
using System.Text;

namespace _Recuperacion.Net
{
    class Barco : Cliente
    {
        private static Barco instance;

        public List<Alquiler> alquilers = new List<Alquiler>();

        public int matricula { get; set; }

        public int largo_metros { get; set; }

        public int año_de_frabricacion { get; set; }

        public double ModuloF { get; set; }

        public Barco(int cedula_de_identidad, string Nombre, string Apellido, int matricula, int largo_metros, int año_de_frabricacion, double ModuloF = 0.2)
        {
            this.cedula_de_identidad = cedula_de_identidad;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.matricula = matricula;
            this.largo_metros = largo_metros;
            this.año_de_frabricacion = año_de_frabricacion;
            this.ModuloF = ModuloF;
        }
        public void calcular()
        {
            Console.WriteLine(this.Nombre + " " + this.largo_metros + "Deportivo" + (ModuloF * largo_metros) + " ");
        }
        public void mostrarDatos()
        {
            Console.WriteLine(MostrarDatos() + " Perecio a calcular " + ModuloF + "Dias Ocupados" + largo_metros);
        }

        //Patron de Diseño
        private Barco()
        {

        }

        public static Barco getInstance()
        {
            if (instance == null)
            {
                instance = new Barco();
            }

            return instance;
        }
        public void addAlquiler(Alquiler alquiler) => alquilers.Add(new Alquiler()
        {
            FechaInicial = alquiler.FechaInicial,
            fecha_final = alquiler.fecha_final,
            posicion_de_Amarre = alquiler.posicion_de_Amarre,
            barco_que_ocupa = alquiler.barco_que_ocupa



        });

    }



}
