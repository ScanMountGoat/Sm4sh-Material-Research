using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace AnalyzeMaterialXML
{
    class Program
    {
        public static List<MaterialData> materials = new List<MaterialData>();

        private static void PrintFlags(uint flags)
        {
            string flagsHex = flags.ToString("X");
            for (int i = 0; i < flagsHex.Length; i++)
            {
                Console.Write(flagsHex[i]);
                if ((i + 1) % 2 == 0)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string path = "";
            string materialProperty = "";

            if (args.Length > 0)
            {
                path = args[0];
            }

            if (args.Length > 1)
            {
                materialProperty = args[1];
            }

            if (Directory.Exists(path))
            {
                foreach (string file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    if (file.EndsWith(".xml"))
                    {
                        MaterialXML.MaterialDataFromXML(file);
                    }
                }
            }

            uint necessaryFlags = 0xFFFFFFFF;
            foreach (MaterialData material in materials)
            {
                if (material.materialProperties.ContainsKey(materialProperty))
                {
                    //PrintFlags(material.flags);
                    necessaryFlags = necessaryFlags & material.flags;
                    PrintFlags(necessaryFlags);
                }

            }

            Console.WriteLine();
            Console.WriteLine(materialProperty + " flags:");
            PrintFlags(necessaryFlags);
        }
    }
}
