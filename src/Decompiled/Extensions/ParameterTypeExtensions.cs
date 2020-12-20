#pragma warning disable CS0618 // Type or member is obsolete

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    /// UnitType extension class featuring extension methods for ParameterType enumeration
    /// </summary>
    public static class ParameterTypeExtensions
    {
        private static readonly Dictionary<ParameterType, string> parameterTypes2Shared;
        private static readonly Dictionary<ParameterType, UnitType> parameterTypes2UnitTypes;

        /// <summary>
        /// Static constructor
        /// </summary>
        static ParameterTypeExtensions()
        {
            parameterTypes2Shared = new Dictionary<ParameterType, string>
            {
                { ParameterType.Invalid, string.Empty },
                { ParameterType.Text, "TEXT" },
                { ParameterType.Integer, "INTEGER" },
                { ParameterType.Number, "NUMBER" },
                { ParameterType.Length, "LENGTH" },
                { ParameterType.Area, "AREA" },
                { ParameterType.Volume, "VOLUME" },
                { ParameterType.Angle, "ANGLE" },
                { ParameterType.URL, "URL" },
                { ParameterType.Material, "MATERIAL" },
                { ParameterType.YesNo, "YESNO" },
                { ParameterType.Force, "FORCE" },
                { ParameterType.LinearForce, "LINEAR_FORCE" },
                { ParameterType.AreaForce, "AREA_FORCE" },
                { ParameterType.Moment, "MOMENT" },
                { ParameterType.NumberOfPoles, "NOOFPOLES" },
                { ParameterType.FixtureUnit, "FIXTUREUNIT" },
                { ParameterType.FamilyType, "FAMILYTYPE" },
                { ParameterType.LoadClassification, "LOADCLASSIFICATION" },
                { ParameterType.Image, "IMAGE" },
                { ParameterType.MultilineText, "MULTILINETEXT" },
                { ParameterType.HVACDensity, "HVAC_DENSITY" },
                { ParameterType.HVACEnergy, "HVAC_ENERGY" },
                { ParameterType.HVACFriction, "HVAC_FRICTION" },
                { ParameterType.HVACPower, "HVAC_POWER" },
                { ParameterType.HVACPowerDensity, "HVAC_POWER_DENSITY" },
                { ParameterType.HVACPressure, "HVAC_PRESSURE" },
                { ParameterType.HVACTemperature, "HVAC_TEMPERATURE" },
                { ParameterType.HVACVelocity, "HVAC_VELOCITY" },
                { ParameterType.HVACAirflow, "HVAC_AIR_FLOW" },
                { ParameterType.HVACDuctSize, "HVAC_DUCT_SIZE" },
                { ParameterType.HVACCrossSection, "HVAC_CROSS_SECTION" },
                { ParameterType.HVACHeatGain, "HVAC_HEAT_GAIN" },
                { ParameterType.ElectricalCurrent, "ELECTRICAL_CURRENT" },
                { ParameterType.ElectricalPotential, "ELECTRICAL_POTENTIAL" },
                { ParameterType.ElectricalFrequency, "ELECTRICAL_FREQUENCY" },
                { ParameterType.ElectricalIlluminance, "ELECTRICAL_ILLUMINANCE" },
                { ParameterType.ElectricalLuminousFlux, "ELECTRICAL_LUMINOUS_FLUX" },
                { ParameterType.ElectricalPower, "ELECTRICAL_POWER" },
                { ParameterType.HVACRoughness, "HVAC_ROUGHNESS" },
                { ParameterType.ElectricalApparentPower, "ELECTRICAL_APPARENT_POWER" },
                { ParameterType.ElectricalPowerDensity, "ELECTRICAL_POWER_DENSITY" },
                { ParameterType.PipingDensity, "PIPING_DENSITY" },
                { ParameterType.PipingFlow, "PIPING_FLOW" },
                { ParameterType.PipingFriction, "PIPING_FRICTION" },
                { ParameterType.PipingPressure, "PIPING_PRESSURE" },
                { ParameterType.PipingTemperature, "PIPING_TEMPERATURE" },
                { ParameterType.PipingVelocity, "PIPING_VELOCITY" },
                { ParameterType.PipingViscosity, "PIPING_VISCOSITY" },
                { ParameterType.PipeSize, "PIPE_SIZE" },
                { ParameterType.PipingRoughness, "PIPING_ROUGHNESS" },
                { ParameterType.Stress, "STRESS" },
                { ParameterType.UnitWeight, "UNIT_WEIGHT" },
                { ParameterType.ThermalExpansion, "THERMAL_EXPANSION_COEFFICIENT" },
                { ParameterType.LinearMoment, "LINEAR_MOMENT" },
                { ParameterType.ForcePerLength, "POINT_SPRING_COEFFICIENT" },
                { ParameterType.ForceLengthPerAngle, "ROTATIONAL_POINT_SPRING_COEFFICIENT" },
                { ParameterType.LinearForcePerLength, "LINEAR_SPRING_COEFFICIENT" },
                { ParameterType.LinearForceLengthPerAngle, "ROTATIONAL_LINEAR_SPRING_COEFFICIENT" },
                { ParameterType.AreaForcePerLength, "AREA_SPRING_COEFFICIENT" },
                { ParameterType.PipingVolume, "PIPING_VOLUME" },
                { ParameterType.HVACViscosity, "HVAC_VISCOSITY" },
                { ParameterType.HVACCoefficientOfHeatTransfer, "HVAC_COEFFICIENT_OF_HEAT_TRANSFER" },
                { ParameterType.HVACAirflowDensity, "HVAC_AIRFLOW_DENSITY" },
                { ParameterType.Slope, "SLOPE" },
                { ParameterType.HVACCoolingLoad, "HVAC_COOLING_LOAD" },
                { ParameterType.HVACCoolingLoadDividedByArea, "HVAC_COOLING_LOAD_DIVIDED_BY_AREA" },
                { ParameterType.HVACCoolingLoadDividedByVolume, "HVAC_COOLING_LOAD_DIVIDED_BY_VOLUME" },
                { ParameterType.HVACHeatingLoad, "HVAC_HEATING_LOAD" },
                { ParameterType.HVACHeatingLoadDividedByArea, "HVAC_HEATING_LOAD_DIVIDED_BY_AREA" },
                { ParameterType.HVACHeatingLoadDividedByVolume, "HVAC_HEATING_LOAD_DIVIDED_BY_VOLUME" },
                { ParameterType.HVACAirflowDividedByVolume, "HVAC_AIRFLOW_DIVIDED_BY_VOLUME" },
                { ParameterType.HVACAirflowDividedByCoolingLoad, "HVAC_AIRFLOW_DIVIDED_BY_COOLING_LOAD" },
                { ParameterType.HVACAreaDividedByCoolingLoad, "HVAC_AREA_DIVIDED_BY_COOLING_LOAD" },
                { ParameterType.WireSize, "WIRE_SIZE" },
                { ParameterType.HVACSlope, "HVAC_SLOPE" },
                { ParameterType.PipingSlope, "PIPING_SLOPE" },
                { ParameterType.Currency, "CURRENCY" },
                { ParameterType.ElectricalEfficacy, "ELECTRICAL_EFFICACY" },
                { ParameterType.ElectricalWattage, "ELECTRICAL_WATTAGE" },
                { ParameterType.ColorTemperature, "COLOR_TEMPERATURE" },
                { ParameterType.ElectricalLuminousIntensity, "ELECTRICAL_LUMINOUS_INTENSITY" },
                { ParameterType.ElectricalLuminance, "ELECTRICAL_LUMINANCE" },
                { ParameterType.HVACAreaDividedByHeatingLoad, "HVAC_AREA_DIVIDED_BY_HEATING_LOAD" },
                { ParameterType.HVACFactor, "HVAC_FACTOR" },
                { ParameterType.ElectricalTemperature, "ELECTRICAL_TEMPERATURE" },
                { ParameterType.ElectricalCableTraySize, "CABLETRAY_SIZE" },
                { ParameterType.ElectricalConduitSize, "CONDUIT_SIZE" },
                { ParameterType.ReinforcementVolume, "REINFORCEMENT_VOLUME" },
                { ParameterType.ReinforcementLength, "REINFORCEMENT_LENGTH" },
                { ParameterType.ElectricalDemandFactor, "ELECTRICAL_DEMAND_FACTOR" },
                { ParameterType.HVACDuctInsulationThickness, "HVAC_DUCT_INSULATION_THICKNESS" },
                { ParameterType.HVACDuctLiningThickness, "HVAC_DUCT_LINING_THICKNESS" },
                { ParameterType.PipeInsulationThickness, "PIPE_INSUlATION_THICKNESS" },
                { ParameterType.HVACThermalResistance, "HVAC_THERMAL_RESISTANCE" },
                { ParameterType.HVACThermalMass, "HVAC_THERMAL_MASS" },
                { ParameterType.Acceleration, "ACCELERATION" },
                { ParameterType.BarDiameter, "BAR_DIAMETER" },
                { ParameterType.CrackWidth, "CRACK_WIDTH" },
                { ParameterType.DisplacementDeflection, "DISPLACEMENT/DEFLECTION" },
                { ParameterType.Energy, "ENERGY" },
                { ParameterType.StructuralFrequency, "STRUCTURAL_FREQUENCY" },
                { ParameterType.Mass, "MASS" },
                { ParameterType.MassPerUnitLength, "MASS_PER_UNIT_LENGTH" },
                { ParameterType.MomentOfInertia, "MOMENT_OF_INERTIA" },
                { ParameterType.SurfaceArea, "SURFACE_AREA" },
                { ParameterType.Period, "PERIOD" },
                { ParameterType.Pulsation, "PULSATION" },
                { ParameterType.ReinforcementArea, "REINFORCEMENT_AREA" },
                { ParameterType.ReinforcementAreaPerUnitLength, "REINFORCEMENT_AREA_PER_UNIT_LENGTH" },
                { ParameterType.ReinforcementCover, "REINFORCEMENT_COVER" },
                { ParameterType.ReinforcementSpacing, "REINFORCEMENT_SPACING" },
                { ParameterType.Rotation, "ROTATION" },
                { ParameterType.SectionArea, "SECTION_AREA" },
                { ParameterType.SectionDimension, "SECTION_DIMENSION" },
                { ParameterType.SectionModulus, "SECTION_MODULUS" },
                { ParameterType.SectionProperty, "SECTION_PROPERTY" },
                { ParameterType.StructuralVelocity, "VELOCITY" },
                { ParameterType.WarpingConstant, "WARPING_CONSTANT" },
                { ParameterType.Weight, "WEIGHT" },
                { ParameterType.WeightPerUnitLength, "WEIGHT_PER_UNIT_LENGTH" },
                { ParameterType.HVACThermalConductivity, "HVAC_THERMAL_CONDUCTIVITY" },
                { ParameterType.HVACSpecificHeat, "HVAC_SPECIFIC_HEAT" },
                { ParameterType.HVACSpecificHeatOfVaporization, "HVAC_SPECIFIC_HEAT_OF_VAPORIZATION" },
                { ParameterType.HVACPermeability, "HVAC_PERMEABILITY" },
                { ParameterType.ElectricalResistivity, "ELECTRICAL_RESISTIVITY" },
                { ParameterType.MassDensity, "MASS_DENSITY" },
                { ParameterType.MassPerUnitArea, "MASS_PER_UNIT_AREA" },
                { ParameterType.PipeDimension, "PIPE_DIMENSION" },
                { ParameterType.PipeMass, "PIPE_MASS" },
                { ParameterType.PipeMassPerUnitLength, "PIPE_MASS_PER_UNIT_LENGTH" },
                { ParameterType.HVACTemperatureDifference, "HVAC_TEMPERATURE_DIFFERENCE" },
                { ParameterType.PipingTemperatureDifference, "PIPING_TEMPERATURE_DIFFERENCE" },
                { ParameterType.ElectricalTemperatureDifference, "ELECTRICAL_TEMPERATURE_DIFFERENCE" },
            };

            parameterTypes2UnitTypes = new Dictionary<ParameterType, UnitType>
            {
                //! TODO Check these matches, not really sure about them
                { ParameterType.Text, UnitType.UT_Undefined },
                { ParameterType.MultilineText, UnitType.UT_Undefined },
                { ParameterType.FixtureUnit, UnitType.UT_Undefined },
                { ParameterType.FamilyType, UnitType.UT_Undefined },
                { ParameterType.LoadClassification, UnitType.UT_Undefined },
                { ParameterType.Image, UnitType.UT_Undefined },
                { ParameterType.URL, UnitType.UT_Undefined },
                { ParameterType.Material, UnitType.UT_Undefined },
                { ParameterType.YesNo, UnitType.UT_Undefined },

                // These matches are OK
                { ParameterType.NumberOfPoles, UnitType.UT_Number },
                { ParameterType.Number, UnitType.UT_Number },
                { ParameterType.Integer, UnitType.UT_Number },
                { ParameterType.Length, UnitType.UT_Length },
                { ParameterType.Area, UnitType.UT_Area },
                { ParameterType.Volume, UnitType.UT_Volume },
                { ParameterType.Angle, UnitType.UT_Angle },
                { ParameterType.Force, UnitType.UT_Force },
                { ParameterType.LinearForce, UnitType.UT_LinearForce },
                { ParameterType.AreaForce, UnitType.UT_AreaForce },
                { ParameterType.Moment, UnitType.UT_Moment },
                { ParameterType.HVACDensity, UnitType.UT_HVAC_Density },
                { ParameterType.HVACEnergy, UnitType.UT_HVAC_Energy },
                { ParameterType.HVACFriction, UnitType.UT_HVAC_Friction },
                { ParameterType.HVACPower, UnitType.UT_HVAC_Power },
                { ParameterType.HVACPowerDensity, UnitType.UT_HVAC_Power_Density },
                { ParameterType.HVACPressure, UnitType.UT_HVAC_Pressure },
                { ParameterType.HVACTemperature, UnitType.UT_HVAC_Temperature },
                { ParameterType.HVACVelocity, UnitType.UT_HVAC_Velocity },
                { ParameterType.HVACAirflow, UnitType.UT_HVAC_Airflow },
                { ParameterType.HVACDuctSize, UnitType.UT_HVAC_DuctSize },
                { ParameterType.HVACCrossSection, UnitType.UT_HVAC_CrossSection },
                { ParameterType.HVACHeatGain, UnitType.UT_HVAC_HeatGain },
                { ParameterType.ElectricalCurrent, UnitType.UT_Electrical_Current },
                { ParameterType.ElectricalPotential, UnitType.UT_Electrical_Potential },
                { ParameterType.ElectricalFrequency, UnitType.UT_Electrical_Frequency },
                { ParameterType.ElectricalIlluminance, UnitType.UT_Electrical_Illuminance },
                { ParameterType.ElectricalLuminousFlux, UnitType.UT_Electrical_Luminous_Flux },
                { ParameterType.ElectricalPower, UnitType.UT_Electrical_Power },
                { ParameterType.HVACRoughness, UnitType.UT_HVAC_Roughness },
                { ParameterType.ElectricalApparentPower, UnitType.UT_Electrical_Apparent_Power },
                { ParameterType.ElectricalPowerDensity, UnitType.UT_Electrical_Power_Density },
                { ParameterType.PipingDensity, UnitType.UT_Piping_Density },
                { ParameterType.PipingFlow, UnitType.UT_Piping_Flow },
                { ParameterType.PipingFriction, UnitType.UT_Piping_Friction },
                { ParameterType.PipingPressure, UnitType.UT_Piping_Pressure },
                { ParameterType.PipingTemperature, UnitType.UT_Piping_Temperature },
                { ParameterType.PipingVelocity, UnitType.UT_Piping_Velocity },
                { ParameterType.PipingViscosity, UnitType.UT_Piping_Viscosity },
                { ParameterType.PipeSize, UnitType.UT_PipeSize },
                { ParameterType.PipingRoughness, UnitType.UT_Piping_Roughness },
                { ParameterType.Stress, UnitType.UT_Stress },
                { ParameterType.UnitWeight, UnitType.UT_UnitWeight },
                { ParameterType.ThermalExpansion, UnitType.UT_ThermalExpansion },
                { ParameterType.LinearMoment, UnitType.UT_LinearMoment },
                { ParameterType.ForcePerLength, UnitType.UT_ForcePerLength },
                { ParameterType.ForceLengthPerAngle, UnitType.UT_ForceLengthPerAngle },
                { ParameterType.LinearForcePerLength, UnitType.UT_LinearForcePerLength },
                { ParameterType.LinearForceLengthPerAngle, UnitType.UT_LinearForceLengthPerAngle },
                { ParameterType.AreaForcePerLength, UnitType.UT_AreaForcePerLength },
                { ParameterType.PipingVolume, UnitType.UT_Piping_Volume },
                { ParameterType.HVACViscosity, UnitType.UT_HVAC_Viscosity },
                { ParameterType.HVACCoefficientOfHeatTransfer, UnitType.UT_HVAC_CoefficientOfHeatTransfer },
                { ParameterType.HVACAirflowDensity, UnitType.UT_HVAC_Airflow_Density },
                { ParameterType.Slope, UnitType.UT_Slope },
                { ParameterType.HVACCoolingLoad, UnitType.UT_HVAC_Cooling_Load },
                { ParameterType.HVACCoolingLoadDividedByArea, UnitType.UT_HVAC_Cooling_Load_Divided_By_Area },
                { ParameterType.HVACCoolingLoadDividedByVolume, UnitType.UT_HVAC_Cooling_Load_Divided_By_Volume },
                { ParameterType.HVACHeatingLoad, UnitType.UT_HVAC_Heating_Load },
                { ParameterType.HVACHeatingLoadDividedByArea, UnitType.UT_HVAC_Heating_Load_Divided_By_Area },
                { ParameterType.HVACHeatingLoadDividedByVolume, UnitType.UT_HVAC_Heating_Load_Divided_By_Volume },
                { ParameterType.HVACAirflowDividedByVolume, UnitType.UT_HVAC_Airflow_Divided_By_Volume },
                { ParameterType.HVACAirflowDividedByCoolingLoad, UnitType.UT_HVAC_Airflow_Divided_By_Cooling_Load },
                { ParameterType.HVACAreaDividedByCoolingLoad, UnitType.UT_HVAC_Area_Divided_By_Cooling_Load },
                { ParameterType.WireSize, UnitType.UT_WireSize },
                { ParameterType.HVACSlope, UnitType.UT_HVAC_Slope },
                { ParameterType.PipingSlope, UnitType.UT_Piping_Slope },
                { ParameterType.Currency, UnitType.UT_Currency },
                { ParameterType.ElectricalEfficacy, UnitType.UT_Electrical_Efficacy },
                { ParameterType.ElectricalWattage, UnitType.UT_Electrical_Wattage },
                { ParameterType.ColorTemperature, UnitType.UT_Color_Temperature },
                { ParameterType.ElectricalLuminousIntensity, UnitType.UT_Electrical_Luminous_Intensity },
                { ParameterType.ElectricalLuminance, UnitType.UT_Electrical_Luminance },
                { ParameterType.HVACAreaDividedByHeatingLoad, UnitType.UT_HVAC_Area_Divided_By_Heating_Load },
                { ParameterType.HVACFactor, UnitType.UT_HVAC_Factor },
                { ParameterType.ElectricalTemperature, UnitType.UT_Electrical_Temperature },
                { ParameterType.ElectricalCableTraySize, UnitType.UT_Electrical_CableTraySize },
                { ParameterType.ElectricalConduitSize, UnitType.UT_Electrical_ConduitSize },
                { ParameterType.ReinforcementVolume, UnitType.UT_Reinforcement_Volume },
                { ParameterType.ReinforcementLength, UnitType.UT_Reinforcement_Length },
                { ParameterType.ElectricalDemandFactor, UnitType.UT_Electrical_Demand_Factor },
                { ParameterType.HVACDuctInsulationThickness, UnitType.UT_HVAC_DuctInsulationThickness },
                { ParameterType.HVACDuctLiningThickness, UnitType.UT_HVAC_DuctLiningThickness },
                { ParameterType.PipeInsulationThickness, UnitType.UT_PipeInsulationThickness },
                { ParameterType.HVACThermalResistance, UnitType.UT_HVAC_ThermalResistance },
                { ParameterType.HVACThermalMass, UnitType.UT_HVAC_ThermalMass },
                { ParameterType.Acceleration, UnitType.UT_Acceleration },
                { ParameterType.BarDiameter, UnitType.UT_Bar_Diameter },
                { ParameterType.CrackWidth, UnitType.UT_Crack_Width },
                { ParameterType.DisplacementDeflection, UnitType.UT_Displacement_Deflection },
                { ParameterType.Energy, UnitType.UT_Energy },
                { ParameterType.StructuralFrequency, UnitType.UT_Structural_Frequency },
                { ParameterType.Mass, UnitType.UT_Mass },
                { ParameterType.MassPerUnitLength, UnitType.UT_Mass_per_Unit_Length },
                { ParameterType.MomentOfInertia, UnitType.UT_Moment_of_Inertia },
                { ParameterType.SurfaceArea, UnitType.UT_Surface_Area },
                { ParameterType.Period, UnitType.UT_Period },
                { ParameterType.Pulsation, UnitType.UT_Pulsation },
                { ParameterType.ReinforcementArea, UnitType.UT_Reinforcement_Area },
                { ParameterType.ReinforcementAreaPerUnitLength, UnitType.UT_Reinforcement_Area_per_Unit_Length },
                { ParameterType.ReinforcementCover, UnitType.UT_Reinforcement_Cover },
                { ParameterType.ReinforcementSpacing, UnitType.UT_Reinforcement_Spacing },
                { ParameterType.Rotation, UnitType.UT_Rotation },
                { ParameterType.SectionArea, UnitType.UT_Section_Area },
                { ParameterType.SectionDimension, UnitType.UT_Section_Dimension },
                { ParameterType.SectionModulus, UnitType.UT_Section_Modulus },
                { ParameterType.SectionProperty, UnitType.UT_Section_Property },
                { ParameterType.StructuralVelocity, UnitType.UT_Structural_Velocity },
                { ParameterType.WarpingConstant, UnitType.UT_Warping_Constant },
                { ParameterType.Weight, UnitType.UT_Weight },
                { ParameterType.WeightPerUnitLength, UnitType.UT_Weight_per_Unit_Length },
                { ParameterType.HVACThermalConductivity, UnitType.UT_HVAC_ThermalConductivity },
                { ParameterType.HVACSpecificHeat, UnitType.UT_HVAC_SpecificHeat },
                { ParameterType.HVACSpecificHeatOfVaporization, UnitType.UT_HVAC_SpecificHeatOfVaporization },
                { ParameterType.HVACPermeability, UnitType.UT_HVAC_Permeability },
                { ParameterType.ElectricalResistivity, UnitType.UT_Electrical_Resistivity },
                { ParameterType.MassDensity, UnitType.UT_MassDensity },
                { ParameterType.MassPerUnitArea, UnitType.UT_MassPerUnitArea },
                { ParameterType.PipeDimension, UnitType.UT_Pipe_Dimension },
                { ParameterType.PipeMass, UnitType.UT_PipeMass },
                { ParameterType.PipeMassPerUnitLength, UnitType.UT_PipeMassPerUnitLength },
                { ParameterType.HVACTemperatureDifference, UnitType.UT_HVAC_TemperatureDifference },
                { ParameterType.PipingTemperatureDifference, UnitType.UT_Piping_TemperatureDifference },
                { ParameterType.ElectricalTemperatureDifference, UnitType.UT_Electrical_TemperatureDifference },
            };
        }

        /// <summary>
        /// Converts DATATYPE of a shared parameter to <see cref="ParameterType"/>
        /// </summary>
        /// <param name="dataType">DATATYPE string to convert</param>
        /// <returns></returns>
        public static ParameterType FromSharedDataType(this string dataType)
        {
            var values = parameterTypes2Shared?.Where(u => u.Value.Equals(dataType, StringComparison.OrdinalIgnoreCase)).Select(x => x.Key).ToArray();
            return (values != null && values.Any())
                ? values.FirstOrDefault()
                : ParameterType.Invalid;
        }

        /// <summary>
        /// Converts <see cref="ParameterType"/> value to DATATYPE (shared parameter file)
        /// </summary>
        /// <param name="parameter">ParameterType value to convert</param>
        /// <returns></returns>
        public static string ToSharedDataType(this ParameterType parameter)
        {
            parameterTypes2Shared.TryGetValue(parameter, out string dataType);
            return dataType;
        }

        /// <summary>
        /// Ge value to UnityType
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static UnitType GetUnitType(this ParameterType parameter)
        {
            parameterTypes2UnitTypes.TryGetValue(parameter, out UnitType unitType);
            return unitType;
        }
    }
}
