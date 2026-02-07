/*
Display Height
Description
Given a person's height in centimeters, return the height category:
- "Short"  : height < 150
- "Average": 150 <= height < 180
- "Tall"   : height >= 180

Input: heightCm (int)
Output: category (string)

Constraints:
0 <= heightCm <= 300
*/

using System;

class Height
{
    public string DisplayHeightCategory(int height)
    {
        if(height < 150)
        {
            return "Short";
        }
        else if(height > 150 && height < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }

    static void Main()
    {
        Height height = new Height();
        Console.WriteLine("Enter you height in cm:");
        int heightCm = int.Parse(Console.ReadLine());
        Console.WriteLine($"The category that you fall under is {height.DisplayHeightCategory(heightCm)}");

    }
}