using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07
{
    //Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, 
    //расположенную в алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на букву Э.

    internal class BCoder : ICoder
    {
        public string Decode(string input)
        {
           return Encode(input);
        }

        public string Encode(string input)
        {

            StringBuilder stringBuilder = new StringBuilder(input.Length);

            foreach (char c in input)
            {

                char ec = c;

                {
                    if (c >= 'A' && c <= 'Z')
                     {
                        ec = (char)('A' + 'Z' - c);
                     }

                    if (c >= 'a' && c <= 'z')
                    {
                        ec = (char)('a' + 'z' - c);
                    }

                    if (c >= 'А' && c <= 'Я')
                    {
                        ec = (char)('А' + 'Я' - c);
                    }

                    if (c >= 'а' && c <= 'я')
                    {
                        ec = (char)('а' + 'я' - c);
                    }
                    
                }

                stringBuilder.Append(ec);
            }

            return stringBuilder.ToString();
        }
            
        }
}

            
            

