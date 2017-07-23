![Logo](Penguin.webp)
# Penguin - AspNetCore - Templates
> Project Created by [**Top Nguyen**](http://topnguyen.net)

- This is Template Project for AspNetCore Frameworks [Puppy](https://github.com/stssoftware/Puppy) and AspNetCore Web [Monkey](https://github.com/stssoftware/Monkey)

## Import Templates to Visual Studio
1. Go to Visual Studio
2. Tool > Options
3. Search for: "Template"
4. User Item Template Location: <Penguin folder>
5. - Then Restart Visual Studio, try to use Add New Item and find Puppy, Monkey Templates.

- If Templates still not appeared then try solution below:
1. Open CMD as Administrator
2. "cd" to VS Installed Folder
```markup
> cd "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE"
> devenev /setup
```

** Every time update Template, Need close all VS and run cmd above ! **
see more: https://msdn.microsoft.com/en-us/library/y3kkate1.aspx

## Guide to Export Item as Template
1. Export Template
- VS < 2017
> - Click on "File" > Export Template

- VS >= 2017
> - Click on "Project" > Export Template

2. Select Item Template
3. Select Solution have template
4. Give Name, Icon
5. Copy Export Zip file and use it like Import steps below.

### Second way to import item template
1. Copy .Zip file to visual studio item Templates Without Unzip, Just keep .Zip file!
> - %userprofile%\documents\Visual Studio 2017\Templates\ItemTemplates
> - %userprofile%\documents\Visual Studio 2015\Templates\ItemTemplates

2. Then Restart Visual Studio, try to use Add New Item.
3. Done
