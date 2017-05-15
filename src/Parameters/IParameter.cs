using System;

namespace CodeCave.Revit.Toolkit.Parameters
{
    interface IParameter
    {
        Guid Guid { get; }

        bool IsShared { get; }

        DisplayUnitType DisplayUnitType { get; }
    }
}
