using System;

namespace example_logica
{
    public class Operaciones
    {
        //Propiedades (atributos - caracteristica)
        public int numUno { get; set; }
        public int numDos { get; set; }

        //Metodos (funciones - acciones)
        // public void nuestraSuma(int numeroUno, int numeroDos){
        //     int resultado = 0;

        //     resultado = numeroUno + numeroDos;
            
        //     Console.WriteLine("El resultado de la suma es " + resultado);
        // }

        //Dividir las tareas del metodo anterior
        private int nuestraSuma(int numeroUno, int numeroDos){
            int resultado = 0;

            resultado = numeroUno + numeroDos;
            
            return resultado;
        }

        public void imprimirResulSuma(){
            Console.WriteLine(
                "El resultado de la suma es " +
                nuestraSuma(numUno, numDos)
            );
        }
    }
}