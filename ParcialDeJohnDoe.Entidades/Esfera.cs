using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ParcialDeJohnDoe.Entidades
{
    public class Esfera
    {
        public int Radio { get; set; }
        public Relleno Relleno { get; set; }
        public Trazo Trazo { get; set; }

        public Esfera()
        {
            
        }

        public double GetVolumen()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radio, 3);
        }

        public double GetArea()
        {
            return 4 * Math.PI * Math.Pow(Radio, 2);
        }

        public bool Validar()
        {
            return Radio > 0;
        }
    }
}
