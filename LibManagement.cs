using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    class Program
    {
        static List<dynamic> books = new List<dynamic>();
        static int bookIdCounter = 1;

        static void main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== BOOK LIBRARY MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AdminMenu();
                        break;
                    case 2:
                        UserMenu();
                        break;
                    case 3:
                        Console.WriteLine("Exiting application...");
                        return;
                }
            }
        }

        static void AdminMenu()
        {
            Console.WriteLine("\n--- ADMIN MENU ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    UpdateBook();
                    break;
                case 3:
                    DeleteBook();
                    break;
                case 4:
                    ViewAllBooks();
                    break;
            }
        }

        static void UserMenu()
        {
            Console.WriteLine("\n--- USER MENU ---");
            Console.WriteLine("1. Browse Books");
            Console.WriteLine("2. Search Book by Name");
            Console.WriteLine("3. Search Book by Publisher");
            Console.WriteLine("4. View Highest Price Book");
            Console.WriteLine("5. View Lowest Price Book");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewAllBooks();
                    break;
                case 2:
                    SearchByName();
                    break;
                case 3:
                    SearchByPublisher();
                    break;
                case 4:
                    HighestPriceBook();
                    break;
                case 5:
                    LowestPriceBook();
                    break;
            }
        }


        static void AddBook()
        {
            dynamic book = new System.Dynamic.ExpandoObject();

            book.Id = bookIdCounter++;
            Console.Write("Enter Book Name: ");
            book.Name = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter Publisher Name: ");
            book.Publisher = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            book.Price = double.Parse(Console.ReadLine());

            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        static void UpdateBook()
        {
            Console.Write("Enter Book ID to update: ");
            int id = int.Parse(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                Console.Write("Enter New Book Name: ");
                book.Name = Console.ReadLine();

                Console.Write("Enter New Author Name: ");
                book.Author = Console.ReadLine();

                Console.Write("Enter New Publisher Name: ");
                book.Publisher = Console.ReadLine();

                Console.Write("Enter New Price: ");
                book.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void DeleteBook()
        {
            Console.Write("Enter Book ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void ViewAllBooks()
        {
            Console.WriteLine("\n--- BOOK LIST ---");
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                DisplayBook(book);
            }
        }


        static void SearchByName()
        {
            Console.Write("Enter Book Name to search: ");
            string name = Console.ReadLine();

            var result = books.Where(b => b.Name.ToString().Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count == 0)
                Console.WriteLine("No matching books found.");
            else
                result.ForEach(DisplayBook);
        }

        static void SearchByPublisher()
        {
            Console.Write("Enter Publisher Name: ");
            string publisher = Console.ReadLine();

            var result = books.Where(b => b.Publisher.ToString().Contains(publisher, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count == 0)
                Console.WriteLine("No matching books found.");
            else
                result.ForEach(DisplayBook);
        }

        static void HighestPriceBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            var maxBook = books.OrderByDescending(b => b.Price).First();
            Console.WriteLine("\n--- HIGHEST PRICE BOOK ---");
            DisplayBook(maxBook);
        }

        static void LowestPriceBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            var minBook = books.OrderBy(b => b.Price).First();
            Console.WriteLine("\n--- LOWEST PRICE BOOK ---");
            DisplayBook(minBook);
        }


        static void DisplayBook(dynamic book)
        {
            Console.WriteLine($"ID: {book.Id}, Name: {book.Name}, Author: {book.Author}, " +
                              $"Publisher: {book.Publisher}, Price: {book.Price}");
        }
    }
}
