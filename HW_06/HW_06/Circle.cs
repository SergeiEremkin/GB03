using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06
{
    public class Circle : Point
    {
        public override double Area(double r)
        {
            return (r * r) * Math.PI;
        }
    }
}
