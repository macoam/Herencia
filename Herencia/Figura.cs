using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Figura
    {
        public string Color { get; set; }
        
        //Todas la figuras deben ser capaces de calcular su área
        public abstract double calcularArea();

        public string toString()
        {
            return " \n Soy una figura: " + Color;
        }
    }
}
