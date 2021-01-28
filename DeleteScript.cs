using System;
using System.IO;

namespace GachiClub
{
    class DeleteScript
    {
        static void Main(string[] args)
        {
            DeleteScript.delete();
        }

        static void delete()
        {
            string[] dirs = Directory.GetFiles(@"C:\ГЛАВНОЕ\MyPhotoStudio\арты и прочие"); // получаем все файлы в папке по указонному пути

            int lenght = dirs.Length;
            Console.WriteLine("Общее количество файлов - {0}.", lenght);

            Console.WriteLine("Хотите продолжить? Введите ДА или НЕТ.");
            string agree = Console.ReadLine();
            agree = agree.ToLower();

            if (agree == "да" || agree == "y" || agree == "yes" || agree == "д")
            {

                foreach (string dir in dirs) // перебираем все файлы
                {

                    if (!File.Exists(dir))
                    {
                        //File.Create(path);
                    }

                    DateTime fileEditDate = File.GetLastWriteTime(dir); // получаем время изменения файла
                    var lastMonth = DateTime.Now.AddMonths(-1); // -1 минусует -1 месяц с текущей даты, т.е. получаем прошлый месяц.

                    /*
                     * string file = Path.GetFileName(dir); 
                     * string newPath = Path.Combine(@"C:\ГЛАВНОЕ\MyPhotoStudio\арты и прочие", file); //путь из которого берем файлы
                     * string newPath1 = Path.Combine(@"C:\ГЛАВНОЕ\MyPhotoStudio\арты и прочие\картинки на фон и т.д", file); // куда отправляем файлы
                     * 
                     * С помощью этого скрипта можно переместить файлы с указанного каталога в указанный каталог, снизу в условии, закоментирован сам метод.
                     */

                    if (lastMonth > fileEditDate)
                    {

                        File.Delete(dir);
                        // File.Move(newPath, newPath1); - скрипт который перемещает файлы с newPath в newPath1 
                        Console.WriteLine("Все файлы в каталоге были успешно удалены!!");

                    }
                    else
                    {

                        Console.WriteLine("Старых файлов не найдено!");

                    }

                }

            }
            else if (agree == "нет" || agree == "no" || agree == "n" || agree == "н")
            {

                Console.WriteLine("Вы завершили работу!");

            }
            else
            {

                Console.WriteLine("Неверная команда!");

            }

            Console.ReadKey();
        }

    }
}





