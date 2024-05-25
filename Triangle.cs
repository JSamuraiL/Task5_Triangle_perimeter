using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Triangle
    {
        public float firstside {  get; set; }
        public float secondside { get; set; }
        public float thirdside { get; set; }
        public Triangle(float firstside, float secondside, float thirdside) 
        {
            if ((firstside > secondside + thirdside) ||
            (secondside > firstside + thirdside) ||
            (thirdside > firstside + secondside)) 
            { throw new NonExistentTriangleException("Это не треугольник"); }
            else 
            {
                Console.WriteLine($"Периметр данного треугольника: {firstside + secondside + thirdside}");
            }
        }
    }
}
