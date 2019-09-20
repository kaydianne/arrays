using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < 25; i++)
                {
                    array[i] = 0;
                    Console.Write("Element value = " + i);
                    Console.WriteLine("");

                }

                Console.WriteLine("");
                Console.Write("Now enter a number between 1 and 10: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if ((number >=1) && (number <=10))
                {
                    int[] array2 = new int[number];

                    int pop_array = 0;
                    
                    for (int i = 0; i < number; i++)
                    {
                        array2[i] = pop_array;
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine(number + " elements shoud be populated in the array.");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 10.");
                }
            }
            catch
            {
                Console.WriteLine("There was an error. Please try again.");
            }
        }
    }
}
