using System;
using System.Collections.Generic;

class Bike
{
    public string Model{get; set;}
    public int PricePerDay{get; set;}
    public string Brand{get; set;}
}
class BikeUtility
{
    public SortedDictionary<int, Bike> bikeDetails;

        public BikeUtility(SortedDictionary<int, Bike> bikeDetails)
        {
            this.bikeDetails = bikeDetails;
        }
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = bikeDetails.Count + 1;

        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        bikeDetails.Add(key, bike);
    } 
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> result = new SortedDictionary<string, List<Bike>>();

        foreach (var item in bikeDetails.Values)
        {
            if (!result.ContainsKey(item.Brand))
            {
                result[item.Brand] = new List<Bike>();
            }
            result[item.Brand].Add(item);
        }

        return result; 
    }
}    
    
class Programee
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility(bikeDetails);

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the brand");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int price = int.Parse(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);
                Console.WriteLine();
                Console.WriteLine("Bike details added successfully");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                var grouped = utility.GroupBikesByBrand();
                Console.WriteLine();

                foreach (var brand in grouped)
                {
                    Console.WriteLine(brand.Key);
                    foreach (var bike in brand.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}