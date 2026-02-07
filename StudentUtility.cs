using System;
using System.Collections.Generic;

public class Stud
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var entry in Programer.studentDetails)
        {
            Stud student = entry.Value;

            if (student.Id == id)
            {
                result.Add(student.Id, student.Name + "_" + student.Course);
                return result;
            }
        }

        return result; 
    }

    public Dictionary<string, Stud> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Stud> result = new Dictionary<string, Stud>();

        foreach (var entry in Programer.studentDetails)
        {
            Stud student = entry.Value;

            if (student.Id == id)
            {
                student.Marks = marks;
                result.Add(student.Id, student);
                return result;
            }
        }

        return result; 
    }
}


public class Programer
{
    public static Dictionary<int, Stud> studentDetails =
        new Dictionary<int, Stud>();

    public static void main(string[] args)
    {
        studentDetails.Add(1, new Stud
        {
            Id = "ST01",
            Name = "Alice",
            Course = "DataScience",
            Marks = 85
        });

        studentDetails.Add(2, new Stud
        {
            Id = "ST02",
            Name = "Bob",
            Course = "AI",
            Marks = 78
        });

        StudentUtility utility = new StudentUtility();

        while (true)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                var result = utility.GetStudentDetails(id);

                if (result.Count == 0)
                {
                    Console.WriteLine("Student id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + "   " + item.Value);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the marks");
                int marks = int.Parse(Console.ReadLine());

                var result = utility.UpdateStudentMarks(id, marks);

                if (result.Count == 0)
                {
                    Console.WriteLine("Student id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(
                            item.Key + " updated marks: " + item.Value.Marks
                        );
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}
