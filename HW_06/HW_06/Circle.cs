using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    sealed class Circle : Point
    {

        public double CircleArea(int r)
        {
           return (r * r) * Math.PI;
        }

        public override void MoveX(int x)
        {
            Console.WriteLine($"Circle move by X = {x}");
        }

        public override void MoveY(int y)
        {
            Console.WriteLine($"Circle move by Y = {y}");
        }


        
    }
}
