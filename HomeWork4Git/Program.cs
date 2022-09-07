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
            char[] arrayExceptions = { 'a', 'e', 'i', 'd', 'h', 'j' };
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 27);
                if (arr[i] % 2 == 0)
                {
                    size++;
                }
            }

            int[] arrayEvenNumbers = new int[size];
            int[] arrayOddNumbers = new int[n - size];
            char[] arrayEvenLetters = new char[size];
            char[] arrayOddLetters = new char[n - size];
            char[] arrayEvenUpLetters = new char[size];
            char[] arrayOddUpLetters = new char[n - size];
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrayEvenNumbers[index1] = arr[i];
                    index1++;
                }
                else
                {
                    arrayOddNumbers[index2] = arr[i];
                    index2++;
                }
            }

            Console.WriteLine(string.Join(" ", arrayEvenNumbers));
            Console.WriteLine(string.Join(" ", arrayOddNumbers));
            for (int i = 0; i < arrayEvenLetters.Length; i++)
            {
                arrayEvenLetters[i] = Convert.ToChar(alphabet.Substring(arrayEvenNumbers[i] - 1, 1));
            }

            for (int i = 0; i < arrayOddLetters.Length; i++)
            {
                arrayOddLetters[i] = Convert.ToChar(alphabet.Substring(arrayOddNumbers[i] - 1, 1));
            }

            for (int i =0; i < arrayEvenLetters.Length; i++)
            {
                char letter = arrayEvenLetters[i];
                for (int j=0; j < arrayExceptions.Length; j++)
                {
                    arrayEvenUpLetters[i] = letter;
                    if (letter == arrayExceptions[j])
                    {
                        arrayEvenUpLetters[i] = Char.ToUpper(letter);
                        break;
                    }
                }
            }

            for (int i = 0; i < arrayOddLetters.Length; i++)
            {
                char letter = arrayOddLetters[i];
                for (int j = 0; j < arrayExceptions.Length; j++)
                {
                    arrayOddUpLetters[i] = letter;
                    if (letter == arrayExceptions[j])
                    {
                        arrayOddUpLetters[i] = Char.ToUpper(letter);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arrayEvenLetters));
            Console.WriteLine(string.Join(" ", arrayEvenUpLetters));
            Console.WriteLine(string.Join(" ", arrayOddLetters));
            Console.WriteLine(string.Join(" ", arrayOddUpLetters));
        }
    }
}