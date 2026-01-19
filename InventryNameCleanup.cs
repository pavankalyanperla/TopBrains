using System;
using System.Text;

class Program2
{
   public static void main(string[]args)
   {
      //   Console.WriteLine("Helo babe");
      Console.WriteLine("Enter the Product name: ");

      string ProductName = Console.ReadLine();

      ProductName = ProductName.Trim();

      StringBuilder cleanedProductName = new StringBuilder();

      for(int i =0; i< ProductName.Length; i++)
      {
         if(i == 0 ||ProductName[i] != ProductName[i - 1])
         {
            cleanedProductName.Append(ProductName[i]);
         }
      }

      string[] words = cleanedProductName.ToString()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            // Convert first character to uppercase
            result.Append(char.ToUpper(word[0]));

            // Convert remaining characters to lowercase
            result.Append(word.Substring(1).ToLower());

            // Add space after each word
            result.Append(" ");
        }

        // Final output (trim trailing space)
        Console.WriteLine(result.ToString().Trim());
   } 
}