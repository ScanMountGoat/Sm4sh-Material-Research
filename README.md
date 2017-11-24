# Sm4sh Wii U Material Research
A collection of random notes, tools, and data for understanding NUD materials in Smash 4 for Wii U.

## XML Materials
This folder contains material XML files exported from Smash Forge for many of the models from Smash 4. The 7zip file contains the materials for all fighter models, trophy models, and stage models in the melee folder. 

## Find String
A basic command line application for printing the file paths of all files that contain a particular string in the given directory and subdirectories. This is useful for seeing what types of models use a particular material property and how often it is used.

`FindString.exe path string extension`   

## Analyze Material XML
A command line application for processing multiple material XML files exported from Smash Forge. The XML importing code draws heavily from the code used by Smash Forge for converting an XML file to NUD materials. The license for Smash Forge can be found [here](https://github.com/jam1garner/Smash-Forge/blob/master/License.txt). 
