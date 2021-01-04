using System;

namespace exampleAbstractOverrider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Animal Planet!");

            /*var DocOne = new Dog();
            Console.Write(DocOne.name="Jossi ");
            DocOne.to_run();

            var CatOne = new Cat();
            Console.Write(CatOne.name = "Silvestre ");
            CatOne.to_run();  */

            Console.WriteLine("Type a id");
            string animalId = Console.ReadLine();

            Console.WriteLine("Type a age");
            short animalAge = short.Parse(Console.ReadLine());

            var MyDog = new Dog()
            {
                id = animalId,
                age = animalAge
            };

            Console.WriteLine(MyDog.age + " " + MyDog.id);

            //Abastract example
            /*var DocOne = new Dog();
            var CatOne = new Cat();

            DocOne.name="Jossi";
            CatOne.name="Silvestre";

            Console.WriteLine(
                "My Dog is " + 
                DocOne.name + " " + 
                DocOne.to_run() +
                " and makes " + 
                DocOne.sound()
            );
            
            Console.WriteLine(
                "My Cat is " + 
                CatOne.name + " " + 
                CatOne.to_run() + 
                " and makes " + 
                CatOne.sound()
            );  */
        }
    }
}
