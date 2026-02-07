using System;

public class TimeConversion
{
    public string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return minutes + ":" + seconds.ToString("D2");
    }
    static void Main()
    {
        TimeConversion timeConversion = new TimeConversion();

        Console.WriteLine("Enter the number of seconds you want to convert: ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine($"format time is {timeConversion.FormatTime(seconds)}");
    }
}
