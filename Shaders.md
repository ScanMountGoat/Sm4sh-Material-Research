# Shaders
Smash 4 nud models reference shaders in texas_cross.nsh using a shader ID starting from 92000161. The shader determines the required material properties, textures, and vertex attributes.

## Material Properties
Material properties from the "MC" uniform buffer in the shaders ommit the "NU_" prefix like "aoMinGain" instead of "NU_aoMinGain".

* alphaBlendParams
* angleFadeParams
* aoMinGain
* colorGain
* colorOffset
* colorSampler2UV
* colorSampler3UV
* colorSampler4UV
* colorSamplerUV
* colorStepUV
* customSoftLightParams
* diffuseColor
* dualNormalScrollParams
* finalColorGain
* finalColorGain2
* finalColorGain3
* fogParams
* fresnelColor
* fresnelParams
* normalParams
* normalSamplerAUV
* normalSamplerBUV
* reflectionColor
* reflectionParams
* rotatePivotUV
* softLightingParams
* specularColor
* specularColorGain
* specularParams
* testParam0
* testParam1
* testParam2
* testParam3
* translucentColor
* zOffset

## Effect Properties
Material properties from the "MC_EFFECT" uniform buffer in the shaders ommit the "NU_" prefix like "effColorGain" instead of "NU_effColorGain".

* angleFadeParams
* effColorGain
* effCombinerAlpha0
* effCombinerColor0
* effCombinerColor1
* effDepthOffset
* effMTBlendAlpha
* effMTBlendParam0
* effMTBlendParam1
* effMTBlendParam2
* effRefractParam
* effRotUV
* effScaleUV
* effSilhouetteColor
* effSunShaftParams0
* effSunShaftParams1
* effTransUV
* effUniverseParam
* effYGradColorBottom
* effYGradColorTop
* effYGradParam
* normalParams
* normalSamplerAUV

## Textures
Shaders reference textures defined in the nud material as well as textures calculated during rendering like shadow maps.

| Name | Channels |
| --- | --- |
| colorSampler | RGB = diffuse color, A = alpha |
| colorSampler2 | |
| colorSampler3 | |
| color2Sampler | |
| diffuseSampler | RGB = skin shading diffuse lighting gradient |
| frameSampler | |
| g_PCFTextureSampler | |
| g_VSMTextureSampler | RG = variance shadow map |
| lightMapSampler | RGB = diffuse lighting gradient |
| multiplicationSampler | |
| normalSampler | RGB = tangent space normal map, A = ambient occlusion |
| normal2Sampler | |
| reflectionCubeSampler | RGB = specular reflection map |
| reflectionSampler | |
| sampler0 | |
| Sampler11 | |
| samplerA | |
| samplerB | |

## Attributes
* a_Position
* a_Normal
* a_Tangent
* a_Binormal
* a_Color
* a_TexCoord0
* a_TexCoord1
* a_TexCoord2

