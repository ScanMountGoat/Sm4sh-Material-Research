# Transparency
Smash 4 uses alpha blending and alpha testing to create transparency effects. Various methods of
sorting meshes are used to ensure the alpha blending renders properly.

## SrcFactor
| Value | Blending Factor|
| --- | --- |
| 0x0 | One |
| 0x1 | Source Alpha |
| 0x2 | One |
| 0x3 | Source Alpha |
| 0x4 | Zero |
| 0x5 | Source Alpha |
| 0x6 | Destination Alpha |
| 0x7 | Destination Alpha |
| 0x8 | Destination Color |

## DstFactor
| Value | Blending Factor | Blend Function |
| --- | --- | --- |
| 0x0 | Zero | Add |
| 0x1 | One Minus Source Alpha | Add |
| 0x2 | One | Add |
| 0x3 | One | Reverse Subtract |
| 0x4 | Source Alpha | Add |
| 0x5 | Source Alpha | Reverse Sutract |
| 0x6 | One Minus Destination Alpha | Add |
| 0x7 | One | Add |
| 0x8 | Zero | Add |

## Alpha Test
The alpha test controls whether the alpha test is used. When disabled, fragments will always pass
the alpha test.

| Value | Description|
| --- | --- |
| 0x0 | Disabled |
| 0x2 | Enabled |

## Alpha Function
The alpha function determines when a fragment passes the alpha test. Fragments that don't pass the
alpha test are discarded. The reference alpha value has values of 0 to 255.

| Value | Description|
| --- | --- |
| 0x0 | Never |
| 0x4 | Greater or Equal |
| 0x6 | Greater or Equal |

## Render Order (WIP)
NUD models are organized into named meshes which can contain one or more polygons. Polygons refer to
a collection of vertices and materials. Materials that use alpha blending are sorted differently
than materials that do not.

Opaque polygons that do not use alpha blending are rendered in the order they are defined. Depth
testing makes the render order for opaque polygons not as crucial.

Transparent polygons that use alpha blending are rendered after all opaque polygons for a model have
been rendered. The order for transparent polygons depends on many factors such as mesh name,
bounding spheres, etc.
