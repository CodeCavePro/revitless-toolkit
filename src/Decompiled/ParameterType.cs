// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.ParameterType
// Assembly: RevitAPI, Version=17.0.0.0, Culture=neutral, PublicKeyToken=null
// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    ///    An enumerated type listing all of the data type interpretation that Autodesk Revit supports.
    /// </summary>
    public enum ParameterType
    {
        Invalid = 0,
        Text = 1,
        Integer = 2,
        Number = 3,
        Length = 4,
        Area = 5,
        Volume = 6,
        Angle = 7,
        URL = 8,
        Material = 9,
        YesNo = 10,
        Force = 11,
        LinearForce = 12,
        AreaForce = 13,
        Moment = 14,
        NumberOfPoles = 15,
        FixtureUnit = 16,
        FamilyType = 17,
        LoadClassification = 18,
        Image = 19,
        MultilineText = 20,
        HVACDensity = 107,
        HVACEnergy = 108,
        HVACFriction = 109,
        HVACPower = 110,
        HVACPowerDensity = 111,
        HVACPressure = 112,
        HVACTemperature = 113,
        HVACVelocity = 114,
        HVACAirflow = 115,
        HVACDuctSize = 116,
        HVACCrossSection = 117,
        HVACHeatGain = 118,
        ElectricalCurrent = 119,
        ElectricalPotential = 120,
        ElectricalFrequency = 121,
        ElectricalIlluminance = 122,
        ElectricalLuminousFlux = 123,
        ElectricalPower = 124,
        HVACRoughness = 125,
        ElectricalApparentPower = 134,
        ElectricalPowerDensity = 135,
        PipingDensity = 136,
        PipingFlow = 137,
        PipingFriction = 138,
        PipingPressure = 139,
        PipingTemperature = 140,
        PipingVelocity = 141,
        PipingViscosity = 142,
        PipeSize = 143,
        PipingRoughness = 144,
        Stress = 145,
        UnitWeight = 146,
        ThermalExpansion = 147,
        LinearMoment = 148,
        ForcePerLength = 150,
        ForceLengthPerAngle = 151,
        LinearForcePerLength = 152,
        LinearForceLengthPerAngle = 153,
        AreaForcePerLength = 154,
        PipingVolume = 155,
        HVACViscosity = 156,
        HVACCoefficientOfHeatTransfer = 157,
        HVACAirflowDensity = 158,
        Slope = 159,
        HVACCoolingLoad = 160,
        HVACCoolingLoadDividedByArea = 161,
        HVACCoolingLoadDividedByVolume = 162,
        HVACHeatingLoad = 163,
        HVACHeatingLoadDividedByArea = 164,
        HVACHeatingLoadDividedByVolume = 165,
        HVACAirflowDividedByVolume = 166,
        HVACAirflowDividedByCoolingLoad = 167,
        HVACAreaDividedByCoolingLoad = 168,
        WireSize = 169,
        HVACSlope = 170,
        PipingSlope = 171,
        Currency = 172,
        ElectricalEfficacy = 173,
        ElectricalWattage = 174,
        ColorTemperature = 175,
        ElectricalLuminousIntensity = 177,
        ElectricalLuminance = 178,
        HVACAreaDividedByHeatingLoad = 179,
        HVACFactor = 180,
        ElectricalTemperature = 181,
        ElectricalCableTraySize = 182,
        ElectricalConduitSize = 183,
        ReinforcementVolume = 184,
        ReinforcementLength = 185,
        ElectricalDemandFactor = 186,
        HVACDuctInsulationThickness = 187,
        HVACDuctLiningThickness = 188,
        PipeInsulationThickness = 189,
        HVACThermalResistance = 190,
        HVACThermalMass = 191,
        Acceleration = 192,
        BarDiameter = 193,
        CrackWidth = 194,
        DisplacementDeflection = 195,
        Energy = 196,
        StructuralFrequency = 197,
        Mass = 198,
        MassPerUnitLength = 199,
        MomentOfInertia = 200,
        SurfaceArea = 201,
        Period = 202,
        Pulsation = 203,
        ReinforcementArea = 204,
        ReinforcementAreaPerUnitLength = 205,
        ReinforcementCover = 206,
        ReinforcementSpacing = 207,
        Rotation = 208,
        SectionArea = 209,
        SectionDimension = 210,
        SectionModulus = 211,
        SectionProperty = 212,
        StructuralVelocity = 213,
        WarpingConstant = 214,
        Weight = 215,
        WeightPerUnitLength = 216,
        HVACThermalConductivity = 217,
        HVACSpecificHeat = 218,
        HVACSpecificHeatOfVaporization = 219,
        HVACPermeability = 220,
        ElectricalResistivity = 221,
        MassDensity = 222,
        MassPerUnitArea = 223,
        PipeDimension = 224,
        PipeMass = 225,
        PipeMassPerUnitLength = 226,
        HVACTemperatureDifference = 227,
        PipingTemperatureDifference = 228,
        ElectricalTemperatureDifference = 229,
    }

    public static class ParameterTypeExtensions
    {
        private static readonly Regex HvacUrlOrCapitalLetter;
        private static readonly Dictionary<ParameterType, string> _parameterTypes;

        static ParameterTypeExtensions()
        {
            HvacUrlOrCapitalLetter = new Regex(@"(HVAC|URL|[A-Z])", RegexOptions.Compiled);

            _parameterTypes = Enum.GetValues(typeof(ParameterType))
                .OfType<ParameterType>()
                .ToDictionary(p => p, p => ConvertToDataType(p));
        }

        public static ParameterType FromSharedDataType(this string dataType)
        {
            var values = _parameterTypes?.Where(u => u.Value.Equals(dataType))?.Select(x => x.Key)?.ToArray();
            return (values.Any())
                ? values.FirstOrDefault()
                : ParameterType.Invalid;
        }

        private static string ConvertToDataType(ParameterType parameter)
        {
            if (ParameterType.Invalid == parameter)
            {
                return string.Empty;
            }

            var parameterAsString = parameter.ToString();
            var parts = HvacUrlOrCapitalLetter
                .Split(parameterAsString)
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .ToArray();

            if (parts.Length <= 2)
            {
                return parameterAsString.ToUpperInvariant();
            }

            parameterAsString = string.Empty;
            for (var i = 0; i < parts.Length; i++)
            {
                if (i != 0 && HvacUrlOrCapitalLetter.IsMatch(parts[i]))
                {
                    parameterAsString += "_";
                }
                parameterAsString += parts[i].ToUpperInvariant();
            }

            return parameterAsString
                .Replace("YES_NO", "YESNO")
                .Replace("LOAD_CLASSIFICATION", "LOADCLASSIFICATION")
                .Replace("NUMBER_OF_POLES", "NOOFPOLES");
        }

        public static string ToSharedDataType(this ParameterType parameter)
        {
            _parameterTypes.TryGetValue(parameter, out string dataType);
            return dataType;
        }
    }
}
