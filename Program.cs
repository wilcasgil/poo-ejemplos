using System;

namespace example_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Console.WriteLine("Project Type:");
            // string projectType = Console.ReadLine();

            /*Console.WriteLine("Your Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Your Surnames:");
            string Surnames = Console.ReadLine();   */

            //Instanciar la class Projects (Hacer copias de la clase Projects)
            /*var projectOne = new Projects()    //constructor
            {
                //Propiedades a utilizar de la class
                ProjectType = projectType
            };  */

            //projectOne.projectPrice(projectOne.ProjectType);

            //projectOne.viewResult();


            /*var woman = new Person();

            string womanOne = woman.fullName(Name, Surnames);

            Console.WriteLine(womanOne);
            
            woman.corazon();  */

            /**
            * static
            * 
             */
            //Cuando el metodo no es estatic se debe hacer una instancia de la class
            /*var MyRadio = new Areas();
            MyRadio.calcularAreaCirculo(20);  */

            //Cuando el metodo es static no es necesario hacer una instancia de la class
            
            Console.WriteLine(Areas.calcularAreaCirculo(20));

        }
    }
}
