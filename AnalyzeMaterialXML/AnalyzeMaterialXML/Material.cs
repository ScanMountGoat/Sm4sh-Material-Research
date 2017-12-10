﻿using System;
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
        public string fileName = "";

        public bool spheremap;
        public bool aomap;
        public bool stagemap;
        public bool cubemap;
        public bool diffuse;
        public bool diffuse2;
        public bool diffuse3;
        public bool ramp;
        public bool shadow;
        public bool dummyramp;
        public bool normalmap;
        public int textureCount = 0;
        public int expectedTextureCount = 0;

        public int srcFactor;
        public int dstFactor;


        public Dictionary<string, float[]> materialProperties = new Dictionary<string, float[]>();

        public uint getFlags()
        {
            return flags;
        }

        public void setFlags(uint newFlags)
        {
            flags = newFlags;
            testFlags();
            calculateTextureCount();
        }

        public void testFlags()
        {
            shadow = (flags & (int)TextureFlags.Shadow) > 0;

            dummyramp = (flags & (int)TextureFlags.DummyRamp) > 0;
            spheremap = (flags & (int)TextureFlags.SphereMap) > 0;

            aomap = (flags & (int)TextureFlags.StageAOMap) > 0 && !dummyramp;
            stagemap = (flags & (int)TextureFlags.StageAOMap) > 0 && dummyramp;

            cubemap = (flags & (int)TextureFlags.RampCubeMap) > 0 && (!dummyramp) && (!spheremap);
            ramp = (flags & (int)TextureFlags.RampCubeMap) > 0 && dummyramp;

            diffuse = (flags & (int)TextureFlags.DiffuseMap) > 0;
            diffuse3 = (flags & 0x00009100) == 0x00009100 || (flags & 0x00009600) == 0x00009600 || (flags & 0x00009900) == 0x00009900;
            diffuse2 = (flags & (int)TextureFlags.RampCubeMap) > 0 && (flags & (int)TextureFlags.NormalMap) == 0
                && dummyramp || diffuse3;

            normalmap = (flags & (int)TextureFlags.NormalMap) > 0;
        }

        public void calculateTextureCount()
        {
            if (diffuse)
                expectedTextureCount += 1;
            if (spheremap)
                expectedTextureCount += 1;
            if (diffuse2)
                expectedTextureCount += 1;
            if (diffuse3)
                expectedTextureCount += 1;
            if (stagemap)
                expectedTextureCount += 1;
            if (cubemap)
                expectedTextureCount += 1;
            if (aomap)
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