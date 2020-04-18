// Generates an array of random ints, then sorts values ascending

using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int arrSize = 10;
            int[] arr = new int[arrSize];
            //bool swaps = true;

            Console.WriteLine("Initial Array:");

            // Populate and print initial array 
            for (int a = 0; a < arrSize; a++)
            {
                arr[a] = rand.Next(100);
                Console.Write(" | " + arr[a]);
            }
            Console.WriteLine(" |\n");

            // Continue loop until no swaps occur
            for (int d = 0; d < arr.Length - 1; d++)
            {
                // Loop though array once
                for (int b = 0; b < arr.Length - 1; b++)
                {

                    // If out of order, swap values
                    if (arr[b] > arr[b + 1])
                    {
                        int buffer = arr[b];
                        arr[b] = arr[b + 1];
                        arr[b + 1] = buffer;
                    }
                }

                // Write resulting array
                for (int c = 0; c < arr.Length; c++)
                {
                    Console.Write(" | " + arr[c]);
                }
                Console.WriteLine(" |");
                System.Threading.Thread.Sleep(500);
            } 



            // Prevent Console from closing
            Console.ReadLine(); 
        }
    }
}
