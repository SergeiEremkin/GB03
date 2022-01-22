using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
     interface IActionWithFigure
    {
        void ShowInfo();

        void ChangeColor(string color);

        void Visibility();

        void Move(int x, int y);

        double Area(double a);
    }

    
}
