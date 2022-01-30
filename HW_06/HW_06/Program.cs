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
            Figure figure = new Figure("red", true);
            Figure figure2 = new Figure("yellow", false);
            figure.ChangeColor("Green");
            figure.Visibility();
            figure2.Visibility();
            figure.MoveX(1);
            Point point = new Point(1, 2);
            point.MoveY(3);
            Console.WriteLine(figure.ToString());
            Rectangle rectangle = new Rectangle();
            point.ChangeColor("green");
            Console.WriteLine(rectangle.ToString());
            Console.ReadLine();
        }
    }
}
