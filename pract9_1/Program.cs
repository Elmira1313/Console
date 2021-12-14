using System;
using System.Collections.Generic;
using System.IO;

namespace pract9_1
{
	class Program
	{
		static void zadanie1()
		{
			int a;
			Console.Write("I. Работа с двоичными файлами: \nДана последовательность из n целых чисел. Создать файл и записать \nв него числа последовательности, не кратные заданному числу. \nВывести содержимое файла на экран.\n\n");
			Console.Write("Введите количество чисел в последовательности: ");
			int n = Int32.Parse(Console.ReadLine());
			Console.Write("Заданное число: ");
			int c = Int32.Parse(Console.ReadLine());
			FileStream f = new FileStream("z1.bin", FileMode.Open);
			BinaryWriter fOut = new BinaryWriter(f);
			Random rnd = new Random();
			for (int i = 1; i <= n; i++)
			{
				a = rnd.Next(-100, 100); 
				if (a % c != 0)
				{
					fOut.Write(a);
				}
			}
			fOut.Close();
			f = new FileStream("z1.bin", FileMode.Open);
			BinaryReader fIn = new BinaryReader(f);
			long m = f.Length;
			Console.WriteLine();
			for (long i = 0; i < m; i += 4)
			{
				f.Seek(i, SeekOrigin.Begin);
				a = fIn.ReadInt32();
				Console.Write($"{a} ");
			}
			Console.WriteLine();
			fIn.Close();
			f.Close();

		}

		static void zadanie2()
		{
			string z2path = Environment.CurrentDirectory + @"\z2.txt";
			Console.Write("II. Работа с текстовым (символьным) файлом: \nДан текстовый файл. Напечатать \nпервый символ каждой строки.\n\n");
			Console.WriteLine("\tФайл z2.txt\n");
			string[] allstr = File.ReadAllLines(z2path);
			for (int i = 0; i < allstr.Length; i++)
			{
				char[] chText = allstr[i].ToCharArray();
				Console.WriteLine($"{i + 1}: {chText[0]}");
			}
		}
		static void Main(string[] args)
		{
			int n = 10, o = 1;
			Console.WriteLine("\t~Всего 2 задания~\n0-выход\n");
			while (n != 0)
			{
				try
				{
					Console.Write("Ведите номер задания: ");
					n = int.Parse(Console.ReadLine());
					Console.WriteLine();
					switch (n)
					{
						case 0: Console.WriteLine("\t~Выход~"); break;
						case 1: zadanie1(); Console.WriteLine(""); break;
						case 2: zadanie2(); Console.WriteLine(""); break;
						default: Console.WriteLine("\tВы ошиблись номером\n"); break;
					}
				}
				catch (Exception)
				{
					Console.WriteLine($"!Что-то введено не так!\nЕще раз!\n\n");
				}

			}
		}
	}
}
