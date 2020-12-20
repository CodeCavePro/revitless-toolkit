#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

using System;

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.UnitType
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>The type of physical quantity to be measured, for example length or force.</summary>
    /// <remarks>
    ///      <para>Some unit types represent fundamental physical quantities to
    /// be measured, for example UT_Length, UT_Area, UT_Mass, or
    /// UT_Force.</para>
    ///      <para>Other unit types exist to provide an alternate set of unit
    /// settings for a physical quantity.  For example, UT_HVAC_DuctSize is
    /// used for measuring sizes of ducts, UT_PipeSize is used for
    /// measuring sizes of pipes, and UT_SheetLength is used for measuring
    /// distances on a piece of paper.  All of those are lengths and could
    /// use UT_Length, but they are typically measured using different
    /// units or to a different degree of accuracy compared with typical
    /// lengths in a building.  By using different unit types, the Units
    /// class can have different default settings for measuring values of
    /// the same physical quantity.</para>
    ///    </remarks>
    [Obsolete("This enumeration is deprecated in Revit 2021 and may be removed in a future version of Revit. Please use the `ForgeTypeId` class instead. Use constant members of the `SpecTypeId` class to replace uses of specific values of this enumeration.")]
    public enum UnitType
    {
        /// <summary>Undefined unit value</summary>
        UT_Undefined = -2, // 0xFFFFFFFE
        /// <summary>A custom unit value</summary>
        UT_Custom = -1, // 0xFFFFFFFF
        /// <summary>Length, e.g. ft, in, m, mm</summary>
        UT_Length = 0,
        /// <summary>Area, e.g. ft², in², m², mm²</summary>
        UT_Area = 1,
        /// <summary>Volume, e.g. ft³, in³, m³, mm³</summary>
        UT_Volume = 2,
        /// <summary>Angular measurement, e.g. radians, degrees</summary>
        UT_Angle = 3,
        /// <summary>General format unit, appropriate for general counts or percentages</summary>
        UT_Number = 4,
        /// <summary>Sheet length</summary>
        UT_SheetLength = 5,
        /// <summary>Site angle</summary>
        UT_SiteAngle = 6,
        /// <summary>Density (HVAC) e.g.	kg/m³</summary>
        UT_HVAC_Density = 7,
        /// <summary>Energy (HVAC) e.g.	(m² · kg)/s², J</summary>
        UT_HVAC_Energy = 8,
        /// <summary>Friction (HVAC) e.g. kg/(m² · s²), Pa/m</summary>
        UT_HVAC_Friction = 9,
        /// <summary>Power (HVAC) e.g. (m² · kg)/s³, W</summary>
        UT_HVAC_Power = 10, // 0x0000000A
        /// <summary>Power Density (HVAC), e.g. kg/s³, W/m²</summary>
        UT_HVAC_Power_Density = 11, // 0x0000000B
        /// <summary>Pressure (HVAC) e.g. kg/(m · s²), Pa</summary>
        UT_HVAC_Pressure = 12, // 0x0000000C
        /// <summary>Temperature (HVAC) e.g. K, C, F</summary>
        UT_HVAC_Temperature = 13, // 0x0000000D
        /// <summary>Velocity (HVAC) e.g. m/s</summary>
        UT_HVAC_Velocity = 14, // 0x0000000E
        /// <summary>Air Flow (HVAC) e.g. m³/s</summary>
        UT_HVAC_Airflow = 15, // 0x0000000F
        /// <summary>Duct Size (HVAC) e.g. mm, in</summary>
        UT_HVAC_DuctSize = 16, // 0x00000010
        /// <summary>Cross Section (HVAC) e.g. mm², in²</summary>
        UT_HVAC_CrossSection = 17, // 0x00000011
        /// <summary>Heat Gain (HVAC) e.g. (m² · kg)/s³, W</summary>
        UT_HVAC_HeatGain = 18, // 0x00000012
        /// <summary>Current (Electrical) e.g. A</summary>
        UT_Electrical_Current = 19, // 0x00000013
        /// <summary>Electrical Potential e.g.	(m² · kg) / (s³· A), V</summary>
        UT_Electrical_Potential = 20, // 0x00000014
        /// <summary>Frequency (Electrical) e.g. 1/s, Hz</summary>
        UT_Electrical_Frequency = 21, // 0x00000015
        /// <summary>Illuminance (Electrical) e.g. (cd · sr)/m², lm/m²</summary>
        UT_Electrical_Illuminance = 22, // 0x00000016
        /// <summary>Luminous Flux (Electrical) e.g. cd · sr, lm</summary>
        UT_Electrical_Luminous_Flux = 23, // 0x00000017
        /// <summary>Power (Electrical) e.g.	(m² · kg)/s³, W</summary>
        UT_Electrical_Power = 24, // 0x00000018
        /// <summary>Roughness factor (HVAC) e,g. ft, in, mm</summary>
        UT_HVAC_Roughness = 25, // 0x00000019
        /// <summary>Force, e.g. (kg · m)/s², N</summary>
        UT_Force = 26, // 0x0000001A
        /// <summary>Force per unit length, e.g. kg/s², N/m</summary>
        UT_LinearForce = 27, // 0x0000001B
        /// <summary>Force per unit area, e.g. kg/(m · s²), N/m²</summary>
        UT_AreaForce = 28, // 0x0000001C
        /// <summary>Moment, e.g. (kg · m²)/s², N · m</summary>
        UT_Moment = 29, // 0x0000001D
        /// <summary>Force scale, e.g. m / N</summary>
        UT_ForceScale = 30, // 0x0000001E
        /// <summary>Linear force scale, e.g. m² / N</summary>
        UT_LinearForceScale = 31, // 0x0000001F
        /// <summary>Area force scale, e.g. m³ / N</summary>
        UT_AreaForceScale = 32, // 0x00000020
        /// <summary>Moment scale, e.g. 1 / N</summary>
        UT_MomentScale = 33, // 0x00000021
        /// <summary>Apparent Power (Electrical), e.g. (m² · kg)/s³, W</summary>
        UT_Electrical_Apparent_Power = 34, // 0x00000022
        /// <summary>Power Density (Electrical), e.g. kg/s³, W/m²</summary>
        UT_Electrical_Power_Density = 35, // 0x00000023
        /// <summary>Density (Piping) e.g. kg/m³</summary>
        UT_Piping_Density = 36, // 0x00000024
        /// <summary>Flow (Piping), e.g. m³/s</summary>
        UT_Piping_Flow = 37, // 0x00000025
        /// <summary>Friction (Piping), e.g. kg/(m² · s²), Pa/m</summary>
        UT_Piping_Friction = 38, // 0x00000026
        /// <summary>Pressure (Piping), e.g. kg/(m · s²), Pa</summary>
        UT_Piping_Pressure = 39, // 0x00000027
        /// <summary>Temperature (Piping), e.g. K</summary>
        UT_Piping_Temperature = 40, // 0x00000028
        /// <summary>Velocity (Piping), e.g. m/s</summary>
        UT_Piping_Velocity = 41, // 0x00000029
        /// <summary>Dynamic Viscosity (Piping), e.g. kg/(m · s), Pa · s</summary>
        UT_Piping_Viscosity = 42, // 0x0000002A
        /// <summary>Pipe Size (Piping), e.g.	m</summary>
        UT_PipeSize = 43, // 0x0000002B
        /// <summary>Roughness factor (Piping), e.g. ft, in, mm</summary>
        UT_Piping_Roughness = 44, // 0x0000002C
        /// <summary>Stress, e.g. kg/(m · s²), ksi, MPa</summary>
        UT_Stress = 45, // 0x0000002D
        /// <summary>Unit weight, e.g. N/m³</summary>
        UT_UnitWeight = 46, // 0x0000002E
        /// <summary>Thermal expansion, e.g. 1/K</summary>
        UT_ThermalExpansion = 47, // 0x0000002F
        /// <summary>Linear moment, e,g. (N · m)/m, lbf / ft</summary>
        UT_LinearMoment = 48, // 0x00000030
        /// <summary>Linear moment scale, e.g. ft/kip, m/kN</summary>
        UT_LinearMomentScale = 49, // 0x00000031
        /// <summary>Point Spring Coefficient, e.g. kg/s², N/m</summary>
        UT_ForcePerLength = 50, // 0x00000032
        /// <summary>
        ///    Rotational Point Spring Coefficient, e.g. (kg · m²)/(s² · rad), (N · m)/rad
        /// </summary>
        UT_ForceLengthPerAngle = 51, // 0x00000033
        /// <summary>Line Spring Coefficient, e.g. kg/(m · s²), (N · m)/m²</summary>
        UT_LinearForcePerLength = 52, // 0x00000034
        /// <summary>Rotational Line Spring Coefficient, e.g. (kg · m)/(s² · rad), N/rad</summary>
        UT_LinearForceLengthPerAngle = 53, // 0x00000035
        /// <summary>Area Spring Coefficient, e.g.  kg/(m² · s²), N/m³</summary>
        UT_AreaForcePerLength = 54, // 0x00000036
        /// <summary>Pipe Volume, e.g. gallons, liters</summary>
        UT_Piping_Volume = 55, // 0x00000037
        /// <summary>Dynamic Viscosity (HVAC), e.g. kg/(m · s), Pa · s</summary>
        UT_HVAC_Viscosity = 56, // 0x00000038
        /// <summary>
        ///    Coefficient of Heat Transfer (U-value) (HVAC), e.g. kg/(s³ · K), W/(m² · K)
        /// </summary>
        UT_HVAC_CoefficientOfHeatTransfer = 57, // 0x00000039
        /// <summary>Air Flow Density (HVAC), m³/(s · m²)</summary>
        UT_HVAC_Airflow_Density = 58, // 0x0000003A
        /// <summary>Slope, rise/run</summary>
        UT_Slope = 59, // 0x0000003B
        /// <summary>Cooling load (HVAC), e.g. (m² · kg)/s³, W, kW, Btu/s, Btu/h</summary>
        UT_HVAC_Cooling_Load = 60, // 0x0000003C
        /// <summary>
        ///    Cooling load per unit area (HVAC), e.g. kg/s³, W/m², W/ft², Btu/(h·ft²)
        /// </summary>
        UT_HVAC_Cooling_Load_Divided_By_Area = 61, // 0x0000003D
        /// <summary>
        ///    Cooling load per unit volume (HVAC), e.g. kg/(s³ · m), W/m³, Btu/(h·ft³)
        /// </summary>
        UT_HVAC_Cooling_Load_Divided_By_Volume = 62, // 0x0000003E
        /// <summary>Heating load (HVAC), e.g. (m² · kg)/s³, W, kW, Btu/s, Btu/h</summary>
        UT_HVAC_Heating_Load = 63, // 0x0000003F
        /// <summary>
        ///    Heating load per unit area (HVAC), e.g. kg/s³, W/m², W/ft², Btu/(h·ft²)
        /// </summary>
        UT_HVAC_Heating_Load_Divided_By_Area = 64, // 0x00000040
        /// <summary>
        ///    Heating load per unit volume (HVAC), e.g. kg/(s³ · m), W/m³, Btu/(h·ft³)
        /// </summary>
        UT_HVAC_Heating_Load_Divided_By_Volume = 65, // 0x00000041
        /// <summary>
        ///    Airflow per unit volume (HVAC), e.g. m³/(s · m³), CFM/ft³, CFM/CF, L/(s·m³)
        /// </summary>
        UT_HVAC_Airflow_Divided_By_Volume = 66, // 0x00000042
        /// <summary>
        ///    Airflow per unit cooling load (HVAC), e.g. (m · s²)/kg, ft²/ton, SF/ton, m²/kW
        /// </summary>
        UT_HVAC_Airflow_Divided_By_Cooling_Load = 67, // 0x00000043
        /// <summary>Area per unit cooling load (HVAC), e.g.  s³/kg, ft²/ton, m²/kW</summary>
        UT_HVAC_Area_Divided_By_Cooling_Load = 68, // 0x00000044
        /// <summary>Wire Size (Electrical), e.g.	mm, inch</summary>
        UT_WireSize = 69, // 0x00000045
        /// <summary>Slope (HVAC)</summary>
        UT_HVAC_Slope = 70, // 0x00000046
        /// <summary>Slope (Piping)</summary>
        UT_Piping_Slope = 71, // 0x00000047
        /// <summary>Currency</summary>
        UT_Currency = 72, // 0x00000048
        /// <summary>Electrical efficacy (lighting), e.g. cd·sr·s³/(m²·kg), lm/W</summary>
        UT_Electrical_Efficacy = 73, // 0x00000049
        /// <summary>Wattage (lighting), e.g. (m² · kg)/s³, W</summary>
        UT_Electrical_Wattage = 74, // 0x0000004A
        /// <summary>Color temperature (lighting), e.g. K</summary>
        UT_Color_Temperature = 75, // 0x0000004B
        /// <summary>Sheet length in decimal form, decimal inches, mm</summary>
        UT_DecSheetLength = 76, // 0x0000004C
        /// <summary>Luminous Intensity (Lighting), e.g. cd, cd</summary>
        UT_Electrical_Luminous_Intensity = 77, // 0x0000004D
        /// <summary>Luminance (Lighting), cd/m², cd/m²</summary>
        UT_Electrical_Luminance = 78, // 0x0000004E
        /// <summary>Area per unit heating load (HVAC), e.g.  s³/kg, ft²/ton, m²/kW</summary>
        UT_HVAC_Area_Divided_By_Heating_Load = 79, // 0x0000004F
        /// <summary>Heating and coooling factor, percentage</summary>
        UT_HVAC_Factor = 80, // 0x00000050
        /// <summary>Temperature (electrical), e.g. F, C</summary>
        UT_Electrical_Temperature = 81, // 0x00000051
        /// <summary>Cable tray size (electrical), e.g. in, mm</summary>
        UT_Electrical_CableTraySize = 82, // 0x00000052
        /// <summary>Conduit size (electrical), e.g. in, mm</summary>
        UT_Electrical_ConduitSize = 83, // 0x00000053
        /// <summary>Structural reinforcement volume, e.g. in³, cm³</summary>
        UT_Reinforcement_Volume = 84, // 0x00000054
        /// <summary>Structural reinforcement length, e.g. mm, in, ft</summary>
        UT_Reinforcement_Length = 85, // 0x00000055
        /// <summary>Electrical demand factor, percentage</summary>
        UT_Electrical_Demand_Factor = 86, // 0x00000056
        /// <summary>Duct Insulation Thickness (HVAC), e.g. mm, in</summary>
        UT_HVAC_DuctInsulationThickness = 87, // 0x00000057
        /// <summary>Duct Lining Thickness (HVAC), e.g. mm, in</summary>
        UT_HVAC_DuctLiningThickness = 88, // 0x00000058
        /// <summary>Pipe Insulation Thickness (Piping), e.g. mm, in</summary>
        UT_PipeInsulationThickness = 89, // 0x00000059
        /// <summary>Thermal Resistance (HVAC), R Value, e.g. m²·K/W</summary>
        UT_HVAC_ThermalResistance = 90, // 0x0000005A
        /// <summary>Thermal Mass (HVAC), e.g.  J/K, BTU/F</summary>
        UT_HVAC_ThermalMass = 91, // 0x0000005B
        /// <summary>Acceleration, e.g. m/s², km/s², in/s², ft/s², mi/s²</summary>
        UT_Acceleration = 92, // 0x0000005C
        /// <summary>Bar Diameter, e.g. ', LF, ", m, cm, mm</summary>
        UT_Bar_Diameter = 93, // 0x0000005D
        /// <summary>Crack Width, e.g. ', LF, ", m, cm, mm</summary>
        UT_Crack_Width = 94, // 0x0000005E
        /// <summary>Displacement/Deflection, e.g. ', LF, ", m, cm, mm</summary>
        UT_Displacement_Deflection = 95, // 0x0000005F
        /// <summary>Energy, e.g. J, kJ, kgf-m, lb-ft, N-m</summary>
        UT_Energy = 96, // 0x00000060
        /// <summary>FREQUENCY, Frequency (Structural) e.g. Hz</summary>
        UT_Structural_Frequency = 97, // 0x00000061
        /// <summary>Mass, e.g.  kg, lb, t</summary>
        UT_Mass = 98, // 0x00000062
        /// <summary>Mass per Unit Length, e.g. kg/m, lb/ft</summary>
        UT_Mass_per_Unit_Length = 99, // 0x00000063
        /// <summary>Moment of Inertia, e.g. ft^4, in^4, mm^4, cm^4, m^4</summary>
        UT_Moment_of_Inertia = 100, // 0x00000064
        /// <summary>Surface Area, e.g. ft²/ft, m²/m</summary>
        UT_Surface_Area = 101, // 0x00000065
        /// <summary>Period, e.g. ms, s, min, h</summary>
        UT_Period = 102, // 0x00000066
        /// <summary>Pulsation, e.g. rad/s</summary>
        UT_Pulsation = 103, // 0x00000067
        /// <summary>Reinforcement Area, e.g. SF, ft², in², mm², cm², m²</summary>
        UT_Reinforcement_Area = 104, // 0x00000068
        /// <summary>
        ///    Reinforcement Area per Unit Length, e.g. ft²/ft, in²/ft, mm²/m, cm²/m, m²/m
        /// </summary>
        UT_Reinforcement_Area_per_Unit_Length = 105, // 0x00000069
        /// <summary>Reinforcement Cover, e.g. ', LF, ", m, cm, mm</summary>
        UT_Reinforcement_Cover = 106, // 0x0000006A
        /// <summary>Reinforcement Spacing, e.g. ', LF, ", m, cm, mm</summary>
        UT_Reinforcement_Spacing = 107, // 0x0000006B
        /// <summary>Rotation, e.g. °, rad, grad</summary>
        UT_Rotation = 108, // 0x0000006C
        /// <summary>Section Area, e.g.  ft²/ft, in²/ft, mm²/m, cm²/m, m²/m</summary>
        UT_Section_Area = 109, // 0x0000006D
        /// <summary>Section Dimension, e.g.  ', LF, ", m, cm, mm</summary>
        UT_Section_Dimension = 110, // 0x0000006E
        /// <summary>Section Modulus, e.g. ft^3, in^3, mm^3, cm^3, m^3</summary>
        UT_Section_Modulus = 111, // 0x0000006F
        /// <summary>Section Property, e.g.  ', LF, ", m, cm, mm</summary>
        UT_Section_Property = 112, // 0x00000070
        /// <summary>Section Property, e.g. km/h, m/s, ft/min, ft/s, mph</summary>
        UT_Structural_Velocity = 113, // 0x00000071
        /// <summary>Warping Constant, e.g. ft^6, in^6, mm^6, cm^6, m^6</summary>
        UT_Warping_Constant = 114, // 0x00000072
        /// <summary>Weight, e.g. N, daN, kN, MN, kip, kgf, Tf, lb, lbf</summary>
        UT_Weight = 115, // 0x00000073
        /// <summary>
        ///    Weight per Unit Length, e.g. N/m, daN/m, kN/m, MN/m, kip/ft, kgf/m, Tf/m, lb/ft, lbf/ft, kip/in
        /// </summary>
        UT_Weight_per_Unit_Length = 116, // 0x00000074
        /// <summary>Thermal Conductivity (HVAC), e.g. W/(m·K)</summary>
        UT_HVAC_ThermalConductivity = 117, // 0x00000075
        /// <summary>Specific Heat (HVAC), e.g. J/(g·°C)</summary>
        UT_HVAC_SpecificHeat = 118, // 0x00000076
        /// <summary>Specific Heat of Vaporization, e.g. J/g</summary>
        UT_HVAC_SpecificHeatOfVaporization = 119, // 0x00000077
        /// <summary>Permeability, e.g. ng/(Pa·s·m²)</summary>
        UT_HVAC_Permeability = 120, // 0x00000078
        /// <summary>Electrical Resistivity, e.g.</summary>
        UT_Electrical_Resistivity = 121, // 0x00000079
        /// <summary>Mass Density, e.g. kg/m³, lb/ft³</summary>
        UT_MassDensity = 122, // 0x0000007A
        /// <summary>Mass Per Unit Area, e.g. kg/m², lb/ft²</summary>
        UT_MassPerUnitArea = 123, // 0x0000007B
        /// <summary>Length unit for pipe dimension, e.g. in, mm</summary>
        UT_Pipe_Dimension = 124, // 0x0000007C
        /// <summary>Mass, e.g.  kg, lb, t</summary>
        UT_PipeMass = 125, // 0x0000007D
        /// <summary>Mass per Unit Length, e.g. kg/m, lb/ft</summary>
        UT_PipeMassPerUnitLength = 126, // 0x0000007E
        /// <summary>Temperature Difference (HVAC) e.g. C, F, K, R</summary>
        UT_HVAC_TemperatureDifference = 127, // 0x0000007F
        /// <summary>Temperature Difference (Piping), e.g. C, F, K, R</summary>
        UT_Piping_TemperatureDifference = 128, // 0x00000080
        /// <summary>Temperature Difference (Electrical), e.g. C, F, K, R</summary>
        UT_Electrical_TemperatureDifference = 129, // 0x00000081
        /// <summary>Interval of time e.g. ms, s, min, h</summary>
        UT_TimeInterval = 130, // 0x00000082
        /// <summary>Distance interval over time e.g.  m/h etc.</summary>
        UT_Speed = 131, // 0x00000083
        /// <summary>Infrastructure Alignment stationing/distance e.g. 1+020 ft etc.</summary>
        UT_Stationing = 132, // 0x00000084
    }

}
