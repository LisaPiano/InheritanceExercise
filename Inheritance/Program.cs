using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bigBird = new Bird();

            bigBird.Color = "yellow";
            bigBird.EatsWorms = true;
            bigBird.HasHair = false;
            bigBird.Name = "BigBird";
            bigBird.NumberOfEggs = 100;
            bigBird.NumberOfEyes = 2;
            bigBird.Sound = "Hi there boys and girls!";



            bigBird.MakesSound();

            Reptile kermit = new Reptile()
            {
                Color = "green",
                HasHair = false,
                HasLegs = true,
                Name = "Kermit",
                NumberOfEyes = 2,
                Size = "Small",
                Sound = "It's not Easy Being Green",
                SpeaksEnglish = true
            };

            kermit.MakesSound();

        }//end main

           

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

