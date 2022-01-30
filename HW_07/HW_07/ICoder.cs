using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07
{
    internal interface ICoder
    {
        string Encode(string input);
        string Decode(string input);
    }
}
