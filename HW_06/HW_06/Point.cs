using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    public class Point : Figure
    {
        private int _x;
        private int _y;

        public Point() : this (1)
        {
            
        }

        public Point(int x) : this(1,2)
        {
           
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => _x; set=> _x = value; }
        public int Y { get => _y; set => _y = value; }


        public override void MoveX(int x)
        {
            Console.WriteLine($"Point move by X = {x}");
        }

        public override void MoveY(int y)
        {
            Console.WriteLine($"Point move by Y = {y}");
        }


       


    }
}
