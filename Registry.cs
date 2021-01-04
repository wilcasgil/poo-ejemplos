using System;
using System.Collections.Generic;

namespace arraysExample
{
    class Registry
    {
        private bool hasDiscount;    //tieneDescuento
        private List<Person> people;
        public int Price { get; set; }

        public Registry()   //Esto es un constructor explicito
        {
            people = new List<Person>();   //list sirve para almacenar una lista de objetos, en este caso personas
        }

        public void printAllPeople()
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }

        public void addPerson(Person person)
        {            
            people.Add(person);
            
        }

        public void discount(int value)
        {
            if (value == 1)
            {
                hasDiscount = true;
            }
            else
            {
                hasDiscount = false;
            }            
        }

        public double calculateAndReturnPrice(int numberOfGuests, int daysOfStay)
        {
            double finalPrice;
            switch (numberOfGuests)
            {
                case 1:
                    finalPrice = PricesDao.INDIVDUAL_PRICE * daysOfStay * 1.19;
                    finalPrice = hasDiscount ? finalPrice / 1.05 : finalPrice;
                    break;
                case 2:
                    finalPrice = PricesDao.DOUBLE_PRICE * daysOfStay * 1.19;
                    finalPrice = hasDiscount ? finalPrice / 1.09 : finalPrice;
                    break;
                default:
                    finalPrice = PricesDao.FAMILIAR_PRICE * daysOfStay * 1.19;
                    finalPrice = hasDiscount ? finalPrice / 1.15 : finalPrice;
                    break;
            }

            return finalPrice;
        }
    }
}