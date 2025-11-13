# Material Properties
A list of all material properties accessed by in game shader code.  
*Unused*: the channel is never accessed by any in game shader.

| Property Name | Param1 | Param2 | Param3 | Param4 |
| --- | --- | --- | --- | --- |
| NU_alphaBlendParams | Alpha Offset | ??? | ??? | ??? |
| NU_angleFadeParams | Blend Amount at 0 Degrees | Blend Amount at 90 Degrees | *Unused* | *Unused* |
| NU_aoMinGain | Red | Green | Blue | AO Mix Factor |
| NU_blinkColor | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_characterColor | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_colorGain  | Red | Green | Blue | *Unused* |
| NU_colorOffset | Red | Green | Blue | *Unused* |
| NU_colorSampler2UV | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler3UV | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler4UV | Scale U | Scale V | Translate U | Translate V |
| NU_colorStepUV | horizontal sprite count | vertical sprite count | frames per sprite | ??? |
| NU_customSoftLightParams | Ambient Saturation | Darken Ambient | Smooth Amount | *Unused* |
| NU_diffuseColor | Red | Green | Blue | ??? |
| NU_dualNormalScrollParams | ??? | ??? | ??? | ??? |
| NU_envDiffuseColor | ??? | ??? | ??? | *Unused* |
| NU_finalColorGain | Red | Green | Blue | Alpha |
| NU_finalColorGain2 | Red | Green | Blue | Alpha |
| NU_finalColorGain3 | Red | Green | Blue | Alpha |
| NU_fogColor | ??? | ??? | ??? | ??? |
| NU_fogParams | Minimum Distance | Maximum Distance | Minimum Intensity | Maximum Intensity |
| NU_fresnelColor |   Red | Green | Blue | Color Blend |
| NU_fresnelParams | Exponent | ??? | ??? | ??? |
| NU_lightMapColorOffset | ??? | ??? | ??? | *Unused* |
| NU_materialHash | Hash | *Unused* | *Unused* | *Unused* | |
| NU_normalParams | Normal Map Intensity | *Unused* | DuDv Intensity | ??? |
| NU_normalSamplerAUV | Scale U | Scale V | Translate U | Translate V |
| NU_normalSamplerBUV | Scale U | Scale V | Translate U | Translate V |
| NU_reflectionColor |   Red | Green | Blue | Color Blend |
| NU_reflectionParams | Cubemap Intensity | Sphere Map Param | Anisotropic Width | Anisotropic Height |
| NU_rotatePivotUV | ??? | *Unused* | ??? | ??? |
| NU_softLightingParams | Ambient Saturation | Darken Ambient | Smooth Amount | *Unused* |
| NU_specularColor | Red | Green | Blue | Color Blend |
| NU_specularColorGain | Red | Green | Blue | ??? |
| NU_specularParams | *Unused* | Exponent | ??? | *Unused* |
| NU_testParam0 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_testParam1 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_testParam2 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_testParam3 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_translucentColor | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_zOffset | Z Offset | *Unused* | *Unused* | *Unused* | *Unused* |

# Effect Properties
A list of all effect material properties accessed by in game shader code.  
*Unused*: the channel is never accessed by any in game shader.

| Property Name | Param1 | Param2 | Param3 | Param4 |
| --- | --- | --- | --- | --- |
| NU_angleFadeParams | ??? | ??? | *Unused* | *Unused* |
| NU_effColorGain | ??? | ??? | ??? | ??? |
| NU_effCombinerAlpha0 | ??? | ??? | ??? | *Unused* |
| NU_effCombinerColor0 | ??? | ??? | ??? | *Unused* |
| NU_effCombinerColor1 | ??? | ??? | ??? | ??? |
| NU_effDepthOffset | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effMTBlendAlpha | ??? | ??? | *Unused* | *Unused* |
| NU_effMTBlendParam0 | ??? | ??? | ??? | ??? |
| NU_effMTBlendParam1 | ??? | ??? | ??? | ??? |
| NU_effMTBlendParam2 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effRefractParam | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effRotUV | ??? | ??? | *Unused* | *Unused* |
| NU_effScaleUV | ??? | ??? | ??? | ??? |
| NU_effSilhouetteColor | ??? | ??? | ??? | *Unused* |
| NU_effSunShaftParams0 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effSunShaftParams1 | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effTransUV |  ??? | ??? | ??? | ??? |
| NU_effUniverseParam |  ??? | *Unused* | *Unused* | *Unused* |
| NU_effYGradColorBottom |  ??? | ??? | ??? | *Unused* |
| NU_effYGradColorTop |  ??? | ??? | ??? | *Unused* |
| NU_effYGradParam |  ??? | ??? | *Unused* | *Unused* |
| NU_normalParams | ??? | *Unused* | ??? | *Unused* |
| NU_normalSamplerAUV | ??? | ??? | ??? | ??? |


# Unused Properties
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
