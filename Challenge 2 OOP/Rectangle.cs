using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_OOP
{
    class Rectangle
    {
        public double length;
        public double width;
       

       
        public Rectangle(double Plength, double Pwidth)
        {
            length = Plength;
             width = Pwidth;
            
        }

        public double Area()
        {
            double area = length * width;
            return area;
        }

        
    }
}
