# Material Property List
A list of all material properties used in the `XML Materials` folder.  
*Unused*: the in game value is always 0.

| Property Name | Param1 | Param2 | Param3 | Param4 |
| --- | --- | --- | --- | --- |
| NU_fresnelColor |   Red | Green | Blue | Color Blend |
| NU_reflectionColor |   Red | Green | Blue | Color Blend |
| NU_specularColor |   Red | Green | Blue | Color Blend |
| NU_colorSampler2UV | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler3UV | Scale U | Scale V | Translate U | Translate V |
| NU_colorSampler4UV | Scale U | Scale V | Translate U | Translate V |
| NU_aoMinGain | Red | Green | Blue | AO Mix Factor |
| NU_colorGain  | Red | Green | Blue | *Unused* |
| NU_colorOffset | Red | Green | Blue | *Unused* |
| NU_customSoftLightParams | Ambient Saturation | Darken Ambient | Smooth Amount | *Unused* |
| NU_softLightingParams | Ambient Saturation | Darken Ambient | Smooth Amount | *Unused* |
| NU_specularColorGain | Red | Green | Blue | *Unused* |
| NU_reflectionParams | Cubemap Intensity | *Unused* | Anisotropic Width | Anisotropic Height |
| NU_effColorGain | Red | Green | Blue | Alpha |
| NU_finalColorGain | Red | Green | Blue | Alpha |
| NU_finalColorGain2 | Red | Green | Blue | Alpha |
| NU_finalColorGain3 | Red | Green | Blue | Alpha |
| NU_normalSamplerAUV | Scale U | Scale V | Translate U | Translate V |
| NU_normalSamplerBUV | Scale U | Scale V | Translate U | Translate V |
| NU_fogParams | Minimum Distance | Maximum Distance | Minimum Intensity | Maximum Intensity |
| NU_materialHash | Hash | *Unused* | *Unused* | *Unused* | |
| NU_normalParams | Normal Map Intensity | *Unused* | DuDv Intensity | *Unused* |
| NU_zOffset | Z Offset | *Unused* | *Unused* | *Unused* | |
| NU_angleFadeParams | Blend Amount at 0 Degrees | Blend Amount at 90 Degrees | *Unused* | *Unused* |
| NU_effUniverseParam | Scale U | *Unused* | *Unused* | *Unused* |
| NU_fresnelParams | Exponent | ??? | ??? | ??? |
| NU_specularParams | ??? | Exponent | ??? | *Unused* |
| NU_alphaBlendParams | Alpha Offset | ??? | ??? | ??? |
| NU_diffuseColor | Red | Green | Blue | ??? |
| NU_dualNormalScrollParams | ??? | ??? | ??? | ??? |
| NU_colorStepUV | horizontal sprite count | vertical sprite count | frames per sprite | ??? |
| NU_blinkColor | *Unused* | *Unused* | *Unused* | *Unused* |
| NU_effRotUV | ??? | ??? | ??? | ??? |
| NU_effScaleUV | ??? | ??? | *Unused* | *Unused* |
| NU_effTransUV | ??? | ??? | *Unused* | *Unused* |
| NU_effMaxUV | ??? | ??? | ??? | ??? |
| NU_effOffsetUV | ??? | ??? | ??? | ??? |
| NU_effSilhouetteColor | ??? | ??? | ??? | *Unused* |
| NU_effCombinerColor0 | ??? | ??? | ??? | *Unused* |
| NU_effCombinerColor1 | ??? | ??? | ??? | *Unused* |
| NU_effYGradParam | *Unused* | ??? | *Unused* | *Unused* |
| NU_effYGradColorBottom | ??? | ??? | ??? | *Unused* |
| NU_effYGradColorTop | ??? | ??? | ??? | *Unused* |
| NU_characterColor | ??? | ??? | ??? | *Unused* |
| NU_postEffectReflection | ??? | *Unused* | *Unused* | *Unused* |
| NU_lightMapColorOffset | ??? | ??? | ??? | *Unused* |
| NU_fogColor | ??? | ??? | ??? | ??? |
| NU_rotatePivotUV | ??? | *Unused* | ??? | ??? |
| NU_envDiffuseColor | ??? | ??? | ??? | *Unused* |
| NU_effMTBlendType | ??? | ??? | *Unused* | *Unused* |
| NU_effMTBlendParam0 | *Unused* | ??? | ??? | ??? |
| NU_effMTBlendParam1 | *Unused* | ??? | ??? | ??? |
| NU_effMTBlendAlpha | ??? | ??? | ??? | *Unused* |

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
