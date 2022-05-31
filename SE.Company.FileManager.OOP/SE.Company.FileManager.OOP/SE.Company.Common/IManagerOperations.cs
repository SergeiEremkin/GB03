using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    public interface IManagerOperations
    {

        void CreateFD(string path);   //* создавать папки/файлы;
        void DeleteFD(string path);  //* удалять папки/файлы;
        void MoveFD(string oldPath, string newPath);  //* переименовывать папки/файлы;
        void InformationFD(string path); // информация о файлах и папках

        void CopyFD(string oldPath, string newPath, string file); //копировать файл или папку
        
        

        
        


    }
}

    
       

        

        

       

