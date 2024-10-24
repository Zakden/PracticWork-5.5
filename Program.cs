using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, которое нужно разбить на отдельные слова: ");
            string text = Console.ReadLine();
            PrintWords(SplitText(text));
            Console.ReadKey();
            Console.WriteLine("Теперь перевернем слова из предложения в обратной последовательности: ");
            Console.Write(Reverse(text));
            Console.ReadKey();
        }

        static string[] SplitText(string text) 
        {
            char[] separators = new char[] { ' ', '.', ',', ';', ':', '!', '?' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        static void PrintWords(string[] words)
        {
            foreach (string word in words) 
            {
                Console.WriteLine(word);
            }
        }

        static string Reverse(string text) 
        {
            string[] words = SplitText(text);
            string ResultString = string.Empty;

            for(int i = words.Length; --i >= 0;) 
            {
                ResultString += words[i] + " ";
            }

            return ResultString;
        }
    }
}
