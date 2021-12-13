using System;
using System.Text;
using System.Text.RegularExpressions;

namespace pract8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Дана строка, в которой содержится осмысленное текстовое \nсообщение. Слова сообщения разделяются пробелами и знаками \nпрепинания. Удалите из сообщения только те русские слова, \nкоторые начинаются на гласную букву.\n\n");
                Console.Write("Ваша строка: ");
                StringBuilder a = new StringBuilder(Console.ReadLine());
                StringBuilder b = new StringBuilder();
                b.Append(a);
                Regex reg = new Regex(@"(\b[ауоеёиыэюя]|\b[АУОЕЁИЫЭЮЯ])(([а-я])*|([А-Я])*)");
                bool flag = false;

                for (int i = 0; i < a.Length; i++)
                    if (char.IsPunctuation(a[i]))
                    {
                        a.Replace($"{a[i]}", $" {a[i]}");
                        i++;
                    }

                for (int i = 0; i < b.Length;)
                    if (char.IsPunctuation(b[i]))
                    {
                        b.Remove(i, 1);
                    }
                    else ++i;

                string str = b.ToString();
                string[] s = str.Split(' ');

                for (int i = 0; i < s.Length; i++)
                {
                    if (reg.IsMatch(s[i])==true)
                    {
                        flag = true;
                        if (i == 0)
                        {
                            a.Replace($"{s[i]}", "");
                        }
                        else
                        {
                            a.Replace($"{s[i]} ", "");
                        }

                    }
                }
                if (flag == true)
                {
                    for (int i = 0; i < a.Length; i++)
                        if (char.IsPunctuation(a[i]))
                        {
                            a.Remove(i - 1, 1);
                        }
                    Console.WriteLine("\nИзмененная строка: " + a);
                }
                else
                {
                    Console.WriteLine("\nТаких слов нет");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\tЧто-то не так");
            }
        }
    }
}
