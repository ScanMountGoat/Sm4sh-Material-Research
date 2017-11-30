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
        public static List<Material> materials = new List<Material>();
        public static List<string> materialProperties = new List<string>();
        public static List<int> srcFactors = new List<int>();
        public static List<int> dstFactors = new List<int>();
        public static List<uint> flagsValues = new List<uint>();

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
            int occurrences = 0;
            foreach (Material material in materials)
            {
                bool containsSearchProperty = material.materialProperties.ContainsKey(materialProperty);
                containsSearchProperty = material.expectedTextureCount != material.textureCount;
                containsSearchProperty = containsSearchProperty && !((material.getFlags() & 0xF0000000) == 0xB0000000);
                containsSearchProperty = true;

                if (containsSearchProperty)
                {
                    //PrintFlags(material.getFlags());
                    //PrintFlags(necessaryFlags);

                    necessaryFlags = necessaryFlags & material.getFlags();
                    //PrintMaterialPropertyValues(materialProperty, material);
                    //PrintTextureCount(material);
                    //Console.WriteLine("Expected " + material.expectedTextureCount + " texture(s) but found " + material.textureCount);

                    //Console.WriteLine("srcFactor: " + material.srcFactor);
                    //Console.WriteLine("dstFactor: " + material.dstFactor);
                    //PrintFileName(path, material);
                    //Console.WriteLine();

                    occurrences += 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine(materialProperty + " flags:");
            PrintFlags(necessaryFlags);

            /*Console.WriteLine();
            Console.WriteLine("Maximum Values");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", param1Max, param2Max, param3Max, param4Max);*/
            flagsValues.Sort();
            foreach (uint flag in flagsValues)
                Console.WriteLine(flag.ToString("X"));
        }

        private static void PrintTextureCount(Material material)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Expected {0} textures but found {1}",
                material.expectedTextureCount, material.textureCount));
        }

        private static void PrintFileName(string path, Material material)
        {
            string newFileName = material.fileName.Replace(path, "");
            Console.WriteLine(newFileName);
        }

        private static void PrintMaterialPropertyValues(string materialProperty, Material material)
        {
            if (material.materialProperties.ContainsKey(materialProperty))
            {
                float[] values = material.materialProperties[materialProperty];

                param1Max = Math.Max(param1Max, values[0]);
                param2Max = Math.Max(param2Max, values[1]);
                param3Max = Math.Max(param3Max, values[2]);
                param4Max = Math.Max(param4Max, values[3]);

                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", values[0], values[1], values[2], values[3]);
            }
        }
    }
}
