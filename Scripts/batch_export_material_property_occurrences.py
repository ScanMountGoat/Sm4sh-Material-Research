import os
import sys
import xml.etree.ElementTree as ET

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

def parse_xml(file_text, rows):
    root = ET.fromstring(file_text)
    for mesh in root:
        for poly in mesh:
            for material in poly:
                # 1 if parameter is present and 0 otherwise.
                row_values = ['0'] * len(param_names)
                for param_node in material:
                    if param_node.tag == 'param':
                        name = param_node.attrib['name']
                        row_values[param_names.index(name)] = '1'
                        rows.append(','.join(row_values))


if __name__ == '__main__':
    if len(sys.argv) < 3:
        print(f'Usage: {sys.argv[0]} <source folder> <destination file>')
        exit(1)

    source_folder = os.path.abspath(sys.argv[1])
    destination_file = os.path.abspath(sys.argv[2])

    # Add csv header.
    rows = [','.join(param_names)]

    # Parse all the xml files to find all possible values for each material parameter.
    for root, directories, file_paths in os.walk(source_folder):
        for path in file_paths:
            if '.xml' in path:
                abs_path = os.path.join(root, path)
                with open(abs_path, 'r') as file:
                    data = file.read().encode('utf-16-be')
                    parse_xml(data, rows)

    # Write results to a file.
    with open(destination_file, 'w') as file:
        file.write('\n'.join(rows))