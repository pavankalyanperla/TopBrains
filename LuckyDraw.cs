using System;

class LuckyDraw
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number that you want to start from:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number that you want to end with:");
        int end = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (!IsPrime(i))
            {
                int sumX = DigitSum(i);
                int sumSquare = DigitSum(i * i);

                if (sumSquare == sumX * sumX)
                {
                    count++;
                }
            }
        }

        Console.WriteLine($"The total lucky numbers between {start} and {end} are {count}.");
    }

    static int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
