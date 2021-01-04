using System;

namespace exampleAbstractOverrider
{
    class Dog : DomesticAnimal
    {
        //Method implement abstract
        public override string sound(){
            return "Guau guau";
        }
    }
}