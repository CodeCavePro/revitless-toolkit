#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.Plumbing.PipeFlowConfigurationType
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>An enumerated type listing all connector flow configuration.</summary>
    public enum PipeFlowConfigurationType
    {
        /// <summary>Flow configuration is calculated.</summary>
        Calculated,
        /// <summary>Flow configuration is Preset.</summary>
        Preset,
        /// <summary>Flow configuration depends on system.</summary>
        System,
        /// <summary>Flow configuration depends on demand.</summary>
        Demand,
    }
}
