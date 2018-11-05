using System;
using System.IO;

namespace lgPOICreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = ConsoleCommands.AskForDirectory("Enter directory to folder that contain files: ");
            string[] files = ConsoleCommands.CheckAmountOfFiles(directory);
            string outputDirectory = ConsoleCommands.AskForFileName();
            Console.WriteLine("Enter POIs planet (Earth, Mars, Moon (MAKE SURE PLANET NAME IS TYPED CORRECTILY)): ");
            string planet = Console.ReadLine();
            KMLProcesser.ProcessFiles(files, outputDirectory, planet);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
