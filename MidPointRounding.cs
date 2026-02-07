using System;

class MidPointRounding
{
    public double CalAreaOfCircle(double radius)
    {
        double Area = Math.PI * radius * radius;

        return Math.Round(Area, 2, MidpointRounding.AwayFromZero);;
    }
    public static void Main()
    {
        MidPointRounding areaOfCircle = new MidPointRounding();
        Console.WriteLine("Enter the radius of your choice: ");
        int rad = int.Parse(Console.ReadLine());
        Console.WriteLine(areaOfCircle.CalAreaOfCircle(rad));
    }
}