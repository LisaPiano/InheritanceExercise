using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

            public class Animal
        {
            public Animal()
            {

            }
            public bool hasHair { get; set; }
            public string name { get; set; }
            public string sound { get; set; }
            public int numberOfEyes { get; set; }

            public void makesSound()
            {
                Console.WriteLine($"{sound}");
            }
        }// End Animal CLass


        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public class Bird : Animal
        {

            public Bird()
            {

            }
            public bool canFly { get; set; }
            public string color { get; set; }
            
            public int numberOfEggs { get; set; }

            public bool eatsWorms { get; set; }

        }//end class Bird
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class


        public class Reptile : Animal
        { 
        public Reptile() 
            { 
            
            }
            public bool hasLegs { get; set; }
            public string color { get; set; }

            public string size { get; set; }    

            public bool speaksEnglish { get; set; } 
        
        }//end class Reptile

        /*Create an object of your Bird class
         *  give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */
    

            
        }//end Program
    }//end namespace

