using System;

namespace myjinxin
{
    public class Kata
    {
        public int rectangleRotation(int a, int b)
        {
            if (a < 2 || a > 10000)
            {
                throw new ArgumentException($"The {nameof(a)} must be greater than 2 and less than 10000.");
            }

            if (a % 2 != 0)
            {
                throw new ArgumentException($"The {a} must be an even number.");
            }

            if (b < 2 || b > 10000)
            {
                throw new ArgumentException($"The {nameof(b)} must be greater than 2 and less than 10000.");
            }

            if (b % 2 != 0)
            {
                throw new ArgumentException($"The {b} must be an even number.");
            }

            //----------------------
            //int numberOfColumns = (int) Math.Floor((double) a / Math.Sqrt(2)) + 1;
            // ---------------------
            //int numberOfColumns = (int)(a / Math.Sqrt(2)) + 1;
            //--------------------------

            int numberOfColumns = (int)(a / (Math.Sqrt(2) / 2));

            //int columnHeight = (int)Math.Floor((double)b / Math.Sqrt(2)) + 1;

            int columnHeight = (int)(b / Math.Sqrt(2));

            int points = 0;

            Console.WriteLine($"ORIGINAL Number of columns: {numberOfColumns}");
            numberOfColumns++;
            Console.WriteLine($"number of columns: {numberOfColumns}");

            Console.WriteLine($"ORIGINAL Column height: {columnHeight}");
            columnHeight++;
            Console.WriteLine($"column height: {columnHeight}");

            for (int i = 0; i < numberOfColumns; i++)
            {
                if (i % 2 == 0)
                {
                    points += columnHeight;
                }
                else
                {
                    points += columnHeight - 1;
                }
            }

            //if (numberOfColumns % 2 != 0)
            //{
            //    points--;
            //}

            return points;
        }
    }
}
