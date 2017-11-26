# Material Flags
## Flags Overview
* Byte 1
    * First Nibble: Material Type
    * Second Nibble: Lighting
* Byte 2
* Byte 3
* Byte 4: Texture Flags & Effects

## Material types
## Lighting
## Byte 2
## Byte 3
## Byte 4
| Texture | 4th Byte |
| ---- | --- |
| Diffuse | 01 |

## Material Properties Flags
Certain material flags are required to use some material properties. Most
material properties don't require special flags. NU_colorOffset is a notable
exception and won't work unless `((flags & 9c400061) > 0)`. Effect materials
only work with a material type of `B`. Some material properties are only present
in materials with specific flags, which may or may not be required.

### Material Properties
| Material Property | Bitwise And | Example Flags|
| ------------- | ------------- |
| NU_colorOffset| 9C400061 | 9C611061, FC440061, FC420061, FC420161 |
| NU_colorGain| 9C400061 | 9C611061, FC440061, FC420061, FC420161 |
| NU_specularColorGain| 9C400061 | 9C611061, FC440061 |
| NU_postEffectReflection | A6081047 | A6081047 |

### Effect Material Properties
| Material Property | Bitwise And | Example Flags|
| ------------- | ------------- |
| NU_effColorGain| B0000000 | B0E01000, B0201000, B0201000, B0241000 |
| NU_effUniverseParam | B0A01001 | B0A01001 |
