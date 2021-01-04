using System;
using System.Collections.Generic;

namespace arraysExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Todos estos eventos son simulados y en un programa real vendrían de la base de datos.
            //No pido los datos por consola, porque la idea es que estos ya existan.
            AccesoData data = new AccesoData();
            List<Evento> eventos = data.obtenerListaEventos();

            OrquestadorConsola.solicitarDatosPersonas();
            OrquestadorConsola.imprimirEventos(eventos);
        }
    }
}
