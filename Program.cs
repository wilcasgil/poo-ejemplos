using System;

namespace example_logica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como mostrar mensajes con console.write()
            //Console.WriteLine("Que mas pues!");

            Console.WriteLine("Bienvenidos a C#, soy Wilson Castro");

            //Ejemplos con variables
            Console.WriteLine("Numero Uno");
            int nUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero Dos");
            int nDos = int.Parse(Console.ReadLine());

            //Para utlizar las propiedades y los metodos de
            //la clas Operaciones, debemos de generar una
            //instancia de ella (crear un objeto de la class)

            Operaciones mySumaUno = new Operaciones(){
                numUno = nUno,
                numDos = nDos
            };

            //Imprimir las propiedades de la class
            //Console.WriteLine(mySumaUno.numUno);

            //Mostrar el resultado de la suma
            //mySumaUno.nuestraSuma(mySumaUno.numUno, mySumaUno.numDos);
            mySumaUno.imprimirResulSuma();

            // 

            // Console.WriteLine("Resultado multiplicación " + resultMul);
        }
    }
}
