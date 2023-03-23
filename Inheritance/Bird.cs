using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {

        public Bird()
        {
            CanFly = true;
        }
        public bool CanFly { get; set; }
        public string Color { get; set; }
        public int NumberOfEggs { get; set; }
        public bool EatsWorms { get; set; }
    }



}
