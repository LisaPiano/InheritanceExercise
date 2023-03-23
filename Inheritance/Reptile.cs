using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public bool HasLegs { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public bool SpeaksEnglish { get; set; }

    }

}
