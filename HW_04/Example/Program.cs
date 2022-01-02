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
             
            
            Creator.CreateBuild(new Building { Apartment = 25, Floor = 2, Height = 10, Front = 45, });

            Creator.CreateBuild(new Building { Apartment = 25, Floor = 2, Height = 10, Front = 45, });

            Creator.CreateBuild(new Building { Apartment = 25, Floor = 2, Height = 10, Front = 45, });

            Creator.CreateBuild(new Building { Apartment = 25, Floor = 2, Height = 10, Front = 45, });

            Creator.DataInfo();

            Creator.Delete(2);

            Console.WriteLine("=====================================================================");
            
            Creator.DataInfo();
            
            



            Console.ReadLine();

        }
    }
}
