#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

using System;

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.DisplayUnitType
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    ///    The units and display format used to format numbers as strings.  Also used for unit conversions.
    /// </summary>
    /// <remarks>
    ///      <para>Display units are used for two purposes:</para>
    ///      <list type="number">
    ///        <item>Formatting and parsing string representations of values.  See
    /// FormatOptions.DisplayUnit and the formatting and parsing utilities
    /// in the UnitFormatUtils class.</item>
    ///        <item>Conversion of values from one unit to another.  See the unit
    /// conversion utilities in the UnitUtils class.</item>
    ///      </list>
    ///      <para>Most display units represent simple units like meters, square
    /// feet, or degrees, and are formatted as decimal numbers.  Some
    /// display units represent specialized formatting methods like "feet
    /// and fractional inches" or "degrees, minutes and seconds".  Such
    /// display units still correspond to an underlying simple unit when
    /// used with the conversion utilities.</para>
    ///    </remarks>
    [Obsolete("This enumeration is deprecated in Revit 2021 and may be removed in a future version of Revit. Please use the `ForgeTypeId` class instead. Use constant members of the `UnitTypeId` class to replace uses of specific values of this enumeration.")]
    public enum DisplayUnitType
    {
        DUT_UNDEFINED = -2, // 0xFFFFFFFE
        DUT_CUSTOM = -1, // 0xFFFFFFFF
        DUT_METERS = 0,
        DUT_CENTIMETERS = 1,
        DUT_MILLIMETERS = 2,
        DUT_DECIMAL_FEET = 3,
        DUT_FEET_FRACTIONAL_INCHES = 4,
        DUT_FRACTIONAL_INCHES = 5,
        DUT_DECIMAL_INCHES = 6,
        DUT_ACRES = 7,
        DUT_HECTARES = 8,
        DUT_METERS_CENTIMETERS = 9,
        DUT_CUBIC_YARDS = 10, // 0x0000000A
        DUT_SQUARE_FEET = 11, // 0x0000000B
        DUT_SQUARE_METERS = 12, // 0x0000000C
        DUT_CUBIC_FEET = 13, // 0x0000000D
        DUT_CUBIC_METERS = 14, // 0x0000000E
        DUT_DECIMAL_DEGREES = 15, // 0x0000000F
        DUT_DEGREES_AND_MINUTES = 16, // 0x00000010
        DUT_GENERAL = 17, // 0x00000011
        DUT_FIXED = 18, // 0x00000012
        DUT_PERCENTAGE = 19, // 0x00000013
        DUT_SQUARE_INCHES = 20, // 0x00000014
        DUT_SQUARE_CENTIMETERS = 21, // 0x00000015
        DUT_SQUARE_MILLIMETERS = 22, // 0x00000016
        DUT_CUBIC_INCHES = 23, // 0x00000017
        DUT_CUBIC_CENTIMETERS = 24, // 0x00000018
        DUT_CUBIC_MILLIMETERS = 25, // 0x00000019
        /// <summary>liter (L).</summary>
        DUT_LITERS = 26, // 0x0000001A
        /// <summary>gallon (U.S.) (gal).</summary>
        DUT_GALLONS_US = 27, // 0x0000001B
        /// <summary>kilogram per cubic meter (kg/m³).</summary>
        DUT_KILOGRAMS_PER_CUBIC_METER = 28, // 0x0000001C
        /// <summary>pound per cubic foot (lb/ft³).</summary>
        DUT_POUNDS_MASS_PER_CUBIC_FOOT = 29, // 0x0000001D
        /// <summary>pound per cubic inch (lb/in³).</summary>
        DUT_POUNDS_MASS_PER_CUBIC_INCH = 30, // 0x0000001E
        /// <summary>British thermal unit[IT] (Btu[IT]).</summary>
        DUT_BRITISH_THERMAL_UNITS = 31, // 0x0000001F
        /// <summary>calorie[IT] (cal[IT]).</summary>
        DUT_CALORIES = 32, // 0x00000020
        /// <summary>kilocalorie[IT] (kcal[IT]).</summary>
        DUT_KILOCALORIES = 33, // 0x00000021
        /// <summary>joule (J).</summary>
        DUT_JOULES = 34, // 0x00000022
        /// <summary>kilowatt hour (kW · h).</summary>
        DUT_KILOWATT_HOURS = 35, // 0x00000023
        /// <summary>therm (EC).</summary>
        DUT_THERMS = 36, // 0x00000024
        /// <summary>Inches of water per 100 feet.</summary>
        DUT_INCHES_OF_WATER_PER_100FT = 37, // 0x00000025
        /// <summary>pascal per meter (N/m).</summary>
        DUT_PASCALS_PER_METER = 38, // 0x00000026
        /// <summary>watt (W).</summary>
        DUT_WATTS = 39, // 0x00000027
        /// <summary>kilowatt (kW).</summary>
        DUT_KILOWATTS = 40, // 0x00000028
        /// <summary>British thermal unit[IT] per second (Btu[IT]/s).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_SECOND = 41, // 0x00000029
        /// <summary>British thermal unit[IT] per hour (Btu[IT]/h).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR = 42, // 0x0000002A
        /// <summary>calorie[IT] per second (cal[IT]/s).</summary>
        DUT_CALORIES_PER_SECOND = 43, // 0x0000002B
        /// <summary>kilocalorie[IT] per second (kcal[IT]/s).</summary>
        DUT_KILOCALORIES_PER_SECOND = 44, // 0x0000002C
        /// <summary>watt per square foot (W/ft²).</summary>
        DUT_WATTS_PER_SQUARE_FOOT = 45, // 0x0000002D
        /// <summary>watt per square meter (W/m²).</summary>
        DUT_WATTS_PER_SQUARE_METER = 46, // 0x0000002E
        /// <summary>inch of water (60.8°F).</summary>
        DUT_INCHES_OF_WATER = 47, // 0x0000002F
        /// <summary>pascal (Pa).</summary>
        DUT_PASCALS = 48, // 0x00000030
        /// <summary>kilopascal (kPa).</summary>
        DUT_KILOPASCALS = 49, // 0x00000031
        /// <summary>megapascal (MPa).</summary>
        DUT_MEGAPASCALS = 50, // 0x00000032
        /// <summary>pound-force per square inch (psi) (lbf/in2).</summary>
        DUT_POUNDS_FORCE_PER_SQUARE_INCH = 51, // 0x00000033
        /// <summary>inch of mercury  conventional (inHg).</summary>
        DUT_INCHES_OF_MERCURY = 52, // 0x00000034
        /// <summary>millimeter of mercury  conventional (mmHg).</summary>
        DUT_MILLIMETERS_OF_MERCURY = 53, // 0x00000035
        /// <summary>atmosphere  standard (atm).</summary>
        DUT_ATMOSPHERES = 54, // 0x00000036
        /// <summary>bar (bar).</summary>
        DUT_BARS = 55, // 0x00000037
        /// <summary>degree Fahrenheit (°F).</summary>
        DUT_FAHRENHEIT = 56, // 0x00000038
        /// <summary>degree Celsius (°C).</summary>
        DUT_CELSIUS = 57, // 0x00000039
        /// <summary>kelvin (K).</summary>
        DUT_KELVIN = 58, // 0x0000003A
        /// <summary>degree Rankine (°R).</summary>
        DUT_RANKINE = 59, // 0x0000003B
        /// <summary>foot per minute (ft/min).</summary>
        DUT_FEET_PER_MINUTE = 60, // 0x0000003C
        /// <summary>meter per second (m/s).</summary>
        DUT_METERS_PER_SECOND = 61, // 0x0000003D
        /// <summary>centimeter per minute (cm/min).</summary>
        DUT_CENTIMETERS_PER_MINUTE = 62, // 0x0000003E
        /// <summary>cubic foot per minute (ft³/min).</summary>
        DUT_CUBIC_FEET_PER_MINUTE = 63, // 0x0000003F
        /// <summary>liter per second (L/s).</summary>
        DUT_LITERS_PER_SECOND = 64, // 0x00000040
        /// <summary>cubic meter per second (m³/s).</summary>
        DUT_CUBIC_METERS_PER_SECOND = 65, // 0x00000041
        /// <summary>cubic meters per hour (m³/h).</summary>
        DUT_CUBIC_METERS_PER_HOUR = 66, // 0x00000042
        /// <summary>gallon (U.S.) per minute (gpm) (gal/min).</summary>
        DUT_GALLONS_US_PER_MINUTE = 67, // 0x00000043
        /// <summary>gallon (U.S.) per hour (gph) (gal/h).</summary>
        DUT_GALLONS_US_PER_HOUR = 68, // 0x00000044
        /// <summary>ampere (A).</summary>
        DUT_AMPERES = 69, // 0x00000045
        /// <summary>kiloampere (kA).</summary>
        DUT_KILOAMPERES = 70, // 0x00000046
        /// <summary>milliampere (mA).</summary>
        DUT_MILLIAMPERES = 71, // 0x00000047
        /// <summary>volt (V).</summary>
        DUT_VOLTS = 72, // 0x00000048
        /// <summary>kilovolt (kV).</summary>
        DUT_KILOVOLTS = 73, // 0x00000049
        /// <summary>millivolt (mV).</summary>
        DUT_MILLIVOLTS = 74, // 0x0000004A
        /// <summary>hertz (Hz).</summary>
        DUT_HERTZ = 75, // 0x0000004B
        DUT_CYCLES_PER_SECOND = 76, // 0x0000004C
        /// <summary>lux (lx).</summary>
        DUT_LUX = 77, // 0x0000004D
        /// <summary>footcandle.</summary>
        DUT_FOOTCANDLES = 78, // 0x0000004E
        /// <summary>footlambert.</summary>
        DUT_FOOTLAMBERTS = 79, // 0x0000004F
        /// <summary>candela per square meter (cd/m²).</summary>
        DUT_CANDELAS_PER_SQUARE_METER = 80, // 0x00000050
        /// <summary>candela (cd).</summary>
        DUT_CANDELAS = 81, // 0x00000051
        /// <summary>obsolete.</summary>
        DUT_CANDLEPOWER = 82, // 0x00000052
        /// <summary>lumen (lm).</summary>
        DUT_LUMENS = 83, // 0x00000053
        DUT_VOLT_AMPERES = 84, // 0x00000054
        DUT_KILOVOLT_AMPERES = 85, // 0x00000055
        /// <summary>horsepower (550 ft · lbf/s).</summary>
        DUT_HORSEPOWER = 86, // 0x00000056
        DUT_NEWTONS = 87, // 0x00000057
        DUT_DECANEWTONS = 88, // 0x00000058
        DUT_KILONEWTONS = 89, // 0x00000059
        DUT_MEGANEWTONS = 90, // 0x0000005A
        DUT_KIPS = 91, // 0x0000005B
        DUT_KILOGRAMS_FORCE = 92, // 0x0000005C
        DUT_TONNES_FORCE = 93, // 0x0000005D
        DUT_POUNDS_FORCE = 94, // 0x0000005E
        DUT_NEWTONS_PER_METER = 95, // 0x0000005F
        DUT_DECANEWTONS_PER_METER = 96, // 0x00000060
        DUT_KILONEWTONS_PER_METER = 97, // 0x00000061
        DUT_MEGANEWTONS_PER_METER = 98, // 0x00000062
        DUT_KIPS_PER_FOOT = 99, // 0x00000063
        DUT_KILOGRAMS_FORCE_PER_METER = 100, // 0x00000064
        DUT_TONNES_FORCE_PER_METER = 101, // 0x00000065
        DUT_POUNDS_FORCE_PER_FOOT = 102, // 0x00000066
        DUT_NEWTONS_PER_SQUARE_METER = 103, // 0x00000067
        DUT_DECANEWTONS_PER_SQUARE_METER = 104, // 0x00000068
        DUT_KILONEWTONS_PER_SQUARE_METER = 105, // 0x00000069
        DUT_MEGANEWTONS_PER_SQUARE_METER = 106, // 0x0000006A
        DUT_KIPS_PER_SQUARE_FOOT = 107, // 0x0000006B
        DUT_KILOGRAMS_FORCE_PER_SQUARE_METER = 108, // 0x0000006C
        DUT_TONNES_FORCE_PER_SQUARE_METER = 109, // 0x0000006D
        DUT_POUNDS_FORCE_PER_SQUARE_FOOT = 110, // 0x0000006E
        DUT_NEWTON_METERS = 111, // 0x0000006F
        DUT_DECANEWTON_METERS = 112, // 0x00000070
        DUT_KILONEWTON_METERS = 113, // 0x00000071
        DUT_MEGANEWTON_METERS = 114, // 0x00000072
        DUT_KIP_FEET = 115, // 0x00000073
        DUT_KILOGRAM_FORCE_METERS = 116, // 0x00000074
        DUT_TONNE_FORCE_METERS = 117, // 0x00000075
        DUT_POUND_FORCE_FEET = 118, // 0x00000076
        DUT_METERS_PER_KILONEWTON = 119, // 0x00000077
        DUT_FEET_PER_KIP = 120, // 0x00000078
        DUT_SQUARE_METERS_PER_KILONEWTON = 121, // 0x00000079
        DUT_SQUARE_FEET_PER_KIP = 122, // 0x0000007A
        DUT_CUBIC_METERS_PER_KILONEWTON = 123, // 0x0000007B
        DUT_CUBIC_FEET_PER_KIP = 124, // 0x0000007C
        DUT_INV_KILONEWTONS = 125, // 0x0000007D
        DUT_INV_KIPS = 126, // 0x0000007E
        /// <summary>foot of water  conventional (ftH2O) per 100 ft.</summary>
        DUT_FEET_OF_WATER_PER_100FT = 127, // 0x0000007F
        /// <summary>foot of water  conventional (ftH2O).</summary>
        DUT_FEET_OF_WATER = 128, // 0x00000080
        /// <summary>pascal second (Pa · s).</summary>
        DUT_PASCAL_SECONDS = 129, // 0x00000081
        /// <summary>pound per foot second (lb/(ft · s)).</summary>
        DUT_POUNDS_MASS_PER_FOOT_SECOND = 130, // 0x00000082
        /// <summary>centipoise (cP).</summary>
        DUT_CENTIPOISES = 131, // 0x00000083
        /// <summary>foot per second (ft/s).</summary>
        DUT_FEET_PER_SECOND = 132, // 0x00000084
        DUT_KIPS_PER_SQUARE_INCH = 133, // 0x00000085
        /// <summary>kilnewtons per cubic meter (kN/m³).</summary>
        DUT_KILONEWTONS_PER_CUBIC_METER = 134, // 0x00000086
        /// <summary>pound per cubic foot (kip/ft³).</summary>
        DUT_POUNDS_FORCE_PER_CUBIC_FOOT = 135, // 0x00000087
        /// <summary>pound per cubic foot (kip/in³).</summary>
        DUT_KIPS_PER_CUBIC_INCH = 136, // 0x00000088
        DUT_INV_FAHRENHEIT = 137, // 0x00000089
        DUT_INV_CELSIUS = 138, // 0x0000008A
        DUT_NEWTON_METERS_PER_METER = 139, // 0x0000008B
        DUT_DECANEWTON_METERS_PER_METER = 140, // 0x0000008C
        DUT_KILONEWTON_METERS_PER_METER = 141, // 0x0000008D
        DUT_MEGANEWTON_METERS_PER_METER = 142, // 0x0000008E
        DUT_KIP_FEET_PER_FOOT = 143, // 0x0000008F
        DUT_KILOGRAM_FORCE_METERS_PER_METER = 144, // 0x00000090
        DUT_TONNE_FORCE_METERS_PER_METER = 145, // 0x00000091
        DUT_POUND_FORCE_FEET_PER_FOOT = 146, // 0x00000092
        /// <summary>pound per foot hour (lb/(ft · h)).</summary>
        DUT_POUNDS_MASS_PER_FOOT_HOUR = 147, // 0x00000093
        DUT_KIPS_PER_INCH = 148, // 0x00000094
        /// <summary>pound per cubic foot (kip/ft³).</summary>
        DUT_KIPS_PER_CUBIC_FOOT = 149, // 0x00000095
        DUT_KIP_FEET_PER_DEGREE = 150, // 0x00000096
        DUT_KILONEWTON_METERS_PER_DEGREE = 151, // 0x00000097
        DUT_KIP_FEET_PER_DEGREE_PER_FOOT = 152, // 0x00000098
        DUT_KILONEWTON_METERS_PER_DEGREE_PER_METER = 153, // 0x00000099
        /// <summary>watt per square meter kelvin (W/(m² · K)).</summary>
        DUT_WATTS_PER_SQUARE_METER_KELVIN = 154, // 0x0000009A
        /// <summary>
        ///    British thermal unit[IT] per hour square foot degree Fahrenheit (Btu[IT]/(h · ft² · °F).
        /// </summary>
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_SQUARE_FOOT_FAHRENHEIT = 155, // 0x0000009B
        /// <summary>cubic foot per minute square foot.</summary>
        DUT_CUBIC_FEET_PER_MINUTE_SQUARE_FOOT = 156, // 0x0000009C
        /// <summary>liter per second square meter.</summary>
        DUT_LITERS_PER_SECOND_SQUARE_METER = 157, // 0x0000009D
        DUT_RATIO_10 = 158, // 0x0000009E
        DUT_RATIO_12 = 159, // 0x0000009F
        DUT_SLOPE_DEGREES = 160, // 0x000000A0
        DUT_RISE_OVER_INCHES = 161, // 0x000000A1
        DUT_RISE_OVER_FOOT = 162, // 0x000000A2
        DUT_RISE_OVER_MMS = 163, // 0x000000A3
        /// <summary>watt per cubic foot (W/m³).</summary>
        DUT_WATTS_PER_CUBIC_FOOT = 164, // 0x000000A4
        /// <summary>watt per cubic meter (W/m³).</summary>
        DUT_WATTS_PER_CUBIC_METER = 165, // 0x000000A5
        /// <summary>British thermal unit[IT] per hour square foot (Btu[IT]/(h · ft²).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_SQUARE_FOOT = 166, // 0x000000A6
        /// <summary>British thermal unit[IT] per hour cubic foot (Btu[IT]/(h · ft³).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_CUBIC_FOOT = 167, // 0x000000A7
        /// <summary>Ton of refrigeration (12 000 Btu[IT]/h).</summary>
        DUT_TON_OF_REFRIGERATION = 168, // 0x000000A8
        /// <summary>cubic foot per minute cubic foot.</summary>
        DUT_CUBIC_FEET_PER_MINUTE_CUBIC_FOOT = 169, // 0x000000A9
        /// <summary>liter per second cubic meter.</summary>
        DUT_LITERS_PER_SECOND_CUBIC_METER = 170, // 0x000000AA
        /// <summary>cubic foot per minute ton of refrigeration.</summary>
        DUT_CUBIC_FEET_PER_MINUTE_TON_OF_REFRIGERATION = 171, // 0x000000AB
        /// <summary>liter per second kilowatt.</summary>
        DUT_LITERS_PER_SECOND_KILOWATTS = 172, // 0x000000AC
        /// <summary>square foot per ton of refrigeration.</summary>
        DUT_SQUARE_FEET_PER_TON_OF_REFRIGERATION = 173, // 0x000000AD
        /// <summary>square meter per kilowatt.</summary>
        DUT_SQUARE_METERS_PER_KILOWATTS = 174, // 0x000000AE
        DUT_CURRENCY = 175, // 0x000000AF
        DUT_LUMENS_PER_WATT = 176, // 0x000000B0
        /// <summary>square foot per thousand British thermal unit[IT] per hour.</summary>
        DUT_SQUARE_FEET_PER_THOUSAND_BRITISH_THERMAL_UNITS_PER_HOUR = 177, // 0x000000B1
        DUT_KILONEWTONS_PER_SQUARE_CENTIMETER = 178, // 0x000000B2
        DUT_NEWTONS_PER_SQUARE_MILLIMETER = 179, // 0x000000B3
        DUT_KILONEWTONS_PER_SQUARE_MILLIMETER = 180, // 0x000000B4
        DUT_RISE_OVER_120_INCHES = 181, // 0x000000B5
        DUT_1_RATIO = 182, // 0x000000B6
        DUT_RISE_OVER_10_FEET = 183, // 0x000000B7
        DUT_HOUR_SQUARE_FOOT_FAHRENHEIT_PER_BRITISH_THERMAL_UNIT = 184, // 0x000000B8
        DUT_SQUARE_METER_KELVIN_PER_WATT = 185, // 0x000000B9
        DUT_BRITISH_THERMAL_UNIT_PER_FAHRENHEIT = 186, // 0x000000BA
        DUT_JOULES_PER_KELVIN = 187, // 0x000000BB
        DUT_KILOJOULES_PER_KELVIN = 188, // 0x000000BC
        /// <summary>kilograms (kg).</summary>
        DUT_KILOGRAMS_MASS = 189, // 0x000000BD
        /// <summary>tonnes (t).</summary>
        DUT_TONNES_MASS = 190, // 0x000000BE
        /// <summary>pounds (lb).</summary>
        DUT_POUNDS_MASS = 191, // 0x000000BF
        /// <summary>meters per second squared (m/s²).</summary>
        DUT_METERS_PER_SECOND_SQUARED = 192, // 0x000000C0
        /// <summary>kilometers per second squared (km/s²).</summary>
        DUT_KILOMETERS_PER_SECOND_SQUARED = 193, // 0x000000C1
        /// <summary>inches per second squared (in/s²).</summary>
        DUT_INCHES_PER_SECOND_SQUARED = 194, // 0x000000C2
        /// <summary>feet per second squared (ft/s²).</summary>
        DUT_FEET_PER_SECOND_SQUARED = 195, // 0x000000C3
        /// <summary>miles per second squared (mi/s²).</summary>
        DUT_MILES_PER_SECOND_SQUARED = 196, // 0x000000C4
        /// <summary>feet to the fourth power	(ft^4).</summary>
        DUT_FEET_TO_THE_FOURTH_POWER = 197, // 0x000000C5
        /// <summary>inches to the fourth power	(in^4).</summary>
        DUT_INCHES_TO_THE_FOURTH_POWER = 198, // 0x000000C6
        /// <summary>millimeters to the fourth power	(mm^4).</summary>
        DUT_MILLIMETERS_TO_THE_FOURTH_POWER = 199, // 0x000000C7
        /// <summary>centimeters to the fourth power	(cm^4).</summary>
        DUT_CENTIMETERS_TO_THE_FOURTH_POWER = 200, // 0x000000C8
        /// <summary>Meters to the fourth power	(m^4).</summary>
        DUT_METERS_TO_THE_FOURTH_POWER = 201, // 0x000000C9
        /// <summary>feet to the sixth power	(ft^6).</summary>
        DUT_FEET_TO_THE_SIXTH_POWER = 202, // 0x000000CA
        /// <summary>inches to the sixth power	(in^6).</summary>
        DUT_INCHES_TO_THE_SIXTH_POWER = 203, // 0x000000CB
        /// <summary>millimeters to the sixth power	(mm^6).</summary>
        DUT_MILLIMETERS_TO_THE_SIXTH_POWER = 204, // 0x000000CC
        /// <summary>centimeters to the sixth power	(cm^6).</summary>
        DUT_CENTIMETERS_TO_THE_SIXTH_POWER = 205, // 0x000000CD
        /// <summary>meters to the sixth power	(m^6).</summary>
        DUT_METERS_TO_THE_SIXTH_POWER = 206, // 0x000000CE
        /// <summary>square feet per foot	(ft²/ft).</summary>
        DUT_SQUARE_FEET_PER_FOOT = 207, // 0x000000CF
        /// <summary>square inches per foot	(in²/ft).</summary>
        DUT_SQUARE_INCHES_PER_FOOT = 208, // 0x000000D0
        /// <summary>square millimeters per meter	(mm²/m).</summary>
        DUT_SQUARE_MILLIMETERS_PER_METER = 209, // 0x000000D1
        /// <summary>square centimeters per meter	(cm²/m).</summary>
        DUT_SQUARE_CENTIMETERS_PER_METER = 210, // 0x000000D2
        /// <summary>square meters per meter	(m²/m).</summary>
        DUT_SQUARE_METERS_PER_METER = 211, // 0x000000D3
        /// <summary>kilograms per meter (kg/m).</summary>
        DUT_KILOGRAMS_MASS_PER_METER = 212, // 0x000000D4
        /// <summary>pounds per foot (lb/ft).</summary>
        DUT_POUNDS_MASS_PER_FOOT = 213, // 0x000000D5
        /// <summary>radians.</summary>
        DUT_RADIANS = 214, // 0x000000D6
        /// <summary>grads.</summary>
        DUT_GRADS = 215, // 0x000000D7
        /// <summary>radians per second.</summary>
        DUT_RADIANS_PER_SECOND = 216, // 0x000000D8
        /// <summary>millisecond.</summary>
        DUT_MILISECONDS = 217, // 0x000000D9
        /// <summary>second.</summary>
        DUT_SECONDS = 218, // 0x000000DA
        /// <summary>minutes.</summary>
        DUT_MINUTES = 219, // 0x000000DB
        /// <summary>hours.</summary>
        DUT_HOURS = 220, // 0x000000DC
        /// <summary>kilometers per hour.</summary>
        DUT_KILOMETERS_PER_HOUR = 221, // 0x000000DD
        /// <summary>miles per hour.</summary>
        DUT_MILES_PER_HOUR = 222, // 0x000000DE
        /// <summary>kilojoules.</summary>
        DUT_KILOJOULES = 223, // 0x000000DF
        /// <summary>kilograms per square meter (kg/m²).</summary>
        DUT_KILOGRAMS_MASS_PER_SQUARE_METER = 224, // 0x000000E0
        /// <summary>pounds per square foot (lb/ft²).</summary>
        DUT_POUNDS_MASS_PER_SQUARE_FOOT = 225, // 0x000000E1
        /// <summary>Watts per meter kelvin (W/(m·K)).</summary>
        DUT_WATTS_PER_METER_KELVIN = 226, // 0x000000E2
        /// <summary>Joules per gram Celsius (J/(g·°C)).</summary>
        DUT_JOULES_PER_GRAM_CELSIUS = 227, // 0x000000E3
        /// <summary>Joules per gram (J/g).</summary>
        DUT_JOULES_PER_GRAM = 228, // 0x000000E4
        /// <summary>Nanograms per pascal second square meter (ng/(Pa·s·m²)).</summary>
        DUT_NANOGRAMS_PER_PASCAL_SECOND_SQUARE_METER = 229, // 0x000000E5
        /// <summary>Ohm meters.</summary>
        DUT_OHM_METERS = 230, // 0x000000E6
        /// <summary>BTU per hour foot Fahrenheit (BTU/(h·ft·°F)).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_HOUR_FOOT_FAHRENHEIT = 231, // 0x000000E7
        /// <summary>BTU per pound Fahrenheit (BTU/(lb·°F)).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_POUND_FAHRENHEIT = 232, // 0x000000E8
        /// <summary>BTU per pound (BTU/lb).</summary>
        DUT_BRITISH_THERMAL_UNITS_PER_POUND = 233, // 0x000000E9
        /// <summary>Grains per hour square foot inch mercury (gr/(h·ft²·inHg)).</summary>
        DUT_GRAINS_PER_HOUR_SQUARE_FOOT_INCH_MERCURY = 234, // 0x000000EA
        /// <summary>Per mille or per thousand(‰).</summary>
        DUT_PER_MILLE = 235, // 0x000000EB
        /// <summary>Decimeters.</summary>
        DUT_DECIMETERS = 236, // 0x000000EC
        /// <summary>Joules per kilogram Celsius (J/(kg·°C)).</summary>
        DUT_JOULES_PER_KILOGRAM_CELSIUS = 237, // 0x000000ED
        /// <summary>Micrometers per meter Celsius (um/(m·°C)).</summary>
        DUT_MICROMETERS_PER_METER_CELSIUS = 238, // 0x000000EE
        /// <summary>Microinches per inch Fahrenheit (uin/(in·°F)).</summary>
        DUT_MICROINCHES_PER_INCH_FAHRENHEIT = 239, // 0x000000EF
        /// <summary>US tonnes (T, Tons, ST).</summary>
        DUT_USTONNES_MASS = 240, // 0x000000F0
        /// <summary>US tonnes (Tonsf, STf).</summary>
        DUT_USTONNES_FORCE = 241, // 0x000000F1
        /// <summary>liters per minute (L/min).</summary>
        DUT_LITERS_PER_MINUTE = 242, // 0x000000F2
        /// <summary>degree Fahrenheit difference (delta °F).</summary>
        DUT_FAHRENHEIT_DIFFERENCE = 243, // 0x000000F3
        /// <summary>degree Celsius difference (delta °C).</summary>
        DUT_CELSIUS_DIFFERENCE = 244, // 0x000000F4
        /// <summary>kelvin difference (delta K).</summary>
        DUT_KELVIN_DIFFERENCE = 245, // 0x000000F5
        /// <summary>degree Rankine difference (delta °R).</summary>
        DUT_RANKINE_DIFFERENCE = 246, // 0x000000F6
        /// <summary>
        ///    stationing meters value (XXX+YYY.ZZZ (base is always 1000 meters, YYY is always 3 digits) 1024.555 = 1+024.555).
        /// </summary>
        DUT_STATIONING_METERS = 247, // 0x000000F7
        /// <summary>
        ///    stationing feet value (XXX+YY.ZZZ Decimal Feet (base is always 100 feet, YY is always 2 digits) 1024.555 = 10+24.555).
        /// </summary>
        DUT_STATIONING_FEET = 248, // 0x000000F8
        /// <summary>cubic feet per hour.</summary>
        DUT_CUBIC_FEET_PER_HOUR = 249, // 0x000000F9
        /// <summary>liters per hour.</summary>
        DUT_LITERS_PER_HOUR = 250, // 0x000000FA
        /// <summary>ratio to 1.</summary>
        DUT_RATIO_TO_1 = 251, // 0x000000FB
        DUT_DECIMAL_US_SURVEY_FEET = 605, // 0x0000025D
    }
}
