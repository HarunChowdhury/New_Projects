using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {       

           Console.Write("Enter Circle's radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());



            Circle aCircle = new Circle(radius);
            
            
            double diameter = aCircle.GetDiameter();
            double perimeter = aCircle.GetPerimeter();
            double area = aCircle.GetArea();

           Console.WriteLine("Circle's \n Diameter ="+diameter+"\n Perimeter = " +perimeter + "\n Area = "+area) ;
            Console.ReadKey();
        }
    }
}
