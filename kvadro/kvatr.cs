using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadro
{
    internal class kvatr
    {
        private double a;
        private double b;
        private double c;

        public kvatr(double a_in, double b_in, double c_in)
        {
            a = a_in; b = b_in; c = c_in;
        }

        public double get_objem()
        {
            return a * b * c;
        }
        
        public double get_povrh()
        {
            return 2*(a*c + a*b + c*b);
        }
    }
}
