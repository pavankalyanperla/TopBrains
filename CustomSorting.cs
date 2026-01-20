using System;
using System.Collections.Generic;
public class Student
{
    public string Name{get; set;}
    public int Age{get; set;}
    public int Marks{get; set;}

}

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x , Student y)
    {
        int markCompare = y.Marks.CompareTo(x.Marks);

        if (markCompare != 0)
            return markCompare;

        return x.Age.CompareTo(y.Age);
    }
}

class Program3
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Console.WriteLine("Enter the number of student that tou want to compare:");
        int NoOfStudents = int.Parse(Console.ReadLine());

        for(int i = 0; i<NoOfStudents; i++)
        {
            Student s = new Student();

            Console.WriteLine("Enter the student Name:");
            s.Name = Console.ReadLine();

            Console.Write("Enter the age of student:");
            s.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total marks of student: ");
            s.Marks = int.Parse(Console.ReadLine());

            students.Add(s);

        }
        students.Sort(new StudentComparer());

        foreach(Student s in students)
        {
            Console.WriteLine($"{s.Name} - Age :{s.Age} Marks:{s.Marks}");
        }
    }
}