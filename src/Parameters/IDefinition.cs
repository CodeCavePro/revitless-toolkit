using System;

namespace CodeCave.Revit.Toolkit.Parameters
{
    interface IDefinition
    {
        string Name { get; }

        UnitType UnitType { get; }

        BuiltInParameterGroup ParameterGroup { get; }

        ParameterType ParameterType { get; }
    }
}
