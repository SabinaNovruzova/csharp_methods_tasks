using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelLetter(text));
        }
                static int VowelLetter(string text)
                {
            int count = 0;
                    foreach (char letter in text.ToLower())
                    {
                        if (letter == 'a' || letter == 'o' || letter == 'e' || letter=='u' || letter=='i')
                        {
                    count++;
                        }
                    }
            return count;
        }
            }
        }
    