using System;

namespace example_oop
{
    public static class Areas   //abstract
    {

        //Propiedades
        

        //Metodos
        const double PI = 3.1416;

        public static double calcularAreaCirculo(int radio)
        {
            return radio * radio * PI;
        }
        
    }
}