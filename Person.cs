using System;

namespace example_oop
{
    public class Person   //Concreta
    {

        //Propiedades


        //Metodos
        public string fullName(string name, string surnames){
            return name + " " + surnames;
        }

        //Caminar, Comer, Amar, Soñar...
        public void corazon(){
            Console.WriteLine("--__--");
        }

    }
}