# Transparency
Smash 4 uses alpha blending and alpha testing to create transparency effects. Various methods of
sorting meshes are used to ensure the alpha blending renders properly.

## SrcFactor
| Value | Description|
| --- | --- |
| 0x0 | |
| 0x1 | |


## DstFactor
| Value | Description|
| --- | --- |
| 0x0 | |
| 0x1 | |

## Blending Function
The blend function is normally set to add. The function depends on the SrcFactor and DstFactor and can't be set directly.

## Alpha Test
The alpha test controls whether the alpha test is used. When disabled, fragments will always pass the alpha test.

| Value | Description|
| --- | --- |
| 0x0 | Disabled |
| 0x2 | Enabled |

## Alpha Function
The alpha function determines when a fragment passes the alpha test. Fragments that don't pass the alpha test are discarded. The reference alpha value has values of 0 to 255.

| Value | Description|
| --- | --- |
| 0x0 | Never |
| 0x4 | Greater or Equal |
| 0x6 | Greater or Equal |
