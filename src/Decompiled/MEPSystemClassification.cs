#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.MEPSystemClassification
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll

namespace Autodesk.Revit.DB
{
    /// <summary>
    ///    This enumeration is used to classify MEP connectors and systems
    ///    and drives certain behavior for a particular system type.
    /// </summary>
    /// <since>2012.</since>
    public enum MEPSystemClassification
    {
        /// <summary>A system classification not yet defined.</summary>
        UndefinedSystemClassification,
        /// <summary>A supply air duct system.</summary>
        SupplyAir,
        /// <summary>A return air duct system.</summary>
        ReturnAir,
        /// <summary>Obsolete classification not used anymore.</summary>
        ExhaustAir,
        /// <summary>An user classified air duct system.</summary>
        OtherAir,
        /// <summary>An electrical data circuit.</summary>
        DataCircuit,
        /// <summary>An electrical circuit.</summary>
        PowerCircuit,
        /// <summary>A hydronic supply piping system.</summary>
        SupplyHydronic,
        /// <summary>A hydronic return piping system.</summary>
        ReturnHydronic,
        /// <summary>An electrical circuit classified as telephone.</summary>
        Telephone,
        /// <summary>An electrical security circuit.</summary>
        Security,
        /// <summary>An electrical fire alarm circuit.</summary>
        FireAlarm,
        /// <summary>An electrical circuit classified as nurse call.</summary>
        NurseCall,
        /// <summary>An electrical circuit classified as controls.</summary>
        Controls,
        /// <summary>An electrical circuit classified as communication.</summary>
        Communication,
        /// <summary>Reserved for future use.</summary>
        CondensateDrain,
        /// <summary>A sanitary piping system.</summary>
        Sanitary,
        /// <summary>A piping ventilation system.</summary>
        Vent,
        /// <summary>Reserved for future use.</summary>
        Storm,
        /// <summary>A hot water piping system.</summary>
        DomesticHotWater,
        /// <summary>A cold water piping system.</summary>
        DomesticColdWater,
        /// <summary>Reserved for future use.</summary>
        Recirculation,
        /// <summary>An user classified piping system.</summary>
        OtherPipe,
        /// <summary>A wet fire protection system.</summary>
        FireProtectWet,
        /// <summary>A dry fire protection system.</summary>
        FireProtectDry,
        /// <summary>A preaction fire protection system.</summary>
        FireProtectPreaction,
        /// <summary>A user defined fire protection system.</summary>
        FireProtectOther,
        /// <summary>An electrical switch system.</summary>
        SwitchTopology,
        /// <summary>Reserved for application usage, used for UI filtering in Family Editor.</summary>
        Fitting,
        /// <summary>Reserved for application usage, used for UI filtering in Family Editor.</summary>
        Global,
        /// <summary>Equivalent with PowerCircuit.</summary>
        PowerBalanced,
        /// <summary>Equivalent with PowerCircuit.</summary>
        PowerUnBalanced,
        /// <summary>Indicates the default type for cable trays and conduits.</summary>
        CableTrayConduit,
    }
}
