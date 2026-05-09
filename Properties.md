# Material Properties
A list of all material properties accessed by in game shader code. Blank columns indicate the channel is never accessed by any in game shader.

The "Default Value" is a value that has no effect or the same effect as not having the parameter defined in the material. This is typically 0.0 for offset values (a + 0.0 = a), 1.0 for scale values (1.0 * a = a), and 1.0 for exponents (a^1.0 = a). The default value for intensities or blend factors for mixing between values may be 0.0 or 1.0 depending on the context.

| Property Name | Default Value | Param1 | Param2 | Param3 | Param4 |
| --- | --- | --- | --- | --- | --- |
| NU_alphaBlendParams | | Alpha Offset | ??? | ??? | ??? |
| NU_angleFadeParams | | Blend Amount at 0 Degrees | Blend Amount at 90 Degrees | | | |
| NU_aoMinGain | | Red | Green | Blue | AO Mix Factor |
| NU_blinkColor | | | | | |
| NU_characterColor | | | | | |
| NU_colorGain | | Red | Green | Blue | |
| NU_colorOffset | | Red | Green | Blue | |
| NU_colorSampler2UV | (1, 1, 0, 0) | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler3UV | (1, 1, 0, 0) | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler4UV | (1, 1, 0, 0) | Scale U | Scale V | Translate U | Translate V |
| NU_colorStepUV | | horizontal sprite count | vertical sprite count | frames per sprite | ??? |
| NU_customSoftLightParams | | Ambient Saturation | Darken Ambient | Smooth Amount | |
| NU_diffuseColor | | Red | Green | Blue | ??? |
| NU_dualNormalScrollParams | | ??? | ??? | ??? | ??? |
| NU_envDiffuseColor | | ??? | ??? | ??? | |
| NU_finalColorGain | | Red | Green | Blue | Alpha |
| NU_finalColorGain2 | | Red | Green | Blue | Alpha |
| NU_finalColorGain3 | | Red | Green | Blue | Alpha |
| NU_fogColor | | ??? | ??? | ??? | ??? |
| NU_fogParams | | Minimum Distance | Maximum Distance | Minimum Intensity | Maximum Intensity |
| NU_fresnelColor | | Red | Green | Blue | Color Blend |
| NU_fresnelParams | | Exponent | ??? | ??? | ??? |
| NU_lightMapColorOffset | | ??? | ??? | ??? | |
| NU_materialHash | | Hash | | | | |
| NU_normalParams | | Normal Map Intensity | | DuDv Intensity | ??? |
| NU_normalSamplerAUV | | Scale U | Scale V | Translate U | Translate V |
| NU_normalSamplerBUV | | Scale U | Scale V | Translate U | Translate V |
| NU_reflectionColor | (1, 1, 1, 0) | Red | Green | Blue | Color Blend |
| NU_reflectionParams | | Cubemap Intensity | Sphere Map Param | Anisotropic Width | Anisotropic Height |
| NU_rotatePivotUV | | ??? | | ??? | ??? |
| NU_softLightingParams | | Ambient Saturation | Darken Ambient | Smooth Amount | |
| NU_specularColor | (1, 1, 1, 0) | Red | Green | Blue | Color Blend |
| NU_specularColorGain | | Red | Green | Blue | ??? |
| NU_specularParams | | | Exponent | ??? | |
| NU_testParam0 | | | | | |
| NU_testParam1 | | | | | |
| NU_testParam2 | | | | | |
| NU_testParam3 | | | | | |
| NU_translucentColor | | | | | |
| NU_zOffset | (0, 0, 0, 0) | Z Offset | | | | |

## Effect Properties
A list of all effect material properties accessed by in game shader code.

| Property Name | Default Value | Param1 | Param2 | Param3 | Param4 |
| --- | --- | --- | --- | --- | --- |
| NU_angleFadeParams | | ??? | ??? | | |
| NU_effColorGain | | ??? | ??? | ??? | ??? |
| NU_effCombinerAlpha0 | | ??? | ??? | ??? | |
| NU_effCombinerColor0 | | ??? | ??? | ??? | |
| NU_effCombinerColor1 | | ??? | ??? | ??? | ??? |
| NU_effDepthOffset | | | | | |
| NU_effMTBlendAlpha | | ??? | ??? | | |
| NU_effMTBlendParam0 | | ??? | ??? | ??? | ??? |
| NU_effMTBlendParam1 | | ??? | ??? | ??? | ??? |
| NU_effMTBlendParam2 | | | | | |
| NU_effRefractParam | | | | | |
| NU_effRotUV | | ??? | ??? | | |
| NU_effScaleUV | | ??? | ??? | ??? | ??? |
| NU_effSilhouetteColor | | ??? | ??? | ??? | |
| NU_effSunShaftParams0 | | | | | |
| NU_effSunShaftParams1 | | | | | |
| NU_effTransUV | | ??? | ??? | ??? | ??? |
| NU_effUniverseParam | | ??? | | | |
| NU_effYGradColorBottom | | ??? | ??? | ??? | |
| NU_effYGradColorTop | | ??? | ??? | ??? | |
| NU_effYGradParam | | ??? | ??? | | |
| NU_normalParams | | ??? | | ??? | |
| NU_normalSamplerAUV | | ??? | ??? | ??? | ??? |


## Unused Properties
No in game model has been found using these material properties. It's probably
still possible to use them, since the values are present in the shaders. The
results are from searching the fighter, stage/melee, trophy, smash tour, item,
mii hat, and ui model folders.

NU_translucentColor  
NU_testParam0  
NU_testParam1  
NU_testParam2  
NU_testParam3  
NU_effRefractParam  
NU_effCombinerAlpha0  
NU_effDepthOffset  
NU_effMTBlendParam2  
NU_effSunShaftParams0  
NU_effSunShaftParams1  
NU_rdShadowColor  
