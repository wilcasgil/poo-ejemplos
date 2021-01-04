using System;
using System.Collections.Generic;

namespace arraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome!");

            List<Registry> registries = new List<Registry>();
            while (true)
            {
                Console.WriteLine("What do you want to do?");    //¿Qué quieres hacer?
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. New registry");
                Console.WriteLine("2. See all registries");     //Ver todos los registros
                int optionOne = Int32.Parse(Console.ReadLine());
                if (optionOne == 0)
                {
                    Console.WriteLine("Good bye!!");
                    break;
                }
                if (optionOne == 1)
                {
                    int numberOfGuests;         //numeroDeInvitados
                    do
                    {
                        Console.WriteLine("How many people?");            //Cuantas personas
                        numberOfGuests = Int32.Parse(Console.ReadLine());

                    } while (numberOfGuests > 3);
                    Console.WriteLine("Does it have discount? Put 1 for yes and 0 for no");  //¿Tiene descuento? Ponga 1 para sí y 0 para no
                    int optionTree = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Days of stay?");                //Días de estancia?
                    int daysOfStay = Int32.Parse(Console.ReadLine());
                    Registry registry = new Registry();     //Registro
                    registries.Add(registry);               //registros
                    registry.discount(optionTree);
                    double finalPrice;
                    for (int i = 0; i < numberOfGuests; i++)     ////numeroDeInvitados
                    {
                        Console.WriteLine("Give me the name of the " + (i + 1) + " guest");       //Dame el nombre del invitado
                        string name = Console.ReadLine();
                        Person person = new Person(name);

                        registry.addPerson(person);
                    }

                    finalPrice = registry.calculateAndReturnPrice(numberOfGuests, daysOfStay);
                    Console.WriteLine("This is the price for the room: " + finalPrice);          //Este es el precio de la habitación.

                }
                else if (optionOne == 2)
                {
                    if (registries.Count < 1)
 
                    {
                        Console.WriteLine("There's no registries yet");     //Aún no hay registros
                    }
                    foreach (Registry registry in registries)
                    {
                        Console.WriteLine("We have the following guests in this room:");   //Tenemos los siguientes invitados en esta sala
                        registry.printAllPeople();
                    }
                }
                else
                {
                    Console.WriteLine("What??? Read! for gods sake!!");    //¿¿¿Qué??? ¡Leer! por el amor de Dios
                }
            }
        }
    }
}
