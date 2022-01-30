using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    internal static class InformationAlerts
    {
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка. Введите комманду повторно");
            Console.ResetColor();
        }

        public static void Success()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выполнено");
            Console.ResetColor();
        }
    }
}
