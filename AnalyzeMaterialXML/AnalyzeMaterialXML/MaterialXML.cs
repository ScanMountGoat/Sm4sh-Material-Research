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
        public static void MaterialDataFromXML(string filename)
        {
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(filename);

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
                                    MaterialData matData = new MaterialData();
                                    Program.materials.Add(matData);

                                    foreach (XmlAttribute attribute in materialNode.Attributes)
                                    {
                                        switch (attribute.Name)
                                        {
                                            case "flags":
                                                uint flags = 0;
                                                uint.TryParse(attribute.Value, NumberStyles.HexNumber, null, out flags);
                                                matData.setFlags(flags);
                                                break;
                                        }
                                    }

                                    foreach (XmlNode materialChildNode in materialNode.ChildNodes)
                                    {
                                        if (materialChildNode.Name.Equals("param"))
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
                                            string[] values = materialChildNode.InnerText.Split(' ');
                                            List<float> v = new List<float>();
                                            float f = 0;

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
                                                matData.materialProperties.Add(name, v.ToArray());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
