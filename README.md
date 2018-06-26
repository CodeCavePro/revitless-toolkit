RevitLESS Toolkit
=============

A cross-platform **Revit-less** toolkit for processing .rfa, .rvt and other files without [Revit](https://en.wikipedia.org/wiki/Autodesk_Revit)

[![Revit API](https://img.shields.io/badge/Revit%20API-2017-447788.svg)](http://www.revitapidocs.com/2017/)
[![NuGet version](https://img.shields.io/nuget/v/CodeCave.Revit.Toolkit.svg?label=NuGet)](https://www.nuget.org/packages/CodeCave.Revit.Toolkit/)
[![Revit API](https://img.shields.io/badge/.NET%20Standard-2.0-484877.svg)](https://social.msdn.microsoft.com/Forums/vstudio/en-US/7035edc6-97fc-49ee-8eee-2fa4d040a63b/)
[![Revit API](https://img.shields.io/badge/.NET%20Framework-4.5.2+-748478.svg)](https://social.msdn.microsoft.com/Forums/vstudio/en-US/7035edc6-97fc-49ee-8eee-2fa4d040a63b/)

[![License](https://img.shields.io/github/license/codecavepro/revit-toolkit.svg)](https://github.com/CodeCavePro/revit-toolkit/blob/master/LICENSE.txt)
[![NuGet downloads](https://img.shields.io/nuget/dt/CodeCave.Revit.Toolkit.svg?label=NuGet%20downloads)](https://www.nuget.org/packages/CodeCave.Revit.Toolkit/)
[![GitHub downloads](https://img.shields.io/github/downloads/CodeCavePro/revit-toolkit/total.svg?label=GitHub%20downloads&colorB=8e8cba)](https://github.com/CodeCavePro/revit-toolkit/releases)

[![AppVeyor build status](https://img.shields.io/appveyor/ci/salaros/revit-toolkit/master.svg?logo=appveyor)](https://ci.appveyor.com/project/salaros/revit-toolkit/history)
[![AppVeyor tests](https://img.shields.io/appveyor/tests/salaros/revit-toolkit.svg)](https://ci.appveyor.com/project/salaros/revit-toolkit/build/tests)
[![Coverage Status](https://coveralls.io/repos/github/CodeCavePro/revit-toolkit/badge.svg?branch=master)](https://coveralls.io/github/CodeCavePro/revit-toolkit?branch=master)
[![Read the Docs (version)](https://img.shields.io/readthedocs/revit-toolkit/latest.svg)](http://revit-toolkit.readthedocs.io/en/latest/)

Installation
============

**RevitLESS Toolkit** can be installed via [NuGet](https://www.nuget.org/packages?q=CodeCave.Revit)
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
Install-Package CodeCave.Revit -ProjectName [<PROJECT>]
```

Usage
=====

**RevitLESS Toolkit** provides various tools, you can easily find the full list by browsing the [documentation](http://revit-toolkit.readthedocs.io/en/latest/).

## Shared parameter file

One of the most interesting tools is Revit [shared parameter file](https://knowledge.autodesk.com/support/revit-products/learn-explore/caas/CloudHelp/cloudhelp/2018/ENU/Revit-Model/files/GUID-E7D12B71-C50D-46D8-886B-8E0C2B285988-htm.html) reading and manipulation.

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
    "Electrical", // Using group's name, because it's just added parameters with a group object having the same name
    ParameterType.NumberOfPoles
);

// Write out shared parameters file to disk
sharedParamFile.Save("path/a/new/shared/file.txt");
```

## Catalog type file

This is a pretty useful tool for easily creating and then writing out Revit [type catalog files](https://knowledge.autodesk.com/support/revit-products/learn-explore/caas/CloudHelp/cloudhelp/2016/ENU/Revit-Customize/files/GUID-FFA71D72-D4C5-416D-BF65-1757657C3CE9-htm.html).

```cs
var catalogTypeFile = new TypeCatalogFile();
var iPhoneCommonParameters = new List<IParameterWithValue>
{
    new TypeCatalogFile.Parameter<string>("Manufacturer", ParameterType.Text, "Apple"),
    new TypeCatalogFile.Parameter<string>("Model", ParameterType.Text, "A1549"),
    new TypeCatalogFile.Parameter<double>("Width", ParameterType.Length, 77.8, DisplayUnitType.DUT_MILLIMETERS),
    new TypeCatalogFile.Parameter<double>("Depth", ParameterType.Length, 6.9, DisplayUnitType.DUT_MILLIMETERS),
    new TypeCatalogFile.Parameter<double>("Height", ParameterType.Length, 158.1, DisplayUnitType.DUT_MILLIMETERS),
};

catalogTypeFile.Add("MG562LL/A", iPhoneCommonParameters.Concat(new List<IParameterWithValue>
{
    new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG562LL/A"),
    new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 16GB Gold (GSM) T-Mobile"),
    new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 299.90),
    new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "$"),
    new TypeCatalogFile.Parameter<int>("Storage GB", 16),
    new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, false),
}).ToArray());
catalogTypeFile.Add("MG5D2LL/A", iPhoneCommonParameters.Concat(new List<IParameterWithValue>
{
    new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG5D2LL/A"),
    new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 64GB Gold (GSM) T-Mobile"),
    new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 380.0),
    new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "$"),
    new TypeCatalogFile.Parameter<int>("Storage GB", 32),
    new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, false),
}).ToArray());
catalogTypeFile.Add("MG3A2CL/A", iPhoneCommonParameters.Concat(new List<IParameterWithValue>
{
    new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG3A2CL/A"),
    new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 16GB Space Grey Unlocked"),
    new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 600.0),
    new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "CAD"),
    new TypeCatalogFile.Parameter<int>("Storage GB", 16),
    new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, true),
}).ToArray());

// Write out type catalog file to disk
catalogTypeFile.Save("path/a/new/shared/file.txt");
```
