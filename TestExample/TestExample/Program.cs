using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_04;

namespace TestExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuild(new Building(34));

            Creator.CreateBuild(new Building());

            Creator.DataInfo();

            Creator.Delete(1);

            Creator.DataInfo();

            Console.ReadLine();
        }
    }
}
