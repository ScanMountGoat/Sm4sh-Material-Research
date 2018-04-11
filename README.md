# Sm4sh Wii U Material Research
A collection of random notes, tools, and data for understanding NUD materials in
Smash 4 for Wii U.

## XML Materials
This folder contains material XML files exported from Smash Forge for many of
the models from Smash 4. The 7zip file contains the materials for all fighter
models, trophy models, and stage models in the melee folder.
Material Count: ~105,000  
Model Count: ~6,200  

## Find String
A basic command line application for printing the file paths of all files that
contain a particular string in the given directory and subdirectories. This is
useful for seeing what types of models use a particular material property and
how often it is used. Searching for "NU_" will print all files containing a
material property name, for example.

Usage example:  
`FindString.exe "Smash XML Materials" SORTBIAS .xml`   

## Searching Material XML Files
[Material-XML](https://github.com/ScanMountGoat/Smash-Material-XML) is a desktop application for
searching for specific XML materials. See the ReadMe page for details.