## Shader IDs
Each shader has a unique integer ID listed as hexadecimal in the table. Most of the compiled shader program binaries are found in the `shader/texas_cross.nsh` file. See [sm4sh_shader](https://github.com/ScanMountGoat/sm4sh_lib/tree/main/sm4sh_shader) for how to generate this data.

| Shader ID | Shader File | Program Index |
| --- | --- | --- |
| 00000000 | | |
| 00020000 | | |
| 24080000 | | |
| 92000161 | `shader/texas_cross.nsh` | 0 |
| 92001001 | `shader/texas_cross.nsh` | 2 |
| 92001081 | `shader/texas_cross.nsh` | 3 |
| 92001161 | `shader/texas_cross.nsh` | 4 |
| 92011001 | `shader/texas_cross.nsh` | 7 |
| 92011061 | `shader/texas_cross.nsh` | 8 |
| 92021001 | `shader/texas_cross.nsh` | 10 |
| 92041001 | `shader/texas_cross.nsh` | 11 |
| 92101001 | `shader/texas_cross.nsh` | 12 |
| 92401011 | `shader/texas_cross.nsh` | 13 |
| 92409011 | `shader/texas_cross.nsh` | 14 |
| 92501011 | `shader/texas_cross.nsh` | 15 |
| 92C01101 | `shader/texas_cross.nsh` | 16 |
| 92D01101 | `shader/texas_cross.nsh` | 17 |
| 92F01101 | `shader/texas_cross.nsh` | 18 |
| 94010061 | `shader/texas_cross.nsh` | 20 |
| 94010063 | `shader/texas_cross.nsh` | 21 |
| 94010161 | `shader/texas_cross.nsh` | 22 |
| 94011021 | `shader/texas_cross.nsh` | 23 |
| 94011061 | `shader/texas_cross.nsh` | 25 |
| 94011063 | `shader/texas_cross.nsh` | 26 |
| 94013063 | `shader/texas_cross.nsh` | 27 |
| 94051063 | `shader/texas_cross.nsh` | 28 |
| 95211175 | `shader/texas_cross.nsh` | 32 |
| 95411165 | `shader/texas_cross.nsh` | 33 |
| 96011069 | `shader/texas_cross.nsh` | 34 |
| 9601106B | `shader/texas_cross.nsh` | 35 |
| 9601116B | `shader/texas_cross.nsh` | 36 |
| 9601306B | `shader/texas_cross.nsh` | 37 |
| 96015069 | `shader/texas_cross.nsh` | 38 |
| 9605102B | `shader/texas_cross.nsh` | 39 |
| 9605106B | `shader/texas_cross.nsh` | 40 |
| 9605906B | `shader/texas_cross.nsh` | 41 |
| 9611106B | `shader/texas_cross.nsh` | 43 |
| 96C11069 | `shader/texas_cross.nsh` | 44 |
| 96C1106B | `shader/texas_cross.nsh` | 45 |
| 96C1116B | `shader/texas_cross.nsh` | 46 |
| 96E11049 | `shader/texas_cross.nsh` | 47 |
| 98011069 | `shader/texas_cross.nsh` | 51 |
| 9801106B | `shader/texas_cross.nsh` | 52 |
| 9801906B | `shader/texas_cross.nsh` | 56 |
| 9809106B | `shader/texas_cross.nsh` | 57 |
| 98C1106B | `shader/texas_cross.nsh` | 58 |
| 9A001063 | `shader/texas_cross.nsh` | 59 |
| 9A010063 | `shader/texas_cross.nsh` | 60 |
| 9A011021 | `shader/texas_cross.nsh` | 61 |
| 9A011023 | `shader/texas_cross.nsh` | 62 |
| 9A011061 | `shader/texas_cross.nsh` | 63 |
| 9A011063 | `shader/texas_cross.nsh` | 64 |
| 9A0110E3 | `shader/texas_cross.nsh` | 65 |
| 9A011163 | `shader/texas_cross.nsh` | 66 |
| 9A013063 | `shader/texas_cross.nsh` | 69 |
| 9A015061 | `shader/texas_cross.nsh` | 70 |
| 9A211027 | `shader/texas_cross.nsh` | 73 |
| 9A211065 | `shader/texas_cross.nsh` | 74 |
| 9A211067 | `shader/texas_cross.nsh` | 75 |
| 9A2110E7 | `shader/texas_cross.nsh` | 77 |
| 9A2116E7 | `shader/texas_cross.nsh` | 78 |
| 9A411073 | `shader/texas_cross.nsh` | 79 |
| 9A415071 | `shader/texas_cross.nsh` | 80 |
| 9A811061 | `shader/texas_cross.nsh` | 82 |
| 9A811063 | `shader/texas_cross.nsh` | 83 |
| 9AC11061 | `shader/texas_cross.nsh` | 88 |
| 9AC11063 | `shader/texas_cross.nsh` | 89 |
| 9AC11163 | `shader/texas_cross.nsh` | 92 |
| 9AC15161 | `shader/texas_cross.nsh` | 97 |
| 9AE11163 | `shader/texas_cross.nsh` | 99 |
| 9AE11165 | `shader/texas_cross.nsh` | 100 |
| 9C001063 | `shader/texas_cross.nsh` | 101 |
| 9C009063 | `shader/texas_cross.nsh` | 102 |
| 9C011063 | `shader/texas_cross.nsh` | 105 |
| 9C610061 | `shader/texas_cross.nsh` | 109 |
| 9C611061 | `shader/texas_cross.nsh` | 110 |
| 9E01106B | `shader/texas_cross.nsh` | 115 |
| A0001040 | `shader/texas_cross.nsh` | 118 |
| A2000000 | `shader/texas_cross.nsh` | 119 |
| A2000001 | `shader/texas_cross.nsh` | 120 |
| A2000501 | `shader/texas_cross.nsh` | 121 |
| A2001001 | `shader/texas_cross.nsh` | 122 |
| A2001021 | `shader/texas_cross.nsh` | 123 |
| A2001041 | `shader/texas_cross.nsh` | 124 |
| A2001081 | `shader/texas_cross.nsh` | 126 |
| A2001101 | `shader/texas_cross.nsh` | 127 |
| A2001141 | `shader/texas_cross.nsh` | 128 |
| A2001181 | `shader/texas_cross.nsh` | 129 |
| A20011C1 | `shader/texas_cross.nsh` | 130 |
| A2001901 | `shader/texas_cross.nsh` | 131 |
| A2001941 | `shader/texas_cross.nsh` | 132 |
| A2001981 | `shader/texas_cross.nsh` | 133 |
| A2003303 | `shader/texas_cross.nsh` | 135 |
| A2003383 | `shader/texas_cross.nsh` | 136 |
| A2005009 | `shader/texas_cross.nsh` | 139 |
| A2005049 | `shader/texas_cross.nsh` | 140 |
| A2010001 | `shader/texas_cross.nsh` | 142 |
| A2011000 | `shader/texas_cross.nsh` | 144 |
| A2011001 | `shader/texas_cross.nsh` | 145 |
| A2011021 | `shader/texas_cross.nsh` | 147 |
| A2011041 | `shader/texas_cross.nsh` | 148 |
| A2011061 | `shader/texas_cross.nsh` | 149 |
| A2011081 | `shader/texas_cross.nsh` | 150 |
| A2011101 | `shader/texas_cross.nsh` | 151 |
| A2011201 | `shader/texas_cross.nsh` | 152 |
| A2011501 | `shader/texas_cross.nsh` | 153 |
| A2011581 | `shader/texas_cross.nsh` | 154 |
| A2011901 | `shader/texas_cross.nsh` | 155 |
| A2011981 | `shader/texas_cross.nsh` | 156 |
| A2013303 | `shader/texas_cross.nsh` | 158 |
| A2013B03 | `shader/texas_cross.nsh` | 159 |
| A2015009 | `shader/texas_cross.nsh` | 161 |
| A2015049 | `shader/texas_cross.nsh` | 162 |
| A2021001 | `shader/texas_cross.nsh` | 163 |
| A2021041 | `shader/texas_cross.nsh` | 164 |
| A2031001 | `shader/texas_cross.nsh` | 167 |
| A2041001 | `shader/texas_cross.nsh` | 170 |
| A2041081 | `shader/texas_cross.nsh` | 171 |
| A2041101 | `shader/texas_cross.nsh` | 172 |
| A2041901 | `shader/texas_cross.nsh` | 173 |
| A2041981 | `shader/texas_cross.nsh` | 174 |
| A2043B03 | `shader/texas_cross.nsh` | 175 |
| A2081005 | `shader/texas_cross.nsh` | 176 |
| A2081045 | `shader/texas_cross.nsh` | 177 |
| A2091005 | `shader/texas_cross.nsh` | 178 |
| A2101005 | `shader/texas_cross.nsh` | 179 |
| A2101045 | `shader/texas_cross.nsh` | 180 |
| A2111005 | `shader/texas_cross.nsh` | 181 |
| A2111045 | `shader/texas_cross.nsh` | 182 |
| A211500D | `shader/texas_cross.nsh` | 183 |
| A211504D | `shader/texas_cross.nsh` | 184 |
| A2121005 | `shader/texas_cross.nsh` | 185 |
| A2121045 | `shader/texas_cross.nsh` | 186 |
| A2131045 | `shader/texas_cross.nsh` | 188 |
| A2200001 | `shader/texas_cross.nsh` | 189 |
| A2200501 | `shader/texas_cross.nsh` | 190 |
| A2200581 | `shader/texas_cross.nsh` | 191 |
| A2201000 | `shader/texas_cross.nsh` | 192 |
| A2201001 | `shader/texas_cross.nsh` | 193 |
| A2201081 | `shader/texas_cross.nsh` | 194 |
| A2201501 | `shader/texas_cross.nsh` | 196 |
| A2201901 | `shader/texas_cross.nsh` | 197 |
| A2201981 | `shader/texas_cross.nsh` | 198 |
| A2201A81 | `shader/texas_cross.nsh` | 200 |
| A2211406 | `shader/texas_cross.nsh` | 202 |
| A2211486 | `shader/texas_cross.nsh` | 205 |
| A2211581 | `shader/texas_cross.nsh` | 206 |
| A2215009 | `shader/texas_cross.nsh` | 208 |
| A2415009 | `shader/texas_cross.nsh` | 210 |
| A2415049 | `shader/texas_cross.nsh` | 211 |
| A2A05E89 | `shader/texas_cross.nsh` | 216 |
| A2A09609 | `shader/texas_cross.nsh` | 217 |
| A2E15C05 | `shader/texas_cross.nsh` | 219 |
| A3215C05 | `shader/texas_cross.nsh` | 221 |
| A3405181 | `shader/texas_cross.nsh` | 223 |
| A3405901 | `shader/texas_cross.nsh` | 224 |
| A3405981 | `shader/texas_cross.nsh` | 225 |
| A3805101 | `shader/texas_cross.nsh` | 232 |
| A3805901 | `shader/texas_cross.nsh` | 233 |
| A3805981 | `shader/texas_cross.nsh` | 234 |
| A3809901 | `shader/texas_cross.nsh` | 236 |
| A3809941 | `shader/texas_cross.nsh` | 237 |
| A3815941 | `shader/texas_cross.nsh` | 240 |
| A3829901 | `shader/texas_cross.nsh` | 242 |
| A3A05101 | `shader/texas_cross.nsh` | 243 |
| A3A19001 | `shader/texas_cross.nsh` | 246 |
| A3C01001 | `shader/texas_cross.nsh` | 248 |
| A3C01081 | `shader/texas_cross.nsh` | 249 |
| A3C01181 | `shader/texas_cross.nsh` | 250 |
| A3C01201 | `shader/texas_cross.nsh` | 251 |
| A3C01281 | `shader/texas_cross.nsh` | 252 |
| A3C01901 | `shader/texas_cross.nsh` | 253 |
| A3C01981 | `shader/texas_cross.nsh` | 254 |
| A3C03303 | `shader/texas_cross.nsh` | 255 |
| A3C03383 | `shader/texas_cross.nsh` | 256 |
| A3C11001 | `shader/texas_cross.nsh` | 258 |
| A3C11101 | `shader/texas_cross.nsh` | 259 |
| A3C11181 | `shader/texas_cross.nsh` | 260 |
| A3C11901 | `shader/texas_cross.nsh` | 262 |
| A3C31141 | `shader/texas_cross.nsh` | 263 |
| A3C41001 | `shader/texas_cross.nsh` | 264 |
| A3C81105 | `shader/texas_cross.nsh` | 265 |
| A3CC1105 | `shader/texas_cross.nsh` | 266 |
| A3D01045 | `shader/texas_cross.nsh` | 268 |
| A3D11045 | `shader/texas_cross.nsh` | 269 |
| A3D21105 | `shader/texas_cross.nsh` | 270 |
| A3D23107 | `shader/texas_cross.nsh` | 272 |
| A3E01001 | `shader/texas_cross.nsh` | 274 |
| A3E01081 | `shader/texas_cross.nsh` | 275 |
| A3E01181 | `shader/texas_cross.nsh` | 276 |
| A3E11001 | `shader/texas_cross.nsh` | 277 |
| A3E41181 | `shader/texas_cross.nsh` | 278 |
| A4001001 | `shader/texas_cross.nsh` | 279 |
| A4001003 | `shader/texas_cross.nsh` | 280 |
| A4001041 | `shader/texas_cross.nsh` | 281 |
| A4001061 | `shader/texas_cross.nsh` | 282 |
| A4001081 | `shader/texas_cross.nsh` | 283 |
| A40010E1 | `shader/texas_cross.nsh` | 284 |
| A4001101 | `shader/texas_cross.nsh` | 285 |
| A4001981 | `shader/texas_cross.nsh` | 287 |
| A4010001 | `shader/texas_cross.nsh` | 288 |
| A4010041 | `shader/texas_cross.nsh` | 289 |
| A4011001 | `shader/texas_cross.nsh` | 290 |
| A4011003 | `shader/texas_cross.nsh` | 291 |
| A4011021 | `shader/texas_cross.nsh` | 293 |
| A4011041 | `shader/texas_cross.nsh` | 294 |
| A4011043 | `shader/texas_cross.nsh` | 295 |
| A4011061 | `shader/texas_cross.nsh` | 296 |
| A4011101 | `shader/texas_cross.nsh` | 297 |
| A4011901 | `shader/texas_cross.nsh` | 298 |
| A4011941 | `shader/texas_cross.nsh` | 299 |
| A4011981 | `shader/texas_cross.nsh` | 300 |
| A4015009 | `shader/texas_cross.nsh` | 303 |
| A4021001 | `shader/texas_cross.nsh` | 304 |
| A4021041 | `shader/texas_cross.nsh` | 306 |
| A4031001 | `shader/texas_cross.nsh` | 308 |
| A4031041 | `shader/texas_cross.nsh` | 309 |
| A4201001 | `shader/texas_cross.nsh` | 311 |
| A4211901 | `shader/texas_cross.nsh` | 313 |
| A4215009 | `shader/texas_cross.nsh` | 314 |
| A4415009 | `shader/texas_cross.nsh` | 315 |
| A4415049 | `shader/texas_cross.nsh` | 317 |
| A4615009 | `shader/texas_cross.nsh` | 320 |
| A5C01041 | `shader/texas_cross.nsh` | 322 |
| A5C01081 | `shader/texas_cross.nsh` | 323 |
| A5C010C1 | `shader/texas_cross.nsh` | 324 |
| A5C01141 | `shader/texas_cross.nsh` | 325 |
| A5C01181 | `shader/texas_cross.nsh` | 326 |
| A5C11001 | `shader/texas_cross.nsh` | 328 |
| A5C11041 | `shader/texas_cross.nsh` | 329 |
| A5C11901 | `shader/texas_cross.nsh` | 330 |
| A5C15049 | `shader/texas_cross.nsh` | 331 |
| A6003307 | `shader/texas_cross.nsh` | 333 |
| A6003347 | `shader/texas_cross.nsh` | 334 |
| A6013307 | `shader/texas_cross.nsh` | 335 |
| A6081005 | `shader/texas_cross.nsh` | 336 |
| A6081045 | `shader/texas_cross.nsh` | 337 |
| A6081047 | `shader/texas_cross.nsh` | 338 |
| A6081085 | `shader/texas_cross.nsh` | 339 |
| A6091005 | `shader/texas_cross.nsh` | 340 |
| A6101005 | `shader/texas_cross.nsh` | 342 |
| A6101045 | `shader/texas_cross.nsh` | 344 |
| A6101047 | `shader/texas_cross.nsh` | 345 |
| A61010C5 | `shader/texas_cross.nsh` | 346 |
| A6111005 | `shader/texas_cross.nsh` | 347 |
| A6111007 | `shader/texas_cross.nsh` | 348 |
| A6111045 | `shader/texas_cross.nsh` | 350 |
| A6111067 | `shader/texas_cross.nsh` | 352 |
| A6121005 | `shader/texas_cross.nsh` | 353 |
| A6121007 | `shader/texas_cross.nsh` | 354 |
| A6121045 | `shader/texas_cross.nsh` | 355 |
| A6131145 | `shader/texas_cross.nsh` | 358 |
| A61311C5 | `shader/texas_cross.nsh` | 359 |
| A62B1005 | `shader/texas_cross.nsh` | 362 |
| A6301005 | `shader/texas_cross.nsh` | 363 |
| A6301045 | `shader/texas_cross.nsh` | 364 |
| A6331005 | `shader/texas_cross.nsh` | 365 |
| A651504D | `shader/texas_cross.nsh` | 366 |
| A671500D | `shader/texas_cross.nsh` | 369 |
| A693564D | `shader/texas_cross.nsh` | 370 |
| A6B0560D | `shader/texas_cross.nsh` | 371 |
| A7809945 | `shader/texas_cross.nsh` | 372 |
| A7C03307 | `shader/texas_cross.nsh` | 373 |
| A7C91005 | `shader/texas_cross.nsh` | 377 |
| A7C91905 | `shader/texas_cross.nsh` | 378 |
| A7D01047 | `shader/texas_cross.nsh` | 380 |
| A7D31945 | `shader/texas_cross.nsh` | 381 |
| A8101045 | `shader/texas_cross.nsh` | 384 |
| AA415049 | `shader/texas_cross.nsh` | 387 |
| AA415609 | `shader/texas_cross.nsh` | 388 |
| AA605E09 | `shader/texas_cross.nsh` | 390 |
| AB809901 | `shader/texas_cross.nsh` | 394 |
| AB819901 | `shader/texas_cross.nsh` | 395 |
| ABA09601 | `shader/texas_cross.nsh` | 398 |
| ABA15101 | `shader/texas_cross.nsh` | 400 |
| ADA19101 | `shader/texas_cross.nsh` | 402 |
| B0200000 | `shader/texas_cross.nsh` | 403 |
| B0200100 | `shader/texas_cross.nsh` | 404 |
| B0201000 | `shader/texas_cross.nsh` | 405 |
| B0201100 | `shader/texas_cross.nsh` | 407 |
| B0202000 | `shader/texas_cross.nsh` | 408 |
| B0209300 | `shader/texas_cross.nsh` | 414 |
| B0209600 | `shader/texas_cross.nsh` | 415 |
| B0211000 | `shader/texas_cross.nsh` | 418 |
| B0211100 | `shader/texas_cross.nsh` | 419 |
| B0221000 | `shader/texas_cross.nsh` | 422 |
| B0221100 | `shader/texas_cross.nsh` | 423 |
| B0231000 | `shader/texas_cross.nsh` | 426 |
| B0231100 | `shader/texas_cross.nsh` | 427 |
| B0240000 | `shader/texas_cross.nsh` | 428 |
| B0240100 | `shader/texas_cross.nsh` | 429 |
| B0241000 | `shader/texas_cross.nsh` | 430 |
| B0241100 | `shader/texas_cross.nsh` | 431 |
| B0261100 | `shader/texas_cross.nsh` | 441 |
| B0281000 | `shader/texas_cross.nsh` | 447 |
| B0400109 | `shader/texas_cross.nsh` | 459 |
| B0401109 | `shader/texas_cross.nsh` | 468 |
| B040110B | `shader/texas_cross.nsh` | 470 |
| B0A01001 | `shader/texas_cross.nsh` | 496 |
| B0C01000 | `shader/texas_cross.nsh` | 498 |
| B0E01000 | `shader/texas_cross.nsh` | 500 |
| D20010C1 | `shader/texas_cross.nsh` | 514 |
| D2101101 | `shader/texas_cross.nsh` | 515 |
| D2109001 | `shader/texas_cross.nsh` | 516 |
| D2141101 | `shader/texas_cross.nsh` | 517 |
| D2C01101 | `shader/texas_cross.nsh` | 518 |
| D2C80101 | `shader/texas_cross.nsh` | 519 |
| D2C81101 | `shader/texas_cross.nsh` | 520 |
| D2D01001 | `shader/texas_cross.nsh` | 521 |
| D4014061 | `shader/texas_cross.nsh` | 522 |
| D4015061 | `shader/texas_cross.nsh` | 523 |
| D601106B | `shader/texas_cross.nsh` | 525 |
| D6014069 | `shader/texas_cross.nsh` | 526 |
| D6015069 | `shader/texas_cross.nsh` | 527 |
| D6090069 | `shader/texas_cross.nsh` | 529 |
| D6091069 | `shader/texas_cross.nsh` | 530 |
| D609106B | `shader/texas_cross.nsh` | 531 |
| D6C1106B | `shader/texas_cross.nsh` | 532 |
| D6C1116B | `shader/texas_cross.nsh` | 533 |
| D6C90069 | `shader/texas_cross.nsh` | 534 |
| D6C90169 | `shader/texas_cross.nsh` | 535 |
| D6C91069 | `shader/texas_cross.nsh` | 536 |
| D6C91169 | `shader/texas_cross.nsh` | 538 |
| D801906B | `shader/texas_cross.nsh` | 540 |
| DA011061 | `shader/texas_cross.nsh` | 541 |
| DA011063 | `shader/texas_cross.nsh` | 542 |
| DA0110E3 | `shader/texas_cross.nsh` | 543 |
| DA015061 | `shader/texas_cross.nsh` | 546 |
| DA019063 | `shader/texas_cross.nsh` | 547 |
| DA090061 | `shader/texas_cross.nsh` | 549 |
| DA091061 | `shader/texas_cross.nsh` | 551 |
| DAC90061 | `shader/texas_cross.nsh` | 557 |
| DAC90161 | `shader/texas_cross.nsh` | 558 |
| DAC91061 | `shader/texas_cross.nsh` | 559 |
| DAC91161 | `shader/texas_cross.nsh` | 561 |
| E2015C09 | `shader/texas_cross.nsh` | 565 |
| E2041001 | `shader/texas_cross.nsh` | 566 |
| E2041101 | `shader/texas_cross.nsh` | 567 |
| E2041901 | `shader/texas_cross.nsh` | 568 |
| E2247B03 | `shader/texas_cross.nsh` | 570 |
| E2408101 | `shader/texas_cross.nsh` | 572 |
| E2409101 | `shader/texas_cross.nsh` | 573 |
| E2411041 | `shader/texas_cross.nsh` | 575 |
| E2413A03 | `shader/texas_cross.nsh` | 576 |
| E2429D09 | `shader/texas_cross.nsh` | 579 |
| E2445409 | `shader/texas_cross.nsh` | 580 |
| E2445C09 | `shader/texas_cross.nsh` | 582 |
| E2447A03 | `shader/texas_cross.nsh` | 583 |
| E2581001 | `shader/texas_cross.nsh` | 584 |
| E2605009 | `shader/texas_cross.nsh` | 586 |
| E2641001 | `shader/texas_cross.nsh` | 591 |
| E2647A03 | `shader/texas_cross.nsh` | 592 |
| E2811001 | `shader/texas_cross.nsh` | 593 |
| E2845901 | `shader/texas_cross.nsh` | 595 |
| E2847A03 | `shader/texas_cross.nsh` | 596 |
| E2849901 | `shader/texas_cross.nsh` | 597 |
| E2A01109 | `shader/texas_cross.nsh` | 598 |
| E4605109 | `shader/texas_cross.nsh` | 601 |
| E4605509 | `shader/texas_cross.nsh` | 602 |
| E62A3307 | `shader/texas_cross.nsh` | 605 |
| E6413A06 | `shader/texas_cross.nsh` | 606 |
| F664006B | `shader/texas_cross.nsh` | 608 |
| F882006B | `shader/texas_cross.nsh` | 609 |
| FA220067 | `shader/texas_cross.nsh` | 611 |
| FA240067 | `shader/texas_cross.nsh` | 612 |
| FA600063 | `shader/texas_cross.nsh` | 613 |
| FA640063 | `shader/texas_cross.nsh` | 614 |
| FC420061 | `shader/texas_cross.nsh` | 615 |
| FC420161 | `shader/texas_cross.nsh` | 616 |
| FC440061 | `shader/texas_cross.nsh` | 617 |
