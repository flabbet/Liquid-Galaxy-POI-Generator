# Liquid-Galaxy-POI-Generator
Generates Liquid Galaxy POI text file based on decompressed .KMZ files.

# Builds

## How to build: 

1. Open Terminal
2. cd into ```\lg_POI_generator\lgPOICreator```
3. Type ```dotnet publish lgPOICreator.sln -c Release -r yoursystem``` (In yoursystem type your OS relating to [this](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog) link.

## Open in Visual Studio like program

Just open .sln file

# Usage

1. Make sure that every file that you want to include must be in common folder.
2. Type that directory in program.
3. Program will tell you how many .KMZ files found and ask you to confirm if it is correct.
4. Enter output directory (!WITH FILE NAME AND EXTENSION!) ex. ```E:\Desktop\POI Drawer\Queries.txt```
5. Enter on which planet the points of interest are located.
6. If everything was done correctily program will generate file in choosen directory.
