using System;

class Conversion
{
    public double ConversionofFoottoCm(int foot)
    {
        double centimeter = foot * 30.48;

        return Math.Round(centimeter, 2, MidpointRounding.AwayFromZero);
    }

    static void Main()
    {
        Conversion con = new Conversion();
        Console.WriteLine("Enter the value in Foot:");
        int Foot = int.Parse(Console.ReadLine());
        Console.WriteLine(con.ConversionofFoottoCm(Foot));

    }
}