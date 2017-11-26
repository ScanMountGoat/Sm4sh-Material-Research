﻿using System;
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

        private static float param1Max = 0;
        private static float param2Max = 0;
        private static float param3Max = 0;
        private static float param4Max = 0;

        private static void PrintFlags(uint flags)
        {
            string flagsHex = flags.ToString("X");
            for (int i = 0; i < flagsHex.Length; i++)
            {
                Console.Write(flagsHex[i]);
                if ((i + 1) % 2 == 0)
                    Console.Write(" ");
            }
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
                bool containsSearchProperty = material.materialProperties.ContainsKey(materialProperty);
                //containsSearchProperty = (material.getFlags() & 0xF0000000) == 0xE0000000;

                if (containsSearchProperty)
                {
                    //PrintFlags(material.getFlags());
                    necessaryFlags = necessaryFlags & material.getFlags();

                    PrintMaterialPropertyValues(materialProperty, material);

                    PrintFileName(path, material);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine(materialProperty + " flags:");
            PrintFlags(necessaryFlags);

            Console.WriteLine();
            Console.WriteLine("Maximum Values");
            Console.Write("{0,10} {1,10} {2,10} {3,10}", param1Max, param2Max, param3Max, param4Max);
        }

        private static void PrintFileName(string path, MaterialData material)
        {
            string newFileName = material.fileName.Replace(path, "");
            Console.Write(" " + newFileName);
        }

        private static void PrintMaterialPropertyValues(string materialProperty, MaterialData material)
        {
            if (material.materialProperties.ContainsKey(materialProperty))
            {
                float[] values = material.materialProperties[materialProperty];

                param1Max = Math.Max(param1Max, values[0]);
                param2Max = Math.Max(param2Max, values[1]);
                param3Max = Math.Max(param3Max, values[2]);
                param4Max = Math.Max(param4Max, values[3]);

                Console.Write("{0,19} {1,10} {2,10} {3,10}", values[0], values[1], values[2], values[3]);
            }
        }
    }
}
