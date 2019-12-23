import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import os
import sys

param_names = ['NU_alphaBlendParams', 'NU_angleFadeParams', 'NU_aoMinGain', 'NU_blinkColor', 'NU_characterColor', 
    'NU_colorGain', 'NU_colorOffset', 'NU_colorSampler2UV', 'NU_colorSampler3UV', 'NU_colorSamplerUV', 'NU_colorStepUV', 
    'NU_customSoftLightParams', 'NU_diffuseColor', 'NU_dualNormalScrollParams', 'NU_effColorGain', 'NU_effCombinerAlpha0', 
    'NU_effCombinerColor0', 'NU_effCombinerColor1', 'NU_effMaxUV', 'NU_effOffsetUV', 'NU_effRotUV', 'NU_effScaleUV', 
    'NU_effSilhouetteColor', 'NU_effTransUV', 'NU_effUniverseParam', 'NU_effYGradColorBottom', 'NU_effYGradColorTop', 
    'NU_effYGradParam', 'NU_envDiffuseColor', 'NU_finalColorGain', 'NU_finalColorGain2', 'NU_finalColorGain3', 'NU_fogColor', 
    'NU_fogParams', 'NU_fresnelColor', 'NU_fresnelParams', 'NU_lightMapColorOffset', 'NU_materialHash', 'NU_normalParams', 
    'NU_normalSamplerAUV', 'NU_normalSamplerBUV', 'NU_normalSamplerUV', 'NU_postEffectReflection', 'NU_reflectionColor', 
    'NU_reflectionParams', 'NU_rotatePivotUV', 'NU_softLightingParams', 'NU_specularColor', 'NU_specularColorGain', 
    'NU_specularParams', 'NU_zOffset', 'NU_effMTBlendType', 'NU_effMTBlendParam0', 'NU_effMTBlendParam1', 'NU_effMTBlendAlpha']

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print(f'Usage: {sys.argv[0]} <source file>')
        exit(1)

    source_file = os.path.abspath(sys.argv[1])
    df = pd.read_csv(source_file)

    # Plot a correlation heatmap.
    plt.figure()
    labels = param_names
    sns.heatmap(df.corr(),vmin=-1.0,vmax=1.0, linewidth=0.25, cmap='coolwarm', xticklabels=labels, yticklabels=labels)
    plt.show()