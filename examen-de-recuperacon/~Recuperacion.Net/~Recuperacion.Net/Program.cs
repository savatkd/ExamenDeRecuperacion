using System;
using System.Collections.Generic;
using System.Linq;

namespace _Recuperacion.Net
{
    class Program
    {
        Barco barco = Barco.getInstance();

        static void Main(string[] args)
        {
            //Barco barco = Barco.getInstance();
            Console.WriteLine(" \t\t\t ~ P R O G R A M I N G~");


            List<Alquiler> ListaAlquiler = new List<Alquiler>
            {
               new Alquiler {Nombre=" Edwin ", cedula_de_identidad= 1315400067, precio=1.9, DiaOcp=15, FechaInicial=new DateTime(1,1,2),barco_que_ocupa="Velero"},
               new Alquiler {Nombre=" Dennis ", cedula_de_identidad= 135636345, precio=1.14, DiaOcp=35, FechaInicial=new DateTime(2,2,3),barco_que_ocupa="Motor"},
               new Alquiler {Nombre=" Ivana ", cedula_de_identidad= 1315478933, precio=1.80, DiaOcp=45,FechaInicial=new DateTime(1,1,2),barco_que_ocupa="Lujo"},
               new Alquiler {Nombre=" Karina ", cedula_de_identidad= 1307849618, precio=1.85, DiaOcp=5,FechaInicial=new DateTime(1,8,5),barco_que_ocupa="Deportivo"}
            };

            Console.WriteLine("\nCosto mayor o igual a 50\n");
            var consulta = ListaAlquiler.Where(p => ((p.precio * p.DiaOcp) >= 50));

            foreach (var item in consulta)
            {
                item.mostrarDatos();
            }
            Console.WriteLine("\nAlquileres del cliente con determinado número de cédula\n");
            var consulta2 = ListaAlquiler.Where(p => (p.cedula_de_identidad == 1315400067));

            foreach (var item in consulta2)
            {
                item.mostrarDatos();
            }
            Console.WriteLine("\nAlquileres hechos en determinada fecha\n");
            var consulta3 = ListaAlquiler.Where(p => p.FechaInicial == new DateTime(1, 1, 2));
            foreach (var item in consulta3)
            {
                item.mostrarDatos();

            }

            Console.ReadKey();

        }
    }
}
