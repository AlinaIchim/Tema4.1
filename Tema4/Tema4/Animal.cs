using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    public class Animal
    {
        public string ceFelDeAnimal { get; set; }
        public string culoare { get; set; }
        public int varsta { get; set; }

        public Animal()
        {
            ceFelDeAnimal = "";
            culoare = "";
            varsta = 0;
        }

        public Animal(string ceFelDeAnimal)
        {
            this.ceFelDeAnimal = ceFelDeAnimal;
            this.culoare = "";
            this.varsta = 0;
        }

        public Animal(string ceFelDeAnimal, string culoare, int varsta)
        {
            this.ceFelDeAnimal = ceFelDeAnimal;
            this.culoare = culoare;
            this.varsta = varsta;
        }
    }
}
