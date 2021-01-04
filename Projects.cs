using System;

namespace example_oop
{
    public class Projects   //Abstracta
    {
        //Propiedades (Atributos)
        public string ProjectType { get; set; }
        //public => el modificador de acceso (private, protected, selled)
        //int => tipo de dato que va a almacenar la propiedad
        //MyProperty => nombre de la propiedad (nombre nemotecnico)
        //{ get; set; } => metodos con los que cuenta la propiedad para recibir el dato (set) y para devolver el dato (get)

        //Metodos (Funciones) sin return
        /* public void projectPrice(string projecttype){
             int price = 0;

             if ( projecttype == "a" || projecttype == "A" )
             {
                 price = 1000;
             } else
             {
                 if ( projecttype == "b" || projecttype == "B" )
                 {
                     price = 2000;
                 } else
                 {
                     price = 500;
                 }
             }
            
             Console.WriteLine("The price is: " + price);

        }  */
        //public => el modificador de acceso (private, protected, selled)
        //void => tipo de retorno que va a devolver el metodo (la funcion)
        //MyMethod => nombre del metodo (nombre nemotecnico)
        //()Parametros del metodo (de la funcion) => son opcionales. Cuando se colocan, el usuario al momento de utilizar
        //el metodo los debe de colocar para que el metodo pueda funcionar. Los parametros son variables con su tipo de dato


        //Metodos (Funciones) con return
        public short projectPrice(string projecttype){
            short price = 0;

            if ( projecttype == "a" || projecttype == "A" )
            {
                price = 1000;
            } else
            {
                if ( projecttype == "b" || projecttype == "B" )
                {
                    price = 2000;
                } else
                {
                    price = 500;
                }
            }
            
            //Entregar el valor (retornarlo)
            return price;
        }

        public void viewResult()
        {
            short printPrice = 0;

            printPrice = projectPrice(ProjectType);

            Console.WriteLine("The price is: " + printPrice);
        } 

        
        
    }
}