using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Company.FileManager.OOP
{
    internal static class UI
    {
        public static void UIMenu()
        {

            var origWidth = Console.WindowWidth;
            var origHight = Console.WindowHeight;
            FileOperations fileOperations = new FileOperations();
            DirectoryOperations directoryOperations = new DirectoryOperations();
            SearchOperations searchOperations = new SearchOperations();

            while (true)
            {

                try
                {
                    string UserChoise = Console.ReadLine();


                    {
                        Console.WriteLine("Верно");
                    }


                    switch (UserChoise)
                    {

                        case "createF":

                            UISettings();
                            Console.WriteLine(@"Укажите путь и название файла. Например C:\Users\MyFile.txt");
                            string pathF = Console.ReadLine();
                            fileOperations.CreateFD(pathF);

                            break;


                        case "createD":

                            UISettings();
                            Console.WriteLine(@"Укажите путь и название папки. Например C:\Users\MyFolder");
                            string pathD = Console.ReadLine();
                            directoryOperations.CreateFD(pathD);

                            break;


                        case "infoDisc":

                            UISettings();
                            searchOperations.ShowDiscInfo();



                            break;

                        case "deleteF":
                            UISettings();
                            Console.WriteLine(@"Укажите путь и название файла. Например C:\Users\MyFile.txt");
                            string delF = Console.ReadLine();
                            fileOperations.DeleteFD(delF);



                            break;

                        case "deleteD":

                            UISettings();
                            Console.WriteLine(@"Укажите путь и название папки. Например C:\Users\MyFolder");
                            string delD = Console.ReadLine();
                            directoryOperations.DeleteFD(delD);


                            break;

                        case "moveF":

                            UISettings();
                            Console.WriteLine(@"Укажите путь откуда переносим файл. Например C:\Users\MyFile.txt");
                            string fromF = Console.ReadLine();
                            Console.WriteLine(@"Укажите путь откуда переносим файл. Например C:\MyFolder\MyFile.txt.Можете переименовать файл, введите другое название");
                            string toF = Console.ReadLine();
                            fileOperations.MoveFD(fromF, toF);



                            break;

                        case "moveD":

                            UISettings();
                            Console.WriteLine(@"Укажите путь откуда переносим файл. Например C:\Users\MyFile.txt");
                            string fromD = Console.ReadLine();
                            Console.WriteLine(@"Укажите путь откуда переносим файл. Например C:\MyFolder\MyFile.txt.Можете переименовать файл, введите другое название");
                            string toD = Console.ReadLine();
                            directoryOperations.MoveFD(fromD, toD);

                            Console.Clear();

                            break;

                        case "copyD":

                            UISettings();
                            Console.WriteLine(@"Укажите путь откуда копируем папку с файлами. Например C:\Users\MyFolder");
                            string copyFrom = Console.ReadLine();
                            Console.WriteLine(@"Укажите путь куда копируем папку с фалами. Например C:\MyFolder\MySecondFolder");
                            string copyTo = Console.ReadLine();
                            Console.WriteLine(@"Введите название файла, который копируем. Например AnyText.txt");
                            string filename = Console.ReadLine();
                            directoryOperations.CopyFD(copyFrom, copyTo, filename);

                            Console.Clear();

                            break;

                        case "copyF":

                            UISettings();
                            Console.WriteLine(@"Укажите путь откуда копируем файл. Например C:\Users\MyFolder");
                            string copyFromF = Console.ReadLine();
                            Console.WriteLine(@"Укажите путь куда копируем файл. Например C:\MyFolder\MySecondFolder");
                            string copyToF = Console.ReadLine();
                            Console.WriteLine(@"Введите название файла, который копируем. Например AnyText.txt");
                            string fileName = Console.ReadLine();
                            directoryOperations.CopyFD(copyFromF, copyToF, fileName);

                            Console.Clear();

                            break;

                        case "infoF":

                            UISettings();
                            Console.WriteLine(@"Укажите путь к файлу. Например C:\Users\MyFile.txt");
                            string pathSize = Console.ReadLine();
                            fileOperations.InformationFD(pathSize);

                            Console.Clear();

                            break;

                        case "infoD":

                            UISettings();
                            Console.WriteLine(@"Укажите путь к папке. Например C:\Users\MyFolder");
                            string pathFolder = Console.ReadLine();
                            directoryOperations.InformationFD(pathFolder);

                            break;

                        case "showInfo":

                            UISettings();
                            Console.WriteLine(@"Укажите путь к папке или диску. Например C:\Users\MyFolder");
                            string info = Console.ReadLine();
                            searchOperations.ShowDirsAndFiles(info);
                            break;

                    }

                }
                catch (Exception e)
                {
                    UISettings();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Что - то пошло не так. Повторно введите ключевое слово");
                    Console.ResetColor();

                }
            }
        }

        public static void UIWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать в программу FileManager 2.0!\nПрограмма разработана для проведения операций с фаловой системой" +
                "\nЭто консольное приложение, в котором команды выполняются посредством ввода ключевых слов");
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку, чтобы узнать список команд...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        public static void UICommandList()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Напечатайте 'createF' для создания файла или 'createD' для создания папки");
            Console.WriteLine("Напечатайте 'infoDisc' для инфомации о дисках");
            Console.WriteLine("Напечатайте 'deleteF' для удаления файла или 'deleteD' для удаления папки");
            Console.WriteLine("Напечатайте 'moveF' для переноса файла или 'moveD' для переноса папки");
            Console.WriteLine("Напечатайте 'copyF' для копирования файла или 'copyD' для копирования папки");
            Console.WriteLine("Напечатайте 'infoF' для вывода инфо о файле или 'infoD' для вывода инфо для папки");
            Console.WriteLine("Напечатайте 'showInfo' для просмотра фалов и папок по указанному пути");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void UISettings()
        {

            Console.Clear();
            UI.UICommandList();
            Console.SetCursorPosition(0, 12);
        }

    }
    
}

