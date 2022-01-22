using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_04
{

     class Program
    {

        static void Main(string[] args)
        {

            Creator.CreateBuild(new Building(23, 50, 100, 23));

            Creator.CreateBuild(new Building (34));

            Creator.CreateBuild(new Building (45, 56, 67));

            Creator.CreateBuild(new Building());

            Creator.DataInfo();

            Creator.Delete(2);

            Console.WriteLine("=====================================================================");
            
            Creator.DataInfo();
            
            Console.ReadLine();

        }
    }
}
