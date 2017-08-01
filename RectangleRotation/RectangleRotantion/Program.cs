using System;
using myjinxin;

namespace RectangleRotantion
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();

            int[,] arr = 
            {
                { 6, 4, 23 },
                { 30, 2, 65 },
                { 8, 6, 49 },
                { 16, 20, 333 },
                { 8844, 8228, 72771979 },
                { 9756, 6618, 64563061 },
                { 4348, 9092, 39534995 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int a = arr[i, 0];
                int b = arr[i, 1];
                int expectedResult = arr[i, 2];

                Console.WriteLine($"[{a},{b}] --> {kata.rectangleRotation(a ,b)} --> expected result: {expectedResult}\n");
            }

            Console.WriteLine("\n\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
