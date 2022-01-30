using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    public class Figure
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

        public override string ToString()
        {
            return "Color" + ": " + Color +" "+ "Видимость" + ": " + IsVisible;
        }


        public string Color { get=> _color ; set => _color = value; }
        
        public bool IsVisible { get =>_isVisible; set => _isVisible = value;}

        public virtual void MoveX(int x)
        {
            Console.WriteLine($"Figure move by X = {x}");
        }

        public virtual void MoveY(int y)
        {
            Console.WriteLine($"Figure move by Y = {y}");
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
    }
}
