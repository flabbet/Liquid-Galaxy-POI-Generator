using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lgPOICreator
{
    public class ConsoleCommands
    {
        public static string AskForDirectory(string directoryQuestion)
        {
            string directory;
            bool directoryExist = false;
            Console.Write(directoryQuestion);
            directory = Console.ReadLine();
            directoryExist = Directory.Exists(directory);

            while (directoryExist == false)
            {
                Console.Write("Wrong directory, try again: ");
                directory = Console.ReadLine();
                directoryExist = Directory.Exists(directory);
            }
            return directory;
        }

        public static string AskForFileName()
        {
            string directory;
            Console.Write(@"Enter output directory and file name (ex. Desktop\myPOIs.txt): ");
            directory = Console.ReadLine();
            return directory;
        }

        public static string[] CheckAmountOfFiles(string path)
        {
            string[] files = Directory.GetFiles(path, "*.KML", SearchOption.AllDirectories);

            Console.Write("{0} .KML files found, is that correct? (y/n): ", files.Length);
            string answer = Console.ReadLine();
            while (answer.ToLower() != "y")
            {
                path = AskForDirectory("Enter directory to folder that contain files: ");
                CheckAmountOfFiles(path);
                return null;
            }
            return files;
        }

    }
}
