using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    { 
            public Animal()
            {

            }
            public bool HasHair { get; set; }
            public string Name { get; set; }
            public string Sound { get; set; }
            public int NumberOfEyes { get; set; }

            public void MakesSound()
            {
                Console.WriteLine($"{Sound}");
            }

    }
}
