using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sEncapsulationDemo
{
    public class Circle
    {
        private double _radius;
        public double radius
        {
            set { _radius = value; }
            get { return _radius; }
        
        }



        //Calculate the area of circle==pi* r*r
        const float pi = 3.14f;
        public double CalculateArea()
        {
            double area = pi * radius * radius;
        return area;
        
        }


    }
}
