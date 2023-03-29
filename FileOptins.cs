using System.Net;

namespace FileReaderAndWriter;

public static class FileOptins
{
    public static void ReadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine("Reading...");
            Console.WriteLine(File.ReadAllText(fileName));
        } 
        
        else 
            Console.WriteLine("File does not exist, please try again."); 
    }

    public static void WriteFile(string fileName, string content)
    {
        if (File.Exists(fileName) && new FileInfo(fileName).Length == 0)
        {
            Console.WriteLine("Writing..");
            File.WriteAllText(fileName, content);
        }
        
        else if (File.Exists(fileName) && new FileInfo(fileName).Length != 0)
            Console.WriteLine("File contains data, please delete it first.");
        
        else
            Console.WriteLine("File does not exist, please try again.");
    }

    public static void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine("Deleting...");
            File.Delete(fileName);
        }
        
        else
            Console.WriteLine("File does not exist, please try again.");
    }
    
    public static void CreateFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Creating...");
            File.Create(fileName);
        }

        else
            Console.WriteLine("File already exists, please try again.");
    }

    public static void CreateAndWriteFile(string fileName, string content)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Creating...");
            File.Create(fileName);
            Console.WriteLine("Writing...");
            File.WriteAllText(fileName, content);
            Console.WriteLine("Done!");
            Console.WriteLine("New file content: \n" + File.ReadAllText(fileName));
        }
        
        else
            Console.WriteLine("File already exists, please try again.");
    }

    public static void ReadAndWriteFile(string fileName, string content)
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine("Reading...");
            Console.WriteLine(File.ReadAllText(fileName));
            string text = File.ReadAllText(fileName);
            Console.WriteLine("Writing...");
            fileName.Replace(text, content);
            Console.WriteLine("New file content:\n" + File.ReadAllText(fileName));
            Console.WriteLine();
        }
        
        else
            Console.WriteLine("File does not exist, please try again.");
    }
}