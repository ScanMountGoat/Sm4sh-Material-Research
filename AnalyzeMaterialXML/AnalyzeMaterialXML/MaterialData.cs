using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace AnalyzeMaterialXML
{
    class MaterialData
    {
        public uint flags;
        public Dictionary<string, float[]> materialProperties = new Dictionary<string, float[]>();

    }
}
