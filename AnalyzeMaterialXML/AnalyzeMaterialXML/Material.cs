using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace AnalyzeMaterialXML
{
    class Material
    {
        public enum TextureFlags
        {
            Glow = 0x00000080,
            Shadow = 0x00000040,
            DummyRamp = 0x00000020,
            SphereMap = 0x00000010,
            StageAOMap = 0x00000008,
            RampCubeMap = 0x00000004,
            NormalMap = 0x00000002,
            DiffuseMap = 0x00000001
        }

        private uint flags;
        public uint Flags
        {
            get { return flags; }
            set
            {
                flags = value;
                TestFlags();
                CalculateTextureCount();
            }
        }

        public string fileName = "";

        public bool hasSphereMap;
        public bool hasAoMap;
        public bool hasStageMap;
        public bool hasCubeMap;
        public bool hasDiffuse;
        public bool hasDiffuse2;
        public bool hasDiffuse3;
        public bool ramp;
        public bool shadow;
        public bool dummyramp;
        public bool normalmap;
        public int textureCount = 0;
        public int expectedTextureCount = 0;
        public int zBufferOffset = 0;

        public int srcFactor;
        public int dstFactor;

        public Dictionary<string, float[]> materialProperties = new Dictionary<string, float[]>();

        public void TestFlags()
        {
            shadow = (flags & (int)TextureFlags.Shadow) > 0;

            dummyramp = (flags & (int)TextureFlags.DummyRamp) > 0;
            hasSphereMap = (flags & (int)TextureFlags.SphereMap) > 0;

            hasAoMap = (flags & (int)TextureFlags.StageAOMap) > 0 && !dummyramp;
            hasStageMap = (flags & (int)TextureFlags.StageAOMap) > 0 && dummyramp;

            hasCubeMap = (flags & (int)TextureFlags.RampCubeMap) > 0 && (!dummyramp) && (!hasSphereMap);
            ramp = (flags & (int)TextureFlags.RampCubeMap) > 0 && dummyramp;

            hasDiffuse = (flags & (int)TextureFlags.DiffuseMap) > 0;
            hasDiffuse3 = (flags & 0x00009100) == 0x00009100 || (flags & 0x00009600) == 0x00009600 || (flags & 0x00009900) == 0x00009900;
            hasDiffuse2 = (flags & (int)TextureFlags.RampCubeMap) > 0 && (flags & (int)TextureFlags.NormalMap) == 0
                && dummyramp || hasDiffuse3;

            normalmap = (flags & (int)TextureFlags.NormalMap) > 0;
        }

        public void CalculateTextureCount()
        {
            if (hasDiffuse)
                expectedTextureCount += 1;
            if (hasSphereMap)
                expectedTextureCount += 1;
            if (hasDiffuse2)
                expectedTextureCount += 1;
            if (hasDiffuse3)
                expectedTextureCount += 1;
            if (hasStageMap)
                expectedTextureCount += 1;
            if (hasCubeMap)
                expectedTextureCount += 1;
            if (hasAoMap)
                expectedTextureCount += 1;
            if (normalmap)
                expectedTextureCount += 1;
            if (ramp)
                expectedTextureCount += 1;
            if (dummyramp)
                expectedTextureCount += 1;
        }
    }
}
