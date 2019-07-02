# Material Flags
## Flags Overview
* Byte 1
    * First Nibble: Material Type
    * Second Nibble: Lighting
* Byte 2
* Byte 3
* Byte 4: Texture Flags & Effects

## Material types
* 9
* A
* B
* D
* E
* F  

## Lighting

| Hex | Stage Vertex Color | colorGain/Offset | Specular | Stage Lighting | Char Vertex Color |
| --- | --- | --- | --- | --- | --- |
| 0 | no | no  |     | no  | no |
| 2 | yes | no  |     | no  | no |
| 3 | no | no  |     | no  | no |
| 4 | yes | no  |     | yes | yes |
| 5 | no | no  |     |     | no |
| 6 | no | no  |     | yes | no |
| 7 | no | no  |     |     | no |
| 8 | no | no  | yes |     | no |
| A | no | no  | yes |     | yes |
| B | no | no  |     |     | no |
| C | no | yes | yes |     | yes |
| D | no | no  |     |     | no |
| E | no | no  |     |    | no |

## Byte 2
* 00
* 01
* 02
* 03
* 04
* 05
* 08
* 09
* 10
* 11
* 12
* 13
* 14
* 20
* 21
* 22
* 23
* 24
* 25
* 26
* 27
* 28
* 2A
* 2B
* 33
* 40
* 41
* 42
* 44
* 50
* 58
* 60
* 61
* 64
* 80
* 81
* 82
* 84
* 93
* A0
* A1
* B0
* C0
* C1
* C4
* C8
* C9
* CC
* D0
* D1
* D2
* E0
* E1
* E4
* F0

## Byte 3
* 00
* 01
* 05
* 10
* 11
* 12
* 14
* 15
* 16
* 19
* 1A
* 20
* 30
* 33
* 3A
* 3B
* 40
* 50
* 51
* 54
* 55
* 56
* 59
* 5C
* 5E
* 7A
* 7B
* 81
* 90
* 91
* 93
* 96
* 99
* 9D

## Byte 4
| Hex | Textures | Weird Textures |
| --- | ---- | ---|
| 00 | none    |  diffuse (effect material) |
| 01 | diffuse     |        |
| 03 | diffuse, normal     |        |
| 05 | diffuse, cube     |        |
| 06 | cube, normal     |        |
| 07 | diffuse, cube, normal     |        |
| 09 | diffuse, diffuse/ao     |        |
| 0D | diffuse, cube, diffuse/ao     |        |
| 11 | diffuse, sphere     |        |
| 21 | diffuse, dummy ramp     |        |
| 23 | diffuse, normal, dummy ramp |        |
| 27 | diffuse, normal, ramp, dummy ramp |        |
| 2B | diffuse, stage, normal, dummy ramp |        |
| 40 | none |        |
| 41 | diffuse     |        |
| 43 | diffuse, normal     |        |
| 45 | diffuse, cube     |        |
| 47 | diffuse, cube, normal     |        |
| 49 | diffuse, diffuse/ao     |        |
| 4D | diffuse, cube, ao |        |
| 61 | diffuse dummy ramp |        |
| 63 | diffuse, normal, dummy ramp | diffuse, diffuse, normal (9AE11163) |
| 65 | diffuse, diffuse2, ramp, dummy ramp     |        |
| 67 | diffuse, normal, ramp, dummy ramp | diffuse, cube, normal, dummy ramp (a6111067) |
| 69 | diffuse, stage, dummy ramp     |        |
| 6B | diffuse, stage, normal, dummy ramp |        |
| 71 | diffuse, sphere, dummy ramp     |        |
| 73 | diffuse, sphere, normal, dummy ramp |        |
| 75 | diffuse, sphere, diffuse2, ramp, dummy ramp     |        |
| 81 | diffuse     |        |
| 83 | diffuse, normal |        |
| 85 | diffuse, cube |        |
| 86 | cube, normal      |        |
| 89 | diffuse, diffuse/ao |        |
| C1 |      |        |
| C5 |      |        |
| E1 |      |        |
| E3 |      |        |
| E7 |      |        |


## Material Properties Flags
Certain material flags are required to use some material properties. Most
material properties don't require special flags. NU_colorOffset is a notable
exception and won't work unless `((flags & 9c400061) > 0)`. Effect materials
only work with a material type of `B`. Some material properties are only present
in materials with specific flags, which may or may not be required.

### Material Properties
| Material Property | Bitwise And | Example Flags|
| ------------- | ------------- | -------|
| NU_colorOffset| 9C400061 | 9C611061, FC440061, FC420061, FC420161 |
| NU_colorGain| 9C400061 | 9C611061, FC440061, FC420061, FC420161 |
| NU_specularColorGain| 9C400061 | 9C611061, FC440061 |
| NU_postEffectReflection | A6081047 | A6081047 |
| NU_finalColorGain |

### Effect Material Properties
| Material Property | Bitwise And | Example Flags|
| ------------- | ------------- | ------- |
| NU_effColorGain| B0000000 | B0E01000, B0201000, B0201000, B0241000 |
| NU_effUniverseParam | B0A01001 | B0A01001 |

