using System;
using System.Collections.Generic;

namespace AlgorithmQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) In a console application, ask the user to enter a positive number(n).Then ask the user to enter n positive numbers.
                  Print the even numbers of the numbers entered by the user to the console.*/

             Console.WriteLine("Hello! Please enter a positive number :");
             List<float> list = new List<float>();
             float number;
             bool Check = float.TryParse(Console.ReadLine(), out number);
             while (Check == false || number < 0)
             {
                 Console.WriteLine("You entered an incorrect value. Please enter a positive number :");
                 Check = float.TryParse(Console.ReadLine(), out number);
             }
             while (Check == true || number >= 0)
             {
                 if (number % 2 == 0)
                 {
                     list.Add(number);
                     Console.WriteLine("If you want to continue enter a positive number, if not you can enter a letter :");
                     Check = float.TryParse(Console.ReadLine(), out number);
                     if (Check == false)
                     {
                         Console.WriteLine("Process terminated.");
                         foreach (var item in list)
                         {
                             Console.WriteLine(item);
                         }
                         break;
                     }
                 }
                 else
                 {
                     Console.WriteLine("If you want to continue enter a positive number, if not you can enter a letter :");
                     Check = float.TryParse(Console.ReadLine(), out number);
                     if (Check == false)
                     {
                         Console.WriteLine("Process terminated.");
                         foreach (var item in list)
                         {
                             Console.WriteLine(item);
                         }
                         break;
                     }
                 }

             }

            /* 2) Ask the user to enter two positive numbers(n,m).Then ask the user to enter n positive numbers.
               From the numbers entered by User, print the numbers divisible by m or equal.*/

            Console.WriteLine("Please enter two positive numbers :");

            float n, m, number;
            bool Check = float.TryParse(Console.ReadLine(), out n);
            bool Check2 = float.TryParse(Console.ReadLine(), out m);
            List<float> list = new List<float>();

            while (Check == false || Check2 == false || n < 0 || m < 0)
            {
                Console.WriteLine("You entered an incorrect value. Please enter a positive number :");
                Check = float.TryParse(Console.ReadLine(), out n);
                Check2 = float.TryParse(Console.ReadLine(), out m);
            }
            Console.WriteLine("Please enter a positive number :");
            bool check3 = float.TryParse(Console.ReadLine(), out number);
            while (check3 == false || number < 0)
            {
                Console.WriteLine("You entered an incorrect value. Please enter a positive number :");
                check3 = float.TryParse(Console.ReadLine(), out number);
            }
            while (check3 == true && number >= 0)
            {
                if (number == m || number % m == 0)
                {
                    list.Add(number);
                    Console.WriteLine("If you want to continue enter a positive number, if not you can enter a letter :");
                    check3 = float.TryParse(Console.ReadLine(), out number);
                    if (check3 == false)
                    {
                        Console.WriteLine("Process terminated.");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("If you want to continue enter a positive number, if not you can enter a letter :");
                    check3 = float.TryParse(Console.ReadLine(), out number);
                    if (check3 == false)
                    {
                        Console.WriteLine("Process terminated.");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
                }
            }

            /* 3) Ask the user to enter a positive number(n). Then ask the user to enter n words.
                  Print the entered words from top to bottom.*/

            Console.WriteLine("Please enter a positive number :");
            int n;
            bool Check = int.TryParse(Console.ReadLine(), out n);
            String[] arr = new String[n];
            while (Check == false || n < 0)
            {
                Console.WriteLine("You entered an incorrect value. Please enter a positive number :");
                Check = int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine(n + " words enter please :");

            for (int i = 0; i < n; i++)
            {
                String words = Convert.ToString(Console.ReadLine());
                arr[i] = words;
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            /*4) Ask the user enter a sentence. Then print the total number of letters and words in sentence.*/

            Console.WriteLine("Please enter a sentence :");
            String sentence = Convert.ToString(Console.ReadLine());
            String[] words = sentence.Split(' ');
            String sentence2 = sentence.Replace(" ","");
            Console.WriteLine("Number of words : " + words.Length);
            Console.WriteLine("Number of letters : " + sentence2.Length);
            
            

            

        }

    }
}


