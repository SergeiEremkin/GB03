using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    internal class FileOperations : IManagerOperations
    { 
        public void CreateFD(string path)
        {
            if (File.Exists(path))
            {
                InformationAlerts.Error();
            }

            else
            {
                File.Create(path);
                InformationAlerts.Success();
            }
        }

        public void DeleteFD(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                InformationAlerts.Success();
            }
            else
            {

                InformationAlerts.Error();
            }
        }

        public void MoveFD(string oldPath, string newPath)
        {
            if (File.Exists(oldPath) && File.Exists(newPath))
            {
                InformationAlerts.Error();
            }

            else
            {
                File.Move(oldPath, newPath);

                InformationAlerts.Success();

            }
        }

        public void CopyFD(string oldPath, string newPath, string fileName)
        {
            string sourseFile = Path.Combine(oldPath, fileName);
            string destFile = Path.Combine(newPath, fileName);
            
            File.Copy(sourseFile, destFile, true);

            if (Directory.Exists(sourseFile))
            {
                File.Copy(sourseFile, destFile, true);
                InformationAlerts.Success();
            }

            else
            {
                InformationAlerts.Error();
            }
        }


        public void InformationFD(string path)
        {
            FileInfo info = new FileInfo(path);
            Console.WriteLine($"Имя: {info.Name}");
            Console.WriteLine($"Путь: {info.DirectoryName}");
            Console.WriteLine($"Последнее взаимодействие: {info.LastAccessTime}");
            Console.WriteLine($"Дата создания: {info.CreationTime}");
            Console.WriteLine($"Размер: {info.Length}");
            Console.WriteLine($"Расширение: {info.Extension}");
            Console.WriteLine($"Атрибуты: {info.Attributes}");
        }
    }
}
