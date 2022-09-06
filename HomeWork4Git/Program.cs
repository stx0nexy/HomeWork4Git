using System;

namespace HomeWork4Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array dimension:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int size = 0;
            int index1 = 0;
            int index2 = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string exception = "a e i d h j";
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 27);
                if (arr[i] % 2 == 0)
                {
                    size++;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
            int[] mas1 = new int[size];
            int[] mas2 = new int[n - size];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    mas1[index1] = arr[i];
                    index1++;
                }
                else
                {
                    mas2[index2] = arr[i];
                    index2++;
                }
            }

            string a = string.Empty;
            string b = string.Empty;
            Console.WriteLine(string.Join(" ", mas1));
            Console.WriteLine(string.Join(" ", mas2));
            for (int i = 0; i < size; i++)
            {
                a += alphabet.Substring(mas1[i] - 1, 1) + ' ';
            }

            for (int i = 0; i < n - size; i++)
            {
                b += alphabet.Substring(mas2[i] - 1, 1) + ' ';
            }

            Console.WriteLine(a);
            string[] mass1Str = a.Trim().Split(' ');
            string[] mass2Str = b.Trim().Split(' ');
            string[] mass3 = exception.Split(' ');
            string output1 = string.Empty;
            for (var i = 0; i < mass1Str.Length; i++)
            {
                string word = mass1Str[i];
                if (exception.Contains(word))
                {
                    output1 += word.ToUpper() + " ";
                    continue;
                }

                output1 += word + " ";
            }

            Console.WriteLine(output1);
            string output2 = string.Empty;
            for (var i = 0; i < mass2Str.Length; i++)
            {
                string word = mass2Str[i];
                if (exception.Contains(word))
                {
                    output2 += word.ToUpper() + " ";
                    continue;
                }

                output2 += word + " ";
            }

            Console.WriteLine(output2);
        }
    }
}