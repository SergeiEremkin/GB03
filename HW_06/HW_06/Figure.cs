using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    public class Figure : IActionWithFigure
    {
        private string _color;
        private bool _isVisible;

        public Figure() : this ("") 
        { 

        }

        public Figure(string color) : this ("", true)
        {

        }

        public Figure (string color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }

        public string Color { get=> _color ; set => _color = value; }

        public bool IsVisible { get =>_isVisible; set => _isVisible = value;}

        public void ShowInfo()
        {
            Console.WriteLine ("Color" + ": " + Color + " " + "Видимость" + ": " + IsVisible);
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public void Visibility()
        {
            if (IsVisible is true)
            {
                Console.WriteLine("Фигура видимая");
            }

            else
            {
                Console.WriteLine("Фигура невидимая");
            }
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Move by X = {x}, Move by Y = {y}");
        }

        public virtual double Area(double a)
        {
            return a;
        }

        public virtual double Area(double a, double b)
        {
            return a;
        }












    }
}
