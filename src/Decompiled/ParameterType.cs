#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.ParameterType
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    ///    An enumerated type listing all of the data type interpretation that Autodesk Revit supports.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>The parameter type is invalid. This value should not be used.</summary>
        Invalid = 0,
        /// <summary>The parameter data should be interpreted as a string of text.</summary>
        Text = 1,
        /// <summary>
        ///    The parameter data should be interpreted as a whole number, positive or negative.
        /// </summary>
        Integer = 2,
        /// <summary>
        ///    The parameter data should be interpreted as a real number, possibly including decimal points.
        /// </summary>
        Number = 3,
        /// <summary>The parameter data represents a length.</summary>
        Length = 4,
        /// <summary>The parameter data represents an area.</summary>
        Area = 5,
        /// <summary>The parameter data represents a volume.</summary>
        Volume = 6,
        /// <summary>The parameter data represents an angle.</summary>
        Angle = 7,
        /// <summary>A text string that represents a web address.</summary>
        URL = 8,
        /// <summary>The value of this property is considered to be a material.</summary>
        Material = 9,
        /// <summary>A boolean value that will be represented as Yes or No.</summary>
        YesNo = 10, // 0x0000000A
        /// <summary>The data value will be represented as a force.</summary>
        Force = 11, // 0x0000000B
        /// <summary>The data value will be represented as a linear force.</summary>
        LinearForce = 12, // 0x0000000C
        /// <summary>The data value will be represented as an area force.</summary>
        AreaForce = 13, // 0x0000000D
        /// <summary>The data value will be represented as a moment.</summary>
        Moment = 14, // 0x0000000E
        /// <summary>
        ///    A parameter value that represents the number of poles, as used in electrical disciplines.
        /// </summary>
        NumberOfPoles = 15, // 0x0000000F
        /// <summary>
        ///    A parameter value that represents the fixture units, as used in piping disciplines.
        /// </summary>
        FixtureUnit = 16, // 0x00000010
        /// <summary>
        ///    A parameter used to control the type of a family nested within another family.
        /// </summary>
        FamilyType = 17, // 0x00000011
        /// <summary>
        ///    A parameter value that represents the load classification units, as used in electrical disciplines.
        /// </summary>
        LoadClassification = 18, // 0x00000012
        /// <summary>The value of this parameter is the id of an image.</summary>
        Image = 19, // 0x00000013
        /// <summary>The value of this parameter will be represented as multiline text.</summary>
        MultilineText = 20, // 0x00000014
        /// <summary>The data value will be represented as a HVACDensity.</summary>
        HVACDensity = 107, // 0x0000006B
        /// <summary>The data value will be represented as a HVACEnergy.</summary>
        HVACEnergy = 108, // 0x0000006C
        /// <summary>The data value will be represented as a HVACFriction.</summary>
        HVACFriction = 109, // 0x0000006D
        /// <summary>The data value will be represented as a HVACPower.</summary>
        HVACPower = 110, // 0x0000006E
        /// <summary>The data value will be represented as a HVACPowerDensity.</summary>
        HVACPowerDensity = 111, // 0x0000006F
        /// <summary>The data value will be represented as a HVACPressure.</summary>
        HVACPressure = 112, // 0x00000070
        /// <summary>The data value will be represented as a HVACTemperature.</summary>
        HVACTemperature = 113, // 0x00000071
        /// <summary>The data value will be represented as a HVACVelocity.</summary>
        HVACVelocity = 114, // 0x00000072
        /// <summary>The data value will be represented as a HVACAirflow.</summary>
        HVACAirflow = 115, // 0x00000073
        /// <summary>The data value will be represented as a HVACDuctSize.</summary>
        HVACDuctSize = 116, // 0x00000074
        /// <summary>The data value will be represented as a HVACCrossSection.</summary>
        HVACCrossSection = 117, // 0x00000075
        /// <summary>The data value will be represented as a HVACHeatGain.</summary>
        HVACHeatGain = 118, // 0x00000076
        /// <summary>The data value will be represented as an ElectricalCurrent.</summary>
        ElectricalCurrent = 119, // 0x00000077
        /// <summary>The data value will be represented as an ElectricalPotential.</summary>
        ElectricalPotential = 120, // 0x00000078
        /// <summary>The data value will be represented as an ElectricalFrequency.</summary>
        ElectricalFrequency = 121, // 0x00000079
        /// <summary>The data value will be represented as an ElectricalIlluminance.</summary>
        ElectricalIlluminance = 122, // 0x0000007A
        /// <summary>The data value will be represented as an ElectricalLuminousFlux.</summary>
        ElectricalLuminousFlux = 123, // 0x0000007B
        /// <summary>The data value will be represented as an ElectricalPower.</summary>
        ElectricalPower = 124, // 0x0000007C
        /// <summary>The data value will be represented as a HVACRoughness.</summary>
        HVACRoughness = 125, // 0x0000007D
        /// <summary>The data value will be represented as an ElectricalApparentPower.</summary>
        ElectricalApparentPower = 134, // 0x00000086
        /// <summary>The data value will be represented as an ElectricalPowerDensity.</summary>
        ElectricalPowerDensity = 135, // 0x00000087
        /// <summary>The data value will be represented as a PipingDensity.</summary>
        PipingDensity = 136, // 0x00000088
        /// <summary>The data value will be represented as a PipingFlow.</summary>
        PipingFlow = 137, // 0x00000089
        /// <summary>The data value will be represented as a PipingFriction.</summary>
        PipingFriction = 138, // 0x0000008A
        /// <summary>The data value will be represented as a PipingPressure.</summary>
        PipingPressure = 139, // 0x0000008B
        /// <summary>The data value will be represented as a PipingTemperature.</summary>
        PipingTemperature = 140, // 0x0000008C
        /// <summary>The data value will be represented as a PipingVelocity.</summary>
        PipingVelocity = 141, // 0x0000008D
        /// <summary>The data value will be represented as a PipingViscosity.</summary>
        PipingViscosity = 142, // 0x0000008E
        /// <summary>The data value will be represented as a PipeSize.</summary>
        PipeSize = 143, // 0x0000008F
        /// <summary>The data value will be represented as a PipingRoughness.</summary>
        PipingRoughness = 144, // 0x00000090
        /// <summary>The data value will be represented as a Stress.</summary>
        Stress = 145, // 0x00000091
        /// <summary>The data value will be represented as a UnitWeight.</summary>
        UnitWeight = 146, // 0x00000092
        /// <summary>The data value will be represented as a ThermalExpansion.</summary>
        ThermalExpansion = 147, // 0x00000093
        /// <summary>The data value will be represented as a LinearMoment.</summary>
        LinearMoment = 148, // 0x00000094
        /// <summary>The data value will be represented as a ForcePerLength.</summary>
        ForcePerLength = 150, // 0x00000096
        /// <summary>The data value will be represented as a ForceLengthPerAngle.</summary>
        ForceLengthPerAngle = 151, // 0x00000097
        /// <summary>The data value will be represented as a LinearForcePerLength.</summary>
        LinearForcePerLength = 152, // 0x00000098
        /// <summary>The data value will be represented as a LinearForceLengthPerAngle.</summary>
        LinearForceLengthPerAngle = 153, // 0x00000099
        /// <summary>The data value will be represented as an AreaForcePerLength.</summary>
        AreaForcePerLength = 154, // 0x0000009A
        /// <summary>The data value will be represented as a PipingVolume.</summary>
        PipingVolume = 155, // 0x0000009B
        /// <summary>The data value will be represented as a HVACViscosity.</summary>
        HVACViscosity = 156, // 0x0000009C
        /// <summary>The data value will be represented as a HVACCoefficientOfHeatTransfer.</summary>
        HVACCoefficientOfHeatTransfer = 157, // 0x0000009D
        /// <summary>The data value will be represented as a HVACAirflowDensity.</summary>
        HVACAirflowDensity = 158, // 0x0000009E
        /// <summary>The data value will be represented as a Slope.</summary>
        Slope = 159, // 0x0000009F
        /// <summary>The data value will be represented as a HVACCoolingLoad.</summary>
        HVACCoolingLoad = 160, // 0x000000A0
        /// <summary>The data value will be represented as a HVACCoolingLoadDividedByArea.</summary>
        HVACCoolingLoadDividedByArea = 161, // 0x000000A1
        /// <summary>The data value will be represented as a HVACCoolingLoadDividedByVolume.</summary>
        HVACCoolingLoadDividedByVolume = 162, // 0x000000A2
        /// <summary>The data value will be represented as a HVACHeatingLoad.</summary>
        HVACHeatingLoad = 163, // 0x000000A3
        /// <summary>The data value will be represented as a HVACHeatingLoadDividedByArea.</summary>
        HVACHeatingLoadDividedByArea = 164, // 0x000000A4
        /// <summary>The data value will be represented as a HVACHeatingLoadDividedByVolume.</summary>
        HVACHeatingLoadDividedByVolume = 165, // 0x000000A5
        /// <summary>The data value will be represented as a HVACAirflowDividedByVolume.</summary>
        HVACAirflowDividedByVolume = 166, // 0x000000A6
        /// <summary>The data value will be represented as a HVACAirflowDividedByCoolingLoad.</summary>
        HVACAirflowDividedByCoolingLoad = 167, // 0x000000A7
        /// <summary>The data value will be represented as a HVACAreaDividedByCoolingLoad.</summary>
        HVACAreaDividedByCoolingLoad = 168, // 0x000000A8
        /// <summary>The data value will be represented as a WireSize.</summary>
        WireSize = 169, // 0x000000A9
        /// <summary>The data value will be represented as a HVACSlope.</summary>
        HVACSlope = 170, // 0x000000AA
        /// <summary>The data value will be represented as a PipingSlope.</summary>
        PipingSlope = 171, // 0x000000AB
        /// <summary>The data value will be represented as a Currency.</summary>
        Currency = 172, // 0x000000AC
        /// <summary>The data value will be represented as an ElectricalEfficacy.</summary>
        ElectricalEfficacy = 173, // 0x000000AD
        /// <summary>The data value will be represented as an ElectricalWattage.</summary>
        ElectricalWattage = 174, // 0x000000AE
        /// <summary>The data value will be represented as a ColorTemperature.</summary>
        ColorTemperature = 175, // 0x000000AF
        /// <summary>The data value will be represented as an ElectricalLuminousIntensity.</summary>
        ElectricalLuminousIntensity = 177, // 0x000000B1
        /// <summary>The data value will be represented as an ElectricalLuminance.</summary>
        ElectricalLuminance = 178, // 0x000000B2
        /// <summary>The data value will be represented as a HVACAreaDividedByHeatingLoad.</summary>
        HVACAreaDividedByHeatingLoad = 179, // 0x000000B3
        /// <summary>The data value will be represented as a HVACFactor.</summary>
        HVACFactor = 180, // 0x000000B4
        /// <summary>The data value will be represented as a ElectricalTemperature.</summary>
        ElectricalTemperature = 181, // 0x000000B5
        /// <summary>The data value will be represented as a ElectricalCableTraySize.</summary>
        ElectricalCableTraySize = 182, // 0x000000B6
        /// <summary>The data value will be represented as a ElectricalConduitSize.</summary>
        ElectricalConduitSize = 183, // 0x000000B7
        /// <summary>The data value will be represented as a ReinforcementVolume.</summary>
        ReinforcementVolume = 184, // 0x000000B8
        /// <summary>The data value will be represented as a ReinforcementLength.</summary>
        ReinforcementLength = 185, // 0x000000B9
        /// <summary>The data value will be represented as a ElectricalDemandFactor.</summary>
        ElectricalDemandFactor = 186, // 0x000000BA
        /// <summary>The data value will be represented as a HVACDuctInsulationThickness.</summary>
        HVACDuctInsulationThickness = 187, // 0x000000BB
        /// <summary>The data value will be represented as a HVACDuctLiningThickness.</summary>
        HVACDuctLiningThickness = 188, // 0x000000BC
        /// <summary>The data value will be represented as a PipeInsulationThickness.</summary>
        PipeInsulationThickness = 189, // 0x000000BD
        /// <summary>The data value will be represented as a HVACThermalResistance.</summary>
        HVACThermalResistance = 190, // 0x000000BE
        /// <summary>The data value will be represented as a HVACThermalMass.</summary>
        HVACThermalMass = 191, // 0x000000BF
        /// <summary>The data value will be represented as an Acceleration.</summary>
        Acceleration = 192, // 0x000000C0
        /// <summary>The data value will be represented as a BarDiameter.</summary>
        BarDiameter = 193, // 0x000000C1
        /// <summary>The data value will be represented as a CrackWidth.</summary>
        CrackWidth = 194, // 0x000000C2
        /// <summary>The data value will be represented as a DisplacementDeflection.</summary>
        DisplacementDeflection = 195, // 0x000000C3
        /// <summary>The data value will be represented as an Energy.</summary>
        Energy = 196, // 0x000000C4
        /// <summary>The data value will be represented as a StructuralFrequency.</summary>
        StructuralFrequency = 197, // 0x000000C5
        /// <summary>The data value will be represented as a Mass.</summary>
        Mass = 198, // 0x000000C6
        /// <summary>The data value will be represented as a MassPerUnitLength.</summary>
        MassPerUnitLength = 199, // 0x000000C7
        /// <summary>The data value will be represented as a MomentOfInertia.</summary>
        MomentOfInertia = 200, // 0x000000C8
        /// <summary>The data value will be represented as a SurfaceArea.</summary>
        SurfaceArea = 201, // 0x000000C9
        /// <summary>The data value will be represented as a Period.</summary>
        Period = 202, // 0x000000CA
        /// <summary>The data value will be represented as a Pulsation.</summary>
        Pulsation = 203, // 0x000000CB
        /// <summary>The data value will be represented as a ReinforcementArea.</summary>
        ReinforcementArea = 204, // 0x000000CC
        /// <summary>The data value will be represented as a ReinforcementAreaPerUnitLength.</summary>
        ReinforcementAreaPerUnitLength = 205, // 0x000000CD
        /// <summary>The data value will be represented as a ReinforcementCover.</summary>
        ReinforcementCover = 206, // 0x000000CE
        /// <summary>The data value will be represented as a ReinforcementSpacing.</summary>
        ReinforcementSpacing = 207, // 0x000000CF
        /// <summary>The data value will be represented as a Rotation.</summary>
        Rotation = 208, // 0x000000D0
        /// <summary>The data value will be represented as a SectionArea.</summary>
        SectionArea = 209, // 0x000000D1
        /// <summary>The data value will be represented as a SectionDimension.</summary>
        SectionDimension = 210, // 0x000000D2
        /// <summary>The data value will be represented as a SectionModulus.</summary>
        SectionModulus = 211, // 0x000000D3
        /// <summary>The data value will be represented as a SectionProperty.</summary>
        SectionProperty = 212, // 0x000000D4
        /// <summary>The data value will be represented as a StructuralVelocity.</summary>
        StructuralVelocity = 213, // 0x000000D5
        /// <summary>The data value will be represented as a WarpingConstant.</summary>
        WarpingConstant = 214, // 0x000000D6
        /// <summary>The data value will be represented as a Weight.</summary>
        Weight = 215, // 0x000000D7
        /// <summary>The data value will be represented as a WeightPerUnitLength.</summary>
        WeightPerUnitLength = 216, // 0x000000D8
        /// <summary>The data value will be represented as a HVACThermalConductivity.</summary>
        HVACThermalConductivity = 217, // 0x000000D9
        /// <summary>The data value will be represented as a HVACSpecificHeat.</summary>
        HVACSpecificHeat = 218, // 0x000000DA
        /// <summary>The data value will be represented as a HVACSpecificHeatOfVaporization.</summary>
        HVACSpecificHeatOfVaporization = 219, // 0x000000DB
        /// <summary>The data value will be represented as a HVACPermeability.</summary>
        HVACPermeability = 220, // 0x000000DC
        /// <summary>The data value will be represented as a ElectricalResistivity.</summary>
        ElectricalResistivity = 221, // 0x000000DD
        /// <summary>The data value will be represented as a MassDensity.</summary>
        MassDensity = 222, // 0x000000DE
        /// <summary>The data value will be represented as a MassPerUnitArea.</summary>
        MassPerUnitArea = 223, // 0x000000DF
        /// <summary>The value of this parameter will be a Pipe Dimension</summary>
        PipeDimension = 224, // 0x000000E0
        /// <summary>The value of this parameter will be the Pipe Mass</summary>
        PipeMass = 225, // 0x000000E1
        /// <summary>The value of this parameter will be the Pipe Mass per Unit Length</summary>
        PipeMassPerUnitLength = 226, // 0x000000E2
        /// <summary>The data value will be represented as a HVACTemperatureDifference.</summary>
        HVACTemperatureDifference = 227, // 0x000000E3
        /// <summary>The data value will be represented as a PipingTemperatureDifference.</summary>
        PipingTemperatureDifference = 228, // 0x000000E4
        /// <summary>The data value will be represented as an ElectricalTemperatureDifference.</summary>
        ElectricalTemperatureDifference = 229, // 0x000000E5
        /// <summary>The data value will be represented as a TimeInterval</summary>
        TimeInterval = 230, // 0x000000E6
        /// <summary>The data value will be represented as a Speed</summary>
        Speed = 231, // 0x000000E7
        /// <summary>The data value will be represented as infrastructure stationing</summary>
        Stationing = 232, // 0x000000E8
    }

}
