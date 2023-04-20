using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Exercises
    {
        public static void ExerciseOne()
        {
            List<string> nameList = new List<string>();
            string input;

            while (true)
            {
                Console.WriteLine("Enter a name (or press enter to exit):");
                input = Console.ReadLine(); 

                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                nameList.Add(input);
            }

            switch (nameList.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post.", nameList.ElementAt(0));
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", nameList.ElementAt(0),
                        nameList.ElementAt(1));
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post.", nameList.ElementAt(0),
                        nameList.ElementAt(1), nameList.Count - 2);
                    break;
            }
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Enter your name: ");
            string input = Console.ReadLine();
            char[] name = input.ToArray();
            char[] reverseName = new char[input.Length];
            string reverseNameString;
            int index = 0;
            
            Console.WriteLine("Reverse name: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseName[index] = name[i];
                index++;
            }

            reverseNameString = new string(reverseName);
            Console.WriteLine(reverseNameString);
        }

        public static void ExerciseThree()
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Write 5 unique numbers: ");
            while (true)
            {
                input = Console.ReadLine();

                if(numbers.Contains(Convert.ToInt32(input)))
                {
                    Console.WriteLine("The number has already been added. Retry:");
                    continue;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }

                if(numbers.Count == 5)
                {
                    break;
                }
            }

            Console.WriteLine("Sorted numbers: ");
            numbers.Sort();
            
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void ExerciseFour()
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Write numbers: ");
            while (true)
            {
                input = Console.ReadLine();
              
                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));             
            }

            Console.WriteLine("Unique numbers: ");
            var unique = numbers.Distinct();

            foreach (int number in unique)
            {
                Console.WriteLine(number);
            }
        }

        public static void ExerciseFive()
        {
            string input;
            List<int> numbers = new List<int>();
            List<int> smallest = new List<int>();
            
            Console.WriteLine("Write a list of comma separated numbers");
            while (true)
            {
                input = Console.ReadLine();

                if(input.Split(',').Length >= 5)
                {
                    foreach (string number in input.Split(','))
                    {
                        numbers.Add(Convert.ToInt32(number));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid List. Re-try.");
                }
            }

            numbers.Sort();
           
            Console.WriteLine("3 smallest numbers:");
            foreach (var number in numbers)
            {
                if (!smallest.Contains(number))
                    smallest.Add(number);

                if (smallest.Count == 3)
                    break;
            }

            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }

        }
    }
}
