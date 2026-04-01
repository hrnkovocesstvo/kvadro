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

        public void set_a(double a_in) { a = a_in; }
        public void set_b(double b_in) { a = b_in; }
        public void set_c(double c_in) { a = c_in; }

        public double get_a() { return a; }
        public double get_b() { return b; }
        public double get_c() { return c; }

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
