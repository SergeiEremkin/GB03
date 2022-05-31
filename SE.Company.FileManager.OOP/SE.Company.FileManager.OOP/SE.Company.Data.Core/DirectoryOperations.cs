using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    internal class DirectoryOperations : IManagerOperations
    {
        public void CreateFD(string path)
        {
            if (Directory.Exists(path))
            {
                InformationAlerts.Error();
            }

            else

                Directory.CreateDirectory(path);
            InformationAlerts.Success();
        }

        public void DeleteFD(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
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
                Directory.Move(oldPath, newPath);
                InformationAlerts.Success();
            }
        }

        public void CopyFD(string oldPath, string newPath, string fileName)
        {
            string sourseFile = Path.Combine(oldPath, fileName);
            string destFile = Path.Combine(newPath, fileName);
            Directory.CreateDirectory(newPath);
            File.Copy(sourseFile, destFile, true);

            if (Directory.Exists(sourseFile))
            {
                string[] files = Directory.GetDirectories(sourseFile);

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(newPath, fileName);
                    File.Copy(s, destFile, true);
                    InformationAlerts.Success();
                }

                
            }

            else
            {
                InformationAlerts.Error();
            }

        }

        public void InformationFD(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            Console.WriteLine($"Путь: {info.FullName}");
            Console.WriteLine($"Диск: {info.Root}");
            Console.WriteLine($"Последнее взаимодействие: {info.LastAccessTime}");
            Console.WriteLine($"Дата создания: {info.CreationTime}");
            Console.WriteLine($"Атрибуты: {info.Attributes}");
        }
    }
}
