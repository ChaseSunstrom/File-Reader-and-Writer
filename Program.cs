using System;

namespace FileReaderAndWriter
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            string fileName;
            string content;
            
            while (!exit)
            {
                Console.WriteLine("Enter a number:\n1. Read from file\n2. Write to file\n3. Create a file\n4. Delete a file\n5. Create and Write to file\n6. Read and write to file\n7. Exit");
                string answer = Console.ReadLine();

                try
                {
                    switch (answer)
                    {
                        case "1":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            FileOptins.ReadFile(fileName);
                            break;
                        case "2":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            Console.WriteLine("Enter the file contents:");
                            content = Console.ReadLine();
                            FileOptins.WriteFile(fileName, content);
                            break;
                        case "3":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            FileOptins.CreateFile(fileName);
                            break;
                        case "4":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            FileOptins.DeleteFile(fileName);
                            break;
                        case "5":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            Console.WriteLine("Enter the file contents:");
                            content = Console.ReadLine();
                            FileOptins.CreateAndWriteFile(fileName, content);
                            break;
                        case "6":
                            Console.WriteLine("Enter the file name:");
                            fileName = Console.ReadLine();
                            Console.WriteLine("Enter the file contents:");
                            content = Console.ReadLine();
                            FileOptins.ReadAndWriteFile(fileName, content);
                            break;
                        case "7":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}