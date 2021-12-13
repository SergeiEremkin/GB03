using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_01
{

    

       


    }
    internal class Program
    {
    public static void PrintArrayBack(int[] arr)
    {

        for (int i = arr.Length -1 ; i >=0; i--)
        {
            Console.Write(arr[i]);
        }

    }
    static void Main(string[] args)
        {
        var arr = new int[] { 2, 4, 5, 6, 8 };

        foreach (var a in arr)

            Console.Write(a);

        Console.WriteLine();

        PrintArrayBack(arr);

        Console.ReadLine();
        }
    }




