![Logo](Penguin.webp)
# Penguin - AspNetCore - Templates
> Project Created by [**Top Nguyen**](http://topnguyen.net)

- This is Template Project for AspNetCore Frameworks [Puppy](https://github.com/stssoftware/Puppy) and AspNetCore Web [Monkey](https://github.com/stssoftware/Monkey)

- Trello Board: [[AspNetCore] Monkey - Puppy - Penguin](https://trello.com/b/6QCEBwcU)

# Table of Contents

- [Import Templates to Visual Studio](#import-templates-to-visual-studio)
- [Guide to Export Item as Template](#guide-to-export-item-as-template)
- [List Recommend Visual Studio Extensions](#list-recommend-visual-studio-extensions)
- [# List Recommend Visual Studio Extensions](#list-recommend-visual-studio-extensions)

# Import Templates to Visual Studio

1. Go to Visual Studio
2. Tool > Options
3. Search for: "Template"
4. User Item Template Location: `<Penguin folder>`
5. - Then Restart Visual Studio, try to use Add New Item and find `Puppy`, `
Monkey` Templates.

- If Templates still not appeared then try solution below:
1. Open CMD as Administrator
2. "cd" to VS Installed Folder:
`<Visual Studio installation path>\Common7\IDE\ProjectTemplates\` or `<Visual Studio installation path>\Common7\IDE\ItemTemplates\` 

then execute: `devenv /installvstemplates`

Ex:
```markup
> cd "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE"
> devenv /installvstemplates
```

see more: https://msdn.microsoft.com/en-us/library/y3kkate1.aspx

**Every time update Template, Need close all VS and run cmd above !**

# Guide to Export Item as Template

1. Export Template
- VS < 2017
> - Click on "File" > Export Template

- VS >= 2017
> - Click on "Project" > Export Template

2. Select Item Template
3. Select Solution have template
4. Give Name, Icon
5. Copy Export Zip file and use it like Import steps below.

**Second way to import item template**
1. Copy .Zip file to visual studio item Templates Without Unzip, Just keep .Zip file!
> - %userprofile%\documents\Visual Studio 2017\Templates\ItemTemplates
> - %userprofile%\documents\Visual Studio 2015\Templates\ItemTemplates

2. Then Restart Visual Studio, try to use Add New Item.
3. Done

# List Recommend Visual Studio Extensions

- [Resharper](http://www.jetbrains.com/resharper/) license by [Top Nguyen](http://resharper.topnguyen.net/): 

    ![Resharper](https://dl.dropboxusercontent.com/s/ijidwsishbnu5li/resharper.png?dl=0)
    
    ReSharper extends Visual Studio with over 1700 on-the-fly code inspections for C#, VB.NET, ASP.NET, JavaScript, TypeScript and other technologies. For most inspections, ReSharper provides quick-fixes (light bulbs) to improve code in one way or another.

- [CodeMaid](http://www.codemaid.net/)

    CodeMaid is an open source Visual Studio extension to cleanup and simplify our C#, C++, F#, VB, PHP, PowerShell, R, JSON, XAML, XML, ASP, HTML, CSS, LESS, SCSS, JavaScript and TypeScript coding.

    I usually use it for clean up my code, remove redundant using library in the code file.

    See full features and download at [this link](https://visualstudiogallery.msdn.microsoft.com/76293c4d-8c16-4f4a-aee6-21f83a571496)

- [Exporting Objects](http://www.omarelabd.net/exporting-objects-from-the-visual-studio-debugger/)

    Exporting Objects from the Visual Studio Debugger - very useful man!

- [BundlerMinifier](https://github.com/madskristensen/BundlerMinifier)

    A Visual Studio extension that let's you configure bundling and minification of JS, CSS and HTML files.

- [Web Compiler](https://github.com/madskristensen/WebCompiler)

    A Visual Studio extension that compiles LESS, Sass Stylus, JSX, ES6 and CoffeeScript files.

- [.ignore](https://github.com/madskristensen/IgnoreFiles)

    Support ignore files.

- [Markdown Editor](https://github.com/madskristensen/MarkdownEditor)

    A full featured Markdown editor with live preview and syntax highlighting. Supports GitHub flavored Markdown.

- [File Nesting](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileNesting)

    ![File Nesting](https://madskristensen.gallerycdn.vsassets.io/extensions/madskristensen/filenesting/2.6.67/1482139662744/Microsoft.VisualStudio.Services.Icons.Default)

    Automatically nest files based on file name and enables developers to nest and unnest any file manually

- [JavaScript Regions](https://github.com/madskristensen/JavaScriptRegions)

    Adds support for region comments in JavaScript and TypeScript files

- [Viasfora](http://viasfora.com/)

    Colorful, So good so "Buê Đuê" :trollface:

- [VS Color Output](http://mike-ward.net/vscoloroutput/)

    VSColorOutput can change the color of a line emitted to the output window based on specified rules. The rules consist of regular expressions. Rules map to classifications which in turn map to colors.

- [File Icons](https://github.com/madskristensen/FileIcons)

    Adds icons for files that are not recognized by Solution Explorer

- [Stop Build on first error](http://einaregilsson.com/stop-build-on-first-error-in-visual-studio-2010/)

    Stop Build on first error in Visual Studio

- [Analyze Assembly approach](https://blogs.msdn.microsoft.com/dotnet/2014/08/06/leveraging-existing-code-across-net-platforms/)

    Understanding portability with Visual Studio, Helping make the .NET framework better.

# List Recommend Resharper Extensions

## How to install extension for Resharper

- Go to `RESHARPER` > `Extension Manager...`

- [ReSharper Gallery](https://resharper-plugins.jetbrains.com/packages/)

## List of recommend extensions

- [ReSpeller Free](https://resharper-plugins.jetbrains.com/packages/EtherealCode.ReSpeller/)

- [![Logo](https://raw.github.com/MrJul/ReSharper.EnhancedTooltip/master/Logo/Logo32.png "Logo") ReSharper.EnhancedTooltip](https://resharper-plugins.jetbrains.com/packages/JLebosquain.EnhancedTooltip/)

    Enhanced Tooltip is a plugin for [JetBrains ReSharper](http://www.jetbrains.com/resharper/) that enhances the tooltip and parameter information popup.  

    - Colorizes tooltips and parameter information popups for C#.
    - Displays icons for identifiers and issues in the tooltip.
    - Uses the colors and font configured in Visual Studio.
    - Can optionally display more documentation (return type, remarks).
    - Can optionally display base type and implemented interfaces in the tooltip.
    - Can optionally display full attribute information in the tooltip.
    - Everything is configurable.

- [Configuration Sense for ReSharper](https://resharper-plugins.jetbrains.com/packages/Resharper.ConfigurationSense/)
    This extension provides autocomplete and validation for `App settings` and `Connection strings`.  

    ![Demo](https://github.com/olsh/resharper-configuration-sense/raw/master/images/demo.gif)