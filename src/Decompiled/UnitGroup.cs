#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.UnitGroup
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>A group of related unit types, primarily classified by discipline.</summary>
    /// <since>2014.</since>
    public enum UnitGroup
    {
        /// <summary>Common.</summary>
        Common,
        /// <summary>Structural.</summary>
        Structural,
        /// <summary>HVAC.</summary>
        HVAC,
        /// <summary>Electrical.</summary>
        Electrical,
        /// <summary>Piping.</summary>
        Piping,
        /// <summary>Energy.</summary>
        Energy,
        /// <summary>Infrastructure.</summary>
        Infrastructure,
    }
}
