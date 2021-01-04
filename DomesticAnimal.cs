using System;
using System.Threading.Tasks;

namespace exampleAbstractOverrider
{
    abstract class DomesticAnimal
    {
        //Generic property
        private string idV;
        public string id { 
            get { return idV; }

            set {
                if (value.Length == 4)
                {
                    idV = value;
                }
                else
                {
                    Console.WriteLine("Id not valid");
                }
            }
        }


        public string name { get; set; }

        private short ageV;
        public short age { 
            get { return ageV; }

            set {
                if (value >= 3)
                {
                    ageV = value;
                }
                else
                {
                    Console.WriteLine("age not valid");
                }
            }
        }
        
        //Generic method
        public string to_run()
        {
             return "is running";
        }

        //Abstract method
        public abstract string sound();
    }
}


//dato age=5, 7, ...     name=Maria
