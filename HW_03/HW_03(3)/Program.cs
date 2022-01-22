using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_3_
{

    /*
     * 3. * Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес. 
     * Разделителем между ФИО и адресом электронной почты является символ &: Кучма Андрей Витальевич & Kuchma@mail.ru
     * Мизинцев Павел Николаевич & Pasha@mail.ru Сформировать новый файл, содержащий список адресов электронной почты. 
     * Предусмотреть метод, выделяющий из строки адрес почты. Методу в качестве параметра передается символьная строка s,
     * e-mail возвращается в той же строке s: public void SearchMail (ref string s).
     * 
     * 
     */
    internal class Program
    {

        public static void SearchMail(ref string s)

        {

            var splitedText = s.Split('&', '\r');

            for (int i = 0; i < splitedText.Length; i++)

            {
                if (splitedText[i].Contains('@'))

                {

                    s = string.Join("\n", splitedText[i]);

                }

                else

                    return;

            }
            
        }

        static void Main(string[] args)
        {
            string readPath = @"C:\Users\Пользователь\source\repos\HW_03\TextFile1.txt";

            string readText = File.ReadAllText(readPath);

            SearchMail(ref readText);

            string writePath = @"C:\Users\Пользователь\source\repos\HW_03\email2.txt";

            File.WriteAllText(writePath, readText);

            Console.ReadLine();
        }
    }
}
