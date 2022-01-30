using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    public interface ISearch
    {
        void ShowDiscInfo(); // показать инфу о диске

        void ShowDirsAndFiles(string path); // показать директории и файлы

        

    }
}
