using System;

namespace exampleAbstractOverrider
{
    class Cat : DomesticAnimal
    {
        //Method implement abstract
        public override string sound(){
            return "Miau";
        }
    }
}