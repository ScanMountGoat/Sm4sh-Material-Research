using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FindString
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            string searchString = "";
            string extension = "";

            if (args.Length >= 3)
            {
                path = args[0];
                searchString = args[1];
                extension = args[2];
            }

            PrintFilesContainingString(path, searchString, extension);
        }

        private static void PrintFilesContainingString(string path, string searchString, string extension)
        {
            bool foundString = false;

            if (Directory.Exists(path) && searchString != "")
            {
                foreach (string file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    if (file.EndsWith(extension))
                    {
                        foreach (string line in File.ReadLines(file))
                        {
                            if (line.Contains(searchString))
                            {
                                // remove path from output
                                string output = file.Remove(0, path.Length + 1);
                                Console.WriteLine(output);
                                foundString = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (!foundString)
            {
                Console.WriteLine("Did not find any instances of " + searchString + ".");
            }
        }
    }
}