# Flags Values From XML Materials
* 92000161
* 92001001
* 92001081
* 92001161
* 92011001
* 92011061
* 92021001
* 92041001
* 92101001
* 92401011
* 92409011
* 92501011
* 92C01101
* 92D01101
* 92F01101
* 94010061
* 94010063
* 94010161
* 94011021
* 94011061
* 94011063
* 94013063
* 94051063
* 95211175
* 95411165
* 96011069
* 9601106B
* 9601116B
* 9601306B
* 96015069
* 9605102B
* 9605106B
* 9605906B
* 9611106B
* 96C11069
* 96C1106B
* 96C1116B
* 96E11049
* 98011069
* 9801106B
* 9801906B
* 9809106B
* 98C1106B
* 9A001063
* 9A010063
* 9A011021
* 9A011023
* 9A011061
* 9A011063
* 9A0110E3
* 9A011163
* 9A013063
* 9A015061
* 9A211027
* 9A211065
* 9A211067
* 9A2110E7
* 9A2116E7
* 9A411073
* 9A415071
* 9A811061
* 9A811063
* 9AC11061
* 9AC11063
* 9AC11163
* 9AC15161
* 9AE11163
* 9AE11165
* 9C001063
* 9C009063
* 9C011063
* 9C610061
* 9C611061
* 9E01106B
* A0001040
* A2000000
* A2000001
* A2000501
* A2001001
* A2001021
* A2001041
* A2001081
* A2001101
* A2001141
* A2001181
* A20011C1
* A2001901
* A2001941
* A2001981
* A2003303
* A2003383
* A2005009
* A2005049
* A2010001
* A2011000
* A2011001
* A2011021
* A2011041
* A2011061
* A2011081
* A2011101
* A2011201
* A2011501
* A2011581
* A2011901
* A2011981
* A2013303
* A2013B03
* A2015009
* A2015049
* A2021001
* A2021041
* A2031001
* A2041001
* A2041081
* A2041101
* A2041901
* A2041981
* A2043B03
* A2081005
* A2081045
* A2091005
* A2101005
* A2101045
* A2111005
* A2111045
* A211500D
* A211504D
* A2121005
* A2121045
* A2131045
* A2200001
* A2200501
* A2200581
* A2201000
* A2201001
* A2201081
* A2201501
* A2201901
* A2201981
* A2201A81
* A2211406
* A2211486
* A2211581
* A2215009
* A2415009
* A2415049
* A2A05E89
* A2A09609
* A2E15C05
* A3215C05
* A3405181
* A3405901
* A3405981
* A3805101
* A3805901
* A3805981
* A3809901
* A3809941
* A3815941
* A3829901
* A3A05101
* A3A19001
* A3C01001
* A3C01081
* A3C01181
* A3C01201
* A3C01281
* A3C01901
* A3C01981
* A3C03303
* A3C03383
* A3C11001
* A3C11101
* A3C11181
* A3C11901
* A3C41001
* A3C81105
* A3CC1105
* A3D01045
* A3D11045
* A3D21105
* A3E01001
* A3E01081
* A3E01181
* A3E11001
* A3E41181
* A4001001
* A4001003
* A4001041
* A4001061
* A4001081
* A40010E1
* A4001101
* A4001981
* A4010001
* A4010041
* A4011001
* A4011041
* A4011043
* A4011061
* A4011101
* A4011901
* A4011981
* A4015009
* A4021001
* A4021041
* A4031001
* A4031041
* A4215009
* A4415009
* A4415049
* A5C01041
* A5C01081
* A5C010C1
* A5C01141
* A5C01181
* A5C11001
* A5C11041
* A6003307
* A6003347
* A6013307
* A6081005
* A6081045
* A6081047
* A6081085
* A6091005
* A6101005
* A6101045
* A6101047
* A61010C5
* A6111005
* A6111045
* A6111067
* A6121005
* A6121007
* A6121045
* A6131145
* A61311C5
* A62B1005
* A6331005
* A693564D
* A6B0560D
* A7809945
* A7C03307
* A7C91005
* A7C91905
* A8101045
* AA415049
* AA415609
* AA605E09
* AB809901
* AB819901
* ABA09601
* ABA15101
* ADA19101
* B0200000
* B0200100
* B0201000
* B0201100
* B0202000
* B0209300
* B0210000
* B0211000
* B0211100
* B0221000
* B0221100
* B0230000
* B0230100
* B0231000
* B0231100
* B0240000
* B0241000
* B0241100
* B0251100
* B0261100
* B0271000
* B0271100
* B0281100
* B0A01001
* B0C01000
* B0E01000
* D20010C1
* D2101101
* D2109001
* D2141101
* D2C01101
* D2C80101
* D2C81101
* D2D01001
* D4014061
* D4015061
* D601106B
* D6014069
* D6015069
* D6090069
* D6091069
* D609106B
* D6C1116B
* D6C90069
* D6C90169
* D6C91069
* D6C91169
* D801906B
* DA011061
* DA011063
* DA0110E3
* DA015061
* DA019063
* DA090061
* DA091061
* DAC90061
* DAC91061
* DAC91161
* E2015C09
* E2041001
* E2041101
* E2041901
* E2247B03
* E2408101
* E2409101
* E2411041
* E2413A03
* E2429D09
* E2445409
* E2445C09
* E2447A03
* E2581001
* E2641001
* E2647A03
* E2811001
* E2845901
* E2847A03
* E2849901
* E2A01109
* E4605109
* E4605509
* E62A3307
* F664006B
* F882006B
* FA220067
* FA240067
* FA600063
* FA640063
* FC420061
* FC420161
* FC440061
