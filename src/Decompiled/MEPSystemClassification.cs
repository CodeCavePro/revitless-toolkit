// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.MEPSystemClassification
// Assembly: RevitAPI, Version=17.0.0.0, Culture=neutral, PublicKeyToken=null
// ReSharper disable InconsistentNaming

#pragma warning disable 1591

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    ///    This enumeration is used to classify MEP connectors and systems
    ///    and drives certain behavior for a particular system type
    /// </summary>
    /// <since>2012</since>
    public enum MEPSystemClassification
    {
        UndefinedSystemClassification,
        SupplyAir,
        ReturnAir,
        ExhaustAir,
        OtherAir,
        DataCircuit,
        PowerCircuit,
        SupplyHydronic,
        ReturnHydronic,
        Telephone,
        Security,
        FireAlarm,
        NurseCall,
        Controls,
        Communication,
        CondensateDrain,
        Sanitary,
        Vent,
        Storm,
        DomesticHotWater,
        DomesticColdWater,
        Recirculation,
        OtherPipe,
        FireProtectWet,
        FireProtectDry,
        FireProtectPreaction,
        FireProtectOther,
        SwitchTopology,
        Fitting,
        Global,
        PowerBalanced,
        PowerUnBalanced,
        CableTrayConduit,
    }
}
