using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07
{
    //Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
    //(В результате такого сдвига буква А становится буквой Б).

    internal class ACoder : ICoder
    {
        public string Decode(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input.Length);

            foreach (char c in input)

            {
                char ec = c;

                if (c >= 'A' && c <= 'Я')

                {
                    ec = (char)(c + 1);
                }

                if (c >= 'а' && c <= 'я')

                {
                    ec = (char)(c + 1);
                }

                if (c >= 'A' && c <= 'Z')

                {
                    ec = (char)(c + 1);
                }

                if (c >= 'a' && c <= 'z')

                {
                    ec = (char)(c + 1);
                }

                stringBuilder.Append(ec);

            }

            return stringBuilder.ToString();
        }




        public string Encode(string input)
        {

            StringBuilder stringBuilder = new StringBuilder(input.Length);

            foreach (char c in input)

            {
                char ec = c;

                if (c >= 'A' && c <= 'Я')

                {
                    ec = (char)(c - 1);
                }

                if (c >= 'а' && c <= 'я')

                {
                    ec = (char)(c - 1);
                }

                if (c >= 'A' && c <= 'Z')

                {
                    ec = (char)(c - 1);
                }

                if (c >= 'a' && c <= 'z')

                {
                    ec = (char)(c - 1);
                }

                stringBuilder.Append(ec);

            }

            return stringBuilder.ToString();

        }
    }
}




