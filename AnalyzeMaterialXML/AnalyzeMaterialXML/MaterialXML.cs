using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace AnalyzeMaterialXML
{
    class MaterialXML
    {
        public static void MaterialDataFromXML(string fileName)
        {
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(fileName);

            XmlNode main = xmlFile.ChildNodes[0];

            foreach (XmlNode meshNode in main.ChildNodes)
            {
                if (meshNode.Name.Equals("mesh"))
                {
                    foreach (XmlNode polyNode in meshNode.ChildNodes)
                    {
                        if (polyNode.Name.Equals("polygon"))
                        {
                            foreach (XmlNode materialNode in polyNode.ChildNodes)
                            {
                                if (materialNode.Name.Equals("material"))
                                {
                                    Material material = new Material();
                                    Program.materials.Add(material);
                                    material.fileName = fileName;

                                    foreach (XmlAttribute attribute in materialNode.Attributes)
                                    {
                                        switch (attribute.Name)
                                        {
                                            case "flags":
                                                uint flags = 0;
                                                uint.TryParse(attribute.Value, NumberStyles.HexNumber, null, out flags);
                                                material.Flags = flags;
                                                break;
                                            case "srcFactor":
                                                int srcFactor = 0;
                                                int.TryParse(attribute.Value, out srcFactor);
                                                material.srcFactor = srcFactor;
                                                break;
                                            case "dstFactor":
                                                int dstFactor = 0;
                                                int.TryParse(attribute.Value, out dstFactor);
                                                material.dstFactor = dstFactor;
                                                break;
                                            case "zbuffoff":
                                                int zBufferOffset = 0;
                                                int.TryParse(attribute.Value, out zBufferOffset);
                                                material.zBufferOffset = zBufferOffset;
                                                break;
                                        }

                                        if (!Program.flagsValues.Contains(material.Flags))
                                            Program.flagsValues.Add(material.Flags);

                                        // list of unique values
                                        if (!Program.srcFactors.Contains(material.srcFactor))
                                            Program.srcFactors.Add(material.srcFactor);
                                        if (!Program.dstFactors.Contains(material.dstFactor))
                                            Program.dstFactors.Add(material.dstFactor);
                                    }

  
                                    foreach (XmlNode materialChildNode in materialNode.ChildNodes)
                                    {
                                        if (materialChildNode.Name.Equals("param"))
                                        {
                                            ReadMaterialParam(material, materialChildNode);
                                        }

                                        if (materialChildNode.Name.Equals("texture"))
                                        {
                                            material.textureCount += 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void ReadMaterialParam(Material material, XmlNode materialChildNode)
        {
            string name = "";
            foreach (XmlAttribute attribute in materialChildNode.Attributes)
            {
                switch (attribute.Name)
                {
                    case "name":
                        name = attribute.Value;
                        break;
                }
            }
            List<float> v = new List<float>();
            float f = 0;

            string[] values = materialChildNode.InnerText.Split(' ');
            foreach (string stringValue in values)
            {
                if (v.Count < 4)
                {
                    if (name == "NU_materialHash")
                    {
                        int hash;
                        if (int.TryParse(stringValue, NumberStyles.HexNumber, null, out hash))
                        {
                            f = BitConverter.ToSingle(BitConverter.GetBytes(hash), 0);
                            v.Add(f);
                        }
                    }
                    else if (float.TryParse(stringValue, out f))
                        v.Add(f);
                    else
                        v.Add(0.0f);
                }
            }

            if (name != "" && v.Count == 4)
                material.materialProperties.Add(name, v.ToArray());

            if (!Program.materialProperties.Contains(name))
                Program.materialProperties.Add(name);
        }
    }
}
