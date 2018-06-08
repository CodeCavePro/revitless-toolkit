Revit(less) Toolkit
=============

A cross-platform **Revit-less** toolkit for processing .rfa, .rvt and other files without [Revit](https://en.wikipedia.org/wiki/Autodesk_Revit)

[![Revit API](https://img.shields.io/badge/Revit%20API-2017-447788.svg)](http://www.revitapidocs.com/2017/)
[![NuGet version](https://img.shields.io/nuget/v/CodeCave.Revit.Toolkit.svg?label=NuGet)](https://www.nuget.org/packages/CodeCave.Revit.Toolkit/)
[![License](https://img.shields.io/github/license/codecavepro/revit-toolkit.svg)](https://github.com/CodeCavePro/revit-toolkit/blob/master/LICENSE.txt)
[![NuGet downloads](https://img.shields.io/nuget/dt/CodeCave.Revit.Toolkit.svg?label=NuGet%20downloads)](https://www.nuget.org/packages/CodeCave.Revit.Toolkit/)
[![GitHub downloads](https://img.shields.io/github/downloads/CodeCavePro/revit-toolkit/total.svg?label=GitHub%20downloads)](https://github.com/CodeCavePro/revit-toolkit/releases)

[![AppVeyor build status](https://img.shields.io/appveyor/ci/salaros/revit-toolkit/master.svg?logo=appveyor)](https://ci.appveyor.com/project/salaros/revit-toolkit/history)
[![AppVeyor tests](https://img.shields.io/appveyor/tests/salaros/revit-toolkit.svg)](https://ci.appveyor.com/project/salaros/revit-toolkit/build/tests)
[![Read the Docs (version)](https://img.shields.io/readthedocs/revit-toolkit/latest.svg)](http://revit-toolkit.readthedocs.io/en/latest/)

Installation
============

**Revit Toolkit** can be installed via [NuGet](https://www.nuget.org/packages?q=CodeCave.Revit)
by using Package Manager in your IDE, `dotnet` binary or Package Console

```bash
# Add the CodeCave.Revit package to a project named [<PROJECT>]
dotnet add [<PROJECT>] package CodeCave.Revit
```

or Visual Studio's Package Console

```powershell
# Add the CodeCave.Revit package to the default project
Install-Package CodeCave.Revit

# Add the CodeCave.Revit package to a project named [<PROJECT>]
Install-Package Elmah -ProjectName [<PROJECT>]
```

Usage
=====

**Revit Toolkit** provides various tools, you can easily find the full list by browsing the [documentation](http://revit-toolkit.readthedocs.io/en/latest/).

## Shared parameter file

```cs
var sharedParamFile = new SharedParameterFile(@"path/to/shared/parameter/file.txt");

// alternatively you can supply the content of the file
var sharedParamFile = new SharedParameterFile(File.ReadAllText(@"path/to/file.txt"));

// .. or you can create a completely new (empty) shared file
var sharedParamFile = new SharedParameterFile();

// .. or with some empty (with no parameters assigned yet) groups
var sharedParamFile = new SharedParameterFile(new Dictionary<string,int> { { "Identity Data", 100 } } );

sharedParamFile.Parameters.Add(
    new Guid("61ff3d56-09d7-4049-8c78-4abe745e4e5a"),"EquipmentName",
    "Identity Data", // Referencing group by name
    ParameterType.Text
);

sharedParamFile.Parameters.Add(
    new Guid("b5a53ea4-55d9-497c-8488-6607faa11e5f"), "EquipmentServed",
    new SharedParameterFile.Group("Identity Data", 100), // Creating group as object
    ParameterType.Text
);

sharedParamFile.Parameters.Add(
    new Guid("758c97dc-6b88-4fbd-9570-4affdc32f08d"), "EquipmentNumber",
    sharedParamFile.Groups.FirstOrDefault(g => "Identity Data".Equals(g.Name)), // Finding group dynamically
    ParameterType.Text
);


// Create a group object
var electricalGroup = new SharedParameterFile.Group("Electrical", 999);

// Add some parameters assigned to this group
sharedParamFile.Parameters.Add(
    new Guid("5031db93-bb19-454e-bea4-0f77d60f15e6"), "ApparentPower",
    electricalGroup, ParameterType.ElectricalApparentPower
);
sharedParamFile.Parameters.Add(
    new Guid("963abdb6-372f-496c-b99e-f11d8e0e5d20"), "Current",
    electricalGroup, ParameterType.ElectricalCurrent
);
sharedParamFile.Parameters.Add(
    new Guid("c006d4d6-0b12-42ad-8078-fe38ab8b1eff"), "Phases",
    "Electrical", // Using group's name, because we've just added parameters with a group object having the same name
    ParameterType.NumberOfPoles
);

// Write out shared parameters file to disk
sharedParamFile.Save("path/new/shared/file.txt");
```