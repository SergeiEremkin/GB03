using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
     public class SearchOperations: ISearch
    {
        public void ShowDiscInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Диск {0}", d.Name);
                Console.WriteLine("  Тип диска: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Метка: {0}", d.VolumeLabel);
                    Console.WriteLine("  Файловая система: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Доступно памяти для ткущего пользователя :{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Всего доступно свободного места:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Всего метса на диске:            {0, 15} bytes ",
                        d.TotalSize);
                }
            }
        }

        public void ShowDirsAndFiles(string path)
        {
            {
                Console.Clear();

                if (Directory.Exists(path))
                {

                    string[] b = Directory.GetDirectories(path);
                    string[] d;
                    string[] files;

                    for (int i = 0; i < b.Length; i++)
                    {
                        Console.WriteLine($"| {b[i]}");

                        if (Directory.Exists(b[i]))
                        {
                            d = Directory.GetDirectories(b[i]);

                            for (int a = 0; a < d.Length; a++)
                            {
                                files = Directory.GetFiles(d[a]);

                                Console.WriteLine($" - { d[a]}");

                                foreach (string deepthFiles in files)
                                {
                                    Console.WriteLine($"   - {deepthFiles}");
                                }
                            }
                        }

                        files = Directory.GetFiles(b[i]);

                        for (int s = 0; s < files.Length; s++)
                        {
                            Console.WriteLine($"  ╚ { files[s]}");
                        }
                    }

                    d = Directory.GetFiles(path);

                    foreach (string filesInCurrentDirectory in d)
                    {
                        Console.WriteLine($"╚ { filesInCurrentDirectory}");
                    }

                    Console.WriteLine();

                }
                else
                {
                    InformationAlerts.Error();
                }
            }
        }

    }
}

