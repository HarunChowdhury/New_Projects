using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        
        private double radius;

        public double Radius
        {
            set;
            get;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetDiameter()
        {
            return 2*radius;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radius;
        }

        public double GetArea()
        {
            return Math.PI*radius*radius;
        }
    }
}
