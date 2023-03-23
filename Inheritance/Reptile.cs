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
        public bool hasLegs { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public bool speaksEnglish { get; set; }

    }

}
