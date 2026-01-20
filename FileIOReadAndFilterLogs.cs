using System;
using System.IO;

public class Program
{
    public static void main(string[] args)
    {
        string inputFile = "log.txt";

        string outputFile = "error.txt";

        try
        {
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("log.txt file not found.");
                return;
            }

            string[] logLines = File.ReadAllLines(inputFile);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string line in logLines)
                {
                    if (line.Contains("ERROR"))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("ERROR logs extracted successfully to error.txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/O error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
