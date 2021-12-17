using System;
using System.IO;
using System.Text;

namespace pract10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Temp";
                string s1, s2;
                StringBuilder s3 = new StringBuilder();

                string spath1 = @"\К1";
                string spath2 = @"\К2";
                string spathall = @"\ALL";

                Console.WriteLine("\tВ папке С:\\Тemp создаются папки К1 и К2.");

                DirectoryInfo dirInfo;
                dirInfo = Directory.CreateDirectory(path + spath1);
                dirInfo = Directory.CreateDirectory(path + spath2);

                Console.WriteLine("\tВ папке К1 сщздаются 2 файла:\n");
                Console.Write("Введите текст для t1.txt: ");
                s1 = Console.ReadLine();
                Console.Write("Введите текст для t2.txt: ");
                s2 = Console.ReadLine();

                File.WriteAllText(path + spath1 + $"\\t1.txt", s1);
                File.WriteAllText(path + spath1 + $"\\t2.txt", s2);

                string[] bufs1 = File.ReadAllLines(path + spath1 + $"\\t1.txt");
                string[] bufs2 = File.ReadAllLines(path + spath1 + $"\\t2.txt");
                for (int i = 0; i < bufs1.Length; i++)
                {
                    s3.Append(bufs1[i]);
                }
                s3.Append("\n");
                for (int i = 0; i < bufs2.Length; i++)
                {
                    s3.Append(bufs2[i]);
                }
                File.WriteAllText(path + spath2 + $"\\t3.txt", $"{s3}");
                Console.Write("\n\tВ папке К2 создается файл t3.txt:\n");

                Console.WriteLine("\nИнформация о всех созданных файлах:\n");
                dirInfo = Directory.CreateDirectory(path + spath1);
                FileInfo[] files1 = dirInfo.GetFiles();
                for (int i = 0; i < files1.Length; i++)
                {
                    Console.WriteLine($"Имя: {files1[i].Name} \nПуть: {files1[i].FullName} \nРазмер: {files1[i].Length}\n");
                }
                dirInfo = Directory.CreateDirectory(path + spath2);
                FileInfo[] files2 = dirInfo.GetFiles();
                for (int i = 0; i < files2.Length; i++)
                {
                    Console.WriteLine($"Имя: {files2[i].Name} \nПуть: {files2[i].FullName} \nРазмер: {files2[i].Length}\n");
                }

                File.Move(path + spath1 + $"\\t2.txt", path + spath2 + $"\\t2.txt");
                File.Copy(path + spath1 + $"\\t1.txt", path + spath2 + $"\\t1.txt");

                Console.WriteLine("\n\tПапка К2 переименовывается в ALL\n\tПапка К1 удаляется\n");
                Directory.Move(path + spath2, path + spathall);
                Directory.Delete(path + spath1, true);

                Console.WriteLine("Информация о файлах папка ALL:\n");
                dirInfo = Directory.CreateDirectory(path + spathall);
                FileInfo[] filesALL = dirInfo.GetFiles();
                for (int i = 0; i < filesALL.Length; i++)
                {
                    Console.WriteLine($"Имя: {filesALL[i].Name} \nПуть: {filesALL[i].FullName} \nРазмер: {filesALL[i].Length}\n");
                }
            }
            catch
            {
                Console.WriteLine("Что-то не так!\n");
            }
        }
    }
}
