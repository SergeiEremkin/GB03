using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Color = "red", IsVisible = true};
            circle.Move(2, 3);
            circle.ShowInfo();
            Console.WriteLine(circle.Area(5));
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area(3, 4));
            Console.ReadLine();
        }
    }
}
