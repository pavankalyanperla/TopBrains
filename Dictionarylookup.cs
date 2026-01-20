using System;
using System.Collections.Generic;

class DictionaryLookup
{
    static void Main(string[] args)
    {
        Dictionary<int,int> EmployeeSalary = new Dictionary<int, int>();
        List<int> EmployeeIDs = new List<int>();
        Console.WriteLine("Enter the number that you want to add");
        int NoofEmployees = int.Parse(Console.ReadLine());

        for(int i = 0; i<NoofEmployees; i++)
        {
            Console.WriteLine("Enter the id of Employee");
            int EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the salary of the employee: ");
            int salary = int.Parse(Console.ReadLine());

            EmployeeSalary[EmployeeId] = salary;
            EmployeeIDs.Add(EmployeeId);
        }

        int TotalSalary = 0;

        foreach(int id in EmployeeIDs)
        {
            if (EmployeeSalary.ContainsKey(id))
            {
                TotalSalary += EmployeeSalary[id];
            }
        }

        Console.WriteLine($"toatal Salary : {TotalSalary}");
    }
}