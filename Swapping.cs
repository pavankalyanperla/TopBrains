using System;

class Swapping
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number :");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Before Swaping numbers:");
        Console.WriteLine($"num1 is {num1} and num2 is {num2}");

        RefSwap(ref num1, ref num2);

        Console.WriteLine("After Swapping using ref:");
        Console.WriteLine($"num1 = {num1}, num2 = {num2}");
        Console.WriteLine();

        int a, b;

        OutSwap(num1, num2, out a, out b);

        Console.WriteLine("After Swapping numbers using out:");
        Console.WriteLine($"a is {a} and b is {b}"); 
    }

    static void RefSwap(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;

    }
    static void OutSwap(int x, int y, out int a, out int b)
    {
        a = x;
        b = y;
    }
}