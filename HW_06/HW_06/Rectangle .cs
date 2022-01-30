using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    sealed class Rectangle : Point
    {
        public double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public override void MoveX(int x)
        {
            Console.WriteLine($"Rectangle move by X = {x}");
        }

        public override void MoveY(int y)
        {
            Console.WriteLine($"Rectangle move by Y = {y}");
        }
        
    }
}
