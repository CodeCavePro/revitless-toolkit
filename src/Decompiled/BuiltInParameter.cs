#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1591

// ReSharper disable InconsistentNaming

// Decompiled with JetBrains decompiler
// Type: Autodesk.Revit.DB.BuiltInParameter
// Assembly: RevitAPI, Version=21.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E5118772-F025-44D6-A6E2-B8EDEDB90979
// Assembly location: C:\Program Files\Autodesk\Revit 2021\RevitAPI.dll
namespace CodeCave.Revit.Toolkit
{
    /// <summary>An enumerated type listing all of the built-in parameter IDs supported by Autodesk
    /// Revit.</summary>
    /// <remarks>
    /// The ID of the parameter can be used to retrieve property values from an Element
    /// by using the Element.Parameter property.
    /// The documentation for each ID includes the parameter name, as found in the
    /// Element Properties dialog in the English version of Autodesk Revit.  Note that
    /// multiple distinct parameter ids may map to the same English name; in those case you must
    /// examine the parameters associated with a specific element to determine
    /// which parameter id to use.</remarks>
    public enum BuiltInParameter
    {
        /// <summary>"Cuts Geometry"</summary>
        VOID_CUTS_GEOMETRY = -1155218, // 0xFFEE5F6E
        /// <summary>"Hook Rotation At End"</summary>
        REBAR_HOOK_ROTATION_AT_END_SCHEDULES_TAGS_FILTERS = -1155217, // 0xFFEE5F6F
        /// <summary>"Hook Rotation At Start"</summary>
        REBAR_HOOK_ROTATION_AT_START_SCHEDULES_TAGS_FILTERS = -1155216, // 0xFFEE5F70
        /// <summary>"Override Hook Lengths"</summary>
        REBAR_HOOK_LENGTH_OVERRIDE = -1155215, // 0xFFEE5F71
        /// <summary>"Name"</summary>
        INFRASTRUCTURE_ALIGNMENT_NAME = -1155214, // 0xFFEE5F72
        /// <summary>"Description"</summary>
        INFRASTRUCTURE_ALIGNMENT_DESCRIPTION = -1155213, // 0xFFEE5F73
        /// <summary>"Displayed Start Station"</summary>
        INFRASTRUCTURE_ALIGNMENT_DISPLAYED_START_STATION = -1155212, // 0xFFEE5F74
        /// <summary>"Displayed End Station"</summary>
        INFRASTRUCTURE_ALIGNMENT_DISPLAYED_END_STATION = -1155211, // 0xFFEE5F75
        /// <summary>"Disable Precast Updates"</summary>
        ASSEMBLY_PRECAST_FREEZE = -1155210, // 0xFFEE5F76
        /// <summary>"Hook Rotation At End"</summary>
        REBAR_HOOK_ROTATION_AT_END = -1155206, // 0xFFEE5F7A
        /// <summary>"Hook Rotation At Start"</summary>
        REBAR_HOOK_ROTATION_AT_START = -1155205, // 0xFFEE5F7B
        /// <summary>"Hook Rotation At End"</summary>
        REBAR_SHAPE_HOOK_ROTATION_AT_END = -1155204, // 0xFFEE5F7C
        /// <summary>"Hook Rotation At Start"</summary>
        REBAR_SHAPE_HOOK_ROTATION_AT_START = -1155203, // 0xFFEE5F7D
        /// <summary>"From Room"</summary>
        PATH_OF_TRAVEL_FROM_ROOM = -1155202, // 0xFFEE5F7E
        /// <summary>"To Room"</summary>
        PATH_OF_TRAVEL_TO_ROOM = -1155201, // 0xFFEE5F7F
        /// <summary>"Max Number of Circuits"</summary>
        RBS_ELEC_NUMBER_OF_CIRCUITS = -1155150, // 0xFFEE5FB2
        /// <summary>"Volume"</summary>
        STEEL_ELEM_PROFILE_VOLUME = -1155148, // 0xFFEE5FB4
        /// <summary>"Length"</summary>
        STEEL_ELEM_PROFILE_LENGTH = -1155147, // 0xFFEE5FB5
        /// <summary>"Profile Type"</summary>
        STEEL_ELEM_PROFILE_TYPE = -1155146, // 0xFFEE5FB6
        /// <summary>"Circuit Naming Settings"</summary>
        RBS_ELEC_EDIT_CIRCUIT_NAMING_SETTINGS_PARAM = -1155145, // 0xFFEE5FB7
        /// <summary>"Justification"</summary>
        STEEL_ELEM_PLATE_JUSTIFICATION = -1155144, // 0xFFEE5FB8
        /// <summary>"Paint Area"</summary>
        STEEL_ELEM_PLATE_PAINT_AREA = -1155143, // 0xFFEE5FB9
        /// <summary>"Exact Weight"</summary>
        STEEL_ELEM_PLATE_EXACT_WEIGHT = -1155142, // 0xFFEE5FBA
        /// <summary>"Weight"</summary>
        STEEL_ELEM_PLATE_WEIGHT = -1155141, // 0xFFEE5FBB
        /// <summary>"Volume"</summary>
        STEEL_ELEM_PLATE_VOLUME = -1155140, // 0xFFEE5FBC
        /// <summary>"Area"</summary>
        STEEL_ELEM_PLATE_AREA = -1155139, // 0xFFEE5FBD
        /// <summary>"Width"</summary>
        STEEL_ELEM_PLATE_WIDTH = -1155138, // 0xFFEE5FBE
        /// <summary>"Length"</summary>
        STEEL_ELEM_PLATE_LENGTH = -1155137, // 0xFFEE5FBF
        /// <summary>"Type"</summary>
        STEEL_ELEM_PLATE_TYPE = -1155136, // 0xFFEE5FC0
        /// <summary>"Total Weight"</summary>
        STEEL_ELEM_BOLT_TOTAL_WEIGHT = -1155135, // 0xFFEE5FC1
        /// <summary>"Total Weight"</summary>
        STEEL_ELEM_SHEARSTUD_TOTAL_WEIGHT = -1155134, // 0xFFEE5FC2
        /// <summary>"Total Weight"</summary>
        STEEL_ELEM_ANCHOR_TOTAL_WEIGHT = -1155132, // 0xFFEE5FC4
        /// <summary>"Anchor Orientation"</summary>
        STEEL_ELEM_ANCHOR_ORIENTATION = -1155130, // 0xFFEE5FC6
        /// <summary>"Cut Length"</summary>
        STEEL_ELEM_CUT_LENGTH = -1155128, // 0xFFEE5FC8
        /// <summary>"Exact Weight"</summary>
        STEEL_ELEM_EXACT_WEIGHT = -1155127, // 0xFFEE5FC9
        /// <summary>"Paint Area"</summary>
        STEEL_ELEM_PAINT_AREA = -1155125, // 0xFFEE5FCB
        /// <summary>"Weight"</summary>
        STEEL_ELEM_WEIGHT = -1155124, // 0xFFEE5FCC
        /// <summary>"Speed"</summary>
        PATH_OF_TRAVEL_SPEED = -1155123, // 0xFFEE5FCD
        /// <summary>"Location"</summary>
        STEEL_ELEM_BOLT_LOCATION = -1155122, // 0xFFEE5FCE
        /// <summary>"Finish Calculation At Gap"</summary>
        STEEL_ELEM_BOLT_FINISH_CALCULATION_AT_GAP = -1155121, // 0xFFEE5FCF
        /// <summary>"Inverted"</summary>
        STEEL_ELEM_BOLT_INVERTED = -1155120, // 0xFFEE5FD0
        /// <summary>"Grip Length Increase"</summary>
        STEEL_ELEM_BOLT_GRIP_LENGTH_INCREASE = -1155119, // 0xFFEE5FD1
        /// <summary>"Grip Length"</summary>
        STEEL_ELEM_BOLT_GRIP_LENGTH = -1155118, // 0xFFEE5FD2
        /// <summary>"Bolt Length"</summary>
        STEEL_ELEM_BOLT_LENGTH = -1155117, // 0xFFEE5FD3
        /// <summary>"Name"</summary>
        GENERIC_ZONE_NAME = -1155116, // 0xFFEE5FD4
        /// <summary>"Bottom Elevation"</summary>
        RBS_PIPE_BOTTOM_ELEVATION = -1155115, // 0xFFEE5FD5
        /// <summary>"Top Elevation"</summary>
        RBS_PIPE_TOP_ELEVATION = -1155114, // 0xFFEE5FD6
        /// <summary>"Feed Through Lugs Current Phase C"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEC = -1155113, // 0xFFEE5FD7
        /// <summary>"Feed Through Lugs Current Phase B"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEB = -1155112, // 0xFFEE5FD8
        /// <summary>"Feed Through Lugs Current Phase A"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_CURRENT_PHASEA = -1155111, // 0xFFEE5FD9
        /// <summary>"Feed Through Lugs Apparent Load Phase C"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEC = -1155110, // 0xFFEE5FDA
        /// <summary>"Feed Through Lugs Apparent Load Phase B"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEB = -1155109, // 0xFFEE5FDB
        /// <summary>"Feed Through Lugs Apparent Load Phase A"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_APPARENT_LOAD_PHASEA = -1155108, // 0xFFEE5FDC
        /// <summary>"Branch Circuit Current Phase C"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEC = -1155107, // 0xFFEE5FDD
        /// <summary>"Branch Circuit Current Phase B"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEB = -1155106, // 0xFFEE5FDE
        /// <summary>"Branch Circuit Current Phase A"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_CURRENT_PHASEA = -1155105, // 0xFFEE5FDF
        /// <summary>"Branch Circuit Apparent Load Phase C"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEC = -1155104, // 0xFFEE5FE0
        /// <summary>"Branch Circuit Apparent Load Phase B"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEB = -1155103, // 0xFFEE5FE1
        /// <summary>"Branch Circuit Apparent Load Phase A"</summary>
        RBS_ELEC_PANEL_BRANCH_CIRCUIT_APPARENT_LOAD_PHASEA = -1155102, // 0xFFEE5FE2
        /// <summary>"Hole Definition"</summary>
        STEEL_ELEM_HOLE_DEFINITION = -1155101, // 0xFFEE5FE3
        /// <summary>"Feed Through Lugs"</summary>
        RBS_ELEC_PANEL_FEED_THRU_LUGS_PARAM = -1155100, // 0xFFEE5FE4
        /// <summary>"Circuit Numbering Option"</summary>
        RBS_ELEC_CIRCUIT_NUMBERING_TYPE = -1155099, // 0xFFEE5FE5
        /// <summary>"Tag on Placement"</summary>
        TAG_ON_PLACEMENT_UI = -1155096, // 0xFFEE5FE8
        /// <summary>"Route Analysis Settings"</summary>
        ROUTE_ANALYSIS_SETTINGS_PARAM = -1155095, // 0xFFEE5FE9
        /// <summary>"View Name"</summary>
        PATH_OF_TRAVEL_VIEW_NAME = -1155094, // 0xFFEE5FEA
        /// <summary>"Level"</summary>
        PATH_OF_TRAVEL_LEVEL_NAME = -1155093, // 0xFFEE5FEB
        /// <summary>"Override by Instance"</summary>
        STRUCTURAL_CONNECTION_OVERRIDE_TYPE = -1155092, // 0xFFEE5FEC
        /// <summary>"Modify Parameters"</summary>
        STRUCTURAL_CONNECTION_EDIT_TYPE = -1155091, // 0xFFEE5FED
        /// <summary>"Time"</summary>
        PATH_OF_TRAVEL_TIME = -1155090, // 0xFFEE5FEE
        /// <summary>"Boundary"</summary>
        STEEL_ELEM_ZCLIP_TYPE = -1155087, // 0xFFEE5FF1
        /// <summary>"Around beam axis"</summary>
        STEEL_ELEM_COPE_AROUND_AXIS = -1155086, // 0xFFEE5FF2
        /// <summary>"Tilt angle"</summary>
        STEEL_ELEM_COPE_AXIS_ANGLE = -1155085, // 0xFFEE5FF3
        /// <summary>"Plan rotation"</summary>
        STEEL_ELEM_COPE_Z_ANGLE = -1155084, // 0xFFEE5FF4
        /// <summary>"Cross-section rotation"</summary>
        STEEL_ELEM_COPE_X_ANGLE = -1155083, // 0xFFEE5FF5
        /// <summary>"Distance from axis"</summary>
        STEEL_ELEM_COPE_DISTANCE_AXIS = -1155082, // 0xFFEE5FF6
        /// <summary>"Cutback"</summary>
        STEEL_ELEM_COPE_WIDTHX = -1155081, // 0xFFEE5FF7
        /// <summary>"Side 2"</summary>
        STEEL_ELEM_Y_DISTANCE = -1155080, // 0xFFEE5FF8
        /// <summary>"Side 1"</summary>
        STEEL_ELEM_X_DISTANCE = -1155079, // 0xFFEE5FF9
        /// <summary>"Type"</summary>
        STEEL_ELEM_CUT_TYPE = -1155078, // 0xFFEE5FFA
        /// <summary>"Cut straight"</summary>
        STEEL_ELEM_PLATE_SHORTEN_CUTSTRAIGHT = -1155077, // 0xFFEE5FFB
        /// <summary>"Suction"</summary>
        STEEL_ELEM_PLATE_SHORTEN_SUCTION = -1155076, // 0xFFEE5FFC
        /// <summary>"Angle"</summary>
        STEEL_ELEM_PLATE_SHORTEN_ANGLE = -1155075, // 0xFFEE5FFD
        /// <summary>"Prefix"</summary>
        STEEL_ELEM_WELD_PREFIX = -1155074, // 0xFFEE5FFE
        /// <summary>"Text module"</summary>
        STEEL_ELEM_WELD_TEXT_MODULE = -1155073, // 0xFFEE5FFF
        /// <summary>"Depth of bolt head"</summary>
        STEEL_ELEM_HOLE_DEPTH_OF_BOLT_HEAD = -1155072, // 0xFFEE6000
        /// <summary>"Right-handed thread"</summary>
        STEEL_ELEM_HOLE_TAPPING = -1155071, // 0xFFEE6001
        /// <summary>"Back taper thread"</summary>
        STEEL_ELEM_HOLE_BACK_TAPER_THREAD = -1155070, // 0xFFEE6002
        /// <summary>"Tapping hole"</summary>
        STEEL_ELEM_HOLE_TAPPING_HOLE = -1155069, // 0xFFEE6003
        /// <summary>"Head diameter"</summary>
        STEEL_ELEM_HOLE_HEAD_DIAMETER = -1155068, // 0xFFEE6004
        /// <summary>"Chamfer angle"</summary>
        STEEL_ELEM_HOLE_ANGLE = -1155067, // 0xFFEE6005
        /// <summary>"Taper Angle"</summary>
        STEEL_ELEM_HOLE_ALPHA = -1155066, // 0xFFEE6006
        /// <summary>"Hole Depth"</summary>
        STEEL_ELEM_HOLE_DEPTH = -1155065, // 0xFFEE6007
        /// <summary>"Along side 1"</summary>
        STEEL_ELEM_HOLE_SLOT_DIRECTION = -1155064, // 0xFFEE6008
        /// <summary>"Length of the slot"</summary>
        STEEL_ELEM_HOLE_SLOT_LENGTH = -1155063, // 0xFFEE6009
        /// <summary>"Type"</summary>
        STEEL_ELEM_HOLE_TYPE = -1155062, // 0xFFEE600A
        /// <summary>"Diameter"</summary>
        STEEL_ELEM_HOLE_DIAMETER = -1155061, // 0xFFEE600B
        /// <summary>"Number"</summary>
        STEEL_ELEM_PATTERN_NUMBER = -1155060, // 0xFFEE600C
        /// <summary>"Radius"</summary>
        STEEL_ELEM_PATTERN_RADIUS = -1155059, // 0xFFEE600D
        /// <summary>"Edge distance on side 2"</summary>
        STEEL_ELEM_PATTERN_EDGE_DISTANCE_Y = -1155058, // 0xFFEE600E
        /// <summary>"Edge distance on side 1"</summary>
        STEEL_ELEM_PATTERN_EDGE_DISTANCE_X = -1155057, // 0xFFEE600F
        /// <summary>"Intermediate distance on side 2"</summary>
        STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_Y = -1155056, // 0xFFEE6010
        /// <summary>"Intermediate distance on side 1"</summary>
        STEEL_ELEM_PATTERN_INTERMEDIATE_DISTANCE_X = -1155055, // 0xFFEE6011
        /// <summary>"Length on side 2"</summary>
        STEEL_ELEM_PATTERN_TOTAL_WIDTH = -1155054, // 0xFFEE6012
        /// <summary>"Length on side 1"</summary>
        STEEL_ELEM_PATTERN_TOTAL_LENGTH = -1155053, // 0xFFEE6013
        /// <summary>"Number on side 2"</summary>
        STEEL_ELEM_PATTERN_NUMBER_Y = -1155052, // 0xFFEE6014
        /// <summary>"Number on side 1"</summary>
        STEEL_ELEM_PATTERN_NUMBER_X = -1155051, // 0xFFEE6015
        /// <summary>"Double Preparation Depth"</summary>
        STEEL_ELEM_WELD_DOUBLE_PREPDEPTH = -1155050, // 0xFFEE6016
        /// <summary>"Double Effective Throat"</summary>
        STEEL_ELEM_WELD_DOUBLE_EFFECTIVETHROAT = -1155049, // 0xFFEE6017
        /// <summary>"Double Root Opening"</summary>
        STEEL_ELEM_WELD_DOUBLE_ROOTOPENING = -1155048, // 0xFFEE6018
        /// <summary>"Double Weld preparation"</summary>
        STEEL_ELEM_WELD_DOUBLE_WELDPREP = -1155047, // 0xFFEE6019
        /// <summary>"Double Surface Shape"</summary>
        STEEL_ELEM_WELD_DOUBLE_SURFACESHAPE = -1155046, // 0xFFEE601A
        /// <summary>"Double Text"</summary>
        STEEL_ELEM_WELD_DOUBLE_TEXT = -1155045, // 0xFFEE601B
        /// <summary>"Double Thickness"</summary>
        STEEL_ELEM_WELD_DOUBLE_THICKNESS = -1155044, // 0xFFEE601C
        /// <summary>"Double Type"</summary>
        STEEL_ELEM_WELD_DOUBLE_TYPE = -1155043, // 0xFFEE601D
        /// <summary>"Main Preparation Depth"</summary>
        STEEL_ELEM_WELD_MAIN_PREPDEPTH = -1155042, // 0xFFEE601E
        /// <summary>"Main Effective Throat"</summary>
        STEEL_ELEM_WELD_MAIN_EFFECTIVETHROAT = -1155041, // 0xFFEE601F
        /// <summary>"Main Root Opening"</summary>
        STEEL_ELEM_WELD_MAIN_ROOTOPENING = -1155040, // 0xFFEE6020
        /// <summary>"Main Weld preparation"</summary>
        STEEL_ELEM_WELD_MAIN_WELDPREP = -1155039, // 0xFFEE6021
        /// <summary>"Surface Shape"</summary>
        STEEL_ELEM_WELD_MAIN_SURFACESHAPE = -1155038, // 0xFFEE6022
        /// <summary>"Main Text"</summary>
        STEEL_ELEM_WELD_MAIN_TEXT = -1155037, // 0xFFEE6023
        /// <summary>"Pitch"</summary>
        STEEL_ELEM_WELD_PITCH = -1155036, // 0xFFEE6024
        /// <summary>"Continuous"</summary>
        STEEL_ELEM_WELD_CONTINUOUS = -1155035, // 0xFFEE6025
        /// <summary>"Location"</summary>
        STEEL_ELEM_WELD_LOCATION = -1155034, // 0xFFEE6026
        /// <summary>"Length"</summary>
        STEEL_ELEM_WELD_LENGTH = -1155033, // 0xFFEE6027
        /// <summary>"Main Thickness"</summary>
        STEEL_ELEM_WELD_MAIN_THICKNESS = -1155032, // 0xFFEE6028
        /// <summary>"Main Type"</summary>
        STEEL_ELEM_WELD_MAIN_TYPE = -1155031, // 0xFFEE6029
        /// <summary>"Boring out"</summary>
        STEEL_ELEM_PARAM_BORINGOUT = -1155029, // 0xFFEE602B
        /// <summary>"Radius"</summary>
        STEEL_ELEM_PARAM_RADIUS = -1155028, // 0xFFEE602C
        /// <summary>"Boundary distance 2"</summary>
        STEEL_ELEM_CONTOUR_SIDE2DIST = -1155027, // 0xFFEE602D
        /// <summary>"Boundary distance 1"</summary>
        STEEL_ELEM_CONTOUR_SIDE1DIST = -1155026, // 0xFFEE602E
        /// <summary>"Gap Width"</summary>
        STEEL_ELEM_CONTOUR_GAP_WIDTH = -1155023, // 0xFFEE6031
        /// <summary>"Angle along width"</summary>
        STEEL_ELEM_SHORTEN_ANGLEZ = -1155022, // 0xFFEE6032
        /// <summary>"Angle along height"</summary>
        STEEL_ELEM_SHORTEN_ANGLEY = -1155021, // 0xFFEE6033
        /// <summary>"Length"</summary>
        STEEL_ELEM_SHORTEN_REFLENGTH = -1155020, // 0xFFEE6034
        /// <summary>"Length"</summary>
        STEEL_ELEM_SHEARSTUD_LENGTH = -1155019, // 0xFFEE6035
        /// <summary>"Coating"</summary>
        STEEL_ELEM_BOLT_COATING = -1155018, // 0xFFEE6036
        /// <summary>"Length"</summary>
        STEEL_ELEM_ANCHOR_LENGTH = -1155017, // 0xFFEE6037
        /// <summary>"Diameter"</summary>
        STEEL_ELEM_SHEARSTUD_DIAMETER = -1155016, // 0xFFEE6038
        /// <summary>"Grade"</summary>
        STEEL_ELEM_SHEARSTUD_GRADE = -1155015, // 0xFFEE6039
        /// <summary>"Standard"</summary>
        STEEL_ELEM_SHEARSTUD_STANDARD = -1155014, // 0xFFEE603A
        /// <summary>"Diameter"</summary>
        STEEL_ELEM_ANCHOR_DIAMETER = -1155013, // 0xFFEE603B
        /// <summary>"Assembly"</summary>
        STEEL_ELEM_ANCHOR_ASSEMBLY = -1155012, // 0xFFEE603C
        /// <summary>"Grade"</summary>
        STEEL_ELEM_ANCHOR_GRADE = -1155011, // 0xFFEE603D
        /// <summary>"Standard"</summary>
        STEEL_ELEM_ANCHOR_STANDARD = -1155010, // 0xFFEE603E
        /// <summary>"Coating"</summary>
        STEEL_ELEM_COATING = -1155009, // 0xFFEE603F
        /// <summary>"Diameter"</summary>
        STEEL_ELEM_BOLT_DIAMETER = -1155008, // 0xFFEE6040
        /// <summary>"Assembly"</summary>
        STEEL_ELEM_BOLT_ASSEMBLY = -1155007, // 0xFFEE6041
        /// <summary>"Grade"</summary>
        STEEL_ELEM_BOLT_GRADE = -1155006, // 0xFFEE6042
        /// <summary>"Standard"</summary>
        STEEL_ELEM_BOLT_STANDARD = -1155005, // 0xFFEE6043
        /// <summary>"Thickness"</summary>
        STEEL_ELEM_PLATE_THICKNESS = -1155003, // 0xFFEE6045
        /// <summary>"Workshop Instructions"</summary>
        REBAR_WORKSHOP_INSTRUCTIONS = -1154695, // 0xFFEE6179
        /// <summary>"Geometry"</summary>
        REBAR_GEOMETRY_TYPE = -1154694, // 0xFFEE617A
        /// <summary>"Lat"</summary>
        BASEPOINT_LATITUDE_PARAM = -1154693, // 0xFFEE617B
        /// <summary>"Lon"</summary>
        BASEPOINT_LONGITUDE_PARAM = -1154692, // 0xFFEE617C
        /// <summary>"Hook Orientation At End"</summary>
        REBAR_FREE_FORM_HOOK_END_PLANE_ANGLE = -1154691, // 0xFFEE617D
        /// <summary>"Hook Orientation At Start"</summary>
        REBAR_FREE_FORM_HOOK_START_PLANE_ANGLE = -1154690, // 0xFFEE617E
        /// <summary>"Outdoor Airflow"</summary>
        ROOM_OUTDOOR_AIRFLOW_PARAM = -1154689, // 0xFFEE617F
        /// <summary>"Outdoor Air Method"</summary>
        ROOM_OUTDOOR_AIRFLOW_STANDARD_PARAM = -1154687, // 0xFFEE6181
        /// <summary>"Path"</summary>
        DIRECTCONTEXT3D_SOURCE_ID = -1154686, // 0xFFEE6182
        /// <summary>"ApplicationId"</summary>
        DIRECTCONTEXT3D_APPLICATION_ID = -1154685, // 0xFFEE6183
        /// <summary>"Loaded"</summary>
        DIRECTCONTEXT3D_LOADED = -1154677, // 0xFFEE618B
        /// <summary>"ServerId"</summary>
        DIRECTCONTEXT3D_SERVER_ID = -1154676, // 0xFFEE618C
        /// <summary>"Name"</summary>
        DIRECTCONTEXT3D_NAME = -1154675, // 0xFFEE618D
        /// <summary>"Air Changes per Hour"</summary>
        ROOM_AIR_CHANGES_PER_HOUR_PARAM = -1154671, // 0xFFEE6191
        /// <summary>"Outdoor Air per Area"</summary>
        ROOM_OUTDOOR_AIR_PER_AREA_PARAM = -1154668, // 0xFFEE6194
        /// <summary>"Outdoor Air per Person"</summary>
        ROOM_OUTDOOR_AIR_PER_PERSON_PARAM = -1154665, // 0xFFEE6197
        /// <summary>"Outdoor Air Information"</summary>
        ROOM_OUTDOOR_AIR_INFO_PARAM = -1154662, // 0xFFEE619A
        /// <summary>"INTERNAL: Multiplanar Arc Connector"</summary>
        REBAR_INTERNAL_MULTIPLANAR_ARC_CONNECTOR = -1154659, // 0xFFEE619D
        /// <summary>"End Treatment At End"</summary>
        REBAR_SHAPE_ENDTREATMENT_END_TYPE = -1154658, // 0xFFEE619E
        /// <summary>"End Treatment At Start"</summary>
        REBAR_SHAPE_ENDTREATMENT_START_TYPE = -1154657, // 0xFFEE619F
        /// <summary>"End Treatment At End"</summary>
        REBAR_ELEM_ENDTREATMENT_END = -1154656, // 0xFFEE61A0
        /// <summary>"End Treatment At Start"</summary>
        REBAR_ELEM_ENDTREATMENT_START = -1154655, // 0xFFEE61A1
        /// <summary>"End Treatment"</summary>
        END_TREATMENT = -1154654, // 0xFFEE61A2
        /// <summary>"End Treatment 2"</summary>
        COUPLER_COUPLED_ENDTREATMENT = -1154653, // 0xFFEE61A3
        /// <summary>"End Treatment 1"</summary>
        COUPLER_MAIN_ENDTREATMENT = -1154652, // 0xFFEE61A4
        /// <summary>"External Diameter"</summary>
        COUPLER_WIDTH = -1154651, // 0xFFEE61A5
        /// <summary>"Schedule Mark"</summary>
        COUPLER_MARK = -1154649, // 0xFFEE61A7
        /// <summary>"Default Elevation"</summary>
        FAMILY_FREEINST_DEFAULT_ELEVATION = -1154647, // 0xFFEE61A9
        /// <summary>"Bar Engagement 2"</summary>
        COUPLER_COUPLED_ENGAGEMENT = -1154646, // 0xFFEE61AA
        /// <summary>"Bar Engagement 1"</summary>
        COUPLER_MAIN_ENGAGEMENT = -1154645, // 0xFFEE61AB
        /// <summary>"Total Length"</summary>
        COUPLER_LENGTH = -1154644, // 0xFFEE61AC
        /// <summary>"Mass"</summary>
        COUPLER_WEIGHT = -1154643, // 0xFFEE61AD
        /// <summary>"Coupler Number"</summary>
        COUPLER_NUMBER = -1154642, // 0xFFEE61AE
        /// <summary>"Quantity"</summary>
        COUPLER_QUANTITY = -1154641, // 0xFFEE61AF
        /// <summary>"Bar Size 2"</summary>
        COUPLER_COUPLED_BAR_SIZE = -1154640, // 0xFFEE61B0
        /// <summary>"Bar Size 1"</summary>
        COUPLER_MAIN_BAR_SIZE = -1154639, // 0xFFEE61B1
        /// <summary>"Part Number"</summary>
        COUPLER_CODE = -1154638, // 0xFFEE61B2
        /// <summary>"Actual Tread Depth"</summary>
        MULTISTORY_STAIRS_ACTUAL_TREAD_DEPTH = -1154634, // 0xFFEE61B6
        /// <summary>"Reference Level": The reference level of stairs</summary>
        MULTISTORY_STAIRS_REF_LEVEL = -1154630, // 0xFFEE61BA
        /// <summary>"Host Mark"</summary>
        REBAR_ELEM_HOST_MARK = -1154619, // 0xFFEE61C5
        /// <summary>"Shape Image"</summary>
        REBAR_SHAPE_IMAGE = -1154618, // 0xFFEE61C6
        /// <summary>"Fabric Number"</summary>
        FABRIC_NUMBER = -1154617, // 0xFFEE61C7
        /// <summary>"Rebar Number"</summary>
        REBAR_NUMBER = -1154616, // 0xFFEE61C8
        /// <summary>"Sketchy Lines"</summary>
        GRAPHIC_DISPLAY_OPTIONS_SKETCHY_LINES = -1154615, // 0xFFEE61C9
        /// <summary>"Partition"</summary>
        NUMBER_PARTITION_PARAM = -1154614, // 0xFFEE61CA
        /// <summary>"Show Hidden Lines"</summary>
        VIEW_SHOW_HIDDEN_LINES = -1154613, // 0xFFEE61CB
        /// <summary>"Draw Ventilation"</summary>
        MEP_ZONE_EQUIPMENT_DRAW_VENTILATION = -1153528, // 0xFFEE6608
        /// <summary>"Variable Refrigerant Flow Loop"</summary>
        MEP_VRF_LOOP = -1153527, // 0xFFEE6609
        /// <summary>"Reheat Hot Water Loop"</summary>
        MEP_REHEAT_HOTWATER_LOOP = -1153526, // 0xFFEE660A
        /// <summary>"Zone Equipment"</summary>
        MEP_ZONE_EQUIPMENT = -1153519, // 0xFFEE6611
        /// <summary>"Name"</summary>
        MEP_ANALYTICAL_EQUIPMENT_NAME = -1153518, // 0xFFEE6612
        /// <summary>"Heating Hot Water Loop"</summary>
        MEP_ZONE_HOTWATER_LOOP = -1153517, // 0xFFEE6613
        /// <summary>"Air System"</summary>
        MEP_ZONE_AIR_LOOP = -1153516, // 0xFFEE6614
        /// <summary>"Reheat Coil"</summary>
        MEP_REHEAT_COIL_TYPE = -1153514, // 0xFFEE6616
        /// <summary>"Behavior"</summary>
        MEP_ZONE_EQUIPMENT_BEHAVIOR = -1153513, // 0xFFEE6617
        /// <summary>"Equipment Type"</summary>
        MEP_ZONE_EQUIPMENT_TYPE = -1153512, // 0xFFEE6618
        /// <summary>"Fan"</summary>
        MEP_AIRLOOP_FANTYPE = -1153511, // 0xFFEE6619
        /// <summary>"Chilled Water Loop"</summary>
        MEP_CHILLED_WATER_LOOP = -1153510, // 0xFFEE661A
        /// <summary>"Cooling Coil"</summary>
        MEP_COOLING_COIL_TYPE = -1153509, // 0xFFEE661B
        /// <summary>"Heating Hot Water Loop"</summary>
        MEP_HEATING_HOTWATER_LOOP = -1153508, // 0xFFEE661C
        /// <summary>"Heating Coil"</summary>
        MEP_HEATING_COIL_TYPE = -1153507, // 0xFFEE661D
        /// <summary>"Preheat Hot Water Loop"</summary>
        MEP_PREHEAT_HOTWATER_LOOP = -1153506, // 0xFFEE661E
        /// <summary>"Preheat Coil"</summary>
        MEP_AIRLOOP_PREHEAT_COILTYPE = -1153505, // 0xFFEE661F
        /// <summary>"Heat Exchanger"</summary>
        MEP_AIRLOOP_HEATEXCHANGER_TYPE = -1153504, // 0xFFEE6620
        /// <summary>"Condenser Water Loop"</summary>
        MEP_CONDENSER_WATER_LOOP = -1153503, // 0xFFEE6621
        /// <summary>"Chiller Type"</summary>
        MEP_WATERLOOP_CHILLERTYPE = -1153502, // 0xFFEE6622
        /// <summary>"Loop Type"</summary>
        MEP_WATERLOOP_TYPE = -1153501, // 0xFFEE6623
        /// <summary>"Name"</summary>
        MEP_ANALYTICAL_LOOP_NAME = -1153500, // 0xFFEE6624
        /// <summary>"Equipment Sets"</summary>
        SYSTEM_EQUIPMENT_SETS = -1153115, // 0xFFEE67A5
        /// <summary>"Ignore Flow Analysis"</summary>
        MEP_IGNORE_FLOW_ANALYSIS = -1153114, // 0xFFEE67A6
        /// <summary>"Loop Boundary"</summary>
        MEP_ANALYTICAL_LOOP_BOUNDARY_PARAM = -1153113, // 0xFFEE67A7
        /// <summary>"Mechanical Equipment Set"</summary>
        MECHANICAL_EQUIPMENT_SET_ID_PARAM = -1153112, // 0xFFEE67A8
        /// <summary>"Name"</summary>
        MECHANICAL_EQUIPMENT_SET_NAME = -1153111, // 0xFFEE67A9
        /// <summary>"On Standby"</summary>
        MECHANICAL_EQUIPMENT_SET_ON_STANDBY = -1153110, // 0xFFEE67AA
        /// <summary>"On Duty"</summary>
        MECHANICAL_EQUIPMENT_SET_ON_DUTY = -1153109, // 0xFFEE67AB
        /// <summary>"Critical Path"</summary>
        MEP_ANALYTICAL_CRITICALPATH_PARAM = -1153106, // 0xFFEE67AE
        /// <summary>"Design Flow"</summary>
        MEP_ANALYTICAL_PIPE_DESIGNFLOW = -1153105, // 0xFFEE67AF
        /// <summary>"Calculated Pressure Drop"</summary>
        MEP_EQUIPMENT_CALC_PIPINGPRESSUREDROP_PARAM = -1153104, // 0xFFEE67B0
        /// <summary>"Calculated Flow"</summary>
        MEP_EQUIPMENT_CALC_PIPINGFLOW_PARAM = -1153103, // 0xFFEE67B1
        /// <summary>"Classification"</summary>
        MEP_EQUIPMENT_CLASSIFICATION = -1153100, // 0xFFEE67B4
        /// <summary>"Input Elements"</summary>
        STRUCTURAL_CONNECTION_INPUT_ELEMENTS = -1153004, // 0xFFEE6814
        /// <summary>"Noble Status"</summary>
        STRUCTURAL_CONNECTION_NOBLE_STATUS = -1153003, // 0xFFEE6815
        /// <summary>"Code Checking Status"</summary>
        STRUCTURAL_CONNECTION_CODE_CHECKING_STATUS = -1153002, // 0xFFEE6816
        /// <summary>"Approval Status"</summary>
        STRUCTURAL_CONNECTION_APPROVAL_STATUS = -1153001, // 0xFFEE6817
        /// <summary>"Detailed Parameters"</summary>
        STRUCTURAL_CONNECTION_MODIFY_CONNECTION_PARAMETERS = -1153000, // 0xFFEE6818
        /// <summary>"Connection Symbol"</summary>
        STRUCTURAL_CONNECTION_SYMBOL = -1152999, // 0xFFEE6819
        /// <summary>"Image"</summary>
        ALL_MODEL_IMAGE = -1152385, // 0xFFEE6A7F
        /// <summary>"Type Image"</summary>
        ALL_MODEL_TYPE_IMAGE = -1152384, // 0xFFEE6A80
        /// <summary>"Join Status"</summary>
        STRUCT_FRAM_JOIN_STATUS = -1152383, // 0xFFEE6A81
        /// <summary>"Referenced View": The view referenced by a section or callout.</summary>
        REFERENCED_VIEW = -1152380, // 0xFFEE6A84
        /// <summary>"Other Options"</summary>
        ENERGY_ANALYSIS_ADVANCED_OPTIONS = -1152379, // 0xFFEE6A85
        /// <summary>"Mode"</summary>
        RBS_ENERGY_ANALYSIS_MODE = -1152378, // 0xFFEE6A86
        /// <summary>"Analytical Surface Resolution"</summary>
        RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_SURFACE_IDENTIFICATION_RESOLUTION = -1152377, // 0xFFEE6A87
        /// <summary>"Analytical Space Resolution"</summary>
        RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_SPACE_IDENTIFICATION_RESOLUTION = -1152376, // 0xFFEE6A88
        /// <summary>"Round Connector Dimension"</summary>
        FAMILY_ROUNDCONNECTOR_DIMENSIONTYPE = -1152375, // 0xFFEE6A89
        /// <summary>"Profile Definition"</summary>
        FAM_PROFILE_DEFINITION = -1152374, // 0xFFEE6A8A
        /// <summary>"End z Offset Value"</summary>
        END_Z_OFFSET_VALUE = -1152373, // 0xFFEE6A8B
        /// <summary>"End z Justification"</summary>
        END_Z_JUSTIFICATION = -1152372, // 0xFFEE6A8C
        /// <summary>"End y Offset Value"</summary>
        END_Y_OFFSET_VALUE = -1152371, // 0xFFEE6A8D
        /// <summary>"End y Justification"</summary>
        END_Y_JUSTIFICATION = -1152370, // 0xFFEE6A8E
        /// <summary>"Start z Offset Value"</summary>
        START_Z_OFFSET_VALUE = -1152369, // 0xFFEE6A8F
        /// <summary>"Start z Justification"</summary>
        START_Z_JUSTIFICATION = -1152368, // 0xFFEE6A90
        /// <summary>"Start y Offset Value"</summary>
        START_Y_OFFSET_VALUE = -1152367, // 0xFFEE6A91
        /// <summary>"Start y Justification"</summary>
        START_Y_JUSTIFICATION = -1152366, // 0xFFEE6A92
        /// <summary>"z Offset Value"</summary>
        Z_OFFSET_VALUE = -1152365, // 0xFFEE6A93
        /// <summary>"z Justification"</summary>
        Z_JUSTIFICATION = -1152364, // 0xFFEE6A94
        /// <summary>"y Offset Value"</summary>
        Y_OFFSET_VALUE = -1152363, // 0xFFEE6A95
        /// <summary>"y Justification"</summary>
        Y_JUSTIFICATION = -1152362, // 0xFFEE6A96
        /// <summary>"yz Justification"</summary>
        YZ_JUSTIFICATION = -1152361, // 0xFFEE6A97
        /// <summary>"End Join Cutback"</summary>
        END_JOIN_CUTBACK = -1152360, // 0xFFEE6A98
        /// <summary>"Start Join Cutback"</summary>
        START_JOIN_CUTBACK = -1152359, // 0xFFEE6A99
        /// <summary>"End Extension"</summary>
        END_EXTENSION = -1152358, // 0xFFEE6A9A
        /// <summary>"Start Extension"</summary>
        START_EXTENSION = -1152357, // 0xFFEE6A9B
        /// <summary>"Profile Override"</summary>
        DIVISION_SKETCH_CURVE_DIVISION_PARAMS_OVERRIDE_PARAM = -1152356, // 0xFFEE6A9C
        /// <summary>"Extend to Silhouette"</summary>
        DIVISION_SKETCH_CURVE_EXTENTD_TO_SILH_PARAM = -1152352, // 0xFFEE6AA0
        /// <summary>"Division Rule"</summary>
        DIVISION_RULE_PARAM = -1152351, // 0xFFEE6AA1
        /// <summary>"Mirror"</summary>
        PATTERN_MIRROR_FOR_DIVISION_RULE = -1152350, // 0xFFEE6AA2
        /// <summary>"All Grid Rotation"</summary>
        ALL_GRID_ROTATION_FOR_DIVISION_RULE = -1152349, // 0xFFEE6AA3
        /// <summary>"Indent 2"</summary>
        PATTERN_INDENT_2_FOR_DIVISION_RULE = -1152348, // 0xFFEE6AA4
        /// <summary>"Indent 1"</summary>
        PATTERN_INDENT_1_FOR_DIVISION_RULE = -1152347, // 0xFFEE6AA5
        /// <summary>"Division Pattern"</summary>
        DIVISION_PATTERN = -1152346, // 0xFFEE6AA6
        /// <summary>"Shape is modified"</summary>
        DPART_SHAPE_MODIFIED = -1152345, // 0xFFEE6AA7
        /// <summary>"Excluded"</summary>
        DPART_EXCLUDED = -1152344, // 0xFFEE6AA8
        /// <summary>"Manually Adjusted"</summary>
        ANALYTICAL_MODEL_MANUALLY_ADJUSTED = -1152343, // 0xFFEE6AA9
        /// <summary>"Keywords"</summary>
        PROPERTY_SET_KEYWORDS = -1152342, // 0xFFEE6AAA
        /// <summary>"Source URL"</summary>
        MATERIAL_ASSET_PARAM_SOURCE_URL = -1152341, // 0xFFEE6AAB
        /// <summary>"Source"</summary>
        MATERIAL_ASSET_PARAM_SOURCE = -1152340, // 0xFFEE6AAC
        /// <summary>"External Material ID"</summary>
        MATERIAL_ASSET_PARAM_EXTERNAL_MATERIAL_ID = -1152339, // 0xFFEE6AAD
        /// <summary>"Sharing"</summary>
        MATERIAL_ASSET_PARAM_COMMON_SHARED_ASSET = -1152338, // 0xFFEE6AAE
        /// <summary>"Asset library id"</summary>
        MATERIAL_ASSET_PARAM_ASSET_LIB_ID = -1152337, // 0xFFEE6AAF
        /// <summary>"Base Level By Original"</summary>
        DPART_BASE_LEVEL_BY_ORIGINAL = -1152336, // 0xFFEE6AB0
        /// <summary>"Base Level"</summary>
        DPART_BASE_LEVEL = -1152335, // 0xFFEE6AB1
        /// <summary>"Number"</summary>
        POINT_ADAPTIVE_NUM_PARAM = -1152334, // 0xFFEE6AB2
        /// <summary>"Show Placement Number"</summary>
        POINT_ADAPTIVE_SHOW_NUMBER = -1152333, // 0xFFEE6AB3
        /// <summary>"Constrained"</summary>
        POINT_ADAPTIVE_CONSTRAINED = -1152332, // 0xFFEE6AB4
        /// <summary>"Orients to"</summary>
        POINT_ADAPTIVE_ORIENTATION_TYPE = -1152331, // 0xFFEE6AB5
        /// <summary>"Electrical Resistivity"</summary>
        THERMAL_MATERIAL_PARAM_ELECTRICAL_RESISTIVITY = -1152330, // 0xFFEE6AB6
        /// <summary>"Reflectivity"</summary>
        THERMAL_MATERIAL_PARAM_REFLECTIVITY = -1152329, // 0xFFEE6AB7
        /// <summary>"Porosity"</summary>
        THERMAL_MATERIAL_PARAM_POROSITY = -1152328, // 0xFFEE6AB8
        /// <summary>"Permeability"</summary>
        THERMAL_MATERIAL_PARAM_PERMEABILITY = -1152327, // 0xFFEE6AB9
        /// <summary>"Transmits Light"</summary>
        THERMAL_MATERIAL_PARAM_TRANSMITS_LIGHT = -1152326, // 0xFFEE6ABA
        /// <summary>"Vapor Pressure"</summary>
        THERMAL_MATERIAL_PARAM_VAPOR_PRESSURE = -1152325, // 0xFFEE6ABB
        /// <summary>"Specific Heat of Vaporization"</summary>
        THERMAL_MATERIAL_PARAM_SPECIFIC_HEAT_OF_VAPORIZATION = -1152324, // 0xFFEE6ABC
        /// <summary>"Liquid Viscosity"</summary>
        THERMAL_MATERIAL_PARAM_LIQUID_VISCOSITY = -1152323, // 0xFFEE6ABD
        /// <summary>"Compressibility"</summary>
        THERMAL_MATERIAL_PARAM_COMPRESSIBILITY = -1152322, // 0xFFEE6ABE
        /// <summary>"Gas Viscosity"</summary>
        THERMAL_MATERIAL_PARAM_GAS_VISCOSITY = -1152321, // 0xFFEE6ABF
        /// <summary>"Emissivity"</summary>
        THERMAL_MATERIAL_PARAM_EMISSIVITY = -1152320, // 0xFFEE6AC0
        /// <summary>"Construction"</summary>
        PHY_MATERIAL_PARAM_WOOD_CONSTRUCTION = -1152319, // 0xFFEE6AC1
        /// <summary>"5% Modulus of Elasticity"</summary>
        PHY_MATERIAL_PARAM_FIVEPERCENT_MODULUS_OF_ELACTICITY = -1152318, // 0xFFEE6AC2
        /// <summary>"Average Modulus"</summary>
        PHY_MATERIAL_PARAM_AVERAGE_MODULUS = -1152317, // 0xFFEE6AC3
        /// <summary>"Tension Perpendicular to Grain"</summary>
        PHY_MATERIAL_PARAM_TENSION_PERPENDICULAR = -1152316, // 0xFFEE6AC4
        /// <summary>"Tension Parallel to Grain"</summary>
        PHY_MATERIAL_PARAM_TENSION_PARALLEL = -1152315, // 0xFFEE6AC5
        /// <summary>"Thermally Treated"</summary>
        PHY_MATERIAL_PARAM_STRUCTURAL_THERMAL_TREATED = -1152314, // 0xFFEE6AC6
        /// <summary>"Density"</summary>
        PHY_MATERIAL_PARAM_STRUCTURAL_DENSITY = -1152313, // 0xFFEE6AC7
        /// <summary>"Specific Heat"</summary>
        PHY_MATERIAL_PARAM_STRUCTURAL_SPECIFIC_HEAT = -1152312, // 0xFFEE6AC8
        /// <summary>"Thermal Conductivity Z"</summary>
        PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_Z = -1152311, // 0xFFEE6AC9
        /// <summary>"Thermal Conductivity Y"</summary>
        PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_Y = -1152310, // 0xFFEE6ACA
        /// <summary>"Thermal Conductivity X"</summary>
        PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY_X = -1152309, // 0xFFEE6ACB
        /// <summary>"Thermal Conductivity"</summary>
        PHY_MATERIAL_PARAM_THERMAL_CONDUCTIVITY = -1152308, // 0xFFEE6ACC
        /// <summary>"Thermal Expansion Coefficient 2"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF_2 = -1152307, // 0xFFEE6ACD
        /// <summary>"Thermal Expansion Coefficient 1"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF_1 = -1152306, // 0xFFEE6ACE
        /// <summary>"Shear Modulus 12"</summary>
        PHY_MATERIAL_PARAM_SHEAR_MOD_12 = -1152305, // 0xFFEE6ACF
        /// <summary>"Poisson Ratio 23"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD_23 = -1152304, // 0xFFEE6AD0
        /// <summary>"Poisson Ratio 12"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD_12 = -1152303, // 0xFFEE6AD1
        /// <summary>"Young's Modulus 2"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD_2 = -1152302, // 0xFFEE6AD2
        /// <summary>"Young's Modulus 1"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD_1 = -1152301, // 0xFFEE6AD3
        /// <summary>"Offset from Path"</summary>
        STAIRS_RAILING_PLACEMENT_OFFSET = -1152300, // 0xFFEE6AD4
        /// <summary>"Slanted"</summary>
        STAIRS_TRISERTYPE_RISER_IS_SLANTED = -1152177, // 0xFFEE6B4F
        /// <summary>"Riser"</summary>
        STAIRS_TRISERTYPE_RISER = -1152176, // 0xFFEE6B50
        /// <summary>"Apply Nosing Profile"</summary>
        STAIRS_TRISERTYPE_NOSING_PLACEMENT = -1152175, // 0xFFEE6B51
        /// <summary>"Riser Profile"</summary>
        STAIRS_TRISERTYPE_RISER_PROFILE = -1152174, // 0xFFEE6B52
        /// <summary>"Extension Length"</summary>
        TERMINATION_EXTENSION_LENGTH = -1152167, // 0xFFEE6B59
        /// <summary>"Height"</summary>
        SUPPORT_HEIGHT = -1152166, // 0xFFEE6B5A
        /// <summary>"Hand Clearance"</summary>
        SUPPORT_HAND_CLEARANCE = -1152165, // 0xFFEE6B5B
        /// <summary>"Tread Profile"</summary>
        STAIRS_TRISERTYPE_TREAD_PROFILE = -1152164, // 0xFFEE6B5C
        /// <summary>"Riser Material"</summary>
        STAIRS_TRISERTYPE_RISER_MATERIAL = -1152163, // 0xFFEE6B5D
        /// <summary>"Tread Material"</summary>
        STAIRS_TRISERTYPE_TREAD_MATERIAL = -1152162, // 0xFFEE6B5E
        /// <summary>"Riser To Tread Connection"</summary>
        STAIRS_TRISERTYPE_RISER_TREAD_CONNECTION = -1152161, // 0xFFEE6B5F
        /// <summary>"Riser Thickness"</summary>
        STAIRS_TRISERTYPE_RISER_THICKNESS = -1152160, // 0xFFEE6B60
        /// <summary>"Riser Type": (OBSOLETE)</summary>
        STAIRS_TRISERTYPE_RISER_STYLE = -1152159, // 0xFFEE6B61
        /// <summary>"Back Nosing": (OBSOLETE)</summary>
        STAIRS_TRISERTYPE_BACK_NOSING = -1152158, // 0xFFEE6B62
        /// <summary>"Left Nosing": (OBSOLETE)</summary>
        STAIRS_TRISERTYPE_LEFT_NOSING = -1152157, // 0xFFEE6B63
        /// <summary>"Right Nosing": (OBSOLETE)</summary>
        STAIRS_TRISERTYPE_RIGHT_NOSING = -1152156, // 0xFFEE6B64
        /// <summary>"Front Nosing": (OBSOLETE)</summary>
        STAIRS_TRISERTYPE_FRONT_NOSING = -1152155, // 0xFFEE6B65
        /// <summary>"Nosing Length"</summary>
        STAIRS_TRISERTYPE_NOSING_LENGTH = -1152154, // 0xFFEE6B66
        /// <summary>"Nosing Profile"</summary>
        STAIRS_TRISERTYPE_NOSING_PROFILE = -1152153, // 0xFFEE6B67
        /// <summary>"Tread Thickness"</summary>
        STAIRS_TRISERTYPE_TREAD_THICKNESS = -1152152, // 0xFFEE6B68
        /// <summary>"Tread"</summary>
        STAIRS_TRISERTYPE_TREAD = -1152151, // 0xFFEE6B69
        /// <summary>"Riser Mark": (OBSOLETE)</summary>
        STAIRS_TRISER_RISER_MARK = -1152105, // 0xFFEE6B97
        /// <summary>"Tread Mark": (OBSOLETE)</summary>
        STAIRS_TRISER_TREAD_MARK = -1152104, // 0xFFEE6B98
        /// <summary>"Riser Number": Count the sequential number of riser in the stair.</summary>
        STAIRS_TRISER_RISER_NUMBER = -1152103, // 0xFFEE6B99
        /// <summary>"Tread Number": Count the sequential number of tread in the stair.</summary>
        STAIRS_TRISER_TREAD_NUMBER = -1152102, // 0xFFEE6B9A
        /// <summary>
        ///    "Overridden": (OBSOLETE) Indicate whether selected individual step is governed by default type setting.
        /// </summary>
        STAIRS_TRISER_IS_TYPE_OVERRIDDEN = -1152101, // 0xFFEE6B9B
        /// <summary>"Parallel Treads at End": Number of straight steps at the begin of winder</summary>
        STAIRS_WINDERPATTERN_NUMBER_OF_STRAIGHT_STEPS_AT_END = -1151908, // 0xFFEE6C5C
        /// <summary>
        ///    "Parallel Treads at Start": Number of straight steps at the begin of winder
        /// </summary>
        STAIRS_WINDERPATTERN_NUMBER_OF_STRAIGHT_STEPS_AT_BEGIN = -1151907, // 0xFFEE6C5D
        /// <summary>"Fillet Radius": The fillet corner radius on the interior boundary</summary>
        STAIRS_WINDERPATTERN_RADIUS_INTERIOR = -1151906, // 0xFFEE6C5E
        /// <summary>"Fillet on Corner": Fillet on inside corner</summary>
        STAIRS_WINDERPATTERN_FILLET_INSIDE_CORNER = -1151905, // 0xFFEE6C5F
        /// <summary>
        ///    "Inside Walk Line Offset": The offset from inside walk line to interior boundary
        /// </summary>
        STAIRS_WINDERPATTERN_STAIR_PATH_OFFSET = -1151904, // 0xFFEE6C60
        /// <summary>"Minimum Width on Inside Walk Line": Minimum width on inside walkline</summary>
        STAIRS_WINDERPATTERN_MINIMUM_WIDTH_INSIDE_WALKLINE = -1151903, // 0xFFEE6C61
        /// <summary>"Minimum Width on Inside Boundary": Minimum Width on Inside Boundary</summary>
        STAIRS_WINDERPATTERN_MINIMUM_WIDTH_CORNER = -1151902, // 0xFFEE6C62
        /// <summary>"Winder Style": Winder Style</summary>
        STAIRS_WINDERPATTERN_WINDER_STYLE = -1151901, // 0xFFEE6C63
        /// <summary>"Flip Section Profile": Flip Section Profile</summary>
        STAIRS_SUPPORTTYPE_FLIP_SECTION_PROFILE = -1151811, // 0xFFEE6CBD
        /// <summary>"Structural Depth On Landing": Structural Depth</summary>
        STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH_ON_LANDING = -1151810, // 0xFFEE6CBE
        /// <summary>"Structural Depth On Run": Structural Depth</summary>
        STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH_ON_RUN = -1151809, // 0xFFEE6CBF
        /// <summary>"Material": Material</summary>
        STAIRS_SUPPORTTYPE_MATERIAL = -1151808, // 0xFFEE6CC0
        /// <summary>"Width": Width</summary>
        STAIRS_SUPPORTTYPE_WIDTH = -1151807, // 0xFFEE6CC1
        /// <summary>"Total Depth": Total Depth</summary>
        STAIRS_SUPPORTTYPE_TOTAL_DEPTH = -1151806, // 0xFFEE6CC2
        /// <summary>"Structural Depth": Structural Depth</summary>
        STAIRS_SUPPORTTYPE_STRUCTURAL_DEPTH = -1151805, // 0xFFEE6CC3
        /// <summary>"Underside Surface": Underside Surface</summary>
        STAIRS_SUPPORTTYPE_UNDERSIDE_SURFACE = -1151804, // 0xFFEE6CC4
        /// <summary>"Topside Surface": Topside Surface</summary>
        STAIRS_SUPPORTTYPE_TOPSIDE_SURFACE = -1151803, // 0xFFEE6CC5
        /// <summary>"Section Profile": Section Profile</summary>
        STAIRS_SUPPORTTYPE_SECTION_PROFILE = -1151801, // 0xFFEE6CC7
        /// <summary>"Landing Support Type": Landing Support Type</summary>
        STAIRS_SUPPORT_LANDINGSUPPORT_TYPE = -1151710, // 0xFFEE6D22
        /// <summary>"Overridden": Overridden</summary>
        STAIRS_SUPPORT_OVERRIDDEN = -1151709, // 0xFFEE6D23
        /// <summary>"Trim Support at Upper": Trim Support at Upper</summary>
        STAIRS_SUPPORT_TRIM_SUPPORT_UPPER = -1151708, // 0xFFEE6D24
        /// <summary>"Upper End Cut": Upper End Cut</summary>
        STAIRS_SUPPORT_UPPER_END_CUT = -1151706, // 0xFFEE6D26
        /// <summary>"Lower End Cut": Lower End Cut</summary>
        STAIRS_SUPPORT_LOWER_END_CUT = -1151705, // 0xFFEE6D27
        /// <summary>
        ///    "Vertical Offset": Distance of top plane of edge stringer relative to the plane connecting tread nosing
        /// </summary>
        STAIRS_SUPPORT_VERTICAL_OFFSET = -1151702, // 0xFFEE6D2A
        /// <summary>"Lateral Offset": Distance from center or edge of boundary</summary>
        STAIRS_SUPPORT_HORIZONTAL_OFFSET = -1151701, // 0xFFEE6D2B
        /// <summary>"Monolithic Material": Landing Material</summary>
        STAIRS_LANDINGTYPE_LANDING_MATERIAL = -1151606, // 0xFFEE6D8A
        /// <summary>"Type": Tread/Riser Type</summary>
        STAIRS_LANDINGTYPE_TREADRISER_TYPE = -1151605, // 0xFFEE6D8B
        /// <summary>"Same as Run": Same as Run</summary>
        STAIRS_LANDINGTYPE_USE_SAME_TRISER_AS_RUN = -1151604, // 0xFFEE6D8C
        /// <summary>"Monolithic Thickness": Default thickness</summary>
        STAIRS_LANDINGTYPE_THICKNESS = -1151603, // 0xFFEE6D8D
        /// <summary>"Structure": Structure</summary>
        STAIRS_LANDINGTYPE_STRUCTURE = -1151602, // 0xFFEE6D8E
        /// <summary>"Monolithic Support": Monolithic Support</summary>
        STAIRS_LANDINGTYPE_HAS_MONOLITHIC_SUPPORT = -1151601, // 0xFFEE6D8F
        /// <summary>"Overridden": Overridden</summary>
        STAIRS_LANDING_OVERRIDDEN = -1151508, // 0xFFEE6DEC
        /// <summary>"Total Thickness": Thickness</summary>
        STAIRS_LANDING_THICKNESS = -1151507, // 0xFFEE6DED
        /// <summary>"Structural": Structural</summary>
        STAIRS_LANDING_STRUCTURAL = -1151502, // 0xFFEE6DF2
        /// <summary>"Relative Height": Height</summary>
        STAIRS_LANDING_BASE_ELEVATION = -1151501, // 0xFFEE6DF3
        /// <summary>"Monolithic Material": Material</summary>
        STAIRS_RUNTYPE_RUN_MATERIAL = -1151406, // 0xFFEE6E52
        /// <summary>"Total Depth": Total Depth</summary>
        STAIRS_RUNTYPE_TOTAL_DEPTH = -1151405, // 0xFFEE6E53
        /// <summary>"Structural Depth": Structural Depth</summary>
        STAIRS_RUNTYPE_STRUCTURAL_DEPTH = -1151404, // 0xFFEE6E54
        /// <summary>"Structure": Structure</summary>
        STAIRS_RUNTYPE_STRUCTURE = -1151403, // 0xFFEE6E55
        /// <summary>"Underside Surface": Underside Surface</summary>
        STAIRS_RUNTYPE_UNDERSIDE_SURFACE_TYPE = -1151402, // 0xFFEE6E56
        /// <summary>"Monolithic Support": Monolithic Support</summary>
        STAIRS_RUNTYPE_HAS_MONOLITHIC_SUPPORT = -1151401, // 0xFFEE6E57
        /// <summary>"Extend Below Tread Base": Extend Below Tread Base</summary>
        STAIRS_RUN_EXTEND_BELOW_TREAD_BASE = -1151323, // 0xFFEE6EA5
        /// <summary>"CCW": Revert the run preview</summary>
        STAIRS_RUN_CCW = -1151322, // 0xFFEE6EA6
        /// <summary>"With Automatic Landing": Create automatic landing</summary>
        STAIRS_RUN_CREATE_AUTO_LANDING = -1151321, // 0xFFEE6EA7
        /// <summary>"End with Straight Run": Winder end with straight run</summary>
        STAIRS_RUN_WINDER_END_WITH_STRAIGHT = -1151320, // 0xFFEE6EA8
        /// <summary>"Begin with Straight Run": Winder begin with straight run</summary>
        STAIRS_RUN_WINDER_BEGIN_WITH_STRAIGHT = -1151319, // 0xFFEE6EA9
        /// <summary>"Location Line": Location Line</summary>
        STAIRS_RUN_LOCATIONPATH_JUSTFICATION = -1151318, // 0xFFEE6EAA
        /// <summary>"End with Riser": End with Riser</summary>
        STAIRS_RUN_END_WITH_RISER = -1151317, // 0xFFEE6EAB
        /// <summary>"Begin with Riser": Begin with Riser</summary>
        STAIRS_RUN_BEGIN_WITH_RISER = -1151316, // 0xFFEE6EAC
        /// <summary>"Overridden": Overridden</summary>
        STAIRS_RUN_OVERRIDDEN = -1151315, // 0xFFEE6EAD
        /// <summary>"Structural": Structural</summary>
        STAIRS_RUN_STRUCTURAL = -1151314, // 0xFFEE6EAE
        /// <summary>"Center Mark Visible": Center Mark Visible</summary>
        STAIRS_RUN_CENTER_MARK_VISIBLE = -1151313, // 0xFFEE6EAF
        /// <summary>"Actual Run Width": Actual Run Width</summary>
        STAIRS_RUN_ACTUAL_RUN_WIDTH = -1151309, // 0xFFEE6EB3
        /// <summary>"Actual Tread Depth": Actual Tread Depth</summary>
        STAIRS_RUN_ACTUAL_TREAD_DEPTH = -1151308, // 0xFFEE6EB4
        /// <summary>"Actual Riser Height": Actual Riser Height</summary>
        STAIRS_RUN_ACTUAL_RISER_HEIGHT = -1151307, // 0xFFEE6EB5
        /// <summary>"Actual Number of Treads": Actual Number of Treads</summary>
        STAIRS_RUN_ACTUAL_NUMBER_OF_TREADS = -1151306, // 0xFFEE6EB6
        /// <summary>"Actual Number of Risers": Actual Number of Risers</summary>
        STAIRS_RUN_ACTUAL_NUMBER_OF_RISERS = -1151305, // 0xFFEE6EB7
        /// <summary>"Extend Below Riser Base": Extend Below Base</summary>
        STAIRS_RUN_EXTEND_BELOW_RISER_BASE = -1151304, // 0xFFEE6EB8
        /// <summary>"Run Height": Run Height</summary>
        STAIRS_RUN_HEIGHT = -1151303, // 0xFFEE6EB9
        /// <summary>"Relative Top Height": Top height of run</summary>
        STAIRS_RUN_TOP_ELEVATION = -1151302, // 0xFFEE6EBA
        /// <summary>"Relative Base Height": Relative height to stairs bottom elevation</summary>
        STAIRS_RUN_BOTTOM_ELEVATION = -1151301, // 0xFFEE6EBB
        /// <summary>"Middle Support": Whether stairs is assembled</summary>
        STAIRSTYPE_HAS_INTERMEDIATE_SUPPORT = -1151237, // 0xFFEE6EFB
        /// <summary>"Left Lateral Offset":</summary>
        STAIRSTYPE_LEFT_SUPPORT_LATERAL_OFFSET = -1151236, // 0xFFEE6EFC
        /// <summary>"Right Lateral Offset":</summary>
        STAIRSTYPE_RIGHT_SUPPORT_LATERAL_OFFSET = -1151235, // 0xFFEE6EFD
        /// <summary>"Cut Mark Type": Cut Mark Type</summary>
        STAIRSTYPE_CUTMARK_TYPE = -1151234, // 0xFFEE6EFE
        /// <summary>"Construction Method":</summary>
        STAIRSTYPE_CONSTRUCTION_METHOD = -1151233, // 0xFFEE6EFF
        /// <summary>"Right Support":</summary>
        STAIRSTYPE_HAS_RIGHT_SUPPORT = -1151232, // 0xFFEE6F00
        /// <summary>"Left Support":</summary>
        STAIRSTYPE_HAS_LEFT_SUPPORT = -1151231, // 0xFFEE6F01
        /// <summary>"Notch Width":</summary>
        STAIRSTYPE_NOTCH_WIDTH = -1151230, // 0xFFEE6F02
        /// <summary>"Vertical Gap Distance":</summary>
        STAIRSTYPE_NOTCH_VERTICAL_GAP = -1151229, // 0xFFEE6F03
        /// <summary>"Horizontal Gap Distance":</summary>
        STAIRSTYPE_NOTCH_HORIZONTAL_GAP = -1151228, // 0xFFEE6F04
        /// <summary>"Custom":</summary>
        STAIRSTYPE_NOTCH_CUSTOM_WIDTH = -1151227, // 0xFFEE6F05
        /// <summary>"Notch Thickness":</summary>
        STAIRSTYPE_NOTCH_THICKNESS = -1151226, // 0xFFEE6F06
        /// <summary>"Notch Extension":</summary>
        STAIRSTYPE_NOTCH_EXTENSION = -1151225, // 0xFFEE6F07
        /// <summary>"Connection Method": Cut Style for Geometrically Unjoined End</summary>
        STAIRSTYPE_GEOMUNJOINED_END_CUT_STYLE = -1151224, // 0xFFEE6F08
        /// <summary>"Target Result": Calculation Rule Target Result</summary>
        STAIRSTYPE_CALC_RULE_TARGET_RESULT = -1151223, // 0xFFEE6F09
        /// <summary>"Min. Result": Calculation Rule Min Result</summary>
        STAIRSTYPE_CALC_RULE_MIN_RESULT = -1151222, // 0xFFEE6F0A
        /// <summary>"Max. Result": Calculation Rule Max Result</summary>
        STAIRSTYPE_CALC_RULE_MAX_RESULT = -1151221, // 0xFFEE6F0B
        /// <summary>"Tread Multiplier": Calculation Rule Tread Multiplier</summary>
        STAIRSTYPE_CALC_RULE_TREAD_MULTIPLIER = -1151220, // 0xFFEE6F0C
        /// <summary>"Riser Multiplier": Calculation Rule Riser Multiplier</summary>
        STAIRSTYPE_CALC_RULE_RISER_MULTIPLIER = -1151219, // 0xFFEE6F0D
        /// <summary>"Assembled Stair": Whether stairs is assembled</summary>
        STAIRSTYPE_IS_ASSEMBLED_STAIRS = -1151218, // 0xFFEE6F0E
        /// <summary>"Middle Support Number": Number of intermediate supports</summary>
        STAIRSTYPE_NUMBER_OF_INTERMEDIATE_SUPPORTS = -1151217, // 0xFFEE6F0F
        /// <summary>"Minimum Run Width": Minimum Run Width</summary>
        STAIRSTYPE_MINIMUM_RUN_WIDTH = -1151216, // 0xFFEE6F10
        /// <summary>"Winder Algorithm": Winder Algorithm</summary>
        STAIRSTYPE_WINDER_STEP_FRONT_MEASUREMENT = -1151215, // 0xFFEE6F11
        /// <summary>"Show Up/Down in Plan": Show Up/Down in Plan</summary>
        STAIRSTYPE_SHOW_UPDOWN = -1151214, // 0xFFEE6F12
        /// <summary>"Show Stair Path in Plan": Show Stair Path in Plan</summary>
        STAIRSTYPE_SHOW_STAIR_PATH = -1151213, // 0xFFEE6F13
        /// <summary>"Show Cut Line in Plan": Show Cut Line in Plan</summary>
        STAIRSTYPE_SHOW_CUTLINE = -1151212, // 0xFFEE6F14
        /// <summary>"Middle Support Type": Intermediate Support Type</summary>
        STAIRSTYPE_INTERMEDIATE_SUPPORT_TYPE = -1151211, // 0xFFEE6F15
        /// <summary>"Left Support Type": Left Side Support Type</summary>
        STAIRSTYPE_LEFT_SIDE_SUPPORT_TYPE = -1151210, // 0xFFEE6F16
        /// <summary>"Right Support Type": Right Side Support Type</summary>
        STAIRSTYPE_RIGHT_SIDE_SUPPORT_TYPE = -1151209, // 0xFFEE6F17
        /// <summary>"Landing Type": Landing Type</summary>
        STAIRSTYPE_LANDING_TYPE = -1151208, // 0xFFEE6F18
        /// <summary>"Run Type": Run Type</summary>
        STAIRSTYPE_RUN_TYPE = -1151207, // 0xFFEE6F19
        /// <summary>"Calculation Rules": Calculation Rules</summary>
        STAIRSTYPE_CALCULATION_RULES = -1151206, // 0xFFEE6F1A
        /// <summary>
        ///    "Min. Tread Depth on Winder Inner Boundary": Minimum Tread Width on Inside Boundary
        /// </summary>
        STAIRSTYPE_MINIMUM_TREAD_WIDTH_INSIDE_BOUNDARY = -1151205, // 0xFFEE6F1B
        /// <summary>"Min. Tread Depth": Minimum Tread Depth</summary>
        STAIRSTYPE_MINIMUM_TREAD_DEPTH = -1151204, // 0xFFEE6F1C
        /// <summary>"Max. Riser Height": Maximum Riser Height</summary>
        STAIRSTYPE_MAXIMUM_RISER_HEIGHT = -1151203, // 0xFFEE6F1D
        /// <summary>"Tread/Riser Start Number":</summary>
        STAIRS_TRISER_NUMBER_BASE_INDEX = -1151154, // 0xFFEE6F4E
        /// <summary>"Cut by Cut Plane"</summary>
        STAIRS_DBG_SHOW_ANNOTATION_CUT_MARK = -1151153, // 0xFFEE6F4F
        /// <summary>"Show Monolithic Support Corse Geometry"</summary>
        STAIRS_DBG_SHOW_MONOLITHIC_SUPPORT_CORSE_GEOM = -1151152, // 0xFFEE6F50
        /// <summary>"Show Triser Corse Geometry"</summary>
        STAIRS_DBG_SHOW_TRISER_CORSE_GEOM = -1151151, // 0xFFEE6F51
        /// <summary>"Show Run Corse Geometry"</summary>
        STAIRS_DBG_SHOW_RUN_CORSE_GEOM = -1151150, // 0xFFEE6F52
        /// <summary>"Show Monolithic Support Geometry"</summary>
        STAIRS_DBG_SHOW_MONOLITHIC_SUPPORT_GEOM = -1151149, // 0xFFEE6F53
        /// <summary>"Show Triser Geometry"</summary>
        STAIRS_DBG_SHOW_TRISER_GEOM = -1151148, // 0xFFEE6F54
        /// <summary>"Show Run Geometry"</summary>
        STAIRS_DBG_SHOW_RUN_GEOM = -1151147, // 0xFFEE6F55
        /// <summary>"Show Support Path"</summary>
        STAIRS_DBG_SHOW_SUPPORT_PATH = -1151146, // 0xFFEE6F56
        /// <summary>"Show Stairs' Boundary 3D"</summary>
        STAIRS_DBG_SHOW_BOUNDARY_3D = -1151145, // 0xFFEE6F57
        /// <summary>"Show Stairs' Boundary 2D"</summary>
        STAIRS_DBG_SHOW_BOUNDARY_2D = -1151144, // 0xFFEE6F58
        /// <summary>"Show Landing Path"</summary>
        STAIRS_DBG_SHOW_LANDING_PATH = -1151143, // 0xFFEE6F59
        /// <summary>"Show Landing Boundary"</summary>
        STAIRS_DBG_SHOW_LANDING_BOUNDARY = -1151142, // 0xFFEE6F5A
        /// <summary>"Show Run Outline For Plan"</summary>
        STAIRS_DBG_SHOW_RUN_OUTLINE_FOR_PLAN = -1151141, // 0xFFEE6F5B
        /// <summary>"Show Run's Nosings"</summary>
        STAIRS_DBG_SHOW_RUN_NOSING = -1151140, // 0xFFEE6F5C
        /// <summary>"Show Run's Risers"</summary>
        STAIRS_DBG_SHOW_RUN_RISER = -1151139, // 0xFFEE6F5D
        /// <summary>"Show Run's Path 3D"</summary>
        STAIRS_DBG_SHOW_RUN_PATH_3D = -1151138, // 0xFFEE6F5E
        /// <summary>"Show Run's Path 2D"</summary>
        STAIRS_DBG_SHOW_RUN_PATH_2D = -1151137, // 0xFFEE6F5F
        /// <summary>"Show Run's Right Boundary 3D"</summary>
        STAIRS_DBG_SHOW_RIGHT_RUN_BOUNDARY_3D = -1151136, // 0xFFEE6F60
        /// <summary>"Show Run's Left Boundary 3D"</summary>
        STAIRS_DBG_SHOW_LEFT_RUN_BOUNDARY_3D = -1151135, // 0xFFEE6F61
        /// <summary>"Show Run's Right Boundary 2D"</summary>
        STAIRS_DBG_SHOW_RIGHT_RUN_BOUNDARY_2D = -1151134, // 0xFFEE6F62
        /// <summary>"Show Run's Left Boundary 2D"</summary>
        STAIRS_DBG_SHOW_LEFT_RUN_BOUNDARY_2D = -1151133, // 0xFFEE6F63
        /// <summary>"Show Landing Faces"</summary>
        STAIRS_DBG_SHOW_LANDING_FACES = -1151132, // 0xFFEE6F64
        /// <summary>"Show Run's Tread Faces"</summary>
        STAIRS_DBG_SHOW_TREAD_FACES = -1151131, // 0xFFEE6F65
        /// <summary>"Enable Calculator Rules Check": Enable calculation rule checking</summary>
        STAIRS_ENABLE_CALCULATION_RULE_CHECKING = -1151118, // 0xFFEE6F72
        /// <summary>"Minimum Automatic Landing Depth": The minimum depth of automatic landing</summary>
        STAIRS_MIN_AUTOMATIC_LANDING_DEPTH = -1151117, // 0xFFEE6F73
        /// <summary>"Run Width Measurement": Run Width Measurement</summary>
        STAIRS_RUN_WIDTH_MEASUREMENT = -1151116, // 0xFFEE6F74
        /// <summary>"Total Number of Treads": Total number of treads</summary>
        STAIRS_TOTAL_NUMBER_OF_TREADS = -1151113, // 0xFFEE6F77
        /// <summary>"Total Number of Risers": Total number of risers</summary>
        STAIRS_TOTAL_NUMBER_OF_RISERS = -1151112, // 0xFFEE6F78
        /// <summary>
        ///    "Actual Number of Risers": The total number of actually created risers in model
        /// </summary>
        STAIRS_ACTUAL_NUMBER_OF_RISERS = -1151111, // 0xFFEE6F79
        /// <summary>
        ///    "Desired Number of Risers": The number of risers is calculated based on stairs height
        /// </summary>
        STAIRS_DESIRED_NUMBER_OF_RISERS = -1151110, // 0xFFEE6F7A
        /// <summary>"Multistory Top Level": The top level of multi-story stairs</summary>
        STAIRS_MULTISTORY_UP_TO_LEVEL = -1151106, // 0xFFEE6F7E
        /// <summary>"Desired Stair Height": Stairs unconnected height</summary>
        STAIRS_STAIRS_HEIGHT = -1151105, // 0xFFEE6F7F
        /// <summary>"Top Level": The top level of stairs</summary>
        STAIRS_TOP_LEVEL = -1151103, // 0xFFEE6F81
        /// <summary>"Base Level": The base level of stairs</summary>
        STAIRS_BASE_LEVEL = -1151101, // 0xFFEE6F83
        /// <summary>"Profile Offset"</summary>
        PART_MAKER_DIVISION_PROFILE_OFFSET = -1150624, // 0xFFEE7160
        /// <summary>"Width": Width</summary>
        DIVISION_PROFILE_WIDTH = -1150623, // 0xFFEE7161
        /// <summary>"Edge Match"</summary>
        PART_MAKER_SPLITTER_PROFILE_EDGE_MATCH = -1150622, // 0xFFEE7162
        /// <summary>"Profile Along Flip"</summary>
        PART_MAKER_SPLITTER_PROFILE_FLIP_ALONG = -1150605, // 0xFFEE7173
        /// <summary>"Profile Across Flip"</summary>
        PART_MAKER_SPLITTER_PROFILE_FLIP_ACROSS = -1150604, // 0xFFEE7174
        /// <summary>"Division Profile"</summary>
        PART_MAKER_SPLITTER_PROFILE = -1150603, // 0xFFEE7175
        /// <summary>"Content protection enabled"</summary>
        FAMILY_KEYWORD_PROTECTED = -1150602, // 0xFFEE7176
        /// <summary>"Gap"</summary>
        PARTMAKER_PARAM_DIVISION_GAP = -1150601, // 0xFFEE7177
        /// <summary>"Name": The name of the instance as it will show in the Property Palette</summary>
        POINTCLOUDINSTANCE_NAME = -1150600, // 0xFFEE7178
        /// <summary>"Cross-Section Rotation": The rotation of Analytical Model</summary>
        ANALYTICAL_MODEL_ROTATION = -1150501, // 0xFFEE71DB
        /// <summary>"Scale": The scale for this instance</summary>
        POINTCLOUDTYPE_SCALE = -1150500, // 0xFFEE71DC
        /// <summary>"Description"</summary>
        PROPERTY_SET_DESCRIPTION = -1150481, // 0xFFEE71EF
        /// <summary>"Material aspect"</summary>
        PROPERTY_SET_MATERIAL_ASPECT = -1150480, // 0xFFEE71F0
        /// <summary>"System Abbreviation"</summary>
        RBS_DUCT_PIPE_SYSTEM_ABBREVIATION_PARAM = -1150468, // 0xFFEE71FC
        /// <summary>"Properties"</summary>
        PHY_MATERIAL_PROPERTIES = -1150467, // 0xFFEE71FD
        /// <summary>"Property Set Name"</summary>
        PROPERTY_SET_NAME = -1150466, // 0xFFEE71FE
        /// <summary>"Subclass"</summary>
        PHY_MATERIAL_PARAM_SUBCLASS = -1150465, // 0xFFEE71FF
        /// <summary>"Class"</summary>
        PHY_MATERIAL_PARAM_CLASS = -1150464, // 0xFFEE7200
        /// <summary>"Perimeter": The Perimeter of Analytical Model</summary>
        ANALYTICAL_MODEL_PERIMETER = -1150463, // 0xFFEE7201
        /// <summary>"Area": The Area of Analytical Model</summary>
        ANALYTICAL_MODEL_AREA = -1150462, // 0xFFEE7202
        /// <summary>"Length": The length of Analytical Model</summary>
        ANALYTICAL_MODEL_LENGTH = -1150461, // 0xFFEE7203
        /// <summary>"Assembly: Keynote"</summary>
        SHEET_ASSEMBLY_KEYNOTE = -1150460, // 0xFFEE7204
        /// <summary>"Assembly: Assembly Description"</summary>
        SHEET_ASSEMBLY_ASSEMBLY_DESCRIPTION = -1150459, // 0xFFEE7205
        /// <summary>"Assembly: Cost"</summary>
        SHEET_ASSEMBLY_COST = -1150458, // 0xFFEE7206
        /// <summary>"Assembly: Type Mark"</summary>
        SHEET_ASSEMBLY_TYPE_MARK = -1150457, // 0xFFEE7207
        /// <summary>"Assembly: Assembly Code"</summary>
        SHEET_ASSEMBLY_ASSEMBLY_CODE = -1150456, // 0xFFEE7208
        /// <summary>"Assembly: Description"</summary>
        SHEET_ASSEMBLY_DESCRIPTION = -1150455, // 0xFFEE7209
        /// <summary>"Assembly: URL"</summary>
        SHEET_ASSEMBLY_URL = -1150454, // 0xFFEE720A
        /// <summary>"Assembly: Type Comments"</summary>
        SHEET_ASSEMBLY_TYPE_COMMENTS = -1150453, // 0xFFEE720B
        /// <summary>"Assembly: Manufacturer"</summary>
        SHEET_ASSEMBLY_MANUFACTURER = -1150452, // 0xFFEE720C
        /// <summary>"Assembly: Model"</summary>
        SHEET_ASSEMBLY_MODEL = -1150451, // 0xFFEE720D
        /// <summary>"Assembly: Name"</summary>
        SHEET_ASSEMBLY_NAME = -1150450, // 0xFFEE720E
        /// <summary>"Free Size"</summary>
        RBS_REFERENCE_FREESIZE = -1150435, // 0xFFEE721D
        /// <summary>"Overall Size"</summary>
        RBS_REFERENCE_OVERALLSIZE = -1150434, // 0xFFEE721E
        /// <summary>"Lining Thickness"</summary>
        RBS_REFERENCE_LINING_THICKNESS = -1150433, // 0xFFEE721F
        /// <summary>"Lining Type"</summary>
        RBS_REFERENCE_LINING_TYPE = -1150432, // 0xFFEE7220
        /// <summary>"Insulation Thickness"</summary>
        RBS_REFERENCE_INSULATION_THICKNESS = -1150431, // 0xFFEE7221
        /// <summary>"Insulation Type"</summary>
        RBS_REFERENCE_INSULATION_TYPE = -1150430, // 0xFFEE7222
        /// <summary>"Pipe Size"</summary>
        RBS_PIPE_CALCULATED_SIZE = -1150427, // 0xFFEE7225
        /// <summary>"Duct Size"</summary>
        RBS_DUCT_CALCULATED_SIZE = -1150426, // 0xFFEE7226
        /// <summary>"Volume"</summary>
        RBS_INSULATION_LINING_VOLUME = -1150425, // 0xFFEE7227
        /// <summary>"Assembly Name"</summary>
        ASSEMBLY_NAME = -1150420, // 0xFFEE722C
        /// <summary>"Component Classification"</summary>
        RBS_COMPONENT_CLASSIFICATION_PARAM = -1150412, // 0xFFEE7234
        /// <summary>"Rise / Drop Symbol"</summary>
        RBS_SYSTEM_RISEDROP_PARAM = -1150411, // 0xFFEE7235
        /// <summary>"Two Line Drop Symbol"</summary>
        RBS_SYSTEM_RISEDROP_2LINEDROPSYMBOL_PARAM = -1150410, // 0xFFEE7236
        /// <summary>"Two Line Rise Symbol"</summary>
        RBS_SYSTEM_RISEDROP_2LINERISESYMBOL_PARAM = -1150409, // 0xFFEE7237
        /// <summary>"Single Line Drop Symbol"</summary>
        RBS_SYSTEM_RISEDROP_1LINEDROPSYMBOL_PARAM = -1150408, // 0xFFEE7238
        /// <summary>"Single Line Rise Symbol"</summary>
        RBS_SYSTEM_RISEDROP_1LINERISESYMBOL_PARAM = -1150407, // 0xFFEE7239
        /// <summary>"Single Line Tee Up Symbol"</summary>
        RBS_SYSTEM_RISEDROP_1LINETEEUPSYMBOL_PARAM = -1150406, // 0xFFEE723A
        /// <summary>"Single Line Tee Down Symbol"</summary>
        RBS_SYSTEM_RISEDROP_1LINETEEDOWNSYMBOL_PARAM = -1150405, // 0xFFEE723B
        /// <summary>"Naming Category"</summary>
        ASSEMBLY_NAMING_CATEGORY = -1150403, // 0xFFEE723D
        /// <summary>"Use Top Rail": Whether railing has top rail</summary>
        RAILING_SYSTEM_HAS_TOP_RAIL = -1150380, // 0xFFEE7254
        /// <summary>"Rail Path Join"</summary>
        CONTINUOUSRAIL_JOIN_TYPE_PARAM = -1150373, // 0xFFEE725B
        /// <summary>"Plus Tread Depth"</summary>
        CONTINUOUSRAIL_PLUS_TREAD_DEPTH_PARAM = -1150361, // 0xFFEE7267
        /// <summary>"Length"</summary>
        CONTINUOUSRAIL_LENGTH_PARAM = -1150360, // 0xFFEE7268
        /// <summary>"Justification"</summary>
        HANDRAIL_SUPPORTS_JUSTIFICATION_PARAM = -1150355, // 0xFFEE726D
        /// <summary>"Number"</summary>
        HANDRAIL_SUPPORTS_NUMBER_PARAM = -1150354, // 0xFFEE726E
        /// <summary>"Spacing"</summary>
        HANDRAIL_SUPPORTS_SPACING_PARAM = -1150353, // 0xFFEE726F
        /// <summary>"Layout"</summary>
        HANDRAIL_SUPPORTS_LAYOUT_PARAM = -1150352, // 0xFFEE7270
        /// <summary>"Family"</summary>
        HANDRAIL_SUPPORTS_TYPE_PARAM = -1150351, // 0xFFEE7271
        /// <summary>"Length"</summary>
        CONTINUOUSRAIL_END_EXTENSION_LENGTH_PARAM = -1150350, // 0xFFEE7272
        /// <summary>"Extension Style"</summary>
        CONTINUOUSRAIL_END_TERMINATION_ATTACHMENT_PARAM = -1150349, // 0xFFEE7273
        /// <summary>"Length"</summary>
        CONTINUOUSRAIL_EXTENSION_LENGTH_PARAM = -1150348, // 0xFFEE7274
        /// <summary>"Extension Style"</summary>
        CONTINUOUSRAIL_BEGINNING_TERMINATION_ATTACHMENT_PARAM = -1150347, // 0xFFEE7275
        /// <summary>"End/Top Termination"</summary>
        CONTINUOUSRAIL_END_TERMINATION_TYPE_PARAM = -1150346, // 0xFFEE7276
        /// <summary>"Beginning/Bottom Termination"</summary>
        CONTINUOUSRAIL_BEGINNING_TERMINATION_TYPE_PARAM = -1150345, // 0xFFEE7277
        /// <summary>"Material"</summary>
        CONTINUOUSRAIL_MATERIALS_PARAM = -1150344, // 0xFFEE7278
        /// <summary>"Transitions"</summary>
        CONTINUOUSRAIL_TRANSITION_TYPE_PARAM = -1150343, // 0xFFEE7279
        /// <summary>"Hand Clearance"</summary>
        HANDRAIL_HAND_CLEARANCE_PARAM = -1150342, // 0xFFEE727A
        /// <summary>"Projection"</summary>
        HANDRAIL_PROJECTION_PARAM = -1150341, // 0xFFEE727B
        /// <summary>"Height"</summary>
        HANDRAIL_HEIGHT_PARAM = -1150340, // 0xFFEE727C
        /// <summary>"Profile"</summary>
        CONTINUOUSRAIL_PROFILE_TYPE_PARAM = -1150339, // 0xFFEE727D
        /// <summary>"Fillet Radius"</summary>
        CONTINUOUSRAIL_FILLET_RADIUS_PARAM = -1150338, // 0xFFEE727E
        /// <summary>"Default Join"</summary>
        CONTINUOUSRAIL_DEFAULT_JOIN_TYPE_PARAM = -1150337, // 0xFFEE727F
        /// <summary>"Lateral Offset"</summary>
        RAILING_SYSTEM_SECONDARY_HANDRAILS_LATTERAL_OFFSET = -1150336, // 0xFFEE7280
        /// <summary>"Height"</summary>
        RAILING_SYSTEM_SECONDARY_HANDRAILS_HEIGHT_PARAM = -1150335, // 0xFFEE7281
        /// <summary>"Position"</summary>
        RAILING_SYSTEM_SECONDARY_HANDRAILS_POSITION_PARAM = -1150334, // 0xFFEE7282
        /// <summary>"Type"</summary>
        RAILING_SYSTEM_SECONDARY_HANDRAILS_TYPES_PARAM = -1150333, // 0xFFEE7283
        /// <summary>"Lateral Offset"</summary>
        RAILING_SYSTEM_HANDRAILS_LATTERAL_OFFSET = -1150332, // 0xFFEE7284
        /// <summary>"Height"</summary>
        RAILING_SYSTEM_HANDRAILS_HEIGHT_PARAM = -1150331, // 0xFFEE7285
        /// <summary>"Position"</summary>
        RAILING_SYSTEM_HANDRAILS_POSITION_PARAM = -1150330, // 0xFFEE7286
        /// <summary>"Type"</summary>
        RAILING_SYSTEM_HANDRAILS_TYPES_PARAM = -1150329, // 0xFFEE7287
        /// <summary>"Height"</summary>
        RAILING_SYSTEM_TOP_RAIL_HEIGHT_PARAM = -1150328, // 0xFFEE7288
        /// <summary>"Type"</summary>
        RAILING_SYSTEM_TOP_RAIL_TYPES_PARAM = -1150327, // 0xFFEE7289
        /// <summary>"Rotation Angle"</summary>
        POINT_ELEMENT_ROTATION_ANGLE = -1150322, // 0xFFEE728E
        /// <summary>"Flip"</summary>
        FLEXIBLE_INSTANCE_FLIP = -1150321, // 0xFFEE728F
        /// <summary>"Orientation"</summary>
        POINT_FLEXIBLE_ORIENTATION_TYPE = -1150320, // 0xFFEE7290
        /// <summary>"Mass Floor"</summary>
        DEFAULT_CONSTRUCTION_MASS_FLOOR = -1150310, // 0xFFEE729A
        /// <summary>"Mass Opening"</summary>
        DEFAULT_CONSTRUCTION_MASS_OPENING = -1150309, // 0xFFEE729B
        /// <summary>"Mass Skylight"</summary>
        DEFAULT_CONSTRUCTION_MASS_SKYLIGHT = -1150307, // 0xFFEE729D
        /// <summary>"Mass Glazing"</summary>
        DEFAULT_CONSTRUCTION_MASS_GLAZING = -1150306, // 0xFFEE729E
        /// <summary>"Mass Exterior Wall - Underground"</summary>
        DEFAULT_CONSTRUCTION_EXT_WALL_UNDERGROUND = -1150305, // 0xFFEE729F
        /// <summary>"Mass Slab"</summary>
        DEFAULT_CONSTRUCTION_MASS_SLAB = -1150304, // 0xFFEE72A0
        /// <summary>"Mass Shade"</summary>
        DEFAULT_CONSTRUCTION_MASS_SHADE = -1150303, // 0xFFEE72A1
        /// <summary>"Mass Roof"</summary>
        DEFAULT_CONSTRUCTION_MASS_ROOF = -1150302, // 0xFFEE72A2
        /// <summary>"Mass Interior Wall"</summary>
        DEFAULT_CONSTRUCTION_MASS_INTERIOR_WALL = -1150301, // 0xFFEE72A3
        /// <summary>"Mass Exterior Wall"</summary>
        DEFAULT_CONSTRUCTION_MASS_EXTERIOR_WALL = -1150300, // 0xFFEE72A4
        /// <summary>"Analytical Space Bounding"</summary>
        ENERGY_ANALYSIS_SPACE_BOUNDING_PARAM = -1150236, // 0xFFEE72E4
        /// <summary>"Horizontal Void/Chase Area Threshold"</summary>
        ENERGY_ANALYSIS_HORIZONTAL_VOID_THRESHOLD = -1150235, // 0xFFEE72E5
        /// <summary>"Average Vertical Void Height Threshold"</summary>
        ENERGY_ANALYSIS_VERTICAL_VOID_THRESHOLD = -1150234, // 0xFFEE72E6
        /// <summary>"Analytical Grid Cell Size"</summary>
        RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_ANALYTICAL_GRID_CELL_SIZE = -1150233, // 0xFFEE72E7
        /// <summary>"Building Envelope"</summary>
        RBS_ENERGY_ANALYSIS_BUILDING_ENVELOPE_DETERMINATION_PARAM = -1150232, // 0xFFEE72E8
        /// <summary>"Right Attachment"</summary>
        LEADER_RIGHT_ATTACHMENT = -1150231, // 0xFFEE72E9
        /// <summary>"Left Attachment"</summary>
        LEADER_LEFT_ATTACHMENT = -1150230, // 0xFFEE72EA
        /// <summary>"Measure From"</summary>
        POINT_ELEMENT_MEASURE_FROM = -1150227, // 0xFFEE72ED
        /// <summary>"Angle"</summary>
        POINT_ELEMENT_ANGLE = -1150226, // 0xFFEE72EE
        /// <summary>"Chord Length"</summary>
        POINT_ELEMENT_CHORD_LENGTH = -1150225, // 0xFFEE72EF
        /// <summary>"Normalized Segment Length"</summary>
        POINT_ELEMENT_NORMALIZED_SEGMENT_LENGTH = -1150224, // 0xFFEE72F0
        /// <summary>"Segment Length"</summary>
        POINT_ELEMENT_SEGMENT_LENGTH = -1150223, // 0xFFEE72F1
        /// <summary>"Normalized Curve Parameter"</summary>
        POINT_ELEMENT_NORMALIZED_CURVE_PARAMATER = -1150222, // 0xFFEE72F2
        /// <summary>"Non-Normalized Curve Parameter"</summary>
        POINT_ELEMENT_NON_NORMALIZED_CURVE_PARAMATER = -1150221, // 0xFFEE72F3
        /// <summary>"Measurement Type"</summary>
        POINT_ELEMENT_MEASUREMENT_TYPE = -1150220, // 0xFFEE72F4
        /// <summary>"End of Attachment to Reference Column"</summary>
        STRUCTURAL_BEAM_END_ATTACHMENT_REFCOLUMN_END = -1150219, // 0xFFEE72F5
        /// <summary>"Start of Attachment to Reference Column"</summary>
        STRUCTURAL_BEAM_START_ATTACHMENT_REFCOLUMN_END = -1150218, // 0xFFEE72F6
        /// <summary>"End Attachment Distance"</summary>
        STRUCTURAL_BEAM_END_ATTACHMENT_DISTANCE = -1150217, // 0xFFEE72F7
        /// <summary>"Start Attachment Distance"</summary>
        STRUCTURAL_BEAM_START_ATTACHMENT_DISTANCE = -1150216, // 0xFFEE72F8
        /// <summary>"End Attachment Type"</summary>
        STRUCTURAL_BEAM_END_ATTACHMENT_TYPE = -1150215, // 0xFFEE72F9
        /// <summary>"Start Attachment Type"</summary>
        STRUCTURAL_BEAM_START_ATTACHMENT_TYPE = -1150214, // 0xFFEE72FA
        /// <summary>"Show Border"</summary>
        TEXT_BOX_VISIBILITY = -1150213, // 0xFFEE72FB
        /// <summary>"Projection Type"</summary>
        CURVE_BY_POINTS_PROJECTION_TYPE = -1150212, // 0xFFEE72FC
        /// <summary>"Follow Surface"</summary>
        FOLLOW_SURFACE = -1150211, // 0xFFEE72FD
        /// <summary>"Detailed Elements"</summary>
        RBS_ENERGY_ANALYSIS_INCLUDE_THERMAL_PROPERTIES = -1150210, // 0xFFEE72FE
        /// <summary>"Number"</summary>
        POINT_FLEXIBLE_NUM_PARAM = -1150209, // 0xFFEE72FF
        /// <summary>"Structural Framing Length Roundoff"</summary>
        FRAMING_LENGTH_ROUNDOFF = -1150208, // 0xFFEE7300
        /// <summary>"Base Extension"</summary>
        SLANTED_COLUMN_BASE_EXTENSION = -1150207, // 0xFFEE7301
        /// <summary>"Top Extension"</summary>
        SLANTED_COLUMN_TOP_EXTENSION = -1150206, // 0xFFEE7302
        /// <summary>"Base Cut Style"</summary>
        SLANTED_COLUMN_BASE_CUT_STYLE = -1150205, // 0xFFEE7303
        /// <summary>"Top Cut Style"</summary>
        SLANTED_COLUMN_TOP_CUT_STYLE = -1150204, // 0xFFEE7304
        /// <summary>"Use Load Credits"</summary>
        RBS_BUILDING_USELOADCREDITS = -1150203, // 0xFFEE7305
        /// <summary>"Component Extents"</summary>
        TILE_PATTERN_FAMREF_COMPONENT_EXTENTS = -1150202, // 0xFFEE7306
        /// <summary>"Number of vertical cells"</summary>
        TILE_PATTERN_GRID_CELLS_Y = -1150201, // 0xFFEE7307
        /// <summary>"Number of horizontal cells"</summary>
        TILE_PATTERN_GRID_CELLS_X = -1150200, // 0xFFEE7308
        /// <summary>"Vertical spacing"</summary>
        TILE_PATTERN_GRID_UNIT_Y = -1150199, // 0xFFEE7309
        /// <summary>"Horizontal spacing"</summary>
        TILE_PATTERN_GRID_UNIT_X = -1150198, // 0xFFEE730A
        /// <summary>"Show Normal Reference Plane Only"</summary>
        POINT_ELEMENT_SHOW_NORMAL_PLANE_ONLY = -1150197, // 0xFFEE730B
        /// <summary>"Is ground plane"</summary>
        LEVEL_IS_GROUND_PLANE = -1150195, // 0xFFEE730D
        /// <summary>"Angle to True North"</summary>
        BASEPOINT_ANGLETON_PARAM = -1150194, // 0xFFEE730E
        /// <summary>"Elev"</summary>
        BASEPOINT_ELEVATION_PARAM = -1150193, // 0xFFEE730F
        /// <summary>"E/W"</summary>
        BASEPOINT_EASTWEST_PARAM = -1150192, // 0xFFEE7310
        /// <summary>"N/S"</summary>
        BASEPOINT_NORTHSOUTH_PARAM = -1150191, // 0xFFEE7311
        /// <summary>"Base Geometry Alignment"</summary>
        SLANTED_COLUMN_GEOMETRY_TREATMENT_BASE = -1150190, // 0xFFEE7312
        /// <summary>"Top Geometry Alignment"</summary>
        SLANTED_COLUMN_GEOMETRY_TREATMENT_TOP = -1150189, // 0xFFEE7313
        /// <summary>"Plenum Lighting Contribution"</summary>
        ROOM_PLENUM_LIGHTING_PARAM = -1150188, // 0xFFEE7314
        /// <summary>"Top Attachment Referenced End"</summary>
        STRUCTURAL_ATTACHMENT_TOP_REFERENCEDEND = -1150183, // 0xFFEE7319
        /// <summary>"Top Attachment Ratio"</summary>
        STRUCTURAL_ATTACHMENT_TOP_RATIO = -1150182, // 0xFFEE731A
        /// <summary>"Top Attachment Distance"</summary>
        STRUCTURAL_ATTACHMENT_TOP_DISTANCE = -1150181, // 0xFFEE731B
        /// <summary>"Top Attachment Type"</summary>
        STRUCTURAL_ATTACHMENT_TOP_TYPE = -1150180, // 0xFFEE731C
        /// <summary>"Base Attachment Referenced End"</summary>
        STRUCTURAL_ATTACHMENT_BASE_REFERENCEDEND = -1150179, // 0xFFEE731D
        /// <summary>"Base Attachment Ratio"</summary>
        STRUCTURAL_ATTACHMENT_BASE_RATIO = -1150178, // 0xFFEE731E
        /// <summary>"Base Attachment Distance"</summary>
        STRUCTURAL_ATTACHMENT_BASE_DISTANCE = -1150177, // 0xFFEE731F
        /// <summary>"Base Attachment Type"</summary>
        STRUCTURAL_ATTACHMENT_BASE_TYPE = -1150176, // 0xFFEE7320
        /// <summary>"Move Base With Grids"</summary>
        INSTANCE_MOVE_BASE_WITH_GRIDS = -1150173, // 0xFFEE7323
        /// <summary>"Move Top With Grids"</summary>
        INSTANCE_MOVE_TOP_WITH_GRIDS = -1150172, // 0xFFEE7324
        /// <summary>"Column Style"</summary>
        SLANTED_COLUMN_TYPE_PARAM = -1150171, // 0xFFEE7325
        /// <summary>"Column Symbolic Offset"</summary>
        VIEW_SLANTED_COLUMN_SYMBOL_OFFSET = -1150170, // 0xFFEE7326
        /// <summary>"Mirrored"</summary>
        POINT_ELEMENT_MIRRORED = -1150169, // 0xFFEE7327
        /// <summary>"Flipped"</summary>
        POINT_ELEMENT_ZFLIPPED = -1150168, // 0xFFEE7328
        /// <summary>"Hosted V Parameter"</summary>
        POINT_ELEMENT_HOSTED_ON_FACE_V_PARAM = -1150167, // 0xFFEE7329
        /// <summary>"Hosted U Parameter"</summary>
        POINT_ELEMENT_HOSTED_ON_FACE_U_PARAM = -1150166, // 0xFFEE732A
        /// <summary>"Positive Offset"</summary>
        LOCKED_END_OFFSET = -1150165, // 0xFFEE732B
        /// <summary>"Negative Offset"</summary>
        LOCKED_START_OFFSET = -1150164, // 0xFFEE732C
        /// <summary>"Negative Offset"</summary>
        LOCKED_BASE_OFFSET = -1150163, // 0xFFEE732D
        /// <summary>"Positive Offset"</summary>
        LOCKED_TOP_OFFSET = -1150162, // 0xFFEE732E
        /// <summary>"Report Type"</summary>
        RBS_PROJECT_REPORTTYPE_PARAM = -1150161, // 0xFFEE732F
        /// <summary>"Building Infiltration Class"</summary>
        RBS_BUILDING_CONSTRUCTIONCLASS = -1150160, // 0xFFEE7330
        /// <summary>"Utility"</summary>
        CONNECTOR_UTILITY_PARAM = -1150159, // 0xFFEE7331
        /// <summary>"Show Placement Number"</summary>
        POINT_FLEXIBLE_SHOW_NUMBER = -1150158, // 0xFFEE7332
        /// <summary>"Constrained"</summary>
        POINT_FLEXIBLE_CONSTRAINED = -1150157, // 0xFFEE7333
        /// <summary>"Name"</summary>
        POINT_NAME_PARAM = -1150156, // 0xFFEE7334
        /// <summary>"Point"</summary>
        POINT_ADAPTIVE_TYPE_PARAM = -1150155, // 0xFFEE7335
        /// <summary>"Units Format"</summary>
        SPOT_DIM_STYLE_SLOPE_UNITS = -1150154, // 0xFFEE7336
        /// <summary>"Driving Curve(s)"</summary>
        POINT_ELEMENT_DRIVING = -1150153, // 0xFFEE7337
        /// <summary>"Leader Line Length"</summary>
        SPOT_SLOPE_LEADER_LENGTH = -1150152, // 0xFFEE7338
        /// <summary>"Suffix"</summary>
        SPOT_SLOPE_SUFFIX = -1150151, // 0xFFEE7339
        /// <summary>"Prefix"</summary>
        SPOT_SLOPE_PREFIX = -1150150, // 0xFFEE733A
        /// <summary>"Visibility/Graphics Overrides"</summary>
        POINT_VISIBILITY_PARAM = -1150149, // 0xFFEE733B
        /// <summary>"Show Reference Planes"</summary>
        POINT_ELEMENT_SHOW_PLANES = -1150148, // 0xFFEE733C
        /// <summary>"Is Reference Line"</summary>
        CURVE_IS_REFERENCE_LINE = -1150147, // 0xFFEE733D
        /// <summary>"Hosted Parameter"</summary>
        POINT_ELEMENT_HOSTED_PARAM = -1150146, // 0xFFEE733E
        /// <summary>"Driven by Host"</summary>
        POINT_ELEMENT_DRIVEN = -1150145, // 0xFFEE733F
        /// <summary>"Offset"</summary>
        POINT_ELEMENT_OFFSET = -1150144, // 0xFFEE7340
        /// <summary>"Alternate Units Format"</summary>
        SPOT_DIM_STYLE_SLOPE_UNITS_ALT = -1150143, // 0xFFEE7341
        /// <summary>"None"</summary>
        FBX_LIGHT_PHOTOMETRIC_FILE_CACHE = -1150142, // 0xFFEE7342
        /// <summary>"Light Source Definition (family)"</summary>
        FBX_LIGHT_PHOTOMETRICS_FAM = -1150141, // 0xFFEE7343
        /// <summary>"Attachment Point"</summary>
        FAMILY_CURVE_ATTACHMENT_PROPORTION = -1150140, // 0xFFEE7344
        /// <summary>"Light Loss Factor"</summary>
        FBX_LIGHT_LOSS_FACTOR_CTRL = -1150139, // 0xFFEE7345
        /// <summary>"Initial Color"</summary>
        FBX_LIGHT_INITIAL_COLOR_CTRL = -1150138, // 0xFFEE7346
        /// <summary>"Light Loss Input Method"</summary>
        FBX_LIGHT_LOSS_FACTOR_METHOD = -1150137, // 0xFFEE7347
        /// <summary>"Temperature Color"</summary>
        FBX_LIGHT_INITIAL_COLOR_NAME = -1150134, // 0xFFEE734A
        /// <summary>"At a distance"</summary>
        FBX_LIGHT_AT_A_DISTANCE = -1150133, // 0xFFEE734B
        /// <summary>"Initial Light Intensity Input Method"</summary>
        FBX_LIGHT_INITIAL_INTENSITY_INPUT_METHOD = -1150132, // 0xFFEE734C
        /// <summary>"Light Source Symbol Length"</summary>
        FBX_LIGHT_SOURCE_LENGTH = -1150131, // 0xFFEE734D
        /// <summary>"Light Source Symbol Size"</summary>
        FBX_LIGHT_SOURCE_DIAMETER = -1150130, // 0xFFEE734E
        /// <summary>"Emit from Circle Diameter"</summary>
        FBX_LIGHT_EMIT_CIRCLE_DIAMETER = -1150129, // 0xFFEE734F
        /// <summary>"Emit from Rectangle Length"</summary>
        FBX_LIGHT_EMIT_RECTANGLE_LENGTH = -1150128, // 0xFFEE7350
        /// <summary>"Emit from Rectangle Width"</summary>
        FBX_LIGHT_EMIT_RECTANGLE_WIDTH = -1150127, // 0xFFEE7351
        /// <summary>"Emit from Line Length"</summary>
        FBX_LIGHT_EMIT_LINE_LENGTH = -1150126, // 0xFFEE7352
        /// <summary>"Emit Shape Visible in Rendering"</summary>
        FBX_LIGHT_EMIT_SHAPE_VISIBLE = -1150118, // 0xFFEE735A
        /// <summary>"Dimming Lamp Color Temperature Shift"</summary>
        FBX_LIGHT_DIMMING_LIGHT_COLOR = -1150117, // 0xFFEE735B
        /// <summary>"Luminaire Dirt Depreciation"</summary>
        FBX_LIGHT_LUMENAIRE_DIRT = -1150115, // 0xFFEE735D
        /// <summary>"Lamp Lumen Depreciation"</summary>
        FBX_LIGHT_LAMP_LUMEN_DEPR = -1150114, // 0xFFEE735E
        /// <summary>"Surface Depreciation Loss"</summary>
        FBX_LIGHT_SURFACE_LOSS = -1150113, // 0xFFEE735F
        /// <summary>"Lamp Tilt Loss"</summary>
        FBX_LIGHT_LAMP_TILT_LOSS = -1150112, // 0xFFEE7360
        /// <summary>"Voltage Loss"</summary>
        FBX_LIGHT_VOLTAGE_LOSS = -1150110, // 0xFFEE7362
        /// <summary>"Temperature Loss"</summary>
        FBX_LIGHT_TEMPERATURE_LOSS = -1150109, // 0xFFEE7363
        /// <summary>"Color Filter"</summary>
        FBX_LIGHT_COLOR_FILTER = -1150108, // 0xFFEE7364
        /// <summary>"Initial Color Temperature"</summary>
        FBX_LIGHT_INITIAL_COLOR_TEMPERATURE = -1150107, // 0xFFEE7365
        /// <summary>"Illuminance"</summary>
        FBX_LIGHT_ILLUMINANCE = -1150106, // 0xFFEE7366
        /// <summary>"Luminous Intensity"</summary>
        FBX_LIGHT_LIMUNOUS_INTENSITY = -1150105, // 0xFFEE7367
        /// <summary>"Efficacy"</summary>
        FBX_LIGHT_EFFICACY = -1150104, // 0xFFEE7368
        /// <summary>"Wattage"</summary>
        FBX_LIGHT_WATTAGE = -1150103, // 0xFFEE7369
        /// <summary>"Initial Intensity"</summary>
        FBX_LIGHT_INITIAL_INTENSITY = -1150102, // 0xFFEE736A
        /// <summary>"Light Source Definition"</summary>
        FBX_LIGHT_PHOTOMETRICS = -1150101, // 0xFFEE736B
        /// <summary>"Light Source"</summary>
        FBX_ASSET_TYPE = -1150100, // 0xFFEE736C
        /// <summary>"Option 2"</summary>
        DIVIDED_SURFACE_GRID_OPTION_PARAM_2 = -1150086, // 0xFFEE737A
        /// <summary>"Option 1"</summary>
        DIVIDED_SURFACE_GRID_OPTION_PARAM_1 = -1150085, // 0xFFEE737B
        /// <summary>"Discarded Division Lines"</summary>
        DIVIDED_SURFACE_DISPLAY_DISCARDEDDIVISIONLINES = -1150084, // 0xFFEE737C
        /// <summary>"Component Trim"</summary>
        DIVIDED_SURFACE_COMPONENT_TRIM_TYPE = -1150083, // 0xFFEE737D
        /// <summary>"Component Mirror"</summary>
        DIVIDED_SURFACE_PATTERN_MIRROR = -1150082, // 0xFFEE737E
        /// <summary>"Is grid 2 suspended?"</summary>
        DIVIDED_SURFACE_RULE_2_SUSPENSION = -1150081, // 0xFFEE737F
        /// <summary>"Is grid 1 suspended?"</summary>
        DIVIDED_SURFACE_RULE_1_SUSPENSION = -1150080, // 0xFFEE7380
        /// <summary>"Components"</summary>
        DIVIDED_SURFACE_DISPLAY_COMPONENTS = -1150079, // 0xFFEE7381
        /// <summary>"Pattern Fill Material"</summary>
        DIVIDED_SURFACE_PATTERN_FILL_MATERIAL = -1150078, // 0xFFEE7382
        /// <summary>"Pattern Fill"</summary>
        DIVIDED_SURFACE_DISPLAY_PATTERN_FILL = -1150077, // 0xFFEE7383
        /// <summary>"Pattern Lines Style"</summary>
        DIVIDED_SURFACE_PATTERN_LINES_STYLE = -1150076, // 0xFFEE7384
        /// <summary>"Pattern Lines"</summary>
        DIVIDED_SURFACE_DISPLAY_PATTERN_LINES = -1150075, // 0xFFEE7385
        /// <summary>"Gridlines Style"</summary>
        DIVIDED_SURFACE_GRIDLINES_STYLE = -1150074, // 0xFFEE7386
        /// <summary>"Gridlines"</summary>
        DIVIDED_SURFACE_DISPLAY_GRIDLINES = -1150073, // 0xFFEE7387
        /// <summary>"Nodes"</summary>
        DIVIDED_SURFACE_DISPLAY_NODES = -1150072, // 0xFFEE7388
        /// <summary>"Surface Material"</summary>
        DIVIDED_SURFACE_ORIGINAL_SURFACE_MATERIAL = -1150071, // 0xFFEE7389
        /// <summary>"Surface"</summary>
        DIVIDED_SURFACE_DISPLAY_ORIGINAL_SURFACE = -1150070, // 0xFFEE738A
        /// <summary>"Display Surface Option"</summary>
        DIVIDED_SURFACE_DISPLAY_SURFACE_OPTION = -1150069, // 0xFFEE738B
        /// <summary>"All Grid Rotation"</summary>
        DIVIDED_SURFACE_ALL_GRID_ROTATION = -1150068, // 0xFFEE738C
        /// <summary>"Border Tile"</summary>
        DIVIDED_SURFACE_TILE_BORDER = -1150067, // 0xFFEE738D
        /// <summary>"Show all points"</summary>
        DIVIDED_SURFACE_ALL_POINTS = -1150062, // 0xFFEE7392
        /// <summary>"Tile Pattern"</summary>
        DIVIDED_SURFACE_PATTERN = -1150061, // 0xFFEE7393
        /// <summary>"Component Flip"</summary>
        DIVIDED_SURFACE_PATTERN_FLIP = -1150060, // 0xFFEE7394
        /// <summary>"Component Rotation"</summary>
        DIVIDED_SURFACE_PATTERN_ROTATION_ANGLE = -1150059, // 0xFFEE7395
        /// <summary>"Indent 2"</summary>
        DIVIDED_SURFACE_PATTERN_INDENT_2 = -1150058, // 0xFFEE7396
        /// <summary>"Indent 1"</summary>
        DIVIDED_SURFACE_PATTERN_INDENT_1 = -1150057, // 0xFFEE7397
        /// <summary>"Cover face completely"</summary>
        DIVIDED_SURFACE_COVER_FACE_COMPLETELY = -1150056, // 0xFFEE7398
        /// <summary>"Offset from surface"</summary>
        DIVIDED_SURFACE_OFFSET_FROM_SURFACE = -1150055, // 0xFFEE7399
        /// <summary>"Total edge length"</summary>
        DIVIDED_SURFACE_TOTAL_EDGE_LENGTH = -1150054, // 0xFFEE739A
        /// <summary>"Edge number"</summary>
        DIVIDED_SURFACE_EDGE_NUMBER = -1150053, // 0xFFEE739B
        /// <summary>"Point number"</summary>
        DIVIDED_SURFACE_POINT_NUMBER = -1150052, // 0xFFEE739C
        /// <summary>"Facet number"</summary>
        DIVIDED_SURFACE_FACET_NUMBER = -1150051, // 0xFFEE739D
        /// <summary>"Divided Surface Area"</summary>
        DIVIDED_SURFACE_SURFACE_AREA = -1150050, // 0xFFEE739E
        /// <summary>"Lighting Calculation Luminaire Plane"</summary>
        RBS_ELEC_ROOM_LIGHTING_CALC_LUMINAIREPLANE = -1144331, // 0xFFEE89F5
        /// <summary>"Curve Type Reference"</summary>
        LAYOUTNODE_CURVETYPE_PARAM = -1142000, // 0xFFEE9310
        /// <summary>"Part Pattern Number"</summary>
        FABRICATION_PART_PAT_NO = -1141014, // 0xFFEE96EA
        /// <summary>"Size of Connector End"</summary>
        FABRICATION_END_SIZE = -1141013, // 0xFFEE96EB
        /// <summary>"Size of Primary Branch End"</summary>
        FABRICATION_BRA_SIZE = -1141012, // 0xFFEE96EC
        /// <summary>"Size of Secondary End"</summary>
        FABRICATION_SEC_SIZE = -1141011, // 0xFFEE96ED
        /// <summary>"Size of Primary End"</summary>
        FABRICATION_PRI_SIZE = -1141010, // 0xFFEE96EE
        /// <summary>"Change Service"</summary>
        FABRICATION_CHANGE_SERVICE_PARAM = -1141009, // 0xFFEE96EF
        /// <summary>"SU/SD from Bottom"</summary>
        FABRICATION_SET_UP_DOWN_TAG_FROM_BOTTOM = -1141008, // 0xFFEE96F0
        /// <summary>"Insulation Material"</summary>
        FABRICATION_INSULATION_MATERIAL_FINISH = -1141007, // 0xFFEE96F1
        /// <summary>"Z Displacement"</summary>
        DISPLACED_ELEMENT_DISPLACEMENT_Z = -1141006, // 0xFFEE96F2
        /// <summary>"Y Displacement"</summary>
        DISPLACED_ELEMENT_DISPLACEMENT_Y = -1141005, // 0xFFEE96F3
        /// <summary>"X Displacement"</summary>
        DISPLACED_ELEMENT_DISPLACEMENT_X = -1141004, // 0xFFEE96F4
        /// <summary>"Style"</summary>
        DISPLACEMENT_PATH_STYLE = -1141003, // 0xFFEE96F5
        /// <summary>"Depth"</summary>
        DISPLACEMENT_PATH_DEPTH = -1141002, // 0xFFEE96F6
        /// <summary>
        ///    "Target view": This is used by the UI to allow selection of target view.
        ///    It allows the UI to set a filter that is incompatible
        ///    with the current target view (REFERENCE_VIEWER_TARGET_VIEW).
        /// </summary>
        REFERENCE_VIEWER_UI_TARGET_VIEW = -1141001, // 0xFFEE96F7
        /// <summary>"Filter": This is used by the UI to filter the list of target views.</summary>
        REFERENCE_VIEWER_UI_TARGET_FILTER = -1141000, // 0xFFEE96F8
        /// <summary>"Fabrication Fitting Description"</summary>
        FABRICATION_FITTING_DESCRIPTION = -1140999, // 0xFFEE96F9
        /// <summary>"Double Wall Material Abbreviation"</summary>
        FABRICATION_DOUBLEWALL_MATERIAL_ABBREVIATION = -1140998, // 0xFFEE96FA
        /// <summary>"Material Abbreviation"</summary>
        FABRICATION_MATERIAL_ABBREVIATION = -1140997, // 0xFFEE96FB
        /// <summary>"Insulation Specification Abbreviation"</summary>
        FABRICATION_INSULATION_SPECIFICATION_ABBREVIATION = -1140996, // 0xFFEE96FC
        /// <summary>"Insulation Abbreviation"</summary>
        FABRICATION_INSULATION_ABBREVIATION = -1140995, // 0xFFEE96FD
        /// <summary>"Specification Abbreviation"</summary>
        FABRICATION_SPECIFICATION_ABBREVIATION = -1140994, // 0xFFEE96FE
        /// <summary>"Pipe Invert Elevation"</summary>
        FABRICATION_PIPE_INVERT_ELEVATION = -1140993, // 0xFFEE96FF
        /// <summary>"Bottom Elevation with Insulation"</summary>
        FABRICATION_BOTTOM_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140992, // 0xFFEE9700
        /// <summary>"Bottom Elevation"</summary>
        FABRICATION_BOTTOM_ELEVATION_OF_PART = -1140991, // 0xFFEE9701
        /// <summary>"Top Elevation with Insulation"</summary>
        FABRICATION_TOP_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140990, // 0xFFEE9702
        /// <summary>"Top Elevation"</summary>
        FABRICATION_TOP_ELEVATION_OF_PART = -1140989, // 0xFFEE9703
        /// <summary>"Centerline Elevation"</summary>
        FABRICATION_CENTERLINE_ELEVATION_OF_PART = -1140988, // 0xFFEE9704
        /// <summary>"Spot Bottom Elevation with Insulation"</summary>
        FABRICATION_SPOT_BOTTOM_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140987, // 0xFFEE9705
        /// <summary>"Spot Bottom Elevation"</summary>
        FABRICATION_SPOT_BOTTOM_ELEVATION_OF_PART = -1140986, // 0xFFEE9706
        /// <summary>"Spot Top Elevation with Insulation"</summary>
        FABRICATION_SPOT_TOP_ELEVATION_INCLUDE_INSULATION_OF_PART = -1140985, // 0xFFEE9707
        /// <summary>"Spot Top Elevation"</summary>
        FABRICATION_SPOT_TOP_ELEVATION_OF_PART = -1140984, // 0xFFEE9708
        /// <summary>"Double Wall Material Area"</summary>
        FABRICATION_PART_DOUBLEWALL_MATERIAL_AREA = -1140983, // 0xFFEE9709
        /// <summary>"SU/SD from Top"</summary>
        FABRICATION_SET_UP_DOWN_TAG = -1140982, // 0xFFEE970A
        /// <summary>"Part Sheet Metal Area"</summary>
        FABRICATION_PART_SHEETMETAL_AREA = -1140981, // 0xFFEE970B
        /// <summary>"Fabrication Service Abbreviation"</summary>
        FABRICATION_SERVICE_ABBREVIATION = -1140979, // 0xFFEE970D
        /// <summary>"Part Material Thickness"</summary>
        FABRICATION_PART_MATERIAL_THICKNESS = -1140978, // 0xFFEE970E
        /// <summary>"Fabrication Notes"</summary>
        FABRICATION_PART_NOTES = -1140977, // 0xFFEE970F
        /// <summary>"Lining Area"</summary>
        FABRICATION_PART_LINING_AREA = -1140976, // 0xFFEE9710
        /// <summary>"Item Number"</summary>
        FABRICATION_PART_ITEM_NUMBER = -1140975, // 0xFFEE9711
        /// <summary>"Insulation Area"</summary>
        FABRICATION_PART_INSULATION_AREA = -1140974, // 0xFFEE9712
        /// <summary>"Fabrication Service Name"</summary>
        FABRICATION_SERVICE_NAME = -1140973, // 0xFFEE9713
        /// <summary>"Double Wall Material Thickness"</summary>
        FABRICATION_PART_DOUBLEWALL_MATERIAL_THICKNESS = -1140972, // 0xFFEE9714
        /// <summary>"Double Wall Material"</summary>
        FABRICATION_PART_DOUBLEWALL_MATERIAL = -1140971, // 0xFFEE9715
        /// <summary>"Cut Type"</summary>
        FABRICATION_PART_CUT_TYPE = -1140970, // 0xFFEE9716
        /// <summary>"Bought Out"</summary>
        FABRICATION_PART_BOUGHT_OUT = -1140969, // 0xFFEE9717
        /// <summary>"Alias"</summary>
        FABRICATION_PART_ALIAS = -1140968, // 0xFFEE9718
        /// <summary>"x of XX"</summary>
        FABRICATION_ROUTING_SOLUTIONS_UI_PARAM = -1140967, // 0xFFEE9719
        /// <summary>"Product Code"</summary>
        FABRICATION_PRODUCT_CODE = -1140966, // 0xFFEE971A
        /// <summary>"More Parameters"</summary>
        FABRICATION_PART_TAKEOFF_DIALOG_PARAM = -1140965, // 0xFFEE971B
        /// <summary>"Main Secondary Depth Option"</summary>
        FABRICATION_PART_DEPTH_OUT_OPTION = -1140957, // 0xFFEE9723
        /// <summary>"Main Secondary Width Option"</summary>
        FABRICATION_PART_WIDTH_OUT_OPTION = -1140956, // 0xFFEE9724
        /// <summary>"Main Secondary Diameter Option"</summary>
        FABRICATION_PART_DIAMETER_OUT_OPTION = -1140955, // 0xFFEE9725
        /// <summary>"Main Primary Diameter Option"</summary>
        FABRICATION_PART_DIAMETER_IN_OPTION = -1140952, // 0xFFEE9728
        /// <summary>"Main Primary Depth Option"</summary>
        FABRICATION_PART_DEPTH_IN_OPTION = -1140951, // 0xFFEE9729
        /// <summary>"Main Primary Width Option"</summary>
        FABRICATION_PART_WIDTH_IN_OPTION = -1140950, // 0xFFEE972A
        /// <summary>"Angle Option"</summary>
        FABRICATION_PART_ANGLE_OPTION = -1140949, // 0xFFEE972B
        /// <summary>"Length Option"</summary>
        FABRICATION_PART_LENGTH_OPTION = -1140948, // 0xFFEE972C
        /// <summary>"Insulation Specification"</summary>
        FABRICATION_INSULATION_SPEC = -1140947, // 0xFFEE972D
        /// <summary>"Length"</summary>
        FABRICATION_PART_LENGTH = -1140944, // 0xFFEE9730
        /// <summary>"Product Entry"</summary>
        FABRICATION_PRODUCT_ENTRY = -1140943, // 0xFFEE9731
        /// <summary>"Main Secondary Depth"</summary>
        FABRICATION_PART_DEPTH_OUT = -1140935, // 0xFFEE9739
        /// <summary>"Main Secondary Width"</summary>
        FABRICATION_PART_WIDTH_OUT = -1140934, // 0xFFEE973A
        /// <summary>"Main Secondary Diameter"</summary>
        FABRICATION_PART_DIAMETER_OUT = -1140933, // 0xFFEE973B
        /// <summary>"Main Primary Depth"</summary>
        FABRICATION_PART_DEPTH_IN = -1140930, // 0xFFEE973E
        /// <summary>"Main Primary Width"</summary>
        FABRICATION_PART_WIDTH_IN = -1140929, // 0xFFEE973F
        /// <summary>"End Middle Elevation"</summary>
        FABRICATION_END_OFFSET_PARAM = -1140925, // 0xFFEE9743
        /// <summary>"Start Middle Elevation"</summary>
        FABRICATION_START_OFFSET_PARAM = -1140924, // 0xFFEE9744
        /// <summary>"Slope"</summary>
        FABRICATION_SLOPE_PARAM = -1140923, // 0xFFEE9745
        /// <summary>"Relative File Name"</summary>
        FABRICATION_RELATIVE_FILENAME = -1140921, // 0xFFEE9747
        /// <summary>"Vendor"</summary>
        FABRICATION_VENDOR = -1140920, // 0xFFEE9748
        /// <summary>"Bottom"</summary>
        FABRICATION_BOTTOM_OF_PART = -1140919, // 0xFFEE9749
        /// <summary>"Top"</summary>
        FABRICATION_TOP_OF_PART = -1140918, // 0xFFEE974A
        /// <summary>"Middle Elevation"</summary>
        FABRICATION_OFFSET_PARAM = -1140917, // 0xFFEE974B
        /// <summary>"Reference Level"</summary>
        FABRICATION_LEVEL_PARAM = -1140916, // 0xFFEE974C
        /// <summary>"Specification"</summary>
        FABRICATION_SPECIFICATION = -1140915, // 0xFFEE974D
        /// <summary>"Vendor Code"</summary>
        FABRICATION_VENDOR_CODE = -1140914, // 0xFFEE974E
        /// <summary>"Weight"</summary>
        FABRICATION_PART_WEIGHT = -1140913, // 0xFFEE974F
        /// <summary>"Main Primary Diameter"</summary>
        FABRICATION_PART_DIAMETER_IN = -1140912, // 0xFFEE9750
        /// <summary>"Angle"</summary>
        FABRICATION_PART_ANGLE = -1140911, // 0xFFEE9751
        /// <summary>"Install Type"</summary>
        FABRICATION_PRODUCT_DATA_INSTALL_TYPE = -1140910, // 0xFFEE9752
        /// <summary>"Part Material"</summary>
        FABRICATION_PART_MATERIAL = -1140909, // 0xFFEE9753
        /// <summary>"OEM"</summary>
        FABRICATION_PRODUCT_DATA_OEM = -1140908, // 0xFFEE9754
        /// <summary>"Product Name"</summary>
        FABRICATION_PRODUCT_DATA_PRODUCT = -1140907, // 0xFFEE9755
        /// <summary>"Product Short Description"</summary>
        FABRICATION_PRODUCT_DATA_ITEM_DESCRIPTION = -1140906, // 0xFFEE9756
        /// <summary>"Product Size Description"</summary>
        FABRICATION_PRODUCT_DATA_SIZE_DESCRIPTION = -1140905, // 0xFFEE9757
        /// <summary>"Product Material Description"</summary>
        FABRICATION_PRODUCT_DATA_MATERIAL_DESCRIPTION = -1140904, // 0xFFEE9758
        /// <summary>"Product Specification Description"</summary>
        FABRICATION_PRODUCT_DATA_SPECIFICATION = -1140903, // 0xFFEE9759
        /// <summary>"Product Long Description"</summary>
        FABRICATION_PRODUCT_DATA_LONG_DESCRIPTION = -1140902, // 0xFFEE975A
        /// <summary>"Product Range"</summary>
        FABRICATION_PRODUCT_DATA_RANGE = -1140901, // 0xFFEE975B
        /// <summary>"Product Finish Description"</summary>
        FABRICATION_PRODUCT_DATA_FINISH_DESCRIPTION = -1140900, // 0xFFEE975C
        /// <summary>"Structural Framing Type"</summary>
        TRUSS_FAMILY_BOTTOM_CHORD_STRUCTURAL_TYPES_PARAM = -1140766, // 0xFFEE97E2
        /// <summary>"Angle"</summary>
        TRUSS_FAMILY_BOTTOM_CHORD_ANGLE_PARAM = -1140764, // 0xFFEE97E4
        /// <summary>"Analytical Vertical Projection"</summary>
        TRUSS_FAMILY_BOTTOM_CHORD_VERTICAL_PROJECTION_PARAM = -1140763, // 0xFFEE97E5
        /// <summary>"Start Release"</summary>
        TRUSS_FAMILY_BOTTOM_CHORD_START_RELEASE_TYPE = -1140762, // 0xFFEE97E6
        /// <summary>"End Release"</summary>
        TRUSS_FAMILY_BOTTOM_CHORD_END_RELEASE_TYPE = -1140761, // 0xFFEE97E7
        /// <summary>
        ///    "Reference View": This is used by the UI to allow selection of view reference.
        /// </summary>
        REFERENCE_OTHER_VIEW_UI_REF_VIEW = -1140759, // 0xFFEE97E9
        /// <summary>
        ///    "Reference Other View": This is used to determine whether reference other view is enable or not.
        /// </summary>
        REFERENCE_OTHER_VIEW_UI_TOGGLE = -1140758, // 0xFFEE97EA
        /// <summary>"Tag new members in view"</summary>
        JOIST_SYSTEM_ELEM_TAG_NEW_MEMBERS_VIEW = -1140757, // 0xFFEE97EB
        /// <summary>"View Reference Tag"</summary>
        REFERENCE_VIEWER_ATTR_TAG = -1140756, // 0xFFEE97EC
        /// <summary>"Target view"</summary>
        REFERENCE_VIEWER_TARGET_VIEW = -1140755, // 0xFFEE97ED
        /// <summary>"Bottom Constraint"</summary>
        MATCHLINE_BOTTOM_PLANE = -1140754, // 0xFFEE97EE
        /// <summary>"Top Constraint"</summary>
        MATCHLINE_TOP_PLANE = -1140753, // 0xFFEE97EF
        /// <summary>"Bottom Offset"</summary>
        MATCHLINE_BOTTOM_OFFSET = -1140752, // 0xFFEE97F0
        /// <summary>"Top Offset"</summary>
        MATCHLINE_TOP_OFFSET = -1140751, // 0xFFEE97F1
        /// <summary>"Structural Framing Type"</summary>
        TRUSS_FAMILY_TOP_CHORD_STRUCTURAL_TYPES_PARAM = -1140746, // 0xFFEE97F6
        /// <summary>"Angle"</summary>
        TRUSS_FAMILY_TOP_CHORD_ANGLE_PARAM = -1140744, // 0xFFEE97F8
        /// <summary>"Analytical Vertical Projection"</summary>
        TRUSS_FAMILY_TOP_CHORD_VERTICAL_PROJECTION_PARAM = -1140743, // 0xFFEE97F9
        /// <summary>"Start Release"</summary>
        TRUSS_FAMILY_TOP_CHORD_START_RELEASE_TYPE = -1140742, // 0xFFEE97FA
        /// <summary>"End Release"</summary>
        TRUSS_FAMILY_TOP_CHORD_END_RELEASE_TYPE = -1140741, // 0xFFEE97FB
        /// <summary>"Structural Framing Type"</summary>
        TRUSS_FAMILY_DIAG_WEB_STRUCTURAL_TYPES_PARAM = -1140736, // 0xFFEE9800
        /// <summary>"Angle"</summary>
        TRUSS_FAMILY_DIAG_WEB_ANGLE_PARAM = -1140734, // 0xFFEE9802
        /// <summary>"Start Release"</summary>
        TRUSS_FAMILY_DIAG_WEB_START_RELEASE_TYPE = -1140732, // 0xFFEE9804
        /// <summary>"End Release"</summary>
        TRUSS_FAMILY_DIAG_WEB_END_RELEASE_TYPE = -1140731, // 0xFFEE9805
        /// <summary>"Structural Framing Type"</summary>
        TRUSS_FAMILY_VERT_WEB_STRUCTURAL_TYPES_PARAM = -1140726, // 0xFFEE980A
        /// <summary>"Angle"</summary>
        TRUSS_FAMILY_VERT_WEB_ANGLE_PARAM = -1140724, // 0xFFEE980C
        /// <summary>"Start Release"</summary>
        TRUSS_FAMILY_VERT_WEB_START_RELEASE_TYPE = -1140722, // 0xFFEE980E
        /// <summary>"End Release"</summary>
        TRUSS_FAMILY_VERT_WEB_END_RELEASE_TYPE = -1140721, // 0xFFEE980F
        /// <summary>"Tag new members in view"</summary>
        TRUSS_ELEMENT_TAG_NEW_MEMBERS_VIEW = -1140718, // 0xFFEE9812
        /// <summary>"Non Bearing Offset"</summary>
        TRUSS_NON_BEARING_OFFSET_PARAM = -1140717, // 0xFFEE9813
        /// <summary>"Bearing Chord"</summary>
        TRUSS_BEARING_CHORD_TOP_BOTTOM_PARAM = -1140716, // 0xFFEE9814
        /// <summary>"Span"</summary>
        TRUSS_ELEMENT_SPAN_PARAM = -1140715, // 0xFFEE9815
        /// <summary>"Stick Symbol Location"</summary>
        TRUSS_ELEMENT_STICK_JUST_PARAM = -1140714, // 0xFFEE9816
        /// <summary>"Webs have symbolic cutback"</summary>
        TRUSS_FAMILY_WEBS_HAVE_SYMBOLIC_CUTBACK_PARAM = -1140713, // 0xFFEE9817
        /// <summary>"Truss Height"</summary>
        TRUSS_HEIGHT = -1140712, // 0xFFEE9818
        /// <summary>"Web Orientation"</summary>
        TRUSS_FAMILY_TRANSFORMATION_PARAM = -1140711, // 0xFFEE9819
        /// <summary>"Rotate Chords With Truss"</summary>
        TRUSS_ELEMENT_ROTATE_CHORDS_WITH_TRUSS = -1140710, // 0xFFEE981A
        /// <summary>"Reference Level"</summary>
        TRUSS_ELEMENT_REFERENCE_LEVEL_PARAM = -1140709, // 0xFFEE981B
        /// <summary>"End Level Offset"</summary>
        TRUSS_ELEMENT_END1_ELEVATION = -1140708, // 0xFFEE981C
        /// <summary>"Start Level Offset"</summary>
        TRUSS_ELEMENT_END0_ELEVATION = -1140707, // 0xFFEE981D
        /// <summary>"Bearing Vertical Justification"</summary>
        TRUSS_ELEMENT_BEARING_JUST_PARAM = -1140706, // 0xFFEE981E
        /// <summary>"Create Bottom Chord"</summary>
        TRUSS_ELEMENT_CREATE_BOTTOM_PARAM = -1140705, // 0xFFEE981F
        /// <summary>"Create Top Chord"</summary>
        TRUSS_ELEMENT_CREATE_TOP_PARAM = -1140704, // 0xFFEE9820
        /// <summary>"Rotation Angle"</summary>
        TRUSS_ELEMENT_ANGLE_PARAM = -1140703, // 0xFFEE9821
        /// <summary>"Engineering Type"</summary>
        TRUSS_ELEMENT_CLASS_PARAM = -1140702, // 0xFFEE9822
        /// <summary>"Truss Length"</summary>
        TRUSS_LENGTH = -1140700, // 0xFFEE9824
        /// <summary>"State"</summary>
        BOUNDARY_PARAM_PRESET_AREA = -1140635, // 0xFFEE9865
        /// <summary>"State"</summary>
        BOUNDARY_PARAM_PRESET_LINEAR = -1140634, // 0xFFEE9866
        /// <summary>"State"</summary>
        BOUNDARY_PARAM_PRESET = -1140633, // 0xFFEE9867
        /// <summary>"Z Translation - Spring"</summary>
        BOUNDARY_Z_TRANSLATION_SPRING = -1140532, // 0xFFEE98CC
        /// <summary>"Z Translation - Fixed"</summary>
        BOUNDARY_Z_TRANSLATION_FIXED = -1140531, // 0xFFEE98CD
        /// <summary>"Z Rotation - Spring"</summary>
        BOUNDARY_Z_ROTATION_SPRING = -1140530, // 0xFFEE98CE
        /// <summary>"Z Rotation - Fixed"</summary>
        BOUNDARY_Z_ROTATION_FIXED = -1140529, // 0xFFEE98CF
        /// <summary>"Y Translation - Spring"</summary>
        BOUNDARY_Y_TRANSLATION_SPRING = -1140528, // 0xFFEE98D0
        /// <summary>"Y Translation - Fixed"</summary>
        BOUNDARY_Y_TRANSLATION_FIXED = -1140527, // 0xFFEE98D1
        /// <summary>"Y Rotation - Spring"</summary>
        BOUNDARY_Y_ROTATION_SPRING = -1140526, // 0xFFEE98D2
        /// <summary>"Y Rotation - Fixed"</summary>
        BOUNDARY_Y_ROTATION_FIXED = -1140525, // 0xFFEE98D3
        /// <summary>"X Translation - Spring"</summary>
        BOUNDARY_X_TRANSLATION_SPRING = -1140524, // 0xFFEE98D4
        /// <summary>"X Translation - Fixed"</summary>
        BOUNDARY_X_TRANSLATION_FIXED = -1140523, // 0xFFEE98D5
        /// <summary>"X Rotation - Spring"</summary>
        BOUNDARY_X_ROTATION_SPRING = -1140522, // 0xFFEE98D6
        /// <summary>"X Rotation - Fixed"</summary>
        BOUNDARY_X_ROTATION_FIXED = -1140521, // 0xFFEE98D7
        /// <summary>"Z Spring Modulus"</summary>
        BOUNDARY_AREA_RESTRAINT_Z = -1140520, // 0xFFEE98D8
        /// <summary>"Y Spring Modulus"</summary>
        BOUNDARY_AREA_RESTRAINT_Y = -1140519, // 0xFFEE98D9
        /// <summary>"X Spring Modulus"</summary>
        BOUNDARY_AREA_RESTRAINT_X = -1140518, // 0xFFEE98DA
        /// <summary>"X Spring Modulus"</summary>
        BOUNDARY_LINEAR_RESTRAINT_ROT_X = -1140517, // 0xFFEE98DB
        /// <summary>"Z Spring Modulus"</summary>
        BOUNDARY_LINEAR_RESTRAINT_Z = -1140516, // 0xFFEE98DC
        /// <summary>"Y Spring Modulus"</summary>
        BOUNDARY_LINEAR_RESTRAINT_Y = -1140515, // 0xFFEE98DD
        /// <summary>"X Spring Modulus"</summary>
        BOUNDARY_LINEAR_RESTRAINT_X = -1140514, // 0xFFEE98DE
        /// <summary>"Z Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_ROT_Z = -1140513, // 0xFFEE98DF
        /// <summary>"Y Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_ROT_Y = -1140512, // 0xFFEE98E0
        /// <summary>"X Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_ROT_X = -1140511, // 0xFFEE98E1
        /// <summary>"Z Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_Z = -1140510, // 0xFFEE98E2
        /// <summary>"Y Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_Y = -1140509, // 0xFFEE98E3
        /// <summary>"X Spring Modulus"</summary>
        BOUNDARY_RESTRAINT_X = -1140508, // 0xFFEE98E4
        /// <summary>"Z Rotation"</summary>
        BOUNDARY_DIRECTION_ROT_Z = -1140507, // 0xFFEE98E5
        /// <summary>"Y Rotation"</summary>
        BOUNDARY_DIRECTION_ROT_Y = -1140506, // 0xFFEE98E6
        /// <summary>"X Rotation"</summary>
        BOUNDARY_DIRECTION_ROT_X = -1140505, // 0xFFEE98E7
        /// <summary>"Z Translation"</summary>
        BOUNDARY_DIRECTION_Z = -1140504, // 0xFFEE98E8
        /// <summary>"Y Translation"</summary>
        BOUNDARY_DIRECTION_Y = -1140503, // 0xFFEE98E9
        /// <summary>"X Translation"</summary>
        BOUNDARY_DIRECTION_X = -1140502, // 0xFFEE98EA
        /// <summary>"Is Boundary Conditions External?"</summary>
        BOUNDARY_CONDITIONS_IS_EXT = -1140501, // 0xFFEE98EB
        /// <summary>"Boundary Conditions Type"</summary>
        BOUNDARY_CONDITIONS_TYPE = -1140500, // 0xFFEE98EC
        /// <summary>"Key Source"</summary>
        KEY_SOURCE_PARAM = -1140423, // 0xFFEE9939
        /// <summary>"Keynote"</summary>
        KEYNOTE_PARAM = -1140422, // 0xFFEE993A
        /// <summary>"Key Value"</summary>
        KEYNOTE_NUMBER = -1140421, // 0xFFEE993B
        /// <summary>"Sheet Key Number"</summary>
        SHEET_KEY_NUMBER = -1140420, // 0xFFEE993C
        /// <summary>"Keynote Text"</summary>
        KEYNOTE_TEXT = -1140419, // 0xFFEE993D
        /// <summary>"Key Value"</summary>
        KEY_VALUE = -1140418, // 0xFFEE993E
        /// <summary>"Grade"</summary>
        PHY_MATERIAL_PARAM_GRADE = -1140417, // 0xFFEE993F
        /// <summary>"Species"</summary>
        PHY_MATERIAL_PARAM_SPECIES = -1140416, // 0xFFEE9940
        /// <summary>"Thermal expansion coefficient"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF = -1140415, // 0xFFEE9941
        /// <summary>"Bending"</summary>
        PHY_MATERIAL_PARAM_BENDING = -1140414, // 0xFFEE9942
        /// <summary>"Shear modulus"</summary>
        PHY_MATERIAL_PARAM_SHEAR_MOD = -1140413, // 0xFFEE9943
        /// <summary>"Poisson ratio"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD = -1140412, // 0xFFEE9944
        /// <summary>"Tension perpendicular to grain"</summary>
        PHY_MATERIAL_PARAM_SHEAR_PERPENDICULAR = -1140410, // 0xFFEE9946
        /// <summary>"Shear parallel to grain"</summary>
        PHY_MATERIAL_PARAM_SHEAR_PARALLEL = -1140409, // 0xFFEE9947
        /// <summary>"Compression perpendicular to grain"</summary>
        PHY_MATERIAL_PARAM_COMPRESSION_PERPENDICULAR = -1140408, // 0xFFEE9948
        /// <summary>"Compression parallel to grain"</summary>
        PHY_MATERIAL_PARAM_COMPRESSION_PARALLEL = -1140407, // 0xFFEE9949
        /// <summary>"Young modulus"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD = -1140401, // 0xFFEE994F
        /// <summary>"Material Type"</summary>
        PHY_MATERIAL_PARAM_TYPE = -1140400, // 0xFFEE9950
        /// <summary>"Category"</summary>
        ELEM_CATEGORY_PARAM_MT = -1140363, // 0xFFEE9975
        /// <summary>"Category"</summary>
        ELEM_CATEGORY_PARAM = -1140362, // 0xFFEE9976
        /// <summary>"Volume"</summary>
        MATERIAL_VOLUME = -1140361, // 0xFFEE9977
        /// <summary>"Area"</summary>
        MATERIAL_AREA = -1140360, // 0xFFEE9978
        /// <summary>"As Paint"</summary>
        MATERIAL_ASPAINT = -1140359, // 0xFFEE9979
        /// <summary>"Name"</summary>
        MATERIAL_NAME = -1140355, // 0xFFEE997D
        /// <summary>"Pipe Slope Options"</summary>
        RBS_PIPE_SLOPE_OPTIONS_DEF_PARAM = -1140340, // 0xFFEE998C
        /// <summary>"Fabrication Service"</summary>
        FABRICATION_SERVICE_PARAM = -1140339, // 0xFFEE998D
        /// <summary>"Angle of Deflection"</summary>
        CONNECTOR_ANGLE_OF_DEFLECTION = -1140338, // 0xFFEE998E
        /// <summary>"Length"</summary>
        CONNECTOR_LENGTH = -1140337, // 0xFFEE998F
        /// <summary>"Calculations"</summary>
        RBS_DUCT_SYSTEM_CALCULATION_PARAM = -1140336, // 0xFFEE9990
        /// <summary>"Calculations"</summary>
        RBS_PIPE_SYSTEM_CALCULATION_PARAM = -1140335, // 0xFFEE9991
        /// <summary>"System Type"</summary>
        RBS_PIPING_SYSTEM_TYPE_PARAM = -1140334, // 0xFFEE9992
        /// <summary>"System Type"</summary>
        RBS_DUCT_SYSTEM_TYPE_PARAM = -1140333, // 0xFFEE9993
        /// <summary>"Abbreviation"</summary>
        RBS_SYSTEM_ABBREVIATION_PARAM = -1140332, // 0xFFEE9994
        /// <summary>"Graphic Overrides"</summary>
        MEP_SYSTEM_LINE_GRAPHICS_OVERRIDES_PARAM = -1140331, // 0xFFEE9995
        /// <summary>"Pipe Slope Definitions"</summary>
        RBS_PIPE_SLOPE_DEF_PARAM = -1140330, // 0xFFEE9996
        /// <summary>"Engagement Length"</summary>
        CONNECTOR_ENGAGEMENT_LENGTH = -1140329, // 0xFFEE9997
        /// <summary>"Flow Conversion Method"</summary>
        RBS_SYSTEM_FLOW_CONVERSION_METHOD_PARAM = -1140328, // 0xFFEE9998
        /// <summary>"Number of Elements"</summary>
        RBS_SYSTEM_NUM_ELEMENTS_PARAM = -1140327, // 0xFFEE9999
        /// <summary>"System Equipment"</summary>
        RBS_SYSTEM_BASE_ELEMENT_PARAM = -1140326, // 0xFFEE999A
        /// <summary>"System Classification"</summary>
        RBS_SYSTEM_CLASSIFICATION_PARAM = -1140325, // 0xFFEE999B
        /// <summary>"System Name"</summary>
        RBS_SYSTEM_NAME_PARAM = -1140324, // 0xFFEE999C
        /// <summary>"Lightweight"</summary>
        PHY_MATERIAL_PARAM_LIGHT_WEIGHT = -1140323, // 0xFFEE999D
        /// <summary>"Behavior"</summary>
        PHY_MATERIAL_PARAM_BEHAVIOR = -1140322, // 0xFFEE999E
        /// <summary>"Resistance calculation strength"</summary>
        PHY_MATERIAL_PARAM_RESISTANCE_CALC_STRENGTH = -1140321, // 0xFFEE999F
        /// <summary>"Reduction factor for shear"</summary>
        PHY_MATERIAL_PARAM_REDUCTION_FACTOR = -1140320, // 0xFFEE99A0
        /// <summary>"Minimum tensile strength"</summary>
        PHY_MATERIAL_PARAM_MINIMUM_TENSILE_STRENGTH = -1140319, // 0xFFEE99A1
        /// <summary>"Minimum yield stress"</summary>
        PHY_MATERIAL_PARAM_MINIMUM_YIELD_STRESS = -1140318, // 0xFFEE99A2
        /// <summary>"Shear strength modification"</summary>
        PHY_MATERIAL_PARAM_SHEAR_STRENGTH_REDUCTION = -1140317, // 0xFFEE99A3
        /// <summary>"Shear reinforcement yield stress"</summary>
        PHY_MATERIAL_PARAM_SHEAR_REINFORCEMENT = -1140316, // 0xFFEE99A4
        /// <summary>"Bending reinforcement"</summary>
        PHY_MATERIAL_PARAM_BENDING_REINFORCEMENT = -1140315, // 0xFFEE99A5
        /// <summary>"Concrete compression"</summary>
        PHY_MATERIAL_PARAM_CONCRETE_COMPRESSION = -1140314, // 0xFFEE99A6
        /// <summary>"Thermal expansion coefficient Z"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF3 = -1140312, // 0xFFEE99A8
        /// <summary>"Thermal expansion coefficient Y"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF2 = -1140311, // 0xFFEE99A9
        /// <summary>"Thermal expansion coefficient X"</summary>
        PHY_MATERIAL_PARAM_EXP_COEFF1 = -1140310, // 0xFFEE99AA
        /// <summary>"Unit weight"</summary>
        PHY_MATERIAL_PARAM_UNIT_WEIGHT = -1140309, // 0xFFEE99AB
        /// <summary>"Shear modulus Z"</summary>
        PHY_MATERIAL_PARAM_SHEAR_MOD3 = -1140308, // 0xFFEE99AC
        /// <summary>"Shear modulus Y"</summary>
        PHY_MATERIAL_PARAM_SHEAR_MOD2 = -1140307, // 0xFFEE99AD
        /// <summary>"Shear modulus X"</summary>
        PHY_MATERIAL_PARAM_SHEAR_MOD1 = -1140306, // 0xFFEE99AE
        /// <summary>"Poisson ratio Z"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD3 = -1140305, // 0xFFEE99AF
        /// <summary>"Poisson ratio Y"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD2 = -1140304, // 0xFFEE99B0
        /// <summary>"Poisson ratio X"</summary>
        PHY_MATERIAL_PARAM_POISSON_MOD1 = -1140303, // 0xFFEE99B1
        /// <summary>"Young modulus Z"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD3 = -1140302, // 0xFFEE99B2
        /// <summary>"Young modulus Y"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD2 = -1140301, // 0xFFEE99B3
        /// <summary>"Young modulus X"</summary>
        PHY_MATERIAL_PARAM_YOUNG_MOD1 = -1140300, // 0xFFEE99B4
        /// <summary>"Maximum Size"</summary>
        RBS_PIPE_SIZE_MAXIMUM = -1140284, // 0xFFEE99C4
        /// <summary>"Minimum Size"</summary>
        RBS_PIPE_SIZE_MINIMUM = -1140283, // 0xFFEE99C5
        /// <summary>"Pressure Drop"</summary>
        RBS_DUCT_PRESSURE_DROP = -1140282, // 0xFFEE99C6
        /// <summary>"Routing Preference"</summary>
        ROUTING_PREFERENCE_PARAM = -1140281, // 0xFFEE99C7
        /// <summary>"Routing Preferences"</summary>
        RBS_DUCT_ROUTING_PREFERENCE_PARAM = -1140280, // 0xFFEE99C8
        /// <summary>"Segment Description"</summary>
        RBS_SEGMENT_DESCRIPTION_PARAM = -1140279, // 0xFFEE99C9
        /// <summary>"Connection Type"</summary>
        RBS_PIPE_JOINTTYPE_PARAM = -1140278, // 0xFFEE99CA
        /// <summary>"Pipe Segment"</summary>
        RBS_PIPE_SEGMENT_PARAM = -1140277, // 0xFFEE99CB
        /// <summary>"Routing Preferences"</summary>
        RBS_ROUTING_PREFERENCE_PARAM = -1140276, // 0xFFEE99CC
        /// <summary>"Vertical Offset value for parallel pipes"</summary>
        RBS_PARALLELPIPES_VERTICAL_OFFSET_VALUE = -1140275, // 0xFFEE99CD
        /// <summary>"Horizontal Offset value for parallel pipes"</summary>
        RBS_PARALLELPIPES_HORIZONTAL_OFFSET_VALUE = -1140274, // 0xFFEE99CE
        /// <summary>"Vertical Number for parallel pipes"</summary>
        RBS_PARALLELPIPES_VERTICAL_NUMBER = -1140273, // 0xFFEE99CF
        /// <summary>"Horizontal Number for parallel pipes"</summary>
        RBS_PARALLELPIPES_HORIZONTAL_NUMBER = -1140272, // 0xFFEE99D0
        /// <summary>"Vertical Offset value for parallel conduits"</summary>
        RBS_PARALLELCONDUITS_VERTICAL_OFFSET_VALUE = -1140271, // 0xFFEE99D1
        /// <summary>"Horizontal Offset value for parallel conduits"</summary>
        RBS_PARALLELCONDUITS_HORIZONTAL_OFFSET_VALUE = -1140270, // 0xFFEE99D2
        /// <summary>"Vertical Number for parallel conduits"</summary>
        RBS_PARALLELCONDUITS_VERTICAL_NUMBER = -1140269, // 0xFFEE99D3
        /// <summary>"Horizontal Number for parallel conduits"</summary>
        RBS_PARALLELCONDUITS_HORIZONTAL_NUMBER = -1140268, // 0xFFEE99D4
        /// <summary>"Orifice Size"</summary>
        RBS_FP_SPRINKLER_ORIFICE_SIZE_PARAM = -1140266, // 0xFFEE99D6
        /// <summary>"Temperature Rating"</summary>
        RBS_FP_SPRINKLER_TEMPERATURE_RATING_PARAM = -1140265, // 0xFFEE99D7
        /// <summary>"K-Factor"</summary>
        RBS_FP_SPRINKLER_K_FACTOR_PARAM = -1140264, // 0xFFEE99D8
        /// <summary>"Pressure Class"</summary>
        RBS_FP_SPRINKLER_PRESSURE_CLASS_PARAM = -1140263, // 0xFFEE99D9
        /// <summary>"Orifice"</summary>
        RBS_FP_SPRINKLER_ORIFICE_PARAM = -1140262, // 0xFFEE99DA
        /// <summary>"Coverage"</summary>
        RBS_FP_SPRINKLER_COVERAGE_PARAM = -1140261, // 0xFFEE99DB
        /// <summary>"Response"</summary>
        RBS_FP_SPRINKLER_RESPONSE_PARAM = -1140260, // 0xFFEE99DC
        /// <summary>"Shape"</summary>
        MEP_PROFILE_TYPE_PARAM = -1140259, // 0xFFEE99DD
        /// <summary>"Show Round"</summary>
        RBS_SHOW_PROFILE_TYPE = -1140258, // 0xFFEE99DE
        /// <summary>"Fixture Units"</summary>
        RBS_PIPE_SYSTEM_FIXTURE_UNIT_PARAM = -1140257, // 0xFFEE99DF
        /// <summary>"Slope"</summary>
        RBS_PIPE_SLOPE = -1140256, // 0xFFEE99E0
        /// <summary>"Slope"</summary>
        RBS_DUCT_SLOPE = -1140255, // 0xFFEE99E1
        /// <summary>"Slope"</summary>
        RBS_CURVE_UTSLOPE = -1140254, // 0xFFEE99E2
        /// <summary>"Volume"</summary>
        RBS_PIPE_VOLUME_PARAM = -1140253, // 0xFFEE99E3
        /// <summary>"WFU"</summary>
        RBS_PIPE_WFU_PARAM = -1140252, // 0xFFEE99E4
        /// <summary>"HWFU"</summary>
        RBS_PIPE_HWFU_PARAM = -1140251, // 0xFFEE99E5
        /// <summary>"CWFU"</summary>
        RBS_PIPE_CWFU_PARAM = -1140250, // 0xFFEE99E6
        /// <summary>"Flow Configuration"</summary>
        RBS_PIPE_FLOW_CONFIGURATION_PARAM = -1140249, // 0xFFEE99E7
        /// <summary>"Flow Direction"</summary>
        RBS_PIPE_FLOW_DIRECTION_PARAM = -1140248, // 0xFFEE99E8
        /// <summary>"Fixture Units"</summary>
        RBS_PIPE_FIXTURE_UNITS_PARAM = -1140246, // 0xFFEE99EA
        /// <summary>"Static Pressure"</summary>
        RBS_PIPE_STATIC_PRESSURE = -1140242, // 0xFFEE99EE
        /// <summary>"Insulation Thickness"</summary>
        RBS_PIPE_INSULATION_THICKNESS = -1140241, // 0xFFEE99EF
        /// <summary>"Bottom Elevation"</summary>
        RBS_DUCT_BOTTOM_ELEVATION = -1140240, // 0xFFEE99F0
        /// <summary>"Top Elevation"</summary>
        RBS_DUCT_TOP_ELEVATION = -1140239, // 0xFFEE99F1
        /// <summary>"Outside Diameter"</summary>
        RBS_PIPE_OUTER_DIAMETER = -1140238, // 0xFFEE99F2
        /// <summary>"Invert Elevation"</summary>
        RBS_PIPE_INVERT_ELEVATION = -1140237, // 0xFFEE99F3
        /// <summary>"Loss Method"</summary>
        RBS_PIPE_TYPE_FITTING_LOSS_METHOD_PARAM = -1140234, // 0xFFEE99F6
        /// <summary>"K Coefficient Table"</summary>
        RBS_PIPE_TYPE_FITTING_LOSS_TABLE_PARAM = -1140233, // 0xFFEE99F7
        /// <summary>"K Coefficient"</summary>
        RBS_PIPE_TYPE_FITTING_LOSS_KFACTOR_PARAM = -1140232, // 0xFFEE99F8
        /// <summary>"Cv Coefficient"</summary>
        RBS_PIPE_TYPE_VALVE_LOSS_CVFACTOR_PARAM = -1140231, // 0xFFEE99F9
        /// <summary>"Loss Method"</summary>
        RBS_PIPE_FITTING_LOSS_METHOD_PARAM = -1140230, // 0xFFEE99FA
        /// <summary>"K Coefficient Table"</summary>
        RBS_PIPE_FITTING_LOSS_TABLE_PARAM = -1140229, // 0xFFEE99FB
        /// <summary>"K Coefficient"</summary>
        RBS_PIPE_FITTING_LOSS_KFACTOR_PARAM = -1140228, // 0xFFEE99FC
        /// <summary>"Cv Coefficient"</summary>
        RBS_PIPE_VALVE_LOSS_CVFACTOR_PARAM = -1140227, // 0xFFEE99FD
        /// <summary>"Additional Flow"</summary>
        RBS_PIPE_ADDITIONAL_FLOW_PARAM = -1140226, // 0xFFEE99FE
        /// <summary>"Diameter"</summary>
        RBS_PIPE_DIAMETER_PARAM = -1140225, // 0xFFEE99FF
        /// <summary>"Slope Percentage (%)"</summary>
        RBS_CURVE_SLOPE = -1140224, // 0xFFEE9A00
        /// <summary>"Allow Slope Adjustments"</summary>
        RBS_ADJUSTABLE_CONNECTOR = -1140223, // 0xFFEE9A01
        /// <summary>"Flow Factor"</summary>
        RBS_FLOW_FACTOR_PARAM = -1140222, // 0xFFEE9A02
        /// <summary>"Flow Configuration"</summary>
        RBS_DUCT_FLOW_CONFIGURATION_PARAM = -1140221, // 0xFFEE9A03
        /// <summary>"Flow Direction"</summary>
        RBS_DUCT_FLOW_DIRECTION_PARAM = -1140219, // 0xFFEE9A05
        /// <summary>"Fluid Type"</summary>
        RBS_PIPE_FLUID_TYPE_PARAM = -1140218, // 0xFFEE9A06
        /// <summary>"Fluid Temperature"</summary>
        RBS_PIPE_FLUID_TEMPERATURE_PARAM = -1140217, // 0xFFEE9A07
        /// <summary>"Fluid Dynamic Viscosity"</summary>
        RBS_PIPE_FLUID_VISCOSITY_PARAM = -1140215, // 0xFFEE9A09
        /// <summary>"Fluid Density"</summary>
        RBS_PIPE_FLUID_DENSITY_PARAM = -1140214, // 0xFFEE9A0A
        /// <summary>"Flow"</summary>
        RBS_PIPE_FLOW_PARAM = -1140213, // 0xFFEE9A0B
        /// <summary>"Inside Diameter"</summary>
        RBS_PIPE_INNER_DIAM_PARAM = -1140212, // 0xFFEE9A0C
        /// <summary>"Reynolds Number"</summary>
        RBS_PIPE_REYNOLDS_NUMBER_PARAM = -1140211, // 0xFFEE9A0D
        /// <summary>"Relative Roughness"</summary>
        RBS_PIPE_RELATIVE_ROUGHNESS_PARAM = -1140210, // 0xFFEE9A0E
        /// <summary>"Flow State"</summary>
        RBS_PIPE_FLOW_STATE_PARAM = -1140209, // 0xFFEE9A0F
        /// <summary>"Friction Factor"</summary>
        RBS_PIPE_FRICTION_FACTOR_PARAM = -1140208, // 0xFFEE9A10
        /// <summary>"Velocity"</summary>
        RBS_PIPE_VELOCITY_PARAM = -1140207, // 0xFFEE9A11
        /// <summary>"Friction"</summary>
        RBS_PIPE_FRICTION_PARAM = -1140206, // 0xFFEE9A12
        /// <summary>"Pressure Drop"</summary>
        RBS_PIPE_PRESSUREDROP_PARAM = -1140205, // 0xFFEE9A13
        /// <summary>"Roughness"</summary>
        RBS_PIPE_ROUGHNESS_PARAM = -1140204, // 0xFFEE9A14
        /// <summary>"Material"</summary>
        RBS_PIPE_MATERIAL_PARAM = -1140202, // 0xFFEE9A16
        /// <summary>"Connection Type"</summary>
        RBS_PIPE_CONNECTIONTYPE_PARAM = -1140201, // 0xFFEE9A17
        /// <summary>"Schedule/Type"</summary>
        RBS_PIPE_CLASS_PARAM = -1140200, // 0xFFEE9A18
        /// <summary>"Slot Index"</summary>
        RBS_ELEC_CIRCUIT_SLOT_INDEX = -1140181, // 0xFFEE9A2B
        /// <summary>"Ways"</summary>
        CIRCUIT_WAYS_PARAM = -1140180, // 0xFFEE9A2C
        /// <summary>"Load Classification Abbreviation"</summary>
        CIRCUIT_LOAD_CLASSIFICATION_ABBREVIATION_PARAM = -1140179, // 0xFFEE9A2D
        /// <summary>"Phase Label"</summary>
        CIRCUIT_PHASE_PARAM = -1140178, // 0xFFEE9A2E
        /// <summary>"Circuit Naming Index"</summary>
        RBS_ELEC_CIRCUIT_NAMING_INDEX = -1140177, // 0xFFEE9A2F
        /// <summary>"Connection Type"</summary>
        RBS_ELEC_CIRCUIT_CONNECTION_TYPE_PARAM = -1140176, // 0xFFEE9A30
        /// <summary>"Offset"</summary>
        RBS_ELEC_CIRCUIT_PATH_OFFSET_PARAM = -1140175, // 0xFFEE9A31
        /// <summary>"Path Mode"</summary>
        RBS_ELEC_CIRCUIT_PATH_MODE_PARAM = -1140174, // 0xFFEE9A32
        /// <summary>"Start Slot"</summary>
        RBS_ELEC_CIRCUIT_START_SLOT = -1140173, // 0xFFEE9A33
        /// <summary>"Connector Gender Type"</summary>
        CONNECTOR_GENDER_TYPE = -1140172, // 0xFFEE9A34
        /// <summary>"Connector Joint Type"</summary>
        CONNECTOR_JOINT_TYPE = -1140171, // 0xFFEE9A35
        /// <summary>"Panel Configuration"</summary>
        RBS_ELEC_PANEL_CONFIGURATION_PARAM = -1140170, // 0xFFEE9A36
        /// <summary>"Location"</summary>
        RBS_ELEC_PANEL_LOCATION_PARAM = -1140169, // 0xFFEE9A37
        /// <summary>"Panel Schedule Name"</summary>
        PANEL_SCHEDULE_NAME = -1140168, // 0xFFEE9A38
        /// <summary>"Template"</summary>
        TEMPLATE_NAME = -1140167, // 0xFFEE9A39
        /// <summary>"Current Phase C"</summary>
        RBS_ELEC_PANEL_CURRENT_PHASEC_PARAM = -1140166, // 0xFFEE9A3A
        /// <summary>"Current Phase B"</summary>
        RBS_ELEC_PANEL_CURRENT_PHASEB_PARAM = -1140165, // 0xFFEE9A3B
        /// <summary>"Current Phase A"</summary>
        RBS_ELEC_PANEL_CURRENT_PHASEA_PARAM = -1140164, // 0xFFEE9A3C
        /// <summary>"Description"</summary>
        RBS_ELEC_LOADSUMMARY_DEMAND_FACTOR_RULE_PARAM = -1140163, // 0xFFEE9A3D
        /// <summary>"Estimated Demand Current"</summary>
        RBS_ELEC_LOADSUMMARY_DEMAND_CURRENT_PARAM = -1140162, // 0xFFEE9A3E
        /// <summary>"Connected Current"</summary>
        RBS_ELEC_LOADSUMMARY_CONNECTED_CURRENT_PARAM = -1140161, // 0xFFEE9A3F
        /// <summary>"Estimated Demand (VA)"</summary>
        RBS_ELEC_LOADSUMMARY_DEMAND_LOAD_PARAM = -1140160, // 0xFFEE9A40
        /// <summary>"Demand Factor"</summary>
        RBS_ELEC_LOADSUMMARY_DEMAND_FACTOR_PARAM = -1140159, // 0xFFEE9A41
        /// <summary>"Connected Load (VA)"</summary>
        RBS_ELEC_LOADSUMMARY_CONNECTED_LOAD_PARAM = -1140158, // 0xFFEE9A42
        /// <summary>"Load Classification"</summary>
        RBS_ELEC_LOADSUMMARY_LOADCLASSIFICATION_PARAM = -1140157, // 0xFFEE9A43
        /// <summary>"Schedule Circuit Notes"</summary>
        RBS_ELEC_CIRCUIT_NOTES_PARAM = -1140156, // 0xFFEE9A44
        /// <summary>"Number of Elements"</summary>
        RBS_ELEC_CIRCUIT_NUMBER_OF_ELEMENTS_PARAM = -1140155, // 0xFFEE9A45
        /// <summary>"Frame"</summary>
        RBS_ELEC_CIRCUIT_FRAME_PARAM = -1140154, // 0xFFEE9A46
        /// <summary>"Total Estimated Demand Current"</summary>
        RBS_ELEC_PANEL_TOTAL_DEMAND_CURRENT_PARAM = -1140153, // 0xFFEE9A47
        /// <summary>"Total Connected Current"</summary>
        RBS_ELEC_PANEL_TOTAL_CONNECTED_CURRENT_PARAM = -1140152, // 0xFFEE9A48
        /// <summary>"Total Demand Factor"</summary>
        RBS_ELEC_PANEL_TOTAL_DEMAND_FACTOR_PARAM = -1140151, // 0xFFEE9A49
        /// <summary>"Schedule Footer Notes"</summary>
        RBS_ELEC_PANEL_SCHEDULE_FOOTER_NOTES_PARAM = -1140150, // 0xFFEE9A4A
        /// <summary>"Schedule Header Notes"</summary>
        RBS_ELEC_PANEL_SCHEDULE_HEADER_NOTES_PARAM = -1140149, // 0xFFEE9A4B
        /// <summary>"Number of Wires"</summary>
        RBS_ELEC_PANEL_NUMWIRES_PARAM = -1140148, // 0xFFEE9A4C
        /// <summary>"Number of Phases"</summary>
        RBS_ELEC_PANEL_NUMPHASES_PARAM = -1140147, // 0xFFEE9A4D
        /// <summary>"Neutral Rating"</summary>
        RBS_ELEC_PANEL_NEUTRAL_RATING_PARAM = -1140146, // 0xFFEE9A4E
        /// <summary>"Neutral Bus"</summary>
        RBS_ELEC_PANEL_NEUTRAL_BUS_PARAM = -1140145, // 0xFFEE9A4F
        /// <summary>"Ground Bus"</summary>
        RBS_ELEC_PANEL_GROUND_BUS_PARAM = -1140144, // 0xFFEE9A50
        /// <summary>"Bussing"</summary>
        RBS_ELEC_PANEL_BUSSING_PARAM = -1140143, // 0xFFEE9A51
        /// <summary>"SubFeed Lugs"</summary>
        RBS_ELEC_PANEL_SUBFEED_LUGS_PARAM = -1140142, // 0xFFEE9A52
        /// <summary>"Supply From"</summary>
        RBS_ELEC_PANEL_SUPPLY_FROM_PARAM = -1140141, // 0xFFEE9A53
        /// <summary>"MCB Rating"</summary>
        RBS_ELEC_PANEL_MCB_RATING_PARAM = -1140140, // 0xFFEE9A54
        /// <summary>"Mains Type"</summary>
        RBS_ELEC_PANEL_MAINSTYPE_PARAM = -1140139, // 0xFFEE9A55
        /// <summary>"Feed"</summary>
        RBS_ELEC_PANEL_FEED_PARAM = -1140138, // 0xFFEE9A56
        /// <summary>"Outside Diameter"</summary>
        RBS_CONDUITRUN_OUTER_DIAM_PARAM = -1140137, // 0xFFEE9A57
        /// <summary>"Inside Diameter"</summary>
        RBS_CONDUITRUN_INNER_DIAM_PARAM = -1140136, // 0xFFEE9A58
        /// <summary>"Diameter(Trade Size)"</summary>
        RBS_CONDUITRUN_DIAMETER_PARAM = -1140135, // 0xFFEE9A59
        /// <summary>"Width"</summary>
        RBS_CABLETRAYRUN_WIDTH_PARAM = -1140134, // 0xFFEE9A5A
        /// <summary>"Height"</summary>
        RBS_CABLETRAYRUN_HEIGHT_PARAM = -1140133, // 0xFFEE9A5B
        /// <summary>"Length"</summary>
        RBS_CABLETRAYCONDUITRUN_LENGTH_PARAM = -1140132, // 0xFFEE9A5C
        /// <summary>"Load Sub-Classification Motor"</summary>
        RBS_LOAD_SUB_CLASSIFICATION_MOTOR = -1140131, // 0xFFEE9A5D
        /// <summary>"Shape"</summary>
        RBS_CABLETRAY_SHAPETYPE = -1140130, // 0xFFEE9A5E
        /// <summary>"Bend or Fitting"</summary>
        RBS_CABLETRAYCONDUIT_BENDORFITTING = -1140129, // 0xFFEE9A5F
        /// <summary>"Service Type"</summary>
        RBS_CTC_SERVICE_TYPE = -1140128, // 0xFFEE9A60
        /// <summary>"Outside Diameter"</summary>
        RBS_CONDUIT_OUTER_DIAM_PARAM = -1140127, // 0xFFEE9A61
        /// <summary>"Inside Diameter"</summary>
        RBS_CONDUIT_INNER_DIAM_PARAM = -1140126, // 0xFFEE9A62
        /// <summary>"Bottom Elevation"</summary>
        RBS_CTC_BOTTOM_ELEVATION = -1140125, // 0xFFEE9A63
        /// <summary>"Top Elevation"</summary>
        RBS_CTC_TOP_ELEVATION = -1140124, // 0xFFEE9A64
        /// <summary>"Diameter(Trade Size)"</summary>
        RBS_CONDUIT_DIAMETER_PARAM = -1140123, // 0xFFEE9A65
        /// <summary>"Width"</summary>
        RBS_CABLETRAY_WIDTH_PARAM = -1140122, // 0xFFEE9A66
        /// <summary>"Height"</summary>
        RBS_CABLETRAY_HEIGHT_PARAM = -1140121, // 0xFFEE9A67
        /// <summary>"Load Classification"</summary>
        CIRCUIT_LOAD_CLASSIFICATION_PARAM = -1140120, // 0xFFEE9A68
        /// <summary>"Bend Radius Multiplier"</summary>
        CABLETRAY_MINBENDMULTIPLIER_PARAM = -1140119, // 0xFFEE9A69
        /// <summary>"Standard"</summary>
        CONDUIT_STANDARD_TYPE_PARAM = -1140118, // 0xFFEE9A6A
        /// <summary>"Conduit Size Lookup"</summary>
        RBS_CONDUIT_TRADESIZE = -1140117, // 0xFFEE9A6B
        /// <summary>"Bend Radius"</summary>
        RBS_CONDUIT_BENDRADIUS = -1140116, // 0xFFEE9A6C
        /// <summary>"Bend Radius"</summary>
        RBS_CABLETRAY_BENDRADIUS = -1140115, // 0xFFEE9A6D
        /// <summary>"Rung Height"</summary>
        RBS_CABLETRAY_RUNGHEIGHT = -1140114, // 0xFFEE9A6E
        /// <summary>"Rung Width"</summary>
        RBS_CABLETRAY_RUNGWIDTH = -1140113, // 0xFFEE9A6F
        /// <summary>"Rung Space"</summary>
        RBS_CABLETRAY_RUNGSPACE = -1140112, // 0xFFEE9A70
        /// <summary>"Thickness"</summary>
        RBS_CABLETRAY_THICKNESS = -1140111, // 0xFFEE9A71
        /// <summary>"Switch ID"</summary>
        RBS_ELEC_SWITCH_ID_PARAM = -1140110, // 0xFFEE9A72
        /// <summary>"Circuit Description"</summary>
        RBS_WIRE_CIRCUIT_DESCRIPTION = -1140109, // 0xFFEE9A73
        /// <summary>"Circuit Load Name"</summary>
        RBS_WIRE_CIRCUIT_LOAD_NAME = -1140108, // 0xFFEE9A74
        /// <summary>"Number of Conductors"</summary>
        RBS_WIRE_NUM_CONDUCTORS_PARAM = -1140107, // 0xFFEE9A75
        /// <summary>"Tick Marks"</summary>
        RBS_ELEC_WIRE_TICKMARK_STATE = -1140106, // 0xFFEE9A76
        /// <summary>"Panel"</summary>
        RBS_ELEC_CIRCUIT_PANEL_PARAM = -1140104, // 0xFFEE9A78
        /// <summary>"Circuit Number"</summary>
        RBS_ELEC_CIRCUIT_NUMBER = -1140103, // 0xFFEE9A79
        /// <summary>"Circuits"</summary>
        RBS_ELEC_WIRE_CIRCUITS = -1140102, // 0xFFEE9A7A
        /// <summary>"# of Runs"</summary>
        RBS_ELEC_CIRCUIT_WIRE_NUM_RUNS_PARAM = -1140101, // 0xFFEE9A7B
        /// <summary>"# of Hot Conductors"</summary>
        RBS_ELEC_CIRCUIT_WIRE_NUM_HOTS_PARAM = -1140100, // 0xFFEE9A7C
        /// <summary>"# of Neutral Conductors"</summary>
        RBS_ELEC_CIRCUIT_WIRE_NUM_NEUTRALS_PARAM = -1140099, // 0xFFEE9A7D
        /// <summary>"# of Ground Conductors"</summary>
        RBS_ELEC_CIRCUIT_WIRE_NUM_GROUNDS_PARAM = -1140098, // 0xFFEE9A7E
        /// <summary>"Type"</summary>
        RBS_ELEC_WIRE_TYPE = -1140097, // 0xFFEE9A7F
        /// <summary>"Elevation"</summary>
        RBS_ELEC_WIRE_ELEVATION = -1140096, // 0xFFEE9A80
        /// <summary>"Hot Conductors"</summary>
        RBS_ELEC_WIRE_HOT_ADJUSTMENT = -1140094, // 0xFFEE9A82
        /// <summary>"Neutral Conductors"</summary>
        RBS_ELEC_WIRE_NEUTRAL_ADJUSTMENT = -1140093, // 0xFFEE9A83
        /// <summary>"Ground Conductors"</summary>
        RBS_ELEC_WIRE_GROUND_ADJUSTMENT = -1140092, // 0xFFEE9A84
        /// <summary>"Share Neutral Conductor"</summary>
        RBS_ELEC_WIRE_SHARE_NEUTRAL = -1140091, // 0xFFEE9A85
        /// <summary>"Share Ground Conductor"</summary>
        RBS_ELEC_WIRE_SHARE_GROUND = -1140090, // 0xFFEE9A86
        /// <summary>"Load Name"</summary>
        RBS_ELEC_CIRCUIT_NAME = -1140089, // 0xFFEE9A87
        /// <summary>"Secondary Distribution System"</summary>
        RBS_FAMILY_CONTENT_SECONDARY_DISTRIBSYS = -1140088, // 0xFFEE9A88
        /// <summary>"Circuit Naming"</summary>
        RBS_ELEC_CIRCUIT_NAMING = -1140087, // 0xFFEE9A89
        /// <summary>"Circuit Prefix Separator"</summary>
        RBS_ELEC_CIRCUIT_PREFIX_SEPARATOR = -1140086, // 0xFFEE9A8A
        /// <summary>"Circuit Prefix"</summary>
        RBS_ELEC_CIRCUIT_PREFIX = -1140085, // 0xFFEE9A8B
        /// <summary>"Modifications"</summary>
        RBS_ELEC_MODIFICATIONS = -1140084, // 0xFFEE9A8C
        /// <summary>"Enclosure"</summary>
        RBS_ELEC_ENCLOSURE = -1140083, // 0xFFEE9A8D
        /// <summary>"Mains"</summary>
        RBS_ELEC_MAINS = -1140082, // 0xFFEE9A8E
        /// <summary>"Mounting"</summary>
        RBS_ELEC_MOUNTING = -1140081, // 0xFFEE9A8F
        /// <summary>"Short Circuit Rating"</summary>
        RBS_ELEC_SHORT_CIRCUIT_RATING = -1140080, // 0xFFEE9A90
        /// <summary>"Max Number of Single Pole Breakers"</summary>
        RBS_ELEC_MAX_POLE_BREAKERS = -1140079, // 0xFFEE9A91
        /// <summary>"Panel Name"</summary>
        RBS_ELEC_PANEL_NAME = -1140078, // 0xFFEE9A92
        /// <summary>"HVAC Total Estimated Demand"</summary>
        RBS_ELEC_PANEL_TOTALESTLOAD_HVAC_PARAM = -1140077, // 0xFFEE9A93
        /// <summary>"HVAC Total Connected"</summary>
        RBS_ELEC_PANEL_TOTALLOAD_HVAC_PARAM = -1140076, // 0xFFEE9A94
        /// <summary>"Lighting Total Estimated Demand"</summary>
        RBS_ELEC_PANEL_TOTALESTLOAD_LIGHT_PARAM = -1140075, // 0xFFEE9A95
        /// <summary>"Lighting Total Connected"</summary>
        RBS_ELEC_PANEL_TOTALLOAD_LIGHT_PARAM = -1140074, // 0xFFEE9A96
        /// <summary>"Power Total Estimated Demand"</summary>
        RBS_ELEC_PANEL_TOTALESTLOAD_POWER_PARAM = -1140073, // 0xFFEE9A97
        /// <summary>"Power Total Connected"</summary>
        RBS_ELEC_PANEL_TOTALLOAD_POWER_PARAM = -1140072, // 0xFFEE9A98
        /// <summary>"Other Total Estimated Demand"</summary>
        RBS_ELEC_PANEL_TOTALESTLOAD_OTHER_PARAM = -1140071, // 0xFFEE9A99
        /// <summary>"Other Total Connected"</summary>
        RBS_ELEC_PANEL_TOTALLOAD_OTHER_PARAM = -1140070, // 0xFFEE9A9A
        /// <summary>"Total Estimated Demand"</summary>
        RBS_ELEC_PANEL_TOTALESTLOAD_PARAM = -1140069, // 0xFFEE9A9B
        /// <summary>"Total Connected"</summary>
        RBS_ELEC_PANEL_TOTALLOAD_PARAM = -1140068, // 0xFFEE9A9C
        /// <summary>"Load Classification"</summary>
        RBS_ELEC_DEMANDFACTOR_LOADCLASSIFICATION_PARAM = -1140067, // 0xFFEE9A9D
        /// <summary>"Connected Load"</summary>
        RBS_ELEC_DEMANDFACTOR_LOAD_PARAM = -1140066, // 0xFFEE9A9E
        /// <summary>"Estimated Demand Load"</summary>
        RBS_ELEC_DEMANDFACTOR_DEMANDLOAD_PARAM = -1140065, // 0xFFEE9A9F
        /// <summary>"Distribution System"</summary>
        RBS_FAMILY_CONTENT_DISTRIBUTION_SYSTEM = -1140064, // 0xFFEE9AA0
        /// <summary>"Line to Line Voltage"</summary>
        RBS_DISTRIBUTIONSYS_VLL_PARAM = -1140063, // 0xFFEE9AA1
        /// <summary>"Line to Ground Voltage"</summary>
        RBS_DISTRIBUTIONSYS_VLG_PARAM = -1140062, // 0xFFEE9AA2
        /// <summary>"Phase"</summary>
        RBS_DISTRIBUTIONSYS_PHASE_PARAM = -1140061, // 0xFFEE9AA3
        /// <summary>"Configuration"</summary>
        RBS_DISTRIBUTIONSYS_CONFIG_PARAM = -1140060, // 0xFFEE9AA4
        /// <summary>"Wires"</summary>
        RBS_DISTRIBUTIONSYS_NUMWIRES_PARAM = -1140059, // 0xFFEE9AA5
        /// <summary>"Actual Voltage"</summary>
        RBS_VOLTAGETYPE_VOLTAGE_PARAM = -1140058, // 0xFFEE9AA6
        /// <summary>"Minimum Voltage"</summary>
        RBS_VOLTAGETYPE_MINVOLTAGE_PARAM = -1140057, // 0xFFEE9AA7
        /// <summary>"Maximum Voltage"</summary>
        RBS_VOLTAGETYPE_MAXVOLTAGE_PARAM = -1140056, // 0xFFEE9AA8
        /// <summary>"Apparent Load Phase C"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASEC = -1140055, // 0xFFEE9AA9
        /// <summary>"Apparent Load Phase B"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASEB = -1140054, // 0xFFEE9AAA
        /// <summary>"Apparent Load Phase A"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASEA = -1140053, // 0xFFEE9AAB
        /// <summary>"True Load Phase C"</summary>
        RBS_ELEC_TRUE_LOAD_PHASEC = -1140052, // 0xFFEE9AAC
        /// <summary>"True Load Phase B"</summary>
        RBS_ELEC_TRUE_LOAD_PHASEB = -1140051, // 0xFFEE9AAD
        /// <summary>"True Load Phase A"</summary>
        RBS_ELEC_TRUE_LOAD_PHASEA = -1140050, // 0xFFEE9AAE
        /// <summary>"True Current"</summary>
        RBS_ELEC_TRUE_CURRENT_PARAM = -1140049, // 0xFFEE9AAF
        /// <summary>"True Current Phase A"</summary>
        RBS_ELEC_TRUE_CURRENT_PHASEA_PARAM = -1140048, // 0xFFEE9AB0
        /// <summary>"True Current Phase B"</summary>
        RBS_ELEC_TRUE_CURRENT_PHASEB_PARAM = -1140047, // 0xFFEE9AB1
        /// <summary>"True Current Phase C"</summary>
        RBS_ELEC_TRUE_CURRENT_PHASEC_PARAM = -1140046, // 0xFFEE9AB2
        /// <summary>"Apparent Current"</summary>
        RBS_ELEC_APPARENT_CURRENT_PARAM = -1140045, // 0xFFEE9AB3
        /// <summary>"Apparent Current Phase A"</summary>
        RBS_ELEC_APPARENT_CURRENT_PHASEA_PARAM = -1140044, // 0xFFEE9AB4
        /// <summary>"Apparent Current Phase B"</summary>
        RBS_ELEC_APPARENT_CURRENT_PHASEB_PARAM = -1140043, // 0xFFEE9AB5
        /// <summary>"Apparent Current Phase C"</summary>
        RBS_ELEC_APPARENT_CURRENT_PHASEC_PARAM = -1140042, // 0xFFEE9AB6
        /// <summary>"Voltage Drop"</summary>
        RBS_ELEC_VOLTAGE_DROP_PARAM = -1140041, // 0xFFEE9AB7
        /// <summary>"Calculate Coefficient of Utilization"</summary>
        RBS_ELEC_CALC_COEFFICIENT_UTILIZATION = -1140040, // 0xFFEE9AB8
        /// <summary>"Length"</summary>
        RBS_ELEC_CIRCUIT_LENGTH_PARAM = -1140039, // 0xFFEE9AB9
        /// <summary>"Rating"</summary>
        RBS_ELEC_CIRCUIT_RATING_PARAM = -1140038, // 0xFFEE9ABA
        /// <summary>"Wire Size"</summary>
        RBS_ELEC_CIRCUIT_WIRE_SIZE_PARAM = -1140037, // 0xFFEE9ABB
        /// <summary>"Wire Type"</summary>
        RBS_ELEC_CIRCUIT_WIRE_TYPE_PARAM = -1140036, // 0xFFEE9ABC
        /// <summary>"Room Cavity Ratio"</summary>
        RBS_ELEC_ROOM_CAVITY_RATIO = -1140035, // 0xFFEE9ABD
        /// <summary>"Photometric Web File"</summary>
        FBX_LIGHT_PHOTOMETRIC_FILE = -1140034, // 0xFFEE9ABE
        /// <summary>"Average Estimated Illumination"</summary>
        RBS_ELEC_ROOM_AVERAGE_ILLUMINATION = -1140033, // 0xFFEE9ABF
        /// <summary>"Floor Reflectance"</summary>
        RBS_ELEC_ROOM_REFLECTIVITY_FLOOR = -1140032, // 0xFFEE9AC0
        /// <summary>"Wall Reflectance"</summary>
        RBS_ELEC_ROOM_REFLECTIVITY_WALLS = -1140031, // 0xFFEE9AC1
        /// <summary>"Ceiling Reflectance"</summary>
        RBS_ELEC_ROOM_REFLECTIVITY_CEILING = -1140030, // 0xFFEE9AC2
        /// <summary>"Lighting Calculation Workplane"</summary>
        RBS_ELEC_ROOM_LIGHTING_CALC_WORKPLANE = -1140029, // 0xFFEE9AC3
        /// <summary>"Material"</summary>
        RBS_WIRE_MATERIAL_PARAM = -1140028, // 0xFFEE9AC4
        /// <summary>"Temperature Rating"</summary>
        RBS_WIRE_TEMPERATURE_RATING_PARAM = -1140027, // 0xFFEE9AC5
        /// <summary>"Insulation"</summary>
        RBS_WIRE_INSULATION_PARAM = -1140026, // 0xFFEE9AC6
        /// <summary>"Max Size"</summary>
        RBS_WIRE_MAX_CONDUCTOR_SIZE_PARAM = -1140025, // 0xFFEE9AC7
        /// <summary>"Neutral Multiplier"</summary>
        RBS_WIRE_NEUTRAL_MULTIPLIER_PARAM = -1140024, // 0xFFEE9AC8
        /// <summary>"Neutral Included in Balanced Load"</summary>
        RBS_WIRE_NEUTRAL_INCLUDED_IN_BALANCED_LOAD_PARAM = -1140023, // 0xFFEE9AC9
        /// <summary>"Neutral Size"</summary>
        RBS_WIRE_NEUTRAL_MODE_PARAM = -1140022, // 0xFFEE9ACA
        /// <summary>"Conduit Type"</summary>
        RBS_WIRE_CONDUIT_TYPE_PARAM = -1140021, // 0xFFEE9ACB
        /// <summary>"Ambient Temperature"</summary>
        RBS_ELEC_AMBIENT_TEMPERATURE = -1140020, // 0xFFEE9ACC
        /// <summary>"System Type"</summary>
        RBS_ELEC_CIRCUIT_TYPE = -1140018, // 0xFFEE9ACE
        /// <summary>"Load Classification"</summary>
        RBS_ELEC_LOAD_CLASSIFICATION = -1140014, // 0xFFEE9AD2
        /// <summary>"True Load Phase 3"</summary>
        RBS_ELEC_TRUE_LOAD_PHASE3 = -1140013, // 0xFFEE9AD3
        /// <summary>"True Load Phase 2"</summary>
        RBS_ELEC_TRUE_LOAD_PHASE2 = -1140012, // 0xFFEE9AD4
        /// <summary>"True Load Phase 1"</summary>
        RBS_ELEC_TRUE_LOAD_PHASE1 = -1140011, // 0xFFEE9AD5
        /// <summary>"True Load"</summary>
        RBS_ELEC_TRUE_LOAD = -1140010, // 0xFFEE9AD6
        /// <summary>"Power Factor State"</summary>
        RBS_ELEC_POWER_FACTOR_STATE = -1140009, // 0xFFEE9AD7
        /// <summary>"Power Factor"</summary>
        RBS_ELEC_POWER_FACTOR = -1140008, // 0xFFEE9AD8
        /// <summary>"Apparent Load Phase 3"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASE3 = -1140007, // 0xFFEE9AD9
        /// <summary>"Apparent Load Phase 2"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASE2 = -1140006, // 0xFFEE9ADA
        /// <summary>"Apparent Load Phase 1"</summary>
        RBS_ELEC_APPARENT_LOAD_PHASE1 = -1140005, // 0xFFEE9ADB
        /// <summary>"Apparent Load"</summary>
        RBS_ELEC_APPARENT_LOAD = -1140004, // 0xFFEE9ADC
        /// <summary>"Balanced Load"</summary>
        RBS_ELEC_BALANCED_LOAD = -1140003, // 0xFFEE9ADD
        /// <summary>"Voltage"</summary>
        RBS_ELEC_VOLTAGE = -1140002, // 0xFFEE9ADE
        /// <summary>"Number of Poles"</summary>
        RBS_ELEC_NUMBER_OF_POLES = -1140001, // 0xFFEE9ADF
        /// <summary>"Connector Description"</summary>
        RBS_CONNECTOR_DESCRIPTION = -1140000, // 0xFFEE9AE0
        /// <summary>"Family"</summary>
        VIEW_FAMILY_SCHEDULES = -1139999, // 0xFFEE9AE1
        /// <summary>"Family and Type"</summary>
        VIEW_FAMILY_AND_TYPE_SCHEDULES = -1139998, // 0xFFEE9AE2
        /// <summary>"Type"</summary>
        VIEW_TYPE_SCHEDULES = -1139997, // 0xFFEE9AE3
        /// <summary>"Private"</summary>
        MARKUPS_PRIVATE = -1133908, // 0xFFEEB2AC
        /// <summary>"Notes"</summary>
        MARKUPS_NOTES = -1133907, // 0xFFEEB2AD
        /// <summary>"History"</summary>
        MARKUPS_HISTORY = -1133906, // 0xFFEEB2AE
        /// <summary>"Status"</summary>
        MARKUPS_STATUS = -1133905, // 0xFFEEB2AF
        /// <summary>"Label"</summary>
        MARKUPS_LABEL = -1133904, // 0xFFEEB2B0
        /// <summary>"Creator"</summary>
        MARKUPS_CREATOR = -1133903, // 0xFFEEB2B1
        /// <summary>"Created"</summary>
        MARKUPS_CREATED = -1133902, // 0xFFEEB2B2
        /// <summary>"Modified"</summary>
        MARKUPS_MODIFIED = -1133901, // 0xFFEEB2B3
        /// <summary>"System Color Schemes"</summary>
        VIEW_SCHEMA_SETTING_FOR_SYSTEM_TEMPLATE = -1133900, // 0xFFEEB2B4
        /// <summary>"Detail Level"</summary>
        LEGEND_COMPONENT_DETAIL_LEVEL = -1133753, // 0xFFEEB347
        /// <summary>"Host Length"</summary>
        LEGEND_COMPONENT_LENGTH = -1133752, // 0xFFEEB348
        /// <summary>"View Direction"</summary>
        LEGEND_COMPONENT_VIEW = -1133751, // 0xFFEEB349
        /// <summary>"Component Type"</summary>
        LEGEND_COMPONENT = -1133750, // 0xFFEEB34A
        /// <summary>"Design Option Set Id"</summary>
        OPTION_SET_ID = -1133603, // 0xFFEEB3DD
        /// <summary>"Name"</summary>
        OPTION_NAME = -1133602, // 0xFFEEB3DE
        /// <summary>"Primary Option Id"</summary>
        PRIMARY_OPTION_ID = -1133601, // 0xFFEEB3DF
        /// <summary>"Name"</summary>
        OPTION_SET_NAME = -1133600, // 0xFFEEB3E0
        /// <summary>"Attached to"</summary>
        GROUP_ATTACHED_PARENT_NAME = -1133503, // 0xFFEEB441
        /// <summary>"Allowed View Types"</summary>
        GROUP_ALLOWED_VIEW_TYPES = -1133502, // 0xFFEEB442
        /// <summary>"Origin Level Offset"</summary>
        GROUP_OFFSET_FROM_LEVEL = -1133501, // 0xFFEEB443
        /// <summary>"Reference Level"</summary>
        GROUP_LEVEL = -1133500, // 0xFFEEB444
        /// <summary>"Fill Pattern Graphics Overrides"</summary>
        MEP_SYSTEM_FILL_GRAPHICS_OVERRIDES_PARAM = -1133418, // 0xFFEEB496
        /// <summary>"Engagement Length"</summary>
        DUCT_TERMINAL_ENGAGEMENT_LENGTH = -1133417, // 0xFFEEB497
        /// <summary>"Inside Diameter"</summary>
        CONNECTOR_INSIDE_DIAMETER = -1133416, // 0xFFEEB498
        /// <summary>"Diameter"</summary>
        CONNECTOR_DIAMETER = -1133415, // 0xFFEEB499
        /// <summary>"Connector Type"</summary>
        RBS_CABLETRAYCONDUIT_CONNECTORELEM_TYPE = -1133414, // 0xFFEEB49A
        /// <summary>"System Type"</summary>
        RBS_CABLETRAYCONDUIT_SYSTEM_TYPE = -1133413, // 0xFFEEB49B
        /// <summary>"Primary Connector"</summary>
        RBS_CONNECTOR_ISPRIMARY = -1133412, // 0xFFEEB49C
        /// <summary>"Link Connector Index"</summary>
        CONNECTOR_REFERENCE_INDEX = -1133411, // 0xFFEEB49D
        /// <summary>"System Classification"</summary>
        RBS_PIPE_CONNECTOR_SYSTEM_CLASSIFICATION_PARAM = -1133410, // 0xFFEEB49E
        /// <summary>"Angle"</summary>
        CONNECTOR_ANGLE = -1133409, // 0xFFEEB49F
        /// <summary>"System Classification"</summary>
        RBS_DUCT_CONNECTOR_SYSTEM_CLASSIFICATION_PARAM = -1133408, // 0xFFEEB4A0
        /// <summary>"Index"</summary>
        CONNECTOR_INDEX = -1133406, // 0xFFEEB4A2
        /// <summary>"Size on screen"</summary>
        CONNECTOR_VISIBLE_SIZE = -1133405, // 0xFFEEB4A3
        /// <summary>"Height"</summary>
        CONNECTOR_HEIGHT = -1133404, // 0xFFEEB4A4
        /// <summary>"Width"</summary>
        CONNECTOR_WIDTH = -1133403, // 0xFFEEB4A5
        /// <summary>"Radius"</summary>
        CONNECTOR_RADIUS = -1133401, // 0xFFEEB4A7
        /// <summary>"Shape"</summary>
        CONNECTOR_PROFILE_TYPE = -1133400, // 0xFFEEB4A8
        /// <summary>"Gender Type"</summary>
        PIPING_GENDER_TYPE = -1115974, // 0xFFEEF8BA
        /// <summary>"Connection Type"</summary>
        PIPING_CONNECTION_TYPE = -1115973, // 0xFFEEF8BB
        /// <summary>"Part Type"</summary>
        RBS_PART_TYPE = -1115958, // 0xFFEEF8CA
        /// <summary>"Peak Latent Cooling Load"</summary>
        PEAK_LATENT_COOLING_LOAD = -1114819, // 0xFFEEFD3D
        /// <summary>"Peak Airflow"</summary>
        PEAK_AIRFLOW_PARAM = -1114818, // 0xFFEEFD3E
        /// <summary>"Reference Level"</summary>
        SPACE_REFERENCE_LEVEL_PARAM = -1114817, // 0xFFEEFD3F
        /// <summary>"Infiltration Airflow"</summary>
        SPACE_INFILTRATION_AIRFLOW = -1114816, // 0xFFEEFD40
        /// <summary>"Infiltration Airflow per area"</summary>
        SPACE_INFILTRATION_AIRFLOW_PER_AREA = -1114815, // 0xFFEEFD41
        /// <summary>"Outdoor Airflow"</summary>
        SPACE_OUTDOOR_AIRFLOW = -1114814, // 0xFFEEFD42
        /// <summary>"Outdoor Airflow per person"</summary>
        SPACE_OUTDOOR_AIRFLOW_PER_PERSON = -1114813, // 0xFFEEFD43
        /// <summary>"Outdoor Airflow per area"</summary>
        SPACE_OUTDOOR_AIRFLOW_PER_AREA = -1114812, // 0xFFEEFD44
        /// <summary>"Air Changes per Hour"</summary>
        SPACE_AIR_CHANGES_PER_HOUR = -1114811, // 0xFFEEFD45
        /// <summary>"Power Load"</summary>
        SPACE_POWER_LOAD_PARAM = -1114810, // 0xFFEEFD46
        /// <summary>"Lighting Load"</summary>
        SPACE_LIGHTING_LOAD_PARAM = -1114809, // 0xFFEEFD47
        /// <summary>"Occupancy Load"</summary>
        SPACE_PEOPLE_LOAD_PARAM = -1114808, // 0xFFEEFD48
        /// <summary>"Power Load per area"</summary>
        SPACE_POWER_LOAD_PER_AREA_PARAM = -1114807, // 0xFFEEFD49
        /// <summary>"Lighting Load per area"</summary>
        SPACE_LIGHTING_LOAD_PER_AREA_PARAM = -1114806, // 0xFFEEFD4A
        /// <summary>"Latent Heat Gain per person"</summary>
        SPACE_PEOPLE_LATENT_HEAT_GAIN_PER_PERSON_PARAM = -1114805, // 0xFFEEFD4B
        /// <summary>"Sensible Heat Gain per person"</summary>
        SPACE_PEOPLE_SENSIBLE_HEAT_GAIN_PER_PERSON_PARAM = -1114804, // 0xFFEEFD4C
        /// <summary>"Area per person"</summary>
        SPACE_AREA_PER_PERSON_PARAM = -1114803, // 0xFFEEFD4D
        /// <summary>"Airflow per area"</summary>
        SPACE_AIRFLOW_PER_AREA_PARAM = -1114802, // 0xFFEEFD4E
        /// <summary>"Peak Cooling Load"</summary>
        PEAK_COOLING_LOAD_PARAM = -1114801, // 0xFFEEFD4F
        /// <summary>"Peak Heating Load"</summary>
        PEAK_HEATING_LOAD_PARAM = -1114800, // 0xFFEEFD50
        /// <summary>"Dehumidification Set Point"</summary>
        SPACE_DEHUMIDIFICATION_SET_POINT = -1114711, // 0xFFEEFDA9
        /// <summary>"Humidification Set Point"</summary>
        SPACE_HUMIDIFICATION_SET_POINT = -1114710, // 0xFFEEFDAA
        /// <summary>"Cooling Set Point"</summary>
        SPACE_COOLING_SET_POINT = -1114709, // 0xFFEEFDAB
        /// <summary>"Heating Set Point"</summary>
        SPACE_HEATING_SET_POINT = -1114708, // 0xFFEEFDAC
        /// <summary>"Top Offset"</summary>
        ZONE_LEVEL_OFFSET_TOP = -1114707, // 0xFFEEFDAD
        /// <summary>"Level Offset"</summary>
        ZONE_LEVEL_OFFSET = -1114706, // 0xFFEEFDAE
        /// <summary>"Level"</summary>
        SYSTEM_ZONE_LEVEL_ID = -1114705, // 0xFFEEFDAF
        /// <summary>"Calculated Hydronic Cooling Flow"</summary>
        ZONE_CALCULATED_HYDRONIC_COOLINGFLOW_PARAM = -1114702, // 0xFFEEFDB2
        /// <summary>"Calculated Hydronic Heating Flow"</summary>
        ZONE_CALCULATED_HYDRONIC_HEATINGFLOW_PARAM = -1114701, // 0xFFEEFDB3
        /// <summary>"Space Outdoor Air Option"</summary>
        ZONE_SPACE_OUTDOOR_AIR_OPTION_PARAM = -1114700, // 0xFFEEFDB4
        /// <summary>"Opening Type"</summary>
        RBS_GBXML_OPENING_TYPE = -1114400, // 0xFFEEFEE0
        /// <summary>"Room Calculation Point"</summary>
        ROOM_CALCULATION_POINT = -1114399, // 0xFFEEFEE1
        /// <summary>"Column Distance"</summary>
        GRID_BANK_COL_WIDTH = -1114398, // 0xFFEEFEE2
        /// <summary>"Row Distance"</summary>
        GRID_BANK_ROW_HEIGHT = -1114397, // 0xFFEEFEE3
        /// <summary>"Column"</summary>
        GRID_BANK_COL_NUM = -1114396, // 0xFFEEFEE4
        /// <summary>"Row"</summary>
        GRID_BANK_ROW_NUM = -1114395, // 0xFFEEFEE5
        /// <summary>"Bend"</summary>
        RBS_CURVETYPE_DEFAULT_BEND_PARAM = -1114394, // 0xFFEEFEE6
        /// <summary>"Horizontal Bend"</summary>
        RBS_CURVETYPE_DEFAULT_HORIZONTAL_BEND_PARAM = -1114393, // 0xFFEEFEE7
        /// <summary>"Multi Shape Transition Oval to Round"</summary>
        RBS_CURVETYPE_MULTISHAPE_TRANSITION_OVALROUND_PARAM = -1114392, // 0xFFEEFEE8
        /// <summary>"Multi Shape Transition Rect to Oval"</summary>
        RBS_CURVETYPE_MULTISHAPE_TRANSITION_RECTOVAL_PARAM = -1114391, // 0xFFEEFEE9
        /// <summary>"Tee Down"</summary>
        RBS_CURVETYPE_DEFAULT_TEEDOWN_PARAM = -1114390, // 0xFFEEFEEA
        /// <summary>"Tee Up"</summary>
        RBS_CURVETYPE_DEFAULT_TEEUP_PARAM = -1114389, // 0xFFEEFEEB
        /// <summary>"Vertical Outside Bend"</summary>
        RBS_CURVETYPE_DEFAULT_ELBOWDOWN_PARAM = -1114388, // 0xFFEEFEEC
        /// <summary>"Vertical Inside Bend"</summary>
        RBS_CURVETYPE_DEFAULT_ELBOWUP_PARAM = -1114387, // 0xFFEEFEED
        /// <summary>"Export Category"</summary>
        RBS_ENERGY_ANALYSIS_EXPORT_CATEGORY_PARAM = -1114386, // 0xFFEEFEEE
        /// <summary>"Export Complexity"</summary>
        RBS_ENERGY_ANALYSIS_EXPORT_COMPLEXITY_PARAM = -1114385, // 0xFFEEFEEF
        /// <summary>"Zone"</summary>
        SPACE_ZONE_NAME = -1114384, // 0xFFEEFEF0
        /// <summary>"Export Default Values"</summary>
        RBS_ENERGY_ANALYSIS_EXPORT_GBXML_DEFAULTS_PARAM = -1114383, // 0xFFEEFEF1
        /// <summary>"Plenum Cooling Load"</summary>
        RBS_HVACLOAD_PLENUM_COOLING_LOAD_PARAM = -1114382, // 0xFFEEFEF2
        /// <summary>"Skylight Cooling Load"</summary>
        RBS_HVACLOAD_SKYLIGHT_COOLING_LOAD_PARAM = -1114381, // 0xFFEEFEF3
        /// <summary>"Partition Cooling Load"</summary>
        RBS_HVACLOAD_PARTITION_COOLING_LOAD_PARAM = -1114380, // 0xFFEEFEF4
        /// <summary>"Door Cooling Load"</summary>
        RBS_HVACLOAD_DOOR_COOLING_LOAD_PARAM = -1114379, // 0xFFEEFEF5
        /// <summary>"Window Cooling Load"</summary>
        RBS_HVACLOAD_WINDOW_COOLING_LOAD_PARAM = -1114378, // 0xFFEEFEF6
        /// <summary>"Wall Cooling Load"</summary>
        RBS_HVACLOAD_WALL_COOLING_LOAD_PARAM = -1114377, // 0xFFEEFEF7
        /// <summary>"Roof Cooling Load"</summary>
        RBS_HVACLOAD_ROOF_COOLING_LOAD_PARAM = -1114376, // 0xFFEEFEF8
        /// <summary>"Skylight Area"</summary>
        RBS_HVACLOAD_SKYLIGHT_AREA_PARAM = -1114375, // 0xFFEEFEF9
        /// <summary>"Partition Area"</summary>
        RBS_HVACLOAD_PARTITION_AREA_PARAM = -1114374, // 0xFFEEFEFA
        /// <summary>"Floor Area"</summary>
        RBS_HVACLOAD_FLOOR_AREA_PARAM = -1114373, // 0xFFEEFEFB
        /// <summary>"Door Area"</summary>
        RBS_HVACLOAD_DOOR_AREA_PARAM = -1114372, // 0xFFEEFEFC
        /// <summary>"Window Area"</summary>
        RBS_HVACLOAD_WINDOW_AREA_PARAM = -1114371, // 0xFFEEFEFD
        /// <summary>"Wall Area"</summary>
        RBS_HVACLOAD_WALL_AREA_PARAM = -1114370, // 0xFFEEFEFE
        /// <summary>"Roof Area"</summary>
        RBS_HVACLOAD_ROOF_AREA_PARAM = -1114369, // 0xFFEEFEFF
        /// <summary>"Show a Coordinate System Symbol for each Surface"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_COORD_AXIS_MODE = -1114368, // 0xFFEEFF00
        /// <summary>"Show Room Bounding Elements Dimmed and Underlay"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_RBE_MODE = -1114367, // 0xFFEEFF01
        /// <summary>"Show Shading Surfaces"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_SHADING_SURFACES_MODE = -1114366, // 0xFFEEFF02
        /// <summary>"Show Surfaces Transparent"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_TRANSPARENT_MODE = -1114365, // 0xFFEEFF03
        /// <summary>"Show Surfaces"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_SURFACES_MODE = -1114364, // 0xFFEEFF04
        /// <summary>"Show Inner Space Shells"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_INNER_SHELL_MODE = -1114363, // 0xFFEEFF05
        /// <summary>"Show Analytical Space Shells"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_OUTER_SHELL_MODE = -1114362, // 0xFFEEFF06
        /// <summary>"Show Analytical Building Shell"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_BUILDING_SHELL_MODE = -1114361, // 0xFFEEFF07
        /// <summary>"Lining Thickness"</summary>
        RBS_LINING_THICKNESS_FOR_DUCT = -1114360, // 0xFFEEFF08
        /// <summary>"Insulation Thickness"</summary>
        RBS_INSULATION_THICKNESS_FOR_PIPE = -1114359, // 0xFFEEFF09
        /// <summary>"Insulation Thickness"</summary>
        RBS_INSULATION_THICKNESS_FOR_DUCT = -1114358, // 0xFFEEFF0A
        /// <summary>"Unoccupied Cooling Set Point"</summary>
        BUILDING_UNOCCUPIED_COOLING_SET_POINT_PARAM = -1114357, // 0xFFEEFF0B
        /// <summary>"Closing Time"</summary>
        BUILDING_CLOSING_TIME_PARAM = -1114356, // 0xFFEEFF0C
        /// <summary>"Opening Time"</summary>
        BUILDING_OPENING_TIME_PARAM = -1114355, // 0xFFEEFF0D
        /// <summary>"People Activity Level"</summary>
        SPACE_PEOPLE_ACTIVITY_LEVEL_PARAM = -1114354, // 0xFFEEFF0E
        /// <summary>"Electrical Equipment Radiant"</summary>
        SPACE_ELEC_EQUIPMENT_RADIANT_PERCENTAGE_PARAM = -1114353, // 0xFFEEFF0F
        /// <summary>"Power Schedule"</summary>
        SPACE_POWER_SCHEDULE_PARAM = -1114351, // 0xFFEEFF11
        /// <summary>"Lighting Schedule"</summary>
        SPACE_LIGHTING_SCHEDULE_PARAM = -1114350, // 0xFFEEFF12
        /// <summary>"Occupancy Schedule"</summary>
        SPACE_OCCUPANCY_SCHEDULE_PARAM = -1114349, // 0xFFEEFF13
        /// <summary>"Infiltration Airflow per area"</summary>
        SPACE_INFILTRATION_PARAM = -1114348, // 0xFFEEFF14
        /// <summary>"Carpeting"</summary>
        SPACE_CARPETING_PARAM = -1114347, // 0xFFEEFF15
        /// <summary>"Air Volume Calculation Type"</summary>
        ZONE_AIR_VOLUME_CALCULATION_TYPE_PARAM = -1114345, // 0xFFEEFF17
        /// <summary>"Coil Bypass"</summary>
        ZONE_COIL_BYPASS_PERCENTAGE_PARAM = -1114344, // 0xFFEEFF18
        /// <summary>"Calculated Area per Cooling Load"</summary>
        ZONE_CALCULATED_AREA_PER_COOLING_LOAD_PARAM = -1114343, // 0xFFEEFF19
        /// <summary>"Calculated Area per Heating Load"</summary>
        ZONE_CALCULATED_AREA_PER_HEATING_LOAD_PARAM = -1114342, // 0xFFEEFF1A
        /// <summary>"Use Air Changes Per Hour"</summary>
        ZONE_USE_AIR_CHANGES_PER_HOUR_PARAM = -1114341, // 0xFFEEFF1B
        /// <summary>"Use Outside Air Per Area"</summary>
        ZONE_USE_OUTSIDE_AIR_PER_AREA_PARAM = -1114340, // 0xFFEEFF1C
        /// <summary>"Use Outside Air Per Person"</summary>
        ZONE_USE_OUTSIDE_AIR_PER_PERSON_PARAM = -1114339, // 0xFFEEFF1D
        /// <summary>"Use Dehumidification Set Point"</summary>
        ZONE_USE_DEHUMIDIFICATION_SETPOINT_PARAM = -1114338, // 0xFFEEFF1E
        /// <summary>"Use Humidification Set Point"</summary>
        ZONE_USE_HUMIDIFICATION_SETPOINT_PARAM = -1114337, // 0xFFEEFF1F
        /// <summary>"Outdoor Air Information"</summary>
        ZONE_OUTDOOR_AIR_INFORMATION_PARAM = -1114336, // 0xFFEEFF20
        /// <summary>"Cooling Information"</summary>
        ZONE_COOLING_INFORMATION_PARAM = -1114335, // 0xFFEEFF21
        /// <summary>"Heating Information"</summary>
        ZONE_HEATING_INFORMATION_PARAM = -1114334, // 0xFFEEFF22
        /// <summary>"Sliver Space Tolerance"</summary>
        RBS_ENERGY_ANALYSIS_SLIVER_SPACE_TOLERANCE = -1114333, // 0xFFEEFF23
        /// <summary>"Gross Area"</summary>
        ZONE_AREA_GROSS = -1114332, // 0xFFEEFF24
        /// <summary>"Gross Volume"</summary>
        ZONE_VOLUME_GROSS = -1114331, // 0xFFEEFF25
        /// <summary>"Plenum"</summary>
        SPACE_IS_PLENUM = -1114330, // 0xFFEEFF26
        /// <summary>"Occupiable"</summary>
        SPACE_IS_OCCUPIABLE = -1114329, // 0xFFEEFF27
        /// <summary>"Room Number"</summary>
        SPACE_ASSOC_ROOM_NUMBER = -1114328, // 0xFFEEFF28
        /// <summary>"Room Name"</summary>
        SPACE_ASSOC_ROOM_NAME = -1114327, // 0xFFEEFF29
        /// <summary>"Phase"</summary>
        ZONE_PHASE = -1114326, // 0xFFEEFF2A
        /// <summary>"Phase Id"</summary>
        ZONE_PHASE_ID = -1114325, // 0xFFEEFF2B
        /// <summary>"Project Phase"</summary>
        RBS_ENERGY_ANALYSIS_PROJECT_PHASE_PARAM = -1114324, // 0xFFEEFF2C
        /// <summary>"Calculated Supply Airflow per area"</summary>
        ROOM_CALCULATED_SUPPLY_AIRFLOW_PER_AREA_PARAM = -1114323, // 0xFFEEFF2D
        /// <summary>"Calculated Cooling Load per area"</summary>
        ROOM_CALCULATED_COOLING_LOAD_PER_AREA_PARAM = -1114322, // 0xFFEEFF2E
        /// <summary>"Calculated Heating Load per area"</summary>
        ROOM_CALCULATED_HEATING_LOAD_PER_AREA_PARAM = -1114321, // 0xFFEEFF2F
        /// <summary>"Calculated Supply Airflow per area"</summary>
        ZONE_CALCULATED_SUPPLY_AIRFLOW_PER_AREA_PARAM = -1114320, // 0xFFEEFF30
        /// <summary>"Calculated Cooling Load per area"</summary>
        ZONE_CALCULATED_COOLING_LOAD_PER_AREA_PARAM = -1114319, // 0xFFEEFF31
        /// <summary>"Calculated Heating Load per area"</summary>
        ZONE_CALCULATED_HEATING_LOAD_PER_AREA_PARAM = -1114318, // 0xFFEEFF32
        /// <summary>"Level"</summary>
        ZONE_LEVEL_ID = -1114317, // 0xFFEEFF33
        /// <summary>"Outdoor Air Rate / Air Changes per Hour"</summary>
        ZONE_OA_RATE_PER_ACH_PARAM = -1114316, // 0xFFEEFF34
        /// <summary>"Outdoor Air per Area"</summary>
        ZONE_OUTSIDE_AIR_PER_AREA_PARAM = -1114315, // 0xFFEEFF35
        /// <summary>"Outdoor Air per Person"</summary>
        ZONE_OUTSIDE_AIR_PER_PERSON_PARAM = -1114314, // 0xFFEEFF36
        /// <summary>"Dehumidification Set Point"</summary>
        ZONE_DEHUMIDIFICATION_SET_POINT_PARAM = -1114313, // 0xFFEEFF37
        /// <summary>"Humidification Set Point"</summary>
        ZONE_HUMIDIFICATION_SET_POINT_PARAM = -1114312, // 0xFFEEFF38
        /// <summary>"Cooling Air Temperature"</summary>
        ZONE_COOLING_AIR_TEMPERATURE_PARAM = -1114311, // 0xFFEEFF39
        /// <summary>"Heating Air Temperature"</summary>
        ZONE_HEATING_AIR_TEMPERATURE_PARAM = -1114310, // 0xFFEEFF3A
        /// <summary>"Cooling Set Point"</summary>
        ZONE_COOLING_SET_POINT_PARAM = -1114309, // 0xFFEEFF3B
        /// <summary>"Heating Set Point"</summary>
        ZONE_HEATING_SET_POINT_PARAM = -1114308, // 0xFFEEFF3C
        /// <summary>"Calculated Supply Airflow"</summary>
        ZONE_CALCULATED_SUPPLY_AIRFLOW_PARAM = -1114307, // 0xFFEEFF3D
        /// <summary>"Calculated Cooling Load"</summary>
        ZONE_CALCULATED_COOLING_LOAD_PARAM = -1114306, // 0xFFEEFF3E
        /// <summary>"Calculated Heating Load"</summary>
        ZONE_CALCULATED_HEATING_LOAD_PARAM = -1114305, // 0xFFEEFF3F
        /// <summary>"Service Type"</summary>
        ZONE_SERVICE_TYPE_PARAM = -1114304, // 0xFFEEFF40
        /// <summary>"Occupied Volume"</summary>
        ZONE_VOLUME = -1114303, // 0xFFEEFF41
        /// <summary>"Perimeter"</summary>
        ZONE_PERIMETER = -1114302, // 0xFFEEFF42
        /// <summary>"Occupied Area"</summary>
        ZONE_AREA = -1114301, // 0xFFEEFF43
        /// <summary>"Name"</summary>
        ZONE_NAME = -1114300, // 0xFFEEFF44
        /// <summary>"Update Surfaces"</summary>
        RBS_ENERGY_ANALYSIS_VIEW_UPDATE_SURFACES = -1114299, // 0xFFEEFF45
        /// <summary>"Internal Shading Factor"</summary>
        RBS_PROJECT_CONSTRUCTION_TYPE_SHADINGFACTOR_PARAM = -1114296, // 0xFFEEFF48
        /// <summary>"Internal Shading Factor"</summary>
        RBS_CONSTRUCTION_TYPE_SHADINGFACTOR_PARAM = -1114295, // 0xFFEEFF49
        /// <summary>"Ground Plane"</summary>
        RBS_ENERGY_ANALYSIS_GROUND_PLANE_PARAM = -1114293, // 0xFFEEFF4B
        /// <summary>"Origin (Z)"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_Z = -1114292, // 0xFFEEFF4C
        /// <summary>"Origin (Y)"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_Y = -1114291, // 0xFFEEFF4D
        /// <summary>"Origin (X)"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_ORIGIN_X = -1114290, // 0xFFEEFF4E
        /// <summary>"Azimuth"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_AZIMUTH = -1114289, // 0xFFEEFF4F
        /// <summary>"Tilt"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_TILT = -1114288, // 0xFFEEFF50
        /// <summary>"CADObjectID"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_CADOBJECTID = -1114287, // 0xFFEEFF51
        /// <summary>"Adjacent Space Id (2)"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_ADJACENT_SPACE_ID2 = -1114286, // 0xFFEEFF52
        /// <summary>"Adjacent Space Id (1)"</summary>
        RBS_ENERGY_ANALYSIS_SURFACE_ADJACENT_SPACE_ID1 = -1114285, // 0xFFEEFF53
        /// <summary>"Electrical Loads"</summary>
        ROOM_EDIT_ELECTRICAL_LOADS_PARAM = -1114284, // 0xFFEEFF54
        /// <summary>"People"</summary>
        ROOM_EDIT_PEOPLE_LOADS_PARAM = -1114283, // 0xFFEEFF55
        /// <summary>"Location"</summary>
        RBS_PROJECT_LOCATION_PARAM = -1114282, // 0xFFEEFF56
        /// <summary>"Actual Lighting Load per area"</summary>
        ROOM_ACTUAL_LIGHTING_LOAD_PER_AREA_PARAM = -1114261, // 0xFFEEFF6B
        /// <summary>"Actual Power Load per area"</summary>
        ROOM_ACTUAL_POWER_LOAD_PER_AREA_PARAM = -1114260, // 0xFFEEFF6C
        /// <summary>"Heat Load Values"</summary>
        ROOM_BASE_HEAT_LOAD_ON_PARAM = -1114259, // 0xFFEEFF6D
        /// <summary>"Lighting Load Units"</summary>
        ROOM_LIGHTING_LOAD_UNITS_PARAM = -1114258, // 0xFFEEFF6E
        /// <summary>"Power Load Units"</summary>
        ROOM_POWER_LOAD_UNITS_PARAM = -1114257, // 0xFFEEFF6F
        /// <summary>"Design Cooling Load"</summary>
        ROOM_DESIGN_COOLING_LOAD_PARAM = -1114256, // 0xFFEEFF70
        /// <summary>"Calculated Cooling Load"</summary>
        ROOM_CALCULATED_COOLING_LOAD_PARAM = -1114255, // 0xFFEEFF71
        /// <summary>"Design Heating Load"</summary>
        ROOM_DESIGN_HEATING_LOAD_PARAM = -1114254, // 0xFFEEFF72
        /// <summary>"Calculated Heating Load"</summary>
        ROOM_CALCULATED_HEATING_LOAD_PARAM = -1114253, // 0xFFEEFF73
        /// <summary>"Return Airflow"</summary>
        ROOM_BASE_RETURN_AIRFLOW_ON_PARAM = -1114252, // 0xFFEEFF74
        /// <summary>"Construction Type"</summary>
        ROOM_CONSTRUCTION_SET_PARAM = -1114251, // 0xFFEEFF75
        /// <summary>"Schematic Types"</summary>
        RBS_CONSTRUCTION_SET_PARAM = -1114249, // 0xFFEEFF77
        /// <summary>"Building Service"</summary>
        RBS_SERVICE_TYPE_PARAM = -1114248, // 0xFFEEFF78
        /// <summary>"Area"</summary>
        RBS_GBXML_SURFACE_AREA = -1114247, // 0xFFEEFF79
        /// <summary>"Surface Type"</summary>
        RBS_GBXML_SURFACE_TYPE = -1114246, // 0xFFEEFF7A
        /// <summary>"Surface Name"</summary>
        RBS_GBXML_SURFACE_NAME = -1114245, // 0xFFEEFF7B
        /// <summary>"Maintain Annotation Orientation"</summary>
        FAMILY_ELECTRICAL_MAINTAIN_ANNOTATION_ORIENTATION = -1114243, // 0xFFEEFF7D
        /// <summary>"Use Annotation Scale"</summary>
        RBS_FAMILY_CONTENT_ANNOTATION_DISPLAY = -1114242, // 0xFFEEFF7E
        /// <summary>"Electrical Data"</summary>
        RBS_ELECTRICAL_DATA = -1114241, // 0xFFEEFF7F
        /// <summary>"Size"</summary>
        RBS_CALCULATED_SIZE = -1114240, // 0xFFEEFF80
        /// <summary>"Sensible Heat Gain per person"</summary>
        ROOM_PEOPLE_SENSIBLE_HEAT_GAIN_PER_PERSON_PARAM = -1114239, // 0xFFEEFF81
        /// <summary>"IsCustom"</summary>
        RBS_IS_CUSTOM_FITTING = -1114238, // 0xFFEEFF82
        /// <summary>"Connector Offset"</summary>
        RBS_CONNECTOR_OFFSET_OBSOLETE = -1114237, // 0xFFEEFF83
        /// <summary>"Lookup Table Name"</summary>
        RBS_LOOKUP_TABLE_NAME = -1114236, // 0xFFEEFF84
        /// <summary>"Specified Lighting Load"</summary>
        ROOM_DESIGN_LIGHTING_LOAD_PARAM = -1114230, // 0xFFEEFF8A
        /// <summary>"Specified Power Load"</summary>
        ROOM_DESIGN_POWER_LOAD_PARAM = -1114229, // 0xFFEEFF8B
        /// <summary>"Actual Lighting Load"</summary>
        ROOM_ACTUAL_LIGHTING_LOAD_PARAM = -1114226, // 0xFFEEFF8E
        /// <summary>"Actual Power Load"</summary>
        ROOM_ACTUAL_POWER_LOAD_PARAM = -1114225, // 0xFFEEFF8F
        /// <summary>"Base Lighting Load on"</summary>
        ROOM_BASE_LIGHTING_LOAD_ON_PARAM = -1114224, // 0xFFEEFF90
        /// <summary>"Base Power Load on"</summary>
        ROOM_BASE_POWER_LOAD_ON_PARAM = -1114223, // 0xFFEEFF91
        /// <summary>"Design Other Load per area"</summary>
        ROOM_DESIGN_OTHER_LOAD_PER_AREA_PARAM = -1114222, // 0xFFEEFF92
        /// <summary>"Design HVAC Load per area"</summary>
        ROOM_DESIGN_MECHANICAL_LOAD_PER_AREA_PARAM = -1114221, // 0xFFEEFF93
        /// <summary>"Specified Lighting Load per area"</summary>
        ROOM_DESIGN_LIGHTING_LOAD_PER_AREA_PARAM = -1114220, // 0xFFEEFF94
        /// <summary>"Specified Power Load per area"</summary>
        ROOM_DESIGN_POWER_LOAD_PER_AREA_PARAM = -1114219, // 0xFFEEFF95
        /// <summary>"Ballast Loss"</summary>
        FBX_LIGHT_BALLAST_LOSS = -1114218, // 0xFFEEFF96
        /// <summary>"Total Light Loss Factor"</summary>
        FBX_LIGHT_TOTAL_LIGHT_LOSS = -1114217, // 0xFFEEFF97
        /// <summary>"Coefficient of Utilization"</summary>
        RBS_ROOM_COEFFICIENT_UTILIZATION = -1114216, // 0xFFEEFF98
        /// <summary>"Takeoff Fixed Length"</summary>
        RBS_FAMILY_CONTENT_TAKEOFF_FIXED_LENGTH = -1114215, // 0xFFEEFF99
        /// <summary>"Takeoff Length Projection"</summary>
        RBS_FAMILY_CONTENT_TAKEOFF_PROJLENGTH = -1114214, // 0xFFEEFF9A
        /// <summary>"Takeoff Length"</summary>
        RBS_FAMILY_CONTENT_TAKEOFF_LENGTH = -1114213, // 0xFFEEFF9B
        /// <summary>"OffsetHeight"</summary>
        RBS_FAMILY_CONTENT_OFFSET_HEIGHT = -1114212, // 0xFFEEFF9C
        /// <summary>"OffsetWidth"</summary>
        RBS_FAMILY_CONTENT_OFFSET_WIDTH = -1114211, // 0xFFEEFF9D
        /// <summary>"Part Type"</summary>
        FAMILY_CONTENT_PART_TYPE = -1114206, // 0xFFEEFFA2
        /// <summary>"Energy Settings"</summary>
        GBXML_EDIT_DATA_PARAM = -1114197, // 0xFFEEFFAB
        /// <summary>"Actual Exhaust Airflow"</summary>
        ROOM_ACTUAL_EXHAUST_AIRFLOW_PARAM = -1114196, // 0xFFEEFFAC
        /// <summary>"Actual Return Airflow"</summary>
        ROOM_ACTUAL_RETURN_AIRFLOW_PARAM = -1114195, // 0xFFEEFFAD
        /// <summary>"Actual Supply Airflow"</summary>
        ROOM_ACTUAL_SUPPLY_AIRFLOW_PARAM = -1114194, // 0xFFEEFFAE
        /// <summary>"Latent Heat Gain per person"</summary>
        ROOM_PEOPLE_LATENT_HEAT_GAIN_PER_PERSON_PARAM = -1114189, // 0xFFEEFFB3
        /// <summary>"Total Heat Gain per person"</summary>
        ROOM_PEOPLE_TOTAL_HEAT_GAIN_PER_PERSON_PARAM = -1114188, // 0xFFEEFFB4
        /// <summary>"Calculated Supply Airflow"</summary>
        ROOM_CALCULATED_SUPPLY_AIRFLOW_PARAM = -1114180, // 0xFFEEFFBC
        /// <summary>"Specified Exhaust Airflow"</summary>
        ROOM_DESIGN_EXHAUST_AIRFLOW_PARAM = -1114178, // 0xFFEEFFBE
        /// <summary>"Specified Return Airflow"</summary>
        ROOM_DESIGN_RETURN_AIRFLOW_PARAM = -1114177, // 0xFFEEFFBF
        /// <summary>"Specified Supply Airflow"</summary>
        ROOM_DESIGN_SUPPLY_AIRFLOW_PARAM = -1114176, // 0xFFEEFFC0
        /// <summary>"Area per Person"</summary>
        ROOM_AREA_PER_PERSON_PARAM = -1114175, // 0xFFEEFFC1
        /// <summary>"Number of People"</summary>
        ROOM_NUMBER_OF_PEOPLE_PARAM = -1114174, // 0xFFEEFFC2
        /// <summary>"Occupancy Unit"</summary>
        ROOM_OCCUPANCY_UNIT_PARAM = -1114173, // 0xFFEEFFC3
        /// <summary>"Space Type"</summary>
        ROOM_SPACE_TYPE_PARAM = -1114172, // 0xFFEEFFC4
        /// <summary>"Condition Type"</summary>
        ROOM_CONDITION_TYPE_PARAM = -1114171, // 0xFFEEFFC5
        /// <summary>"Postal Code"</summary>
        PROJECT_POSTAL_CODE = -1114169, // 0xFFEEFFC7
        /// <summary>"Building Type"</summary>
        PROJECT_BUILDING_TYPE = -1114168, // 0xFFEEFFC8
        /// <summary>"Size Lock"</summary>
        RBS_SIZE_LOCK = -1114167, // 0xFFEEFFC9
        /// <summary>"Additional Flow"</summary>
        RBS_ADDITIONAL_FLOW = -1114166, // 0xFFEEFFCA
        /// <summary>"Max Width"</summary>
        RBS_CURVETYPE_MAX_WIDTH_PARAM = -1114165, // 0xFFEEFFCB
        /// <summary>"Loss Method Settings"</summary>
        RBS_PIPE_FITTING_LOSS_METHOD_SETTINGS = -1114150, // 0xFFEEFFDA
        /// <summary>"Loss Method Settings"</summary>
        RBS_DUCT_FITTING_LOSS_METHOD_SETTINGS = -1114149, // 0xFFEEFFDB
        /// <summary>"Cap"</summary>
        RBS_CURVETYPE_DEFAULT_CAP_PARAM = -1114148, // 0xFFEEFFDC
        /// <summary>"Loss Method"</summary>
        RBS_PIPE_FITTING_LOSS_METHOD_SERVER_PARAM = -1114147, // 0xFFEEFFDD
        /// <summary>"Loss Method"</summary>
        RBS_DUCT_FITTING_LOSS_METHOD_SERVER_PARAM = -1114146, // 0xFFEEFFDE
        /// <summary>"Flange"</summary>
        RBS_CURVETYPE_DEFAULT_MECHJOINT_PARAM = -1114145, // 0xFFEEFFDF
        /// <summary>"Size"</summary>
        RBS_PIPE_SIZE_FORMATTED_PARAM = -1114144, // 0xFFEEFFE0
        /// <summary>"Size"</summary>
        RBS_DUCT_SIZE_FORMATTED_PARAM = -1114143, // 0xFFEEFFE1
        /// <summary>"Static Pressure"</summary>
        RBS_DUCT_STATIC_PRESSURE = -1114142, // 0xFFEEFFE2
        /// <summary>"Flex Pipe"</summary>
        RBS_FLEX_PIPE_TYPE_PARAM = -1114141, // 0xFFEEFFE3
        /// <summary>"Pipe Type"</summary>
        RBS_PIPE_TYPE_PARAM = -1114140, // 0xFFEEFFE4
        /// <summary>"Flex Duct Type"</summary>
        RBS_FLEX_DUCT_TYPE_PARAM = -1114139, // 0xFFEEFFE5
        /// <summary>"Duct Type"</summary>
        RBS_DUCT_TYPE_PARAM = -1114138, // 0xFFEEFFE6
        /// <summary>"ASHRAE Table"</summary>
        RBS_DUCT_FITTING_LOSS_TABLE_PARAM = -1114137, // 0xFFEEFFE7
        /// <summary>"Loss Method"</summary>
        RBS_DUCT_FITTING_LOSS_METHOD_PARAM = -1114136, // 0xFFEEFFE8
        /// <summary>"Flex Duct Type"</summary>
        RBS_FLEXDUCT_ROUNDTYPE_PARAM = -1114135, // 0xFFEEFFE9
        /// <summary>"Preferred Junction Type"</summary>
        RBS_CURVETYPE_PREFERRED_BRANCH_PARAM = -1114134, // 0xFFEEFFEA
        /// <summary>"Tap"</summary>
        RBS_CURVETYPE_DEFAULT_TAKEOFF_PARAM = -1114133, // 0xFFEEFFEB
        /// <summary>"Middle Elevation"</summary>
        RBS_OFFSET_PARAM = -1114132, // 0xFFEEFFEC
        /// <summary>"Union"</summary>
        RBS_CURVETYPE_DEFAULT_UNION_PARAM = -1114131, // 0xFFEEFFED
        /// <summary>"Hydraulic Diameter"</summary>
        RBS_HYDRAULIC_DIAMETER_PARAM = -1114129, // 0xFFEEFFEF
        /// <summary>"Reynolds number"</summary>
        RBS_REYNOLDSNUMBER_PARAM = -1114128, // 0xFFEEFFF0
        /// <summary>"Equivalent Diameter"</summary>
        RBS_EQ_DIAMETER_PARAM = -1114127, // 0xFFEEFFF1
        /// <summary>"Multi Shape Transition Rect to Round"</summary>
        RBS_CURVETYPE_MULTISHAPE_TRANSITION_PARAM = -1114126, // 0xFFEEFFF2
        /// <summary>"Section"</summary>
        RBS_SECTION = -1114125, // 0xFFEEFFF3
        /// <summary>"Loss Coefficient"</summary>
        RBS_LOSS_COEFFICIENT = -1114124, // 0xFFEEFFF4
        /// <summary>"Max Flow"</summary>
        RBS_MAX_FLOW = -1114123, // 0xFFEEFFF5
        /// <summary>"Min Flow"</summary>
        RBS_MIN_FLOW = -1114122, // 0xFFEEFFF6
        /// <summary>"Velocity Pressure"</summary>
        RBS_VELOCITY_PRESSURE = -1114121, // 0xFFEEFFF7
        /// <summary>"Area"</summary>
        RBS_CURVE_SURFACE_AREA = -1114120, // 0xFFEEFFF8
        /// <summary>"Max Height"</summary>
        RBS_CURVETYPE_MAX_HEIGHT_PARAM = -1114119, // 0xFFEEFFF9
        /// <summary>"Lining Thickness"</summary>
        RBS_LINING_THICKNESS = -1114118, // 0xFFEEFFFA
        /// <summary>"Insulation Thickness"</summary>
        RBS_INSULATION_THICKNESS = -1114117, // 0xFFEEFFFB
        /// <summary>"Friction"</summary>
        RBS_FRICTION = -1114116, // 0xFFEEFFFC
        /// <summary>"Roughness"</summary>
        RBS_CURVETYPE_ROUGHNESS_PARAM = -1114114, // 0xFFEEFFFE
        /// <summary>"Transition"</summary>
        RBS_CURVETYPE_DEFAULT_TRANSITION_PARAM = -1114113, // 0xFFEEFFFF
        /// <summary>"Cross"</summary>
        RBS_CURVETYPE_DEFAULT_CROSS_PARAM = -1114112, // 0xFFEF0000
        /// <summary>"Tee"</summary>
        RBS_CURVETYPE_DEFAULT_TEE_PARAM = -1114111, // 0xFFEF0001
        /// <summary>"Elbow"</summary>
        RBS_CURVETYPE_DEFAULT_ELBOW_PARAM = -1114110, // 0xFFEF0002
        /// <summary>"Pressure Drop"</summary>
        RBS_PRESSURE_DROP = -1114108, // 0xFFEF0004
        /// <summary>"Velocity"</summary>
        RBS_VELOCITY = -1114107, // 0xFFEF0005
        /// <summary>"Vertical Justification"</summary>
        RBS_CURVE_VERT_OFFSET_PARAM = -1114106, // 0xFFEF0006
        /// <summary>"Horizontal Justification"</summary>
        RBS_CURVE_HOR_OFFSET_PARAM = -1114105, // 0xFFEF0007
        /// <summary>"Flow"</summary>
        RBS_FLOW_OBSOLETE = -1114104, // 0xFFEF0008
        /// <summary>"Diameter"</summary>
        RBS_CURVE_DIAMETER_PARAM = -1114103, // 0xFFEF0009
        /// <summary>"Height"</summary>
        RBS_CURVE_HEIGHT_PARAM = -1114102, // 0xFFEF000A
        /// <summary>"Width"</summary>
        RBS_CURVE_WIDTH_PARAM = -1114101, // 0xFFEF000B
        /// <summary>"Flex Pattern"</summary>
        RBS_FLEX_PATTERN_PARAM = -1114005, // 0xFFEF006B
        /// <summary>"End Middle Elevation"</summary>
        RBS_END_OFFSET_PARAM = -1114003, // 0xFFEF006D
        /// <summary>"Start Middle Elevation"</summary>
        RBS_START_OFFSET_PARAM = -1114002, // 0xFFEF006E
        /// <summary>"End Level"</summary>
        RBS_END_LEVEL_PARAM = -1114001, // 0xFFEF006F
        /// <summary>"Reference Level"</summary>
        RBS_START_LEVEL_PARAM = -1114000, // 0xFFEF0070
        /// <summary>"All non 0 forces at end"</summary>
        ANALYTICAL_MEMBER_FORCE_END_ALL_NON_ZERO = -1060014, // 0xFFEFD352
        /// <summary>"All non 0 forces at start"</summary>
        ANALYTICAL_MEMBER_FORCE_START_ALL_NON_ZERO = -1060013, // 0xFFEFD353
        /// <summary>"Member Forces"</summary>
        STRUCTURAL_MEMBER_FORCES = -1060012, // 0xFFEFD354
        /// <summary>"End Mz"</summary>
        ANALYTICAL_MEMBER_FORCE_END_MZ = -1060011, // 0xFFEFD355
        /// <summary>"End My"</summary>
        ANALYTICAL_MEMBER_FORCE_END_MY = -1060010, // 0xFFEFD356
        /// <summary>"End Mx"</summary>
        ANALYTICAL_MEMBER_FORCE_END_MX = -1060009, // 0xFFEFD357
        /// <summary>"End Fz"</summary>
        ANALYTICAL_MEMBER_FORCE_END_FZ = -1060008, // 0xFFEFD358
        /// <summary>"End Fy"</summary>
        ANALYTICAL_MEMBER_FORCE_END_FY = -1060007, // 0xFFEFD359
        /// <summary>"End Fx"</summary>
        ANALYTICAL_MEMBER_FORCE_END_FX = -1060006, // 0xFFEFD35A
        /// <summary>"Start Mz"</summary>
        ANALYTICAL_MEMBER_FORCE_START_MZ = -1060005, // 0xFFEFD35B
        /// <summary>"Start My"</summary>
        ANALYTICAL_MEMBER_FORCE_START_MY = -1060004, // 0xFFEFD35C
        /// <summary>"Start Mx"</summary>
        ANALYTICAL_MEMBER_FORCE_START_MX = -1060003, // 0xFFEFD35D
        /// <summary>"Start Fz"</summary>
        ANALYTICAL_MEMBER_FORCE_START_FZ = -1060002, // 0xFFEFD35E
        /// <summary>"Start Fy"</summary>
        ANALYTICAL_MEMBER_FORCE_START_FY = -1060001, // 0xFFEFD35F
        /// <summary>"Start Fx"</summary>
        ANALYTICAL_MEMBER_FORCE_START_FX = -1060000, // 0xFFEFD360
        /// <summary>"Path Length"</summary>
        DIVIDEDPATH_TOTAL_PATH_LENGTH = -1050441, // 0xFFEFF8B7
        /// <summary>"Show Node Numbers"</summary>
        DIVIDEDPATH_DISPLAY_NODE_NUMBERS = -1050440, // 0xFFEFF8B8
        /// <summary>"Total Number of Nodes"</summary>
        DIVIDEDPATH_MERGED_POINT_NUM = -1050439, // 0xFFEFF8B9
        /// <summary>"Display Nodes"</summary>
        DIVIDEDPATH_DISPLAY_NODES = -1050437, // 0xFFEFF8BB
        /// <summary>"Display Path"</summary>
        DIVIDEDPATH_DISPLAY_REFERENCE_CURVES = -1050436, // 0xFFEFF8BC
        /// <summary>"Justification"</summary>
        DIVIDEDPATH_JUSTIFICATION = -1050435, // 0xFFEFF8BD
        /// <summary>"Number"</summary>
        DIVIDEDPATH_LAYOUT_FIXED_NUM_POINT = -1050434, // 0xFFEFF8BE
        /// <summary>"Flip Direction"</summary>
        DIVIDEDPATH_FLIP_DIRECTION = -1050433, // 0xFFEFF8BF
        /// <summary>"Measurement Type"</summary>
        DIVIDEDPATH_MEASUREMENT_TYPE = -1050432, // 0xFFEFF8C0
        /// <summary>"Maximum Distance"</summary>
        DIVIDEDPATH_MAX_DISTANCE = -1050431, // 0xFFEFF8C1
        /// <summary>"Minimum Distance"</summary>
        DIVIDEDPATH_MIN_DISTANCE = -1050430, // 0xFFEFF8C2
        /// <summary>"End Indent"</summary>
        DIVIDEDPATH_END_INDENT = -1050429, // 0xFFEFF8C3
        /// <summary>"Beginning Indent"</summary>
        DIVIDEDPATH_BEGINNING_INDENT = -1050428, // 0xFFEFF8C4
        /// <summary>"Distance"</summary>
        DIVIDEDPATH_DISTANCE = -1050427, // 0xFFEFF8C5
        /// <summary>"Layout"</summary>
        DIVIDEDPATH_LAYOUT = -1050426, // 0xFFEFF8C6
        /// <summary>"Angle From Vertical"</summary>
        WALL_SINGLE_SLANT_ANGLE_FROM_VERTICAL = -1019101, // 0xFFF07323
        /// <summary>"Cross-Section"</summary>
        WALL_CROSS_SECTION = -1019100, // 0xFFF07324
        /// <summary>"IfcOrganization"</summary>
        IFC_ORGANIZATION = -1019011, // 0xFFF0737D
        /// <summary>"IfcApplicationVersion"</summary>
        IFC_APPLICATION_VERSION = -1019010, // 0xFFF0737E
        /// <summary>"IfcApplicationName"</summary>
        IFC_APPLICATION_NAME = -1019009, // 0xFFF0737F
        /// <summary>"Organization Name"</summary>
        PROJECT_ORGANIZATION_NAME = -1019008, // 0xFFF07380
        /// <summary>"Organization Description"</summary>
        PROJECT_ORGANIZATION_DESCRIPTION = -1019007, // 0xFFF07381
        /// <summary>"Building Name"</summary>
        PROJECT_BUILDING_NAME = -1019006, // 0xFFF07382
        /// <summary>"Author"</summary>
        PROJECT_AUTHOR = -1019005, // 0xFFF07383
        /// <summary>"IfcSite GUID"</summary>
        IFC_SITE_GUID = -1019004, // 0xFFF07384
        /// <summary>"IfcBuilding GUID"</summary>
        IFC_BUILDING_GUID = -1019003, // 0xFFF07385
        /// <summary>"IfcProject GUID"</summary>
        IFC_PROJECT_GUID = -1019002, // 0xFFF07386
        /// <summary>"Type IfcGUID"</summary>
        IFC_TYPE_GUID = -1019001, // 0xFFF07387
        /// <summary>"IfcGUID"</summary>
        IFC_GUID = -1019000, // 0xFFF07388
        /// <summary>"Name"</summary>
        STRUCT_CONNECTION_TYPE_NAME = -1018850, // 0xFFF0741E
        /// <summary>"Automatic Cutback for Beams and Braces"</summary>
        STRUCT_CONNECTION_CUTBACK = -1018805, // 0xFFF0744B
        /// <summary>"Base Connection"</summary>
        STRUCT_CONNECTION_COLUMN_BASE = -1018804, // 0xFFF0744C
        /// <summary>"Top Connection"</summary>
        STRUCT_CONNECTION_COLUMN_TOP = -1018803, // 0xFFF0744D
        /// <summary>"End Connection"</summary>
        STRUCT_CONNECTION_BEAM_END = -1018802, // 0xFFF0744E
        /// <summary>"Start Connection"</summary>
        STRUCT_CONNECTION_BEAM_START = -1018801, // 0xFFF0744F
        /// <summary>"Apply to"</summary>
        STRUCT_CONNECTION_APPLY_TO = -1018800, // 0xFFF07450
        /// <summary>"Bar Type"</summary>
        REBAR_CONTAINER_BAR_TYPE = -1018505, // 0xFFF07577
        /// <summary>"Reinforcement Volume"</summary>
        REINFORCEMENT_VOLUME = -1018503, // 0xFFF07579
        /// <summary>"Estimated Reinforcement Volume"</summary>
        REIN_EST_BAR_VOLUME = -1018502, // 0xFFF0757A
        /// <summary>"Estimated Total Bar Length"</summary>
        REIN_EST_BAR_LENGTH = -1018501, // 0xFFF0757B
        /// <summary>"Estimated Number of Bars"</summary>
        REIN_EST_NUMBER_OF_BARS = -1018500, // 0xFFF0757C
        /// <summary>"Alternating Bar - Shape"</summary>
        PATH_REIN_SHAPE_2 = -1018362, // 0xFFF07606
        /// <summary>"Primary Bar - Shape"</summary>
        PATH_REIN_SHAPE_1 = -1018361, // 0xFFF07607
        /// <summary>"Offset"</summary>
        PATH_REIN_SPANLENGTH_ALT_OFFSET = -1018360, // 0xFFF07608
        /// <summary>"Length (Alternating Bar)"</summary>
        PATH_REIN_SPANLENGTH_BARLENGTH_ALT = -1018359, // 0xFFF07609
        /// <summary>"Length (Primary Bar)"</summary>
        PATH_REIN_SPANLENGTH_BARLENGTH_PRIM = -1018358, // 0xFFF0760A
        /// <summary>"Top (Alternating Bar)"</summary>
        PATH_REIN_SPANLENGTH_TOP_ALT = -1018357, // 0xFFF0760B
        /// <summary>"End Hook Angle Alternating"</summary>
        PATH_REIN_END_SPANHOOK_ALT = -1018356, // 0xFFF0760C
        /// <summary>"End Hook Angle Primary"</summary>
        PATH_REIN_END_SPANHOOK_PRIM = -1018355, // 0xFFF0760D
        /// <summary>"Summary"</summary>
        PATH_REIN_SUMMARY = -1018354, // 0xFFF0760E
        /// <summary>"Bottom (Alternating Bar)"</summary>
        PATH_REIN_SPANLENGTH_BOTTOM_ALT = -1018353, // 0xFFF0760F
        /// <summary>"Bottom (Primary Bar)"</summary>
        PATH_REIN_SPANLENGTH_BOTTOM_PRIM = -1018352, // 0xFFF07610
        /// <summary>"Start Hook Angle Alternating"</summary>
        PATH_REIN_SPANHOOK_ALT = -1018351, // 0xFFF07611
        /// <summary>"Start Hook Angle Primary"</summary>
        PATH_REIN_SPANHOOK_PRIM = -1018350, // 0xFFF07612
        /// <summary>"Additional Offset"</summary>
        PATH_REIN_ADDL_OFFSET = -1018322, // 0xFFF0762E
        /// <summary>"Alternating Bar - Offset"</summary>
        PATH_REIN_ALT_OFFSET = -1018321, // 0xFFF0762F
        /// <summary>"Alternating Bar - End Hook Orientation"</summary>
        PATH_REIN_END_HOOK_ORIENT_2_WALL = -1018320, // 0xFFF07630
        /// <summary>"Primary Bar - End Hook Orientation"</summary>
        PATH_REIN_END_HOOK_ORIENT_1_WALL = -1018319, // 0xFFF07631
        /// <summary>"Alternating Bar - End Hook Orientation"</summary>
        PATH_REIN_END_HOOK_ORIENT_2_SLAB = -1018318, // 0xFFF07632
        /// <summary>"Primary Bar - End Hook Orientation"</summary>
        PATH_REIN_END_HOOK_ORIENT_1_SLAB = -1018317, // 0xFFF07633
        /// <summary>"Alternating Bar - End Hook Type"</summary>
        PATH_REIN_END_HOOK_TYPE_2 = -1018316, // 0xFFF07634
        /// <summary>"Primary Bar - End Hook Type"</summary>
        PATH_REIN_END_HOOK_TYPE_1 = -1018315, // 0xFFF07635
        /// <summary>"Alternating Bar - Hook Orientation"</summary>
        PATH_REIN_HOOK_ORIENT_2_WALL = -1018314, // 0xFFF07636
        /// <summary>"Primary Bar - Hook Orientation"</summary>
        PATH_REIN_HOOK_ORIENT_1_WALL = -1018313, // 0xFFF07637
        /// <summary>"Alternating Bar - Hook Orientation"</summary>
        PATH_REIN_HOOK_ORIENT_2_SLAB = -1018312, // 0xFFF07638
        /// <summary>"Primary Bar - Hook Orientation"</summary>
        PATH_REIN_HOOK_ORIENT_1_SLAB = -1018311, // 0xFFF07639
        /// <summary>"Alternating Bar - Start Hook Type"</summary>
        PATH_REIN_HOOK_TYPE_2 = -1018310, // 0xFFF0763A
        /// <summary>"Primary Bar - Start Hook Type"</summary>
        PATH_REIN_HOOK_TYPE_1 = -1018309, // 0xFFF0763B
        /// <summary>"Alternating Bar - Length"</summary>
        PATH_REIN_LENGTH_2 = -1018308, // 0xFFF0763C
        /// <summary>"Primary Bar - Length"</summary>
        PATH_REIN_LENGTH_1 = -1018307, // 0xFFF0763D
        /// <summary>"Alternating Bar - Type"</summary>
        PATH_REIN_TYPE_2 = -1018306, // 0xFFF0763E
        /// <summary>"Primary Bar - Type"</summary>
        PATH_REIN_TYPE_1 = -1018305, // 0xFFF0763F
        /// <summary>"Alternating Bars"</summary>
        PATH_REIN_ALTERNATING = -1018304, // 0xFFF07640
        /// <summary>"Number Of Bars"</summary>
        PATH_REIN_NUMBER_OF_BARS = -1018303, // 0xFFF07641
        /// <summary>"Bar Spacing"</summary>
        PATH_REIN_SPACING = -1018302, // 0xFFF07642
        /// <summary>"Face"</summary>
        PATH_REIN_FACE_WALL = -1018301, // 0xFFF07643
        /// <summary>"Face"</summary>
        PATH_REIN_FACE_SLAB = -1018300, // 0xFFF07644
        /// <summary>"Deformation"</summary>
        REBAR_BAR_DEFORMATION_TYPE = -1018274, // 0xFFF0765E
        /// <summary>"Bottom/Interior Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_BOTTOM_DIR_2_GENERIC = -1018273, // 0xFFF0765F
        /// <summary>"Bottom/Interior Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_BOTTOM_DIR_1_GENERIC = -1018272, // 0xFFF07660
        /// <summary>"Top/Exterior Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_TOP_DIR_2_GENERIC = -1018271, // 0xFFF07661
        /// <summary>"Top/Exterior Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_TOP_DIR_1_GENERIC = -1018270, // 0xFFF07662
        /// <summary>"Bottom/Interior Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_2_GENERIC = -1018269, // 0xFFF07663
        /// <summary>"Bottom/Interior Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_1_GENERIC = -1018268, // 0xFFF07664
        /// <summary>"Top/Exterior Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_2_GENERIC = -1018267, // 0xFFF07665
        /// <summary>"Top/Exterior Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_1_GENERIC = -1018266, // 0xFFF07666
        /// <summary>"Bottom/Interior Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_2_GENERIC = -1018257, // 0xFFF0766F
        /// <summary>"Bottom/Interior Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_1_GENERIC = -1018256, // 0xFFF07670
        /// <summary>"Top/Exterior Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_TOP_DIR_2_GENERIC = -1018255, // 0xFFF07671
        /// <summary>"Top/Exterior Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_TOP_DIR_1_GENERIC = -1018254, // 0xFFF07672
        /// <summary>"Bottom/Interior Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_2_GENERIC = -1018253, // 0xFFF07673
        /// <summary>"Bottom/Interior Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_1_GENERIC = -1018252, // 0xFFF07674
        /// <summary>"Top/Exterior Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_TOP_DIR_2_GENERIC = -1018251, // 0xFFF07675
        /// <summary>"Top/Exterior Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_TOP_DIR_1_GENERIC = -1018250, // 0xFFF07676
        /// <summary>"Interior Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_BACK_DIR_2 = -1018225, // 0xFFF0768F
        /// <summary>"Interior Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_BACK_DIR_1 = -1018224, // 0xFFF07690
        /// <summary>"Exterior Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_FRONT_DIR_2 = -1018223, // 0xFFF07691
        /// <summary>"Exterior Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_FRONT_DIR_1 = -1018222, // 0xFFF07692
        /// <summary>"Interior Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BACK_DIR_2 = -1018221, // 0xFFF07693
        /// <summary>"Interior Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BACK_DIR_1 = -1018220, // 0xFFF07694
        /// <summary>"Exterior Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_FRONT_DIR_2 = -1018219, // 0xFFF07695
        /// <summary>"Exterior Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_FRONT_DIR_1 = -1018218, // 0xFFF07696
        /// <summary>"Interior Minor Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_BACK_DIR_2 = -1018217, // 0xFFF07697
        /// <summary>"Interior Major Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_BACK_DIR_1 = -1018216, // 0xFFF07698
        /// <summary>"Exterior Minor Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_FRONT_DIR_2 = -1018215, // 0xFFF07699
        /// <summary>"Exterior Major Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_FRONT_DIR_1 = -1018214, // 0xFFF0769A
        /// <summary>"Interior Minor Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_BACK_DIR_2 = -1018213, // 0xFFF0769B
        /// <summary>"Interior Major Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_BACK_DIR_1 = -1018212, // 0xFFF0769C
        /// <summary>"Exterior Minor Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_FRONT_DIR_2 = -1018211, // 0xFFF0769D
        /// <summary>"Exterior Major Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_FRONT_DIR_1 = -1018210, // 0xFFF0769E
        /// <summary>"Interior Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BACK_DIR_2 = -1018209, // 0xFFF0769F
        /// <summary>"Interior Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BACK_DIR_1 = -1018208, // 0xFFF076A0
        /// <summary>"Exterior Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_FRONT_DIR_2 = -1018207, // 0xFFF076A1
        /// <summary>"Exterior Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_FRONT_DIR_1 = -1018206, // 0xFFF076A2
        /// <summary>"Interior Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BACK_DIR_2 = -1018205, // 0xFFF076A3
        /// <summary>"Interior Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BACK_DIR_1 = -1018204, // 0xFFF076A4
        /// <summary>"Exterior Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_FRONT_DIR_2 = -1018203, // 0xFFF076A5
        /// <summary>"Exterior Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_FRONT_DIR_1 = -1018200, // 0xFFF076A8
        /// <summary>"Bottom Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_BOTTOM_DIR_2 = -1018124, // 0xFFF076F4
        /// <summary>"Bottom Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_BOTTOM_DIR_1 = -1018123, // 0xFFF076F5
        /// <summary>"Top Minor Spacing"</summary>
        REBAR_SYSTEM_SPACING_TOP_DIR_2 = -1018122, // 0xFFF076F6
        /// <summary>"Top Major Spacing"</summary>
        REBAR_SYSTEM_SPACING_TOP_DIR_1 = -1018121, // 0xFFF076F7
        /// <summary>"Bottom Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_2 = -1018120, // 0xFFF076F8
        /// <summary>"Bottom Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_BOTTOM_DIR_1 = -1018119, // 0xFFF076F9
        /// <summary>"Top Minor Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_2 = -1018118, // 0xFFF076FA
        /// <summary>"Top Major Number Of Lines"</summary>
        REBAR_SYSTEM_NUMBER_OF_LINES_TOP_DIR_1 = -1018117, // 0xFFF076FB
        /// <summary>"Bottom Minor Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_BOTTOM_DIR_2 = -1018116, // 0xFFF076FC
        /// <summary>"Bottom Major Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_BOTTOM_DIR_1 = -1018115, // 0xFFF076FD
        /// <summary>"Top Minor Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_TOP_DIR_2 = -1018114, // 0xFFF076FE
        /// <summary>"Top Major Hook Type"</summary>
        REBAR_SYSTEM_HOOK_TYPE_TOP_DIR_1 = -1018113, // 0xFFF076FF
        /// <summary>"Bottom Minor Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_BOTTOM_DIR_2 = -1018112, // 0xFFF07700
        /// <summary>"Bottom Major Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_BOTTOM_DIR_1 = -1018111, // 0xFFF07701
        /// <summary>"Top Minor Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_TOP_DIR_2 = -1018110, // 0xFFF07702
        /// <summary>"Top Major Hook Orientation"</summary>
        REBAR_SYSTEM_HOOK_ORIENT_TOP_DIR_1 = -1018109, // 0xFFF07703
        /// <summary>"Bottom Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_2 = -1018108, // 0xFFF07704
        /// <summary>"Bottom Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_BOTTOM_DIR_1 = -1018107, // 0xFFF07705
        /// <summary>"Top Minor Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_TOP_DIR_2 = -1018106, // 0xFFF07706
        /// <summary>"Top Major Bar Type"</summary>
        REBAR_SYSTEM_BAR_TYPE_TOP_DIR_1 = -1018105, // 0xFFF07707
        /// <summary>"Bottom Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_2 = -1018104, // 0xFFF07708
        /// <summary>"Bottom Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_BOTTOM_DIR_1 = -1018103, // 0xFFF07709
        /// <summary>"Top Minor Direction"</summary>
        REBAR_SYSTEM_ACTIVE_TOP_DIR_2 = -1018102, // 0xFFF0770A
        /// <summary>"Top Major Direction"</summary>
        REBAR_SYSTEM_ACTIVE_TOP_DIR_1 = -1018100, // 0xFFF0770C
        /// <summary>"Hook Angle Top"</summary>
        REBAR_SYSTEM_SPANHOOK_TOP_DIR_2 = -1018055, // 0xFFF07739
        /// <summary>"Hook Angle Bottom"</summary>
        REBAR_SYSTEM_SPANHOOK_BOTTOM_DIR_2 = -1018054, // 0xFFF0773A
        /// <summary>"Hook Angle Right"</summary>
        REBAR_SYSTEM_SPANHOOK_RIGHT_DIR_1 = -1018053, // 0xFFF0773B
        /// <summary>"Hook Angle Left"</summary>
        REBAR_SYSTEM_SPANHOOK_LEFT_DIR_1 = -1018052, // 0xFFF0773C
        /// <summary>"Bars In Minor Direction"</summary>
        REBAR_SYSTEM_SPANACTIVE_DIR_2 = -1018051, // 0xFFF0773D
        /// <summary>"Bars In Major Direction"</summary>
        REBAR_SYSTEM_SPANACTIVE_DIR_1 = -1018050, // 0xFFF0773E
        /// <summary>"Additional Interior Cover Offset"</summary>
        REBAR_SYSTEM_ADDL_INTERIOR_OFFSET = -1018027, // 0xFFF07755
        /// <summary>"Additional Exterior Cover Offset"</summary>
        REBAR_SYSTEM_ADDL_EXTERIOR_OFFSET = -1018026, // 0xFFF07756
        /// <summary>"Additional Bottom Cover Offset"</summary>
        REBAR_SYSTEM_ADDL_BOTTOM_OFFSET = -1018025, // 0xFFF07757
        /// <summary>"Additional Top Cover Offset"</summary>
        REBAR_SYSTEM_ADDL_TOP_OFFSET = -1018024, // 0xFFF07758
        /// <summary>"Top and Bottom Minor Layers Match"</summary>
        REBAR_SYSTEM_TOP_MINOR_MATCHES_BOTTOM_MINOR = -1018023, // 0xFFF07759
        /// <summary>"Top and Bottom Major Layers Match"</summary>
        REBAR_SYSTEM_TOP_MAJOR_MATCHES_BOTTOM_MAJOR = -1018022, // 0xFFF0775A
        /// <summary>"Bottom Major and Minor Layers Match"</summary>
        REBAR_SYSTEM_BOTTOM_MAJOR_MATCHES_BOTTOM_MINOR = -1018021, // 0xFFF0775B
        /// <summary>"Top Major and Minor Layers Match"</summary>
        REBAR_SYSTEM_TOP_MAJOR_MATCHES_TOP_MINOR = -1018020, // 0xFFF0775C
        /// <summary>"Minor, Both Faces (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_DIR_2_NO_SPACING = -1018019, // 0xFFF0775D
        /// <summary>"Minor, Both Faces"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_DIR_2_WITH_SPACING = -1018018, // 0xFFF0775E
        /// <summary>"Major, Both Faces (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_DIR_1_NO_SPACING = -1018017, // 0xFFF0775F
        /// <summary>"Major, Both Faces"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_DIR_1_WITH_SPACING = -1018016, // 0xFFF07760
        /// <summary>"Bottom/Interior Minor (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_2_NO_SPACING = -1018015, // 0xFFF07761
        /// <summary>"Bottom/Interior Minor"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_2_WITH_SPACING = -1018014, // 0xFFF07762
        /// <summary>"Bottom/Interior Major (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_1_NO_SPACING = -1018013, // 0xFFF07763
        /// <summary>"Bottom/Interior Major"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_BOTTOM_DIR_1_WITH_SPACING = -1018012, // 0xFFF07764
        /// <summary>"Top/Exterior Minor (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_2_NO_SPACING = -1018011, // 0xFFF07765
        /// <summary>"Top/Exterior Minor"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_2_WITH_SPACING = -1018010, // 0xFFF07766
        /// <summary>"Top/Exterior Major (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_1_NO_SPACING = -1018009, // 0xFFF07767
        /// <summary>"Top/Exterior Major"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_TOP_DIR_1_WITH_SPACING = -1018008, // 0xFFF07768
        /// <summary>"Rebar Cover Bottom/Interior"</summary>
        REBAR_SYSTEM_COVER_BOTTOM = -1018007, // 0xFFF07769
        /// <summary>"Rebar Cover Top/Exterior"</summary>
        REBAR_SYSTEM_COVER_TOP = -1018006, // 0xFFF0776A
        /// <summary>"Override Area Reinforcement Settings"</summary>
        REBAR_SYSTEM_OVERRIDE = -1018005, // 0xFFF0776B
        /// <summary>"Layer Summary (Brief)"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_NO_SPACING = -1018003, // 0xFFF0776D
        /// <summary>"Layer Summary"</summary>
        REBAR_SYSTEM_LAYER_SUMMARY_WITH_SPACING = -1018002, // 0xFFF0776E
        /// <summary>"Layout Rule"</summary>
        REBAR_SYSTEM_LAYOUT_RULE = -1018001, // 0xFFF0776F
        /// <summary>"Rebar Cover Side/Edge"</summary>
        REBAR_SYSTEM_COVER_SIDE = -1018000, // 0xFFF07770
        /// <summary>"Offset along wire direction": Offset along wire direction</summary>
        FABRIC_WIRE_OFFSET = -1017739, // 0xFFF07875
        /// <summary>"Wire distance": The distance between wires</summary>
        FABRIC_WIRE_DISTANCE = -1017738, // 0xFFF07876
        /// <summary>"Wire length": The wire length</summary>
        FABRIC_WIRE_LENGTH = -1017737, // 0xFFF07877
        /// <summary>"Wire type": The wire type assigned</summary>
        FABRIC_WIRE_TYPE = -1017736, // 0xFFF07878
        /// <summary>"Longitudinal Cut Length": Bent fabric longitudinal cut length.</summary>
        BENT_FABRIC_PARAM_LONGITUDINAL_CUT_LENGTH = -1017734, // 0xFFF0787A
        /// <summary>"Shared family key"</summary>
        FABRIC_PARAM_SHARED_FAMILY_KEY = -1017733, // 0xFFF0787B
        /// <summary>
        ///    "Cut by Host Cover": Single Fabric Sheet is cut or not cut by the Host Cover.
        /// </summary>
        FABRIC_PARAM_CUT_BY_HOST = -1017732, // 0xFFF0787C
        /// <summary>"Straight Wires Location": Location of straight wires in a bent fabric.</summary>
        BENT_FABRIC_PARAM_STRAIGHT_WIRES_LOCATION = -1017731, // 0xFFF0787D
        /// <summary>"Fixed offset"</summary>
        CONSTRAINT_FIXED_OFFSET = -1017730, // 0xFFF0787E
        /// <summary>"Bend Direction": Direction in which FabricSheet is bent.</summary>
        BENT_FABRIC_PARAM_BEND_DIRECTION = -1017729, // 0xFFF0787F
        /// <summary>"Tag Component Reference"</summary>
        FABRIC_PARAM_SPAN_TAG_COMPONENT_REFERENCE = -1017728, // 0xFFF07880
        /// <summary>"D_Right"</summary>
        FABRIC_PARAM_SPAN_SYM_D_RIGHT = -1017727, // 0xFFF07881
        /// <summary>"D_Left"</summary>
        FABRIC_PARAM_SPAN_SYM_D_LEFT = -1017726, // 0xFFF07882
        /// <summary>"D_Bottom"</summary>
        FABRIC_PARAM_SPAN_SYM_D_BOTTOM = -1017725, // 0xFFF07883
        /// <summary>"D_Top"</summary>
        FABRIC_PARAM_SPAN_SYM_D_TOP = -1017724, // 0xFFF07884
        /// <summary>"Right"</summary>
        FABRIC_PARAM_SPAN_SYM_RIGHT = -1017723, // 0xFFF07885
        /// <summary>"Left"</summary>
        FABRIC_PARAM_SPAN_SYM_LEFT = -1017722, // 0xFFF07886
        /// <summary>"Bottom"</summary>
        FABRIC_PARAM_SPAN_SYM_BOTTOM = -1017721, // 0xFFF07887
        /// <summary>"Top"</summary>
        FABRIC_PARAM_SPAN_SYM_TOP = -1017720, // 0xFFF07888
        /// <summary>"Tag new members in view": List of all Plan Views and None.</summary>
        FABRIC_PARAM_TAG_VIEW = -1017713, // 0xFFF0788F
        /// <summary>
        ///    "Cut Sheet Mass": Calculated cut sheet mass [Sheet Mass per Unit Area * (Cut Overall Length * Cut Overall Width)]
        /// </summary>
        FABRIC_PARAM_CUT_SHEET_MASS = -1017712, // 0xFFF07890
        /// <summary>
        ///    "Total Sheet Mass": Calculated all sheet mass: Volume of Wire * Unit Weight.
        /// </summary>
        FABRIC_PARAM_TOTAL_SHEET_MASS = -1017711, // 0xFFF07891
        /// <summary>"Cut Overall Width": Provides a real sheet Width after definition</summary>
        FABRIC_PARAM_CUT_OVERALL_WIDTH = -1017710, // 0xFFF07892
        /// <summary>"Cut Overall Length": Provides a real sheet Length after definition</summary>
        FABRIC_PARAM_CUT_OVERALL_LENGTH = -1017709, // 0xFFF07893
        /// <summary>
        ///    "Additional Cover Offset": Additional cover offset of the fabric distribution.
        /// </summary>
        FABRIC_PARAM_COVER_OFFSET = -1017708, // 0xFFF07894
        /// <summary>
        ///    "Minor Lap Splice Length": Fabric lap splice length in minor direction in the fabric distribution.
        /// </summary>
        FABRIC_PARAM_MINOR_LAPSPLICE_LENGTH = -1017707, // 0xFFF07895
        /// <summary>
        ///    "Major Lap Splice Length": Fabric lap splice length in major direction in the fabric distribution.
        /// </summary>
        FABRIC_PARAM_MAJOR_LAPSPLICE_LENGTH = -1017706, // 0xFFF07896
        /// <summary>"Location": Fabric location in the host.</summary>
        FABRIC_PARAM_LOCATION_GENERIC = -1017705, // 0xFFF07897
        /// <summary>
        ///    "Lap Splice Position": Fabric lap splice position in the fabric distribution
        /// </summary>
        FABRIC_PARAM_LAPSPLICE_POSITION = -1017704, // 0xFFF07898
        /// <summary>"Location": Fabric location in the wall</summary>
        FABRIC_PARAM_LOCATION_WALL = -1017703, // 0xFFF07899
        /// <summary>"Location": Fabric location in the slab</summary>
        FABRIC_PARAM_LOCATION_SLAB = -1017702, // 0xFFF0789A
        /// <summary>"Fabric Sheet": List all Fabric Sheet types</summary>
        FABRIC_PARAM_SHEET_TYPE = -1017701, // 0xFFF0789B
        /// <summary>"Bend Diameter": Standard Bend Diameter of Fabric Wire.</summary>
        FABRIC_BEND_DIAMETER = -1017625, // 0xFFF078E7
        /// <summary>
        ///    "Sheet Mass per Unit Area": Structural Sheet Mass per Unit Area  [Sheet Mass / (Overall Length * Overall Width)]
        /// </summary>
        FABRIC_SHEET_MASSUNIT = -1017624, // 0xFFF078E8
        /// <summary>"Minor Reinforcement Area": Minor Reinforcement Area</summary>
        FABRIC_SHEET_MINOR_REINFORCEMENT_AREA = -1017623, // 0xFFF078E9
        /// <summary>"Major Reinforcement Area": Major Reinforcement Area</summary>
        FABRIC_SHEET_MAJOR_REINFORCEMENT_AREA = -1017622, // 0xFFF078EA
        /// <summary>"Sheet Mass": Sheet Mass</summary>
        FABRIC_SHEET_MASS = -1017621, // 0xFFF078EB
        /// <summary>"Minor Spacing": Minor Spacing</summary>
        FABRIC_SHEET_MINOR_SPACING = -1017620, // 0xFFF078EC
        /// <summary>"Minor Number of Wires": Minor Number of Wires</summary>
        FABRIC_SHEET_MINOR_NUMBER_OF_WIRES = -1017619, // 0xFFF078ED
        /// <summary>"Minor Layout Pattern": Minor Layout Pattern</summary>
        FABRIC_SHEET_MINOR_LAYOUT_PATTERN = -1017618, // 0xFFF078EE
        /// <summary>"Minor End Overhang": Minor End Overhang</summary>
        FABRIC_SHEET_MINOR_END_OVERHANG = -1017617, // 0xFFF078EF
        /// <summary>"Minor Start Overhang": Minor Start Overhang</summary>
        FABRIC_SHEET_MINOR_START_OVERHANG = -1017616, // 0xFFF078F0
        /// <summary>"Width": Width</summary>
        FABRIC_SHEET_WIDTH = -1017615, // 0xFFF078F1
        /// <summary>"Overall Width": Overall Width</summary>
        FABRIC_SHEET_OVERALL_WIDTH = -1017614, // 0xFFF078F2
        /// <summary>"Major Spacing": Major Spacing</summary>
        FABRIC_SHEET_MAJOR_SPACING = -1017613, // 0xFFF078F3
        /// <summary>"Major Number of Wires": Major Number of Wires</summary>
        FABRIC_SHEET_MAJOR_NUMBER_OF_WIRES = -1017612, // 0xFFF078F4
        /// <summary>"Major Layout Pattern": Major Layout Pattern</summary>
        FABRIC_SHEET_MAJOR_LAYOUT_PATTERN = -1017611, // 0xFFF078F5
        /// <summary>"Major End Overhang": Major End Overhang</summary>
        FABRIC_SHEET_MAJOR_END_OVERHANG = -1017610, // 0xFFF078F6
        /// <summary>"Major Start Overhang": Major Start Overhang</summary>
        FABRIC_SHEET_MAJOR_START_OVERHANG = -1017609, // 0xFFF078F7
        /// <summary>"Length": Length</summary>
        FABRIC_SHEET_LENGTH = -1017608, // 0xFFF078F8
        /// <summary>"Overall Length": Overall Length</summary>
        FABRIC_SHEET_OVERALL_LENGTH = -1017607, // 0xFFF078F9
        /// <summary>"Default Minor Lap Splice Length": Default Minor Lap Splice Length</summary>
        FABRIC_SHEET_DEFAULT_MINOR_LAPSPLICE_LENGTH = -1017606, // 0xFFF078FA
        /// <summary>"Default Major Lap Splice Length": Default Major Lap Splice Length</summary>
        FABRIC_SHEET_DEFAULT_MAJOR_LAPSPLICE_LENGTH = -1017605, // 0xFFF078FB
        /// <summary>"Minor Direction Wire Type": Minor Direction Wire Type</summary>
        FABRIC_SHEET_MINOR_DIRECTION_WIRE_TYPE = -1017604, // 0xFFF078FC
        /// <summary>"Major Direction Wire Type": Major Direction Wire Type</summary>
        FABRIC_SHEET_MAJOR_DIRECTION_WIRE_TYPE = -1017603, // 0xFFF078FD
        /// <summary>"Physical Material Asset": Physical Material Asset</summary>
        FABRIC_SHEET_PHYSICAL_MATERIAL_ASSET = -1017602, // 0xFFF078FE
        /// <summary>"Nominal Diameter": Nominal Diameter of Fabric Wire.</summary>
        FABRIC_WIRE_DIAMETER = -1017601, // 0xFFF078FF
        /// <summary>"Quantity By Rebar Set"</summary>
        REBAR_QUANITY_BY_DISTRIB = -1017065, // 0xFFF07B17
        /// <summary>"Minimum bar length"</summary>
        REBAR_MIN_LENGTH = -1017064, // 0xFFF07B18
        /// <summary>"Maximum bar length"</summary>
        REBAR_MAX_LENGTH = -1017063, // 0xFFF07B19
        /// <summary>"Maxim Suffix"</summary>
        REBAR_MAXIM_SUFFIX = -1017062, // 0xFFF07B1A
        /// <summary>"Minim Suffix"</summary>
        REBAR_MINIM_SUFFIX = -1017061, // 0xFFF07B1B
        /// <summary>"Rebar Number Suffix"</summary>
        REBAR_NUMBER_SUFFIX = -1017060, // 0xFFF07B1C
        /// <summary>"Distribution Type"</summary>
        REBAR_DISTRIBUTION_TYPE = -1017057, // 0xFFF07B1F
        /// <summary>"Can host rebar"</summary>
        DPART_CAN_HOST_REBAR = -1017056, // 0xFFF07B20
        /// <summary>"Host Category"</summary>
        REBAR_HOST_CATEGORY = -1017055, // 0xFFF07B21
        /// <summary>"End Tangent Hook Length"</summary>
        REBAR_SHAPE_PARAM_END_HOOK_TAN_LEN = -1017054, // 0xFFF07B22
        /// <summary>"Start Tangent Hook Length"</summary>
        REBAR_SHAPE_PARAM_START_HOOK_TAN_LEN = -1017053, // 0xFFF07B23
        /// <summary>"INTERNAL: Multiplanar End Connector"</summary>
        REBAR_INTERNAL_MULTIPLANAR_END_CONNECTOR = -1017052, // 0xFFF07B24
        /// <summary>"INTERNAL: Multiplanar Start Connector"</summary>
        REBAR_INTERNAL_MULTIPLANAR_START_CONNECTOR = -1017051, // 0xFFF07B25
        /// <summary>"INTERNAL: Multiplanar Duplicate"</summary>
        REBAR_INTERNAL_MULTIPLANAR_DUPLICATE = -1017050, // 0xFFF07B26
        /// <summary>"INTERNAL: Multiplanar"</summary>
        REBAR_INTERNAL_MULTIPLANAR = -1017049, // 0xFFF07B27
        /// <summary>"Out of Plane Bend Diameter"</summary>
        REBAR_SHAPE_OUT_OF_PLANE_BEND_DIAMETER = -1017048, // 0xFFF07B28
        /// <summary>"Stirrup/Tie Attachment"</summary>
        REBAR_INSTANCE_STIRRUP_TIE_ATTACHMENT = -1017047, // 0xFFF07B29
        /// <summary>"Stirrup/Tie Attachment"</summary>
        REBAR_SHAPE_STIRRUP_TIE_ATTACHMENT = -1017046, // 0xFFF07B2A
        /// <summary>"Base Finishing Turns"</summary>
        REBAR_SHAPE_SPIRAL_BASE_FINISHING_TURNS = -1017045, // 0xFFF07B2B
        /// <summary>"Top Finishing Turns"</summary>
        REBAR_SHAPE_SPIRAL_TOP_FINISHING_TURNS = -1017044, // 0xFFF07B2C
        /// <summary>"Height"</summary>
        REBAR_SHAPE_SPIRAL_HEIGHT = -1017043, // 0xFFF07B2D
        /// <summary>"Pitch"</summary>
        REBAR_SHAPE_SPIRAL_PITCH = -1017042, // 0xFFF07B2E
        /// <summary>"Standard Hook Bend Diameter"</summary>
        REBAR_STANDARD_HOOK_BEND_DIAMETER = -1017041, // 0xFFF07B2F
        /// <summary>"Include Last Bar"</summary>
        REBAR_INCLUDE_LAST_BAR = -1017040, // 0xFFF07B30
        /// <summary>"Include First Bar"</summary>
        REBAR_INCLUDE_FIRST_BAR = -1017039, // 0xFFF07B31
        /// <summary>"Bend Diameter"</summary>
        REBAR_INSTANCE_BEND_DIAMETER = -1017038, // 0xFFF07B32
        /// <summary>"Bar Diameter"</summary>
        REBAR_INSTANCE_BAR_DIAMETER = -1017037, // 0xFFF07B33
        /// <summary>"End Hook Offset Length"</summary>
        REBAR_SHAPE_END_HOOK_OFFSET = -1017036, // 0xFFF07B34
        /// <summary>"End Hook Length"</summary>
        REBAR_SHAPE_END_HOOK_LENGTH = -1017035, // 0xFFF07B35
        /// <summary>"Start Hook Offset Length"</summary>
        REBAR_SHAPE_START_HOOK_OFFSET = -1017034, // 0xFFF07B36
        /// <summary>"Start Hook Length"</summary>
        REBAR_SHAPE_START_HOOK_LENGTH = -1017033, // 0xFFF07B37
        /// <summary>"Schedule Mark"</summary>
        REBAR_ELEM_SCHEDULE_MARK = -1017032, // 0xFFF07B38
        /// <summary>"Rounding Overrides"</summary>
        FABRIC_PARAM_ROUNDING = -1017028, // 0xFFF07B3C
        /// <summary>"Rounding Overrides"</summary>
        REBAR_ELEMENT_ROUNDING = -1017027, // 0xFFF07B3D
        /// <summary>"Style"</summary>
        REBAR_ELEM_HOOK_STYLE = -1017026, // 0xFFF07B3E
        /// <summary>"Hook At End"</summary>
        REBAR_SHAPE_HOOK_END_TYPE = -1017024, // 0xFFF07B40
        /// <summary>"Hook At Start"</summary>
        REBAR_SHAPE_HOOK_START_TYPE = -1017023, // 0xFFF07B41
        /// <summary>"Style"</summary>
        REBAR_SHAPE_HOOK_STYLE = -1017022, // 0xFFF07B42
        /// <summary>"Allowable Rebar Bar Types"</summary>
        REBAR_BAR_ALLOWED_BAR_TYPES = -1017021, // 0xFFF07B43
        /// <summary>"Allowable Rebar Bar Types"</summary>
        REBAR_SHAPE_ALLOWED_BAR_TYPES = -1017021, // 0xFFF07B43
        /// <summary>"Maximum Bend Radius"</summary>
        REBAR_BAR_MAXIMUM_BEND_RADIUS = -1017020, // 0xFFF07B44
        /// <summary>"Stirrup/Tie Bend Diameter"</summary>
        REBAR_BAR_STIRRUP_BEND_DIAMETER = -1017019, // 0xFFF07B45
        /// <summary>"Hook Lengths"</summary>
        REBAR_BAR_HOOK_LENGTHS = -1017018, // 0xFFF07B46
        /// <summary>"Style"</summary>
        REBAR_HOOK_STYLE = -1017017, // 0xFFF07B47
        /// <summary>"Bar Length"</summary>
        REBAR_ELEM_LENGTH = -1017016, // 0xFFF07B48
        /// <summary>"Shape"</summary>
        REBAR_SHAPE = -1017015, // 0xFFF07B49
        /// <summary>"View Visibility States"</summary>
        REBAR_ELEMENT_VISIBILITY = -1017014, // 0xFFF07B4A
        /// <summary>"Spacing"</summary>
        REBAR_ELEM_BAR_SPACING = -1017013, // 0xFFF07B4B
        /// <summary>"Quantity"</summary>
        REBAR_ELEM_QUANTITY_OF_BARS = -1017012, // 0xFFF07B4C
        /// <summary>"Layout Rule"</summary>
        REBAR_ELEM_LAYOUT_RULE = -1017011, // 0xFFF07B4D
        /// <summary>"Standard Bend Diameter"</summary>
        REBAR_STANDARD_BEND_DIAMETER = -1017010, // 0xFFF07B4E
        /// <summary>"Hook Orientation At End"</summary>
        REBAR_ELEM_HOOK_END_ORIENT = -1017009, // 0xFFF07B4F
        /// <summary>"Hook At End"</summary>
        REBAR_ELEM_HOOK_END_TYPE = -1017008, // 0xFFF07B50
        /// <summary>"Hook Orientation At Start"</summary>
        REBAR_ELEM_HOOK_START_ORIENT = -1017007, // 0xFFF07B51
        /// <summary>"Hook At Start"</summary>
        REBAR_ELEM_HOOK_START_TYPE = -1017006, // 0xFFF07B52
        /// <summary>"Total Bar Length"</summary>
        REBAR_ELEM_TOTAL_LENGTH = -1017005, // 0xFFF07B53
        /// <summary>"Extension Multiplier"</summary>
        REBAR_HOOK_LINE_LEN_FACTOR = -1017004, // 0xFFF07B54
        /// <summary>"Hook Angle"</summary>
        REBAR_HOOK_ANGLE = -1017003, // 0xFFF07B55
        /// <summary>"Subcategory"</summary>
        REBAR_BAR_STYLE = -1017002, // 0xFFF07B56
        /// <summary>"Bar Diameter"</summary>
        REBAR_BAR_DIAMETER = -1017000, // 0xFFF07B58
        /// <summary>"Location line to align"</summary>
        WALL_ALIGN_KEY_REF_PARAM = -1016021, // 0xFFF07F2B
        /// <summary>"Copy openings"</summary>
        CWP_COPY_ROOF_INSERTS = -1016019, // 0xFFF07F2D
        /// <summary>"Copy openings/inserts"</summary>
        CWP_COPY_FLOOR_INSERTS = -1016018, // 0xFFF07F2E
        /// <summary>"Copy windows/doors/openings"</summary>
        CWP_COPY_WALL_INSERTS = -1016017, // 0xFFF07F2F
        /// <summary>"Parameters"</summary>
        CWP_LINKED_ROOM_PARAMS = -1016016, // 0xFFF07F30
        /// <summary>"Phases"</summary>
        CWP_LINKED_ROOM_PHASES = -1016015, // 0xFFF07F31
        /// <summary>"Reuse Grids with the same name"</summary>
        CWP_REUSE_GRIDS_SAME_NAME = -1016011, // 0xFFF07F35
        /// <summary>"Reuse Levels with the same name"</summary>
        CWP_REUSE_LEVELS_SAME_NAME = -1016010, // 0xFFF07F36
        /// <summary>"Split Columns by Levels"</summary>
        CWP_SPLIT_COLUMNS_AT_LEVELS = -1016009, // 0xFFF07F37
        /// <summary>"Reuse matching Grids"</summary>
        CWP_REUSE_EXISTING_GRIDS = -1016008, // 0xFFF07F38
        /// <summary>"Reuse matching Levels"</summary>
        CWP_REUSE_EXISTING_LEVELS = -1016007, // 0xFFF07F39
        /// <summary>"Offset Level"</summary>
        CWP_LEVEL_OFFSET = -1016006, // 0xFFF07F3A
        /// <summary>"Add suffix to Level Name"</summary>
        CWP_ADD_LEVEL_SUFFIX = -1016005, // 0xFFF07F3B
        /// <summary>"Add prefix to Level Name"</summary>
        CWP_ADD_LEVEL_PREFIX = -1016004, // 0xFFF07F3C
        /// <summary>"Add suffix to Grid Name"</summary>
        CWP_ADD_GRID_SUFFIX = -1016003, // 0xFFF07F3D
        /// <summary>"Add prefix to Grid Name"</summary>
        CWP_ADD_GRID_PREFIX = -1016002, // 0xFFF07F3E
        /// <summary>"Name"</summary>
        LOAD_USAGE_NAME = -1015259, // 0xFFF08225
        /// <summary>"Factor"</summary>
        LOAD_COMBINATION_FACTOR = -1015256, // 0xFFF08228
        /// <summary>"Name"</summary>
        LOAD_COMBINATION_NAME = -1015255, // 0xFFF08229
        /// <summary>"Name"</summary>
        LOAD_NATURE_NAME = -1015254, // 0xFFF0822A
        /// <summary>"Category"</summary>
        LOAD_CASE_SUBCATEGORY = -1015253, // 0xFFF0822B
        /// <summary>"Nature"</summary>
        LOAD_CASE_NATURE = -1015252, // 0xFFF0822C
        /// <summary>"Case Number"</summary>
        LOAD_CASE_NUMBER = -1015251, // 0xFFF0822D
        /// <summary>"Name"</summary>
        LOAD_CASE_NAME = -1015250, // 0xFFF0822E
        /// <summary>"Area force scale"</summary>
        LOAD_ATTR_AREA_FORCE_SCALE_FACTOR = -1015207, // 0xFFF08259
        /// <summary>"Linear force scale"</summary>
        LOAD_ATTR_LINEAR_FORCE_SCALE_FACTOR = -1015206, // 0xFFF0825A
        /// <summary>"Distance between arrows"</summary>
        LOAD_ARROW_SEPARATION = -1015205, // 0xFFF0825B
        /// <summary>"Moment scale"</summary>
        LOAD_ATTR_MOMENT_SCALE_FACTOR = -1015204, // 0xFFF0825C
        /// <summary>"Moment arrowhead (alternate)"</summary>
        LOAD_ATTR_MOMENT_ARROW_LINE = -1015203, // 0xFFF0825D
        /// <summary>"Moment arrowhead"</summary>
        LOAD_ATTR_MOMENT_ARROW_ARC = -1015202, // 0xFFF0825E
        /// <summary>"Force scale"</summary>
        LOAD_ATTR_FORCE_SCALE_FACTOR = -1015201, // 0xFFF0825F
        /// <summary>"Force arrowhead"</summary>
        LOAD_ATTR_FORCE_ARROW_TYPE = -1015200, // 0xFFF08260
        /// <summary>"Description"</summary>
        LOAD_DESCRIPTION = -1015084, // 0xFFF082D4
        /// <summary>"Comments"</summary>
        LOAD_COMMENTS = -1015083, // 0xFFF082D5
        /// <summary>"Nature"</summary>
        LOAD_CASE_NATURE_TEXT = -1015082, // 0xFFF082D6
        /// <summary>"All non 0 loads"</summary>
        LOAD_ALL_NON_0_LOADS = -1015080, // 0xFFF082D8
        /// <summary>"Projected Load"</summary>
        LOAD_AREA_IS_PROJECTED = -1015070, // 0xFFF082E2
        /// <summary>"Area"</summary>
        LOAD_AREA_AREA = -1015069, // 0xFFF082E3
        /// <summary>"Fz 3"</summary>
        LOAD_AREA_FORCE_FZ3 = -1015068, // 0xFFF082E4
        /// <summary>"Fy 3"</summary>
        LOAD_AREA_FORCE_FY3 = -1015067, // 0xFFF082E5
        /// <summary>"Fx 3"</summary>
        LOAD_AREA_FORCE_FX3 = -1015066, // 0xFFF082E6
        /// <summary>"Fz 2"</summary>
        LOAD_AREA_FORCE_FZ2 = -1015065, // 0xFFF082E7
        /// <summary>"Fy 2"</summary>
        LOAD_AREA_FORCE_FY2 = -1015064, // 0xFFF082E8
        /// <summary>"Fx 2"</summary>
        LOAD_AREA_FORCE_FX2 = -1015063, // 0xFFF082E9
        /// <summary>"Fz 1"</summary>
        LOAD_AREA_FORCE_FZ1 = -1015062, // 0xFFF082EA
        /// <summary>"Fy 1"</summary>
        LOAD_AREA_FORCE_FY1 = -1015061, // 0xFFF082EB
        /// <summary>"Fx 1"</summary>
        LOAD_AREA_FORCE_FX1 = -1015060, // 0xFFF082EC
        /// <summary>"Length"</summary>
        LOAD_LINEAR_LENGTH = -1015043, // 0xFFF082FD
        /// <summary>"Projected Load"</summary>
        LOAD_IS_PROJECTED = -1015042, // 0xFFF082FE
        /// <summary>"Mz 2"</summary>
        LOAD_MOMENT_MZ2 = -1015041, // 0xFFF082FF
        /// <summary>"My 2"</summary>
        LOAD_MOMENT_MY2 = -1015040, // 0xFFF08300
        /// <summary>"Mx 2"</summary>
        LOAD_MOMENT_MX2 = -1015039, // 0xFFF08301
        /// <summary>"Mz 1"</summary>
        LOAD_MOMENT_MZ1 = -1015038, // 0xFFF08302
        /// <summary>"My 1"</summary>
        LOAD_MOMENT_MY1 = -1015037, // 0xFFF08303
        /// <summary>"Mx 1"</summary>
        LOAD_MOMENT_MX1 = -1015036, // 0xFFF08304
        /// <summary>"Fz 2"</summary>
        LOAD_LINEAR_FORCE_FZ2 = -1015035, // 0xFFF08305
        /// <summary>"Fy 2"</summary>
        LOAD_LINEAR_FORCE_FY2 = -1015034, // 0xFFF08306
        /// <summary>"Fx 2"</summary>
        LOAD_LINEAR_FORCE_FX2 = -1015033, // 0xFFF08307
        /// <summary>"Fz 1"</summary>
        LOAD_LINEAR_FORCE_FZ1 = -1015032, // 0xFFF08308
        /// <summary>"Fy 1"</summary>
        LOAD_LINEAR_FORCE_FY1 = -1015031, // 0xFFF08309
        /// <summary>"Fx 1"</summary>
        LOAD_LINEAR_FORCE_FX1 = -1015030, // 0xFFF0830A
        /// <summary>"Mz"</summary>
        LOAD_MOMENT_MZ = -1015015, // 0xFFF08319
        /// <summary>"My"</summary>
        LOAD_MOMENT_MY = -1015014, // 0xFFF0831A
        /// <summary>"Mx"</summary>
        LOAD_MOMENT_MX = -1015013, // 0xFFF0831B
        /// <summary>"Fz"</summary>
        LOAD_FORCE_FZ = -1015012, // 0xFFF0831C
        /// <summary>"Fy"</summary>
        LOAD_FORCE_FY = -1015011, // 0xFFF0831D
        /// <summary>"Fx"</summary>
        LOAD_FORCE_FX = -1015010, // 0xFFF0831E
        /// <summary>"Is Hosted"</summary>
        LOAD_IS_HOSTED = -1015006, // 0xFFF08322
        /// <summary>"Is Reaction"</summary>
        LOAD_IS_REACTION = -1015005, // 0xFFF08323
        /// <summary>"Is created by API"</summary>
        LOAD_IS_CREATED_BY_API = -1015004, // 0xFFF08324
        /// <summary>"Uniform Load"</summary>
        LOAD_IS_UNIFORM = -1015003, // 0xFFF08325
        /// <summary>"Orient to"</summary>
        LOAD_USE_LOCAL_COORDINATE_SYSTEM = -1015001, // 0xFFF08327
        /// <summary>"Load Case"</summary>
        LOAD_CASE_ID = -1015000, // 0xFFF08328
        /// <summary>"Right"</summary>
        SPAN_DIR_SYM_PARAM_RIGHT = -1014004, // 0xFFF0870C
        /// <summary>"Left"</summary>
        SPAN_DIR_SYM_PARAM_LEFT = -1014003, // 0xFFF0870D
        /// <summary>"Bottom"</summary>
        SPAN_DIR_SYM_PARAM_BOTTOM = -1014002, // 0xFFF0870E
        /// <summary>"Top"</summary>
        SPAN_DIR_SYM_PARAM_TOP = -1014001, // 0xFFF0870F
        /// <summary>"Span Direction"</summary>
        SPAN_DIR_INST_PARAM_ANGLE = -1014000, // 0xFFF08710
        /// <summary>"Analytical Model Correct"</summary>
        ANALYTICAL_GEOMETRY_IS_VALID = -1013451, // 0xFFF08935
        /// <summary>"Physical Material Asset"</summary>
        STRUCTURAL_ASSET_PARAM = -1013450, // 0xFFF08936
        /// <summary>
        ///    "Code Checking": Used for Analytical wall, Analytical beam, Analytical column, Analytical floor, Analytical wall foundations, Analytical isolated foundations, Analytical foundations slab, Anaytical brace
        /// </summary>
        ANALYTICAL_MODEL_CODE_CHECKING = -1013447, // 0xFFF08939
        /// <summary>"Node Number": Used for nodes</summary>
        ANALYTICAL_MODEL_NODES_MARK = -1013446, // 0xFFF0893A
        /// <summary>"Foundation Number": Used for isolated, wall foundations</summary>
        ANALYTICAL_MODEL_FOUNDATIONS_MARK = -1013445, // 0xFFF0893B
        /// <summary>"Surface Number": Used for floors, slabs, walls</summary>
        ANALYTICAL_MODEL_SURFACE_ELEMENTS_MARK = -1013444, // 0xFFF0893C
        /// <summary>"Member Number": Used for beams, braces, columns</summary>
        ANALYTICAL_MODEL_STICK_ELEMENTS_MARK = -1013443, // 0xFFF0893D
        /// <summary>"Enable cutting in views"</summary>
        FAMILY_ENABLE_CUTTING_IN_VIEWS = -1013442, // 0xFFF0893E
        /// <summary>"Can host rebar"</summary>
        FAMILY_CAN_HOST_REBAR = -1013441, // 0xFFF0893F
        /// <summary>"Rebar Cover"</summary>
        CLEAR_COVER = -1013440, // 0xFFF08940
        /// <summary>"Rebar Cover - Bottom Face"</summary>
        CLEAR_COVER_BOTTOM = -1013439, // 0xFFF08941
        /// <summary>"Rebar Cover - Top Face"</summary>
        CLEAR_COVER_TOP = -1013438, // 0xFFF08942
        /// <summary>"Rebar Cover - Other Faces"</summary>
        CLEAR_COVER_OTHER = -1013437, // 0xFFF08943
        /// <summary>"Rebar Cover - Interior Face"</summary>
        CLEAR_COVER_INTERIOR = -1013436, // 0xFFF08944
        /// <summary>"Rebar Cover - Exterior Face"</summary>
        CLEAR_COVER_EXTERIOR = -1013435, // 0xFFF08945
        /// <summary>"Length"</summary>
        COVER_TYPE_LENGTH = -1013434, // 0xFFF08946
        /// <summary>"Name"</summary>
        COVER_TYPE_NAME = -1013433, // 0xFFF08947
        /// <summary>"Clear Spacing"</summary>
        JOIST_SYSTEM_CLEAR_SPACING_PARAM = -1013432, // 0xFFF08948
        /// <summary>"Fixed Spacing"</summary>
        JOIST_SYSTEM_FIXED_SPACING_PARAM = -1013431, // 0xFFF08949
        /// <summary>"Maximum Spacing"</summary>
        JOIST_SYSTEM_MAXIMUM_SPACING_PARAM = -1013430, // 0xFFF0894A
        /// <summary>"Wall offset"</summary>
        CURVE_EDGE_OFFSET = -1013429, // 0xFFF0894B
        /// <summary>"3D"</summary>
        BEAM_SYSTEM_3D_PARAM = -1013427, // 0xFFF0894D
        /// <summary>"Beam Type (No Family Name)"</summary>
        JOIST_SYSTEM_NEW_BEAM_TYPE_NO_FAM_NAME_PARAM = -1013419, // 0xFFF08955
        /// <summary>"Beam System Tag Direction"</summary>
        BEAM_SYSTEM_TAG_INST_PARAM_ANGLE = -1013418, // 0xFFF08956
        /// <summary>"Right"</summary>
        BEAM_SYSTEM_TAG_PARAM_RIGHT = -1013417, // 0xFFF08957
        /// <summary>"Left"</summary>
        BEAM_SYSTEM_TAG_PARAM_LEFT = -1013416, // 0xFFF08958
        /// <summary>"Num. of Beams With Same Type"</summary>
        JOIST_SYSTEM_NUM_BEAMS_SAME_TYPE = -1013415, // 0xFFF08959
        /// <summary>"Lateral Justification"</summary>
        BEAM_H_JUSTIFICATION = -1013414, // 0xFFF0895A
        /// <summary>"z-Direction Justification"</summary>
        BEAM_V_JUSTIFICATION = -1013413, // 0xFFF0895B
        /// <summary>"Wall offset"</summary>
        CURVE_SUPPORT_OFFSET = -1013412, // 0xFFF0895C
        /// <summary>"Beam Type"</summary>
        JOIST_SYSTEM_NEW_BEAM_TYPE_PARAM = -1013411, // 0xFFF0895D
        /// <summary>"Layout Rule"</summary>
        JOIST_SYSTEM_LAYOUT_RULE_PARAM = -1013410, // 0xFFF0895E
        /// <summary>"Justification"</summary>
        JOIST_SYSTEM_JUSTIFICATION_PARAM = -1013409, // 0xFFF0895F
        /// <summary>"Centerline Spacing"</summary>
        JOIST_SYSTEM_SPACING_PARAM = -1013408, // 0xFFF08960
        /// <summary>"Number of Lines"</summary>
        JOIST_SYSTEM_NUMBER_OF_LINES_PARAM = -1013407, // 0xFFF08961
        /// <summary>"Flow"</summary>
        RBS_DUCT_FLOW_PARAM = -1013405, // 0xFFF08963
        /// <summary>"Belt Measurement"</summary>
        CURTAINGRID_BELT_RATIO_V = -1013391, // 0xFFF08971
        /// <summary>"Belt Measurement"</summary>
        CURTAINGRID_BELT_RATIO_U = -1013390, // 0xFFF08972
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_V = -1013389, // 0xFFF08973
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_U = -1013388, // 0xFFF08974
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_V = -1013387, // 0xFFF08975
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_U = -1013386, // 0xFFF08976
        /// <summary>"Belt Measurement"</summary>
        CURTAINGRID_BELT_V = -1013385, // 0xFFF08977
        /// <summary>"Belt Measurement"</summary>
        CURTAINGRID_BELT_U = -1013384, // 0xFFF08978
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_V = -1013383, // 0xFFF08979
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_U = -1013382, // 0xFFF0897A
        /// <summary>"Grid Rotation"</summary>
        CURTAINGRID_ANGLE_V = -1013380, // 0xFFF0897C
        /// <summary>"Grid Rotation"</summary>
        CURTAINGRID_ANGLE_U = -1013379, // 0xFFF0897D
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_V = -1013377, // 0xFFF0897F
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_U = -1013376, // 0xFFF08980
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_V = -1013375, // 0xFFF08981
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_U = -1013374, // 0xFFF08982
        /// <summary>"Distance"</summary>
        SPACING_LENGTH_V = -1013373, // 0xFFF08983
        /// <summary>"Distance"</summary>
        SPACING_LENGTH_U = -1013372, // 0xFFF08984
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_V = -1013371, // 0xFFF08985
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_U = -1013370, // 0xFFF08986
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_RATIO_2 = -1013369, // 0xFFF08987
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_RATIO_1 = -1013368, // 0xFFF08988
        /// <summary>"Curtain version"</summary>
        CURTAIN_VERSION_PARAM = -1013367, // 0xFFF08989
        /// <summary>"Padding"</summary>
        PADDING_LENGTH = -1013366, // 0xFFF0898A
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST = -1013354, // 0xFFF08996
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION = -1013353, // 0xFFF08997
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS = -1013352, // 0xFFF08998
        /// <summary>"Spacing"</summary>
        SPACING_LENGTH = -1013351, // 0xFFF08999
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT = -1013350, // 0xFFF0899A
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_2 = -1013349, // 0xFFF0899B
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_1 = -1013348, // 0xFFF0899C
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_2 = -1013347, // 0xFFF0899D
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_1 = -1013346, // 0xFFF0899E
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_2 = -1013345, // 0xFFF0899F
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_1 = -1013344, // 0xFFF089A0
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_2 = -1013343, // 0xFFF089A1
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_1 = -1013342, // 0xFFF089A2
        /// <summary>"Angle"</summary>
        CURTAINGRID_ANGLE_2 = -1013340, // 0xFFF089A4
        /// <summary>"Angle"</summary>
        CURTAINGRID_ANGLE_1 = -1013339, // 0xFFF089A5
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_2 = -1013337, // 0xFFF089A7
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_1 = -1013336, // 0xFFF089A8
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_2 = -1013335, // 0xFFF089A9
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_1 = -1013334, // 0xFFF089AA
        /// <summary>"Spacing"</summary>
        SPACING_LENGTH_2 = -1013333, // 0xFFF089AB
        /// <summary>"Spacing"</summary>
        SPACING_LENGTH_1 = -1013332, // 0xFFF089AC
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_2 = -1013331, // 0xFFF089AD
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_1 = -1013330, // 0xFFF089AE
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_HORIZ = -1013319, // 0xFFF089B9
        /// <summary>"Use Curve Distance"</summary>
        CURTAINGRID_USE_CURVE_DIST_VERT = -1013318, // 0xFFF089BA
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_HORIZ = -1013317, // 0xFFF089BB
        /// <summary>"Adjust for Mullion Size"</summary>
        CURTAINGRID_ADJUST_BORDER_VERT = -1013316, // 0xFFF089BC
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_HORIZ = -1013315, // 0xFFF089BD
        /// <summary>"Measurement Line"</summary>
        CURTAINGRID_BELT_VERT = -1013314, // 0xFFF089BE
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_HORIZ = -1013313, // 0xFFF089BF
        /// <summary>"Offset"</summary>
        CURTAINGRID_ORIGIN_VERT = -1013312, // 0xFFF089C0
        /// <summary>"Angle"</summary>
        CURTAINGRID_ANGLE_HORIZ = -1013310, // 0xFFF089C2
        /// <summary>"Angle"</summary>
        CURTAINGRID_ANGLE_VERT = -1013309, // 0xFFF089C3
        /// <summary>"Type Association"</summary>
        GRIDLINE_SPEC_STATUS = -1013308, // 0xFFF089C4
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_HORIZ = -1013307, // 0xFFF089C5
        /// <summary>"Number"</summary>
        SPACING_NUM_DIVISIONS_VERT = -1013306, // 0xFFF089C6
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_HORIZ = -1013305, // 0xFFF089C7
        /// <summary>"Justification"</summary>
        SPACING_JUSTIFICATION_VERT = -1013304, // 0xFFF089C8
        /// <summary>"Spacing"</summary>
        SPACING_LENGTH_HORIZ = -1013303, // 0xFFF089C9
        /// <summary>"Spacing"</summary>
        SPACING_LENGTH_VERT = -1013302, // 0xFFF089CA
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_HORIZ = -1013301, // 0xFFF089CB
        /// <summary>"Layout"</summary>
        SPACING_LAYOUT_VERT = -1013300, // 0xFFF089CC
        /// <summary>"Design Option"</summary>
        DESIGN_OPTION_ID = -1013201, // 0xFFF08A2F
        /// <summary>"Design Option"</summary>
        DESIGN_OPTION_PARAM = -1013200, // 0xFFF08A30
        /// <summary>"View Range"</summary>
        PLAN_REGION_VIEW_RANGE = -1013103, // 0xFFF08A91
        /// <summary>"Name"</summary>
        GUIDE_GRID_NAME_PARAM = -1013002, // 0xFFF08AF6
        /// <summary>"Guide Spacing"</summary>
        GUIDE_GRID_SPACING_PARAM = -1013001, // 0xFFF08AF7
        /// <summary>"Work Plane Grid Spacing"</summary>
        SKETCH_GRID_SPACING_PARAM = -1013000, // 0xFFF08AF8
        /// <summary>"Abstract Join Strength Order"</summary>
        JOIN_STRENGTH_ORDER = -1012870, // 0xFFF08B7A
        /// <summary>"Host"</summary>
        FAMILY_HOSTING_BEHAVIOR = -1012843, // 0xFFF08B95
        /// <summary>"Elevation Mark Use"</summary>
        FAMILY_IS_ELEVATION_MARK_BODY = -1012842, // 0xFFF08B96
        /// <summary>"Show family pre-cut in plan views"</summary>
        FAMILY_USE_PRECUT_SHAPE = -1012841, // 0xFFF08B97
        /// <summary>"Default Setback"</summary>
        WALL_SWEEP_DEFAULT_SETBACK_PARAM = -1012840, // 0xFFF08B98
        /// <summary>"Cuts Wall"</summary>
        WALL_SWEEP_CUTS_WALL_PARAM = -1012839, // 0xFFF08B99
        /// <summary>"Cut by Inserts"</summary>
        WALL_SWEEP_CUT_BY_INSERTS_PARAM = -1012838, // 0xFFF08B9A
        /// <summary>"Profile"</summary>
        SLAB_EDGE_PROFILE_PARAM = -1012837, // 0xFFF08B9B
        /// <summary>"Profile"</summary>
        GUTTER_PROFILE_PARAM = -1012836, // 0xFFF08B9C
        /// <summary>"Profile"</summary>
        REVEAL_PROFILE_PARAM = -1012835, // 0xFFF08B9D
        /// <summary>"Shared"</summary>
        FAMILY_SHARED = -1012834, // 0xFFF08B9E
        /// <summary>"Work Plane-Based"</summary>
        FAMILY_WORK_PLANE_BASED = -1012833, // 0xFFF08B9F
        /// <summary>"Automatically joins geometry to walls"</summary>
        FAMILY_AUTOJOIN = -1012832, // 0xFFF08BA0
        /// <summary>"Is parametric"</summary>
        FAMILY_IS_PARAMETRIC = -1012831, // 0xFFF08BA1
        /// <summary>"Keep text readable"</summary>
        FAMILY_KEEP_TEXT_READABLE = -1012830, // 0xFFF08BA2
        /// <summary>"Base Extension Distance"</summary>
        WALL_BOTTOM_EXTENSION_DIST_PARAM = -1012829, // 0xFFF08BA3
        /// <summary>"Top Extension Distance"</summary>
        WALL_TOP_EXTENSION_DIST_PARAM = -1012828, // 0xFFF08BA4
        /// <summary>"Vertical Profile Offset"</summary>
        SWEEP_BASE_VERT_OFFSET = -1012827, // 0xFFF08BA5
        /// <summary>"Horizontal Profile Offset"</summary>
        SWEEP_BASE_OFFSET = -1012825, // 0xFFF08BA7
        /// <summary>"Material"</summary>
        SLAB_EDGE_MATERIAL_PARAM = -1012824, // 0xFFF08BA8
        /// <summary>"Material"</summary>
        GUTTER_MATERIAL_PARAM = -1012823, // 0xFFF08BA9
        /// <summary>"Material"</summary>
        FASCIA_MATERIAL_PARAM = -1012822, // 0xFFF08BAA
        /// <summary>"Subcategory of Floors"</summary>
        SWEEP_BASE_FLOOR_SUBCATEGORY_ID = -1012821, // 0xFFF08BAB
        /// <summary>"Subcategory of Roofs"</summary>
        SWEEP_BASE_ROOF_SUBCATEGORY_ID = -1012820, // 0xFFF08BAC
        /// <summary>"Profile"</summary>
        FASCIA_PROFILE_PARAM = -1012819, // 0xFFF08BAD
        /// <summary>"Subcategory"</summary>
        DECAL_SUBCATEGORY_ID = -1012818, // 0xFFF08BAE
        /// <summary>"Height"</summary>
        DECAL_HEIGHT = -1012815, // 0xFFF08BB1
        /// <summary>"Width"</summary>
        DECAL_WIDTH = -1012814, // 0xFFF08BB2
        /// <summary>"Lock Proportions"</summary>
        DECAL_LOCK_PROPORTIONS = -1012813, // 0xFFF08BB3
        /// <summary>"Decal Attributes"</summary>
        DECAL_ATTRIBUTES = -1012812, // 0xFFF08BB4
        /// <summary>"Cut with Voids When Loaded"</summary>
        FAMILY_ALLOW_CUT_WITH_VOIDS = -1012811, // 0xFFF08BB5
        /// <summary>"Filter Parameter"</summary>
        FAMILY_KEY_EXT_PARAM = -1012810, // 0xFFF08BB6
        /// <summary>"Subcategory of Walls"</summary>
        WALL_SWEEP_WALL_SUBCATEGORY_ID = -1012809, // 0xFFF08BB7
        /// <summary>"Always vertical"</summary>
        FAMILY_ALWAYS_VERTICAL = -1012808, // 0xFFF08BB8
        /// <summary>"Rotate with component"</summary>
        FAMILY_ROTATE_WITH_COMPONENT = -1012807, // 0xFFF08BB9
        /// <summary>"Volume"</summary>
        HOST_VOLUME_COMPUTED = -1012806, // 0xFFF08BBA
        /// <summary>"Area"</summary>
        HOST_AREA_COMPUTED = -1012805, // 0xFFF08BBB
        /// <summary>"Offset From Wall"</summary>
        WALL_SWEEP_WALL_OFFSET_PARAM = -1012804, // 0xFFF08BBC
        /// <summary>"Offset From Level"</summary>
        WALL_SWEEP_OFFSET_PARAM = -1012802, // 0xFFF08BBE
        /// <summary>"Level"</summary>
        WALL_SWEEP_LEVEL_PARAM = -1012801, // 0xFFF08BBF
        /// <summary>"Profile"</summary>
        WALL_SWEEP_PROFILE_PARAM = -1012800, // 0xFFF08BC0
        /// <summary>"Rotate text with component"</summary>
        FAMILY_ROTATE_TEXT_WITH_COMPONENT = -1012706, // 0xFFF08C1E
        /// <summary>"Name"</summary>
        AREA_SCHEME_NAME = -1012705, // 0xFFF08C1F
        /// <summary>"Area Scheme Id"</summary>
        AREA_SCHEME_ID = -1012704, // 0xFFF08C20
        /// <summary>"Area Type"</summary>
        AREA_TYPE_TEXT = -1012703, // 0xFFF08C21
        /// <summary>"Area Type"</summary>
        AREA_TYPE = -1012701, // 0xFFF08C23
        /// <summary>"Relative Base"</summary>
        CONTOUR_LABELS_RELATIVE_BASE = -1012622, // 0xFFF08C72
        /// <summary>"Elevation Base"</summary>
        CONTOUR_LABELS_ELEV_BASE_TYPE = -1012621, // 0xFFF08C73
        /// <summary>"Subcategory"</summary>
        PROPERTY_SEGMENT_SUBCATEGORY_ID = -1012620, // 0xFFF08C74
        /// <summary>"L/R"</summary>
        PROPERTY_SEGMENT_L_R = -1012619, // 0xFFF08C75
        /// <summary>"Radius"</summary>
        PROPERTY_SEGMENT_RADIUS = -1012618, // 0xFFF08C76
        /// <summary>"E/W"</summary>
        PROPERTY_SEGMENT_E_W = -1012617, // 0xFFF08C77
        /// <summary>"Bearing"</summary>
        PROPERTY_SEGMENT_BEARING = -1012616, // 0xFFF08C78
        /// <summary>"N/S"</summary>
        PROPERTY_SEGMENT_N_S = -1012615, // 0xFFF08C79
        /// <summary>"Distance"</summary>
        PROPERTY_SEGMENT_DISTANCE = -1012614, // 0xFFF08C7A
        /// <summary>"Units Format"</summary>
        PROPERTY_LENGTH_UNITS = -1012613, // 0xFFF08C7B
        /// <summary>"Area Units, Format"</summary>
        PROPERTY_AREA_UNITS = -1012612, // 0xFFF08C7C
        /// <summary>"Net cut/fill"</summary>
        VOLUME_NET = -1012611, // 0xFFF08C7D
        /// <summary>"Projected Area"</summary>
        PROJECTED_SURFACE_AREA = -1012610, // 0xFFF08C7E
        /// <summary>"Units Format"</summary>
        CONTOUR_LABELS_LINEAR_UNITS = -1012609, // 0xFFF08C7F
        /// <summary>"Label primary contours only"</summary>
        CONTOUR_LABELS_PRIMARY_ONLY = -1012608, // 0xFFF08C80
        /// <summary>"Subcategory"</summary>
        PROPERTY_SUBCATEGORY_ID = -1012607, // 0xFFF08C81
        /// <summary>"Area"</summary>
        PROPERTY_AREA_OPEN = -1012606, // 0xFFF08C82
        /// <summary>"Fill"</summary>
        VOLUME_FILL = -1012604, // 0xFFF08C84
        /// <summary>"Cut"</summary>
        VOLUME_CUT = -1012603, // 0xFFF08C85
        /// <summary>"Perimeter"</summary>
        SURFACE_PERIMETER = -1012602, // 0xFFF08C86
        /// <summary>"Surface Area"</summary>
        SURFACE_AREA = -1012601, // 0xFFF08C87
        /// <summary>"Area"</summary>
        PROPERTY_AREA = -1012600, // 0xFFF08C88
        /// <summary>"Height Offset From Level"</summary>
        BUILDINGPAD_HEIGHTABOVELEVEL_PARAM = -1012502, // 0xFFF08CEA
        /// <summary>"Thickness"</summary>
        BUILDINGPAD_THICKNESS = -1012501, // 0xFFF08CEB
        /// <summary>"Saved Path"</summary>
        TOPOGRAPHY_LINK_PATH = -1012409, // 0xFFF08D47
        /// <summary>"Link Name"</summary>
        TOPOGRAPHY_LINK_NAME = -1012408, // 0xFFF08D48
        /// <summary>"Radius"</summary>
        BOUNDARY_RADIUS = -1012407, // 0xFFF08D49
        /// <summary>"Subcategory"</summary>
        CONTOUR_SUBCATEGORY_ID = -1012405, // 0xFFF08D4B
        /// <summary>"Bearing"</summary>
        BOUNDARY_BEARING = -1012404, // 0xFFF08D4C
        /// <summary>"Distance"</summary>
        BOUNDARY_DISTANCE = -1012403, // 0xFFF08D4D
        /// <summary>"Increment"</summary>
        CONTOUR_ELEVATION_STEP = -1012402, // 0xFFF08D4E
        /// <summary>"Elevation"</summary>
        CONTOUR_ELEVATION = -1012401, // 0xFFF08D4F
        /// <summary>"Elevation"</summary>
        POINT_ELEVATION = -1012400, // 0xFFF08D50
        /// <summary>"Name"</summary>
        VOLUME_OF_INTEREST_NAME = -1012205, // 0xFFF08E13
        /// <summary>"Views Visible"</summary>
        VOLUME_OF_INTEREST_VIEWS_VISIBLE = -1012203, // 0xFFF08E15
        /// <summary>"Scope Box"</summary>
        VIEWER_VOLUME_OF_INTEREST_CROP = -1012202, // 0xFFF08E16
        /// <summary>"Scope Box"</summary>
        DATUM_VOLUME_OF_INTEREST = -1012201, // 0xFFF08E17
        /// <summary>"Rotate With Text"</summary>
        ORIENT_BY_VIEW = -1012200, // 0xFFF08E18
        /// <summary>"Phase"</summary>
        ROOM_PHASE = -1012113, // 0xFFF08E6F
        /// <summary>"Phase Id"</summary>
        ROOM_PHASE_ID = -1012112, // 0xFFF08E70
        /// <summary>"Sequence Number"</summary>
        PHASE_SEQUENCE_NUMBER = -1012111, // 0xFFF08E71
        /// <summary>"Name"</summary>
        PHASE_NAME = -1012110, // 0xFFF08E72
        /// <summary>"Family"</summary>
        VIEW_FAMILY = -1012109, // 0xFFF08E73
        /// <summary>"Family and Type"</summary>
        VIEW_TYPE = -1012106, // 0xFFF08E76
        /// <summary>"Phase Filter"</summary>
        VIEW_PHASE_FILTER = -1012103, // 0xFFF08E79
        /// <summary>"Phase"</summary>
        VIEW_PHASE = -1012102, // 0xFFF08E7A
        /// <summary>"Phase Demolished"</summary>
        PHASE_DEMOLISHED = -1012101, // 0xFFF08E7B
        /// <summary>"Phase Created"</summary>
        PHASE_CREATED = -1012100, // 0xFFF08E7C
        /// <summary>"Slab"</summary>
        MASS_DATA_SLAB = -1012098, // 0xFFF08E7E
        /// <summary>"HVAC System"</summary>
        ENERGY_ANALYSIS_HVAC_SYSTEM = -1012062, // 0xFFF08EA2
        /// <summary>"Outdoor Air Information"</summary>
        ENERGY_ANALYSIS_OUTDOOR_AIR_INFORMATION_PARAM = -1012061, // 0xFFF08EA3
        /// <summary>"Use Energy Data"</summary>
        ENERGY_ANALYSIS_MASSZONE_USEENERGYDATASETTINGS = -1012060, // 0xFFF08EA4
        /// <summary>"Perimeter Zone Division"</summary>
        ENERGY_ANALYSIS_MASSZONE_DIVIDEPERIMETER = -1012059, // 0xFFF08EA5
        /// <summary>"Perimeter Zone Depth"</summary>
        ENERGY_ANALYSIS_MASSZONE_COREOFFSET = -1012058, // 0xFFF08EA6
        /// <summary>"Shade Depth"</summary>
        ENERGY_ANALYSIS_SHADE_DEPTH = -1012057, // 0xFFF08EA7
        /// <summary>"Conceptual Types"</summary>
        ENERGY_ANALYSIS_CONCEPTUAL_CONSTRUCTION = -1012056, // 0xFFF08EA8
        /// <summary>"Skylight Width &amp; Depth"</summary>
        ENERGY_ANALYSIS_SKYLIGHT_WIDTH = -1012055, // 0xFFF08EA9
        /// <summary>"Target Percentage Skylights"</summary>
        ENERGY_ANALYSIS_PERCENTAGE_SKYLIGHTS = -1012054, // 0xFFF08EAA
        /// <summary>"Glazing is Shaded"</summary>
        ENERGY_ANALYSIS_GLAZING_IS_SHADED = -1012053, // 0xFFF08EAB
        /// <summary>"Target Sill Height"</summary>
        ENERGY_ANALYSIS_SILL_HEIGHT = -1012052, // 0xFFF08EAC
        /// <summary>"Target Percentage Glazing"</summary>
        ENERGY_ANALYSIS_PERCENTAGE_GLAZING = -1012051, // 0xFFF08EAD
        /// <summary>"Mass Zoning"</summary>
        ENERGY_ANALYSIS_MASS_ZONING = -1012050, // 0xFFF08EAE
        /// <summary>"Building Operating Schedule"</summary>
        ENERGY_ANALYSIS_BUILDING_OPERATING_SCHEDULE = -1012047, // 0xFFF08EB1
        /// <summary>"Create Energy Model"</summary>
        ENERGY_ANALYSIS_CREATE_ANALYTICAL_MODEL = -1012046, // 0xFFF08EB2
        /// <summary>"Values"</summary>
        MASS_DATA_SURFACE_DATA_SOURCE = -1012045, // 0xFFF08EB3
        /// <summary>"Skylight Width &amp; Depth"</summary>
        MASS_DATA_SKYLIGHT_WIDTH = -1012044, // 0xFFF08EB4
        /// <summary>"Target Percentage Skylights"</summary>
        MASS_DATA_PERCENTAGE_SKYLIGHTS = -1012043, // 0xFFF08EB5
        /// <summary>"Target Sill Height"</summary>
        MASS_DATA_SILL_HEIGHT = -1012042, // 0xFFF08EB6
        /// <summary>"Shade Depth"</summary>
        MASS_DATA_SHADE_DEPTH = -1012041, // 0xFFF08EB7
        /// <summary>"Glazing is Shaded"</summary>
        MASS_DATA_GLAZING_IS_SHADED = -1012040, // 0xFFF08EB8
        /// <summary>"Target Percentage Glazing"</summary>
        MASS_DATA_PERCENTAGE_GLAZING = -1012039, // 0xFFF08EB9
        /// <summary>"Underground"</summary>
        MASS_DATA_UNDERGROUND = -1012038, // 0xFFF08EBA
        /// <summary>"Mass Opening Area"</summary>
        MASS_DATA_MASS_OPENING_AREA = -1012037, // 0xFFF08EBB
        /// <summary>"Mass Skylight Area"</summary>
        MASS_DATA_MASS_SKYLIGHT_AREA = -1012036, // 0xFFF08EBC
        /// <summary>"Mass Window Area"</summary>
        MASS_DATA_MASS_WINDOW_AREA = -1012035, // 0xFFF08EBD
        /// <summary>"Mass Roof Area"</summary>
        MASS_DATA_MASS_ROOF_AREA = -1012034, // 0xFFF08EBE
        /// <summary>"Mass Interior Wall Area"</summary>
        MASS_DATA_MASS_INTERIOR_WALL_AREA = -1012033, // 0xFFF08EBF
        /// <summary>"Mass Exterior Wall Area"</summary>
        MASS_DATA_MASS_EXTERIOR_WALL_AREA = -1012032, // 0xFFF08EC0
        /// <summary>"Subcategory"</summary>
        MASS_DATA_SUBCATEGORY = -1012031, // 0xFFF08EC1
        /// <summary>"Conceptual Types"</summary>
        MASS_DATA_CONCEPTUAL_CONSTRUCTION = -1012030, // 0xFFF08EC2
        /// <summary>"Condition Type"</summary>
        MASS_ZONE_CONDITION_TYPE_PARAM = -1012027, // 0xFFF08EC5
        /// <summary>"Space Type"</summary>
        MASS_ZONE_SPACE_TYPE_PARAM = -1012026, // 0xFFF08EC6
        /// <summary>"Mass Floor Area"</summary>
        MASS_ZONE_FLOOR_AREA = -1012025, // 0xFFF08EC7
        /// <summary>"Graphical Appearance"</summary>
        CONCEPTUAL_CONSTRUCTION_MATERIAL = -1012024, // 0xFFF08EC8
        /// <summary>"Graphical Appearance"</summary>
        MASS_SURFACEDATA_MATERIAL = -1012023, // 0xFFF08EC9
        /// <summary>"Graphical Appearance"</summary>
        MASS_ZONE_MATERIAL = -1012022, // 0xFFF08ECA
        /// <summary>"Mass Zone Volume"</summary>
        MASS_ZONE_VOLUME = -1012021, // 0xFFF08ECB
        /// <summary>"Mass: Description"</summary>
        LEVEL_DATA_MASS_TYPE_DESCRIPTION = -1012020, // 0xFFF08ECC
        /// <summary>"Mass: Comments"</summary>
        LEVEL_DATA_MASS_INSTANCE_COMMENTS = -1012019, // 0xFFF08ECD
        /// <summary>"Mass: Type Comments"</summary>
        LEVEL_DATA_MASS_TYPE_COMMENTS = -1012018, // 0xFFF08ECE
        /// <summary>"Mass: Family and Type"</summary>
        LEVEL_DATA_MASS_FAMILY_AND_TYPE_PARAM = -1012017, // 0xFFF08ECF
        /// <summary>"Mass: Family"</summary>
        LEVEL_DATA_MASS_FAMILY_PARAM = -1012016, // 0xFFF08ED0
        /// <summary>"Usage"</summary>
        LEVEL_DATA_SPACE_USAGE = -1012015, // 0xFFF08ED1
        /// <summary>"Level"</summary>
        LEVEL_DATA_OWNING_LEVEL = -1012014, // 0xFFF08ED2
        /// <summary>"Mass: Type"</summary>
        LEVEL_DATA_MASS_TYPE_PARAM = -1012013, // 0xFFF08ED3
        /// <summary>"Floor Volume"</summary>
        LEVEL_DATA_VOLUME = -1012012, // 0xFFF08ED4
        /// <summary>"Exterior Surface Area"</summary>
        LEVEL_DATA_SURFACE_AREA = -1012011, // 0xFFF08ED5
        /// <summary>"Floor Area"</summary>
        LEVEL_DATA_FLOOR_AREA = -1012010, // 0xFFF08ED6
        /// <summary>"Floor Perimeter"</summary>
        LEVEL_DATA_FLOOR_PERIMETER = -1012009, // 0xFFF08ED7
        /// <summary>"Gross Volume"</summary>
        MASS_GROSS_VOLUME = -1012007, // 0xFFF08ED9
        /// <summary>"Gross Surface Area"</summary>
        MASS_GROSS_SURFACE_AREA = -1012006, // 0xFFF08EDA
        /// <summary>"Mass Floors"</summary>
        MASS_FLOOR_AREA_LEVELS = -1012005, // 0xFFF08EDB
        /// <summary>"Gross Floor Area"</summary>
        MASS_GROSS_AREA = -1012004, // 0xFFF08EDC
        /// <summary>"Constrain to Massing"</summary>
        MASSING_INTEGRATION_LEVEL = -1012000, // 0xFFF08EE0
        /// <summary>"Issued"</summary>
        PROJECT_REVISION_REVISION_ISSUED = -1011957, // 0xFFF08F0B
        /// <summary>"Numbering"</summary>
        PROJECT_REVISION_ENUMERATION = -1011956, // 0xFFF08F0C
        /// <summary>"Issued by"</summary>
        PROJECT_REVISION_REVISION_ISSUED_BY = -1011955, // 0xFFF08F0D
        /// <summary>"Issued to"</summary>
        PROJECT_REVISION_REVISION_ISSUED_TO = -1011954, // 0xFFF08F0E
        /// <summary>"Revision Date"</summary>
        PROJECT_REVISION_REVISION_DATE = -1011953, // 0xFFF08F0F
        /// <summary>"Revision Description"</summary>
        PROJECT_REVISION_REVISION_DESCRIPTION = -1011952, // 0xFFF08F10
        /// <summary>"Revision Number"</summary>
        PROJECT_REVISION_REVISION_NUM = -1011951, // 0xFFF08F11
        /// <summary>
        ///    "Revision Sequence": read_only  Make this read-only again when NewSchedules_DisplayTags is cleaned up
        /// </summary>
        PROJECT_REVISION_SEQUENCE_NUM = -1011950, // 0xFFF08F12
        /// <summary>"Issued by"</summary>
        REVISION_CLOUD_REVISION_ISSUED_BY = -1011906, // 0xFFF08F3E
        /// <summary>"Issued to"</summary>
        REVISION_CLOUD_REVISION_ISSUED_TO = -1011904, // 0xFFF08F40
        /// <summary>"Revision Date"</summary>
        REVISION_CLOUD_REVISION_DATE = -1011903, // 0xFFF08F41
        /// <summary>"Revision Description"</summary>
        REVISION_CLOUD_REVISION_DESCRIPTION = -1011902, // 0xFFF08F42
        /// <summary>"Revision Number"</summary>
        REVISION_CLOUD_REVISION_NUM = -1011901, // 0xFFF08F43
        /// <summary>"Revision"</summary>
        REVISION_CLOUD_REVISION = -1011900, // 0xFFF08F44
        /// <summary>"Detail Rotation"</summary>
        REPEATING_DETAIL_ROTATION = -1011109, // 0xFFF0925B
        /// <summary>"Inside"</summary>
        REPEATING_DETAIL_INSIDE = -1011107, // 0xFFF0925D
        /// <summary>"Detail"</summary>
        REPEATING_DETAIL_ELEMENT = -1011106, // 0xFFF0925E
        /// <summary>"Layout"</summary>
        REPEATING_DETAIL_LAYOUT = -1011105, // 0xFFF0925F
        /// <summary>"Spacing"</summary>
        REPEATING_DETAIL_SPACING = -1011104, // 0xFFF09260
        /// <summary>"Number"</summary>
        REPEATING_DETAIL_NUMBER = -1011103, // 0xFFF09261
        /// <summary>"Insulation Bulge to Width Ratio (1/x)"</summary>
        INSULATION_SCALE = -1011101, // 0xFFF09263
        /// <summary>"Insulation Width"</summary>
        INSULATION_WIDTH = -1011100, // 0xFFF09264
        /// <summary>"Parts Visibility"</summary>
        VIEW_PARTS_VISIBILITY = -1011003, // 0xFFF092C5
        /// <summary>"Detail Level"</summary>
        VIEW_DETAIL_LEVEL = -1011002, // 0xFFF092C6
        /// <summary>"Vent Connection"</summary>
        PLUMBING_FIXTURES_VENT_CONNECTION = -1010707, // 0xFFF093ED
        /// <summary>"Waste Connection"</summary>
        PLUMBING_FIXTURES_WASTE_CONNECTION = -1010706, // 0xFFF093EE
        /// <summary>"CW Connection"</summary>
        PLUMBING_FIXTURES_CW_CONNECTION = -1010705, // 0xFFF093EF
        /// <summary>"HW Connection"</summary>
        PLUMBING_FIXTURES_HW_CONNECTION = -1010704, // 0xFFF093F0
        /// <summary>"Trap"</summary>
        PLUMBING_FIXTURES_TRAP = -1010703, // 0xFFF093F1
        /// <summary>"Drain"</summary>
        PLUMBING_FIXTURES_DRAIN = -1010702, // 0xFFF093F2
        /// <summary>"Supply Pipe"</summary>
        PLUMBING_FIXTURES_SUPPLY_PIPE = -1010701, // 0xFFF093F3
        /// <summary>"Supply Fitting"</summary>
        PLUMBING_FIXTURES_SUPPLY_FITTING = -1010700, // 0xFFF093F4
        /// <summary>"Light Emitter"</summary>
        LIGHTING_FIXTURE_LIGHT_EMITTER = -1010508, // 0xFFF094B4
        /// <summary>"Spot Field Angle"</summary>
        FBX_LIGHT_SPOT_FIELD_ANGLE = -1010507, // 0xFFF094B5
        /// <summary>"Spot Beam Angle"</summary>
        FBX_LIGHT_SPOT_BEAM_ANGLE = -1010506, // 0xFFF094B6
        /// <summary>"Tilt Angle"</summary>
        FBX_LIGHT_SPOT_TILT_ANGLE = -1010505, // 0xFFF094B7
        /// <summary>"Luminous Flux"</summary>
        FBX_LIGHT_LIMUNOUS_FLUX = -1010503, // 0xFFF094B9
        /// <summary>"Lamp"</summary>
        LIGHTING_FIXTURE_LAMP = -1010501, // 0xFFF094BB
        /// <summary>"Wattage Comments"</summary>
        LIGHTING_FIXTURE_WATTAGE = -1010500, // 0xFFF094BC
        /// <summary>"Voltage"</summary>
        ELECTICAL_EQUIP_VOLTAGE = -1010401, // 0xFFF0951F
        /// <summary>"Wattage"</summary>
        ELECTICAL_EQUIP_WATTAGE = -1010400, // 0xFFF09520
        /// <summary>"Thickness"</summary>
        CURTAIN_WALL_SYSPANEL_THICKNESS = -1010304, // 0xFFF09580
        /// <summary>"Host Id"</summary>
        CURTAIN_WALL_PANEL_HOST_ID = -1010303, // 0xFFF09581
        /// <summary>"Offset"</summary>
        CURTAIN_WALL_SYSPANEL_OFFSET = -1010302, // 0xFFF09582
        /// <summary>"Width"</summary>
        CURTAIN_WALL_PANELS_WIDTH = -1010301, // 0xFFF09583
        /// <summary>"Height"</summary>
        CURTAIN_WALL_PANELS_HEIGHT = -1010300, // 0xFFF09584
        /// <summary>"Model"</summary>
        ALL_MODEL_MODEL = -1010109, // 0xFFF09643
        /// <summary>"Manufacturer"</summary>
        ALL_MODEL_MANUFACTURER = -1010108, // 0xFFF09644
        /// <summary>"Comments"</summary>
        ALL_MODEL_INSTANCE_COMMENTS = -1010106, // 0xFFF09646
        /// <summary>"Type Comments"</summary>
        ALL_MODEL_TYPE_COMMENTS = -1010105, // 0xFFF09647
        /// <summary>"URL"</summary>
        ALL_MODEL_URL = -1010104, // 0xFFF09648
        /// <summary>"Description"</summary>
        ALL_MODEL_DESCRIPTION = -1010103, // 0xFFF09649
        /// <summary>"Blue value for RGB color spec. (for Use with XAML Data Template example)"</summary>
        RGB_B_PARAM = -1010024, // 0xFFF09698
        /// <summary>
        ///    "Green value for RGB color spec. (for Use with XAML Data Template example)"
        /// </summary>
        RGB_G_PARAM = -1010023, // 0xFFF09699
        /// <summary>"Red value for RGB color spec. (for Use with XAML Data Template example)"</summary>
        RGB_R_PARAM = -1010022, // 0xFFF0969A
        /// <summary>"Y-Radius Value for Ellipse (for Use with XAML Data Template example)"</summary>
        ELLIPSE_Y_PARAM = -1010021, // 0xFFF0969B
        /// <summary>"X-Radius Value for Ellipse (for Use with XAML Data Template example)"</summary>
        ELLIPSE_X_PARAM = -1010020, // 0xFFF0969C
        /// <summary>"Group Name for Ribbon Combo Items (for Use with XAML)"</summary>
        GROUPNAME_PARAM = -1010018, // 0xFFF0969E
        /// <summary>"Index Into Image File Name Array (for Use with XAML)"</summary>
        ICON_INDEX_PARAM = -1010017, // 0xFFF0969F
        /// <summary>"Flag to display icon in Ribbon Combo Item"</summary>
        SHOW_ICON_PARAM = -1010016, // 0xFFF096A0
        /// <summary>"Double"</summary>
        DEBUGTAB_DATABOUNDCONTROLSDEMO_DOUBLE = -1010013, // 0xFFF096A3
        /// <summary>"Integer"</summary>
        DEBUGTAB_DATABOUNDCONTROLSDEMO_INTEGER = -1010012, // 0xFFF096A4
        /// <summary>"Boolean"</summary>
        DEBUGTAB_DATABOUNDCONTROLSDEMO_BOOLEAN = -1010011, // 0xFFF096A5
        /// <summary>"Options"</summary>
        DEBUGTAB_DATABOUNDCONTROLSDEMO_ENUM = -1010010, // 0xFFF096A6
        /// <summary>"Depth"</summary>
        CASEWORK_DEPTH = -1010003, // 0xFFF096AD
        /// <summary>"Depth"</summary>
        GENERIC_DEPTH = -1010003, // 0xFFF096AD
        /// <summary>"End Projection Orthogonal"</summary>
        ANALYTICAL_MODEL_END_PROJECTION_ORTHOGONAL = -1009532, // 0xFFF09884
        /// <summary>"Start Projection Orthogonal"</summary>
        ANALYTICAL_MODEL_START_PROJECTION_ORTHOGONAL = -1009531, // 0xFFF09885
        /// <summary>"Z Rotation"</summary>
        ANALYTICAL_LINK_RELEASE_ROTATION_Z = -1009530, // 0xFFF09886
        /// <summary>"Y Rotation"</summary>
        ANALYTICAL_LINK_RELEASE_ROTATION_Y = -1009529, // 0xFFF09887
        /// <summary>"X Rotation"</summary>
        ANALYTICAL_LINK_RELEASE_ROTATION_X = -1009528, // 0xFFF09888
        /// <summary>"Z Translation"</summary>
        ANALYTICAL_LINK_RELEASE_TRANSLATION_Z = -1009527, // 0xFFF09889
        /// <summary>"Y Translation"</summary>
        ANALYTICAL_LINK_RELEASE_TRANSLATION_Y = -1009526, // 0xFFF0988A
        /// <summary>"X Translation"</summary>
        ANALYTICAL_LINK_RELEASE_TRANSLATION_X = -1009525, // 0xFFF0988B
        /// <summary>
        ///    "Family Type": the Family Type of the physical element associated with the Analytical Model
        /// </summary>
        ANALYTICAL_MODEL_PHYSICAL_TYPE = -1009524, // 0xFFF0988C
        /// <summary>"In-Plane Projection"</summary>
        ANALYTICAL_MODEL_SKETCH_PROJECTION = -1009523, // 0xFFF0988D
        /// <summary>"Alignment Method"</summary>
        ANALYTICAL_MODEL_SKETCH_ALIGNMENT_METHOD = -1009522, // 0xFFF0988E
        /// <summary>"Base y Projection"</summary>
        ANALYTICAL_MODEL_WALL_BASE_PROJECTION = -1009521, // 0xFFF0988F
        /// <summary>"Top y Projection"</summary>
        ANALYTICAL_MODEL_WALL_TOP_PROJECTION = -1009520, // 0xFFF09890
        /// <summary>"z Projection"</summary>
        ANALYTICAL_MODEL_WALL_PROJECTION = -1009519, // 0xFFF09891
        /// <summary>"Alignment Method"</summary>
        ANALYTICAL_MODEL_WALL_ALIGNMENT_METHOD = -1009518, // 0xFFF09892
        /// <summary>"z Projection"</summary>
        ANALYTICAL_MODEL_FLOOR_PROJECTION = -1009517, // 0xFFF09893
        /// <summary>"Alignment Method"</summary>
        ANALYTICAL_MODEL_FLOOR_ALIGNMENT_METHOD = -1009516, // 0xFFF09894
        /// <summary>"Base x Projection"</summary>
        ANALYTICAL_MODEL_COLUMN_BASE_EXTENSION = -1009515, // 0xFFF09895
        /// <summary>"Base Extension Method"</summary>
        ANALYTICAL_MODEL_BASE_EXTENSION_METHOD = -1009514, // 0xFFF09896
        /// <summary>"Top x Projection"</summary>
        ANALYTICAL_MODEL_COLUMN_TOP_EXTENSION = -1009513, // 0xFFF09897
        /// <summary>"Top Extension Method"</summary>
        ANALYTICAL_MODEL_TOP_EXTENSION_METHOD = -1009512, // 0xFFF09898
        /// <summary>"Top y Projection"</summary>
        ANALYTICAL_MODEL_TOP_Y_PROJECTION = -1009511, // 0xFFF09899
        /// <summary>"Top z Projection"</summary>
        ANALYTICAL_MODEL_TOP_Z_PROJECTION = -1009510, // 0xFFF0989A
        /// <summary>"Top Alignment Method"</summary>
        ANALYTICAL_MODEL_TOP_ALIGNMENT_METHOD = -1009509, // 0xFFF0989B
        /// <summary>"Base y Projection"</summary>
        ANALYTICAL_MODEL_BASE_Y_PROJECTION = -1009508, // 0xFFF0989C
        /// <summary>"Base z Projection"</summary>
        ANALYTICAL_MODEL_BASE_Z_PROJECTION = -1009507, // 0xFFF0989D
        /// <summary>"Base Alignment Method"</summary>
        ANALYTICAL_MODEL_BASE_ALIGNMENT_METHOD = -1009506, // 0xFFF0989E
        /// <summary>"End z Projection"</summary>
        ANALYTICAL_MODEL_END_Z_PROJECTION = -1009505, // 0xFFF0989F
        /// <summary>"End y Projection"</summary>
        ANALYTICAL_MODEL_END_Y_PROJECTION = -1009504, // 0xFFF098A0
        /// <summary>"End Alignment Method"</summary>
        ANALYTICAL_MODEL_END_ALIGNMENT_METHOD = -1009503, // 0xFFF098A1
        /// <summary>"Start z Projection"</summary>
        ANALYTICAL_MODEL_START_Z_PROJECTION = -1009502, // 0xFFF098A2
        /// <summary>"Start y Projection"</summary>
        ANALYTICAL_MODEL_START_Y_PROJECTION = -1009501, // 0xFFF098A3
        /// <summary>"Start Alignment Method"</summary>
        ANALYTICAL_MODEL_START_ALIGNMENT_METHOD = -1009500, // 0xFFF098A4
        /// <summary>"Locked"</summary>
        ELEMENT_LOCKED_PARAM = -1009000, // 0xFFF09A98
        /// <summary>"Post"</summary>
        STAIRS_RAILING_BALUSTER_IS_POST = -1008633, // 0xFFF09C07
        /// <summary>"Rail Connections"</summary>
        STAIRS_RAILING_CONNECTION = -1008632, // 0xFFF09C08
        /// <summary>"Angled Joins"</summary>
        STAIRS_RAILING_ANGLED_CONNECTION = -1008631, // 0xFFF09C09
        /// <summary>"Tangent Joins"</summary>
        STAIRS_RAILING_TANGENT_CONNECTION = -1008630, // 0xFFF09C0A
        /// <summary>"Landing Height Adjustment"</summary>
        STAIRS_RAILING_HEIGHT_SHIFT_VAL = -1008629, // 0xFFF09C0B
        /// <summary>"Use Landing Height Adjustment"</summary>
        STAIRS_RAILING_HEIGHT_SHIFT_TYPE = -1008628, // 0xFFF09C0C
        /// <summary>"Name"</summary>
        STAIRS_RAILING_RAIL_NAME = -1008627, // 0xFFF09C0D
        /// <summary>"Baluster Placement"</summary>
        STAIRS_RAILING_BALUSTER_PLACEMENT = -1008626, // 0xFFF09C0E
        /// <summary>"Slope Angle"</summary>
        STAIRS_RAILING_BALUSTER_SLOPE_ANGLE = -1008625, // 0xFFF09C0F
        /// <summary>"Bottom Cut Angle"</summary>
        STAIRS_RAILING_BALUSTER_BOTTOM_ANGLE = -1008624, // 0xFFF09C10
        /// <summary>"Top Cut Angle"</summary>
        STAIRS_RAILING_BALUSTER_TOP_ANGLE = -1008623, // 0xFFF09C11
        /// <summary>"Baluster Height"</summary>
        STAIRS_RAILING_BALUSTER_HEIGHT = -1008622, // 0xFFF09C12
        /// <summary>"Base Offset"</summary>
        STAIRS_RAILING_HEIGHT_OFFSET = -1008621, // 0xFFF09C13
        /// <summary>"Base Level"</summary>
        STAIRS_RAILING_BASE_LEVEL_PARAM = -1008620, // 0xFFF09C14
        /// <summary>"Baluster Offset"</summary>
        STAIRS_RAILING_BALUSTER_OFFSET = -1008619, // 0xFFF09C15
        /// <summary>"Baluster Family"</summary>
        STAIRS_RAILING_BALUSTER_FAMILY = -1008618, // 0xFFF09C16
        /// <summary>"Rail Offset"</summary>
        STAIRS_RAILING_RAIL_OFFSET = -1008617, // 0xFFF09C17
        /// <summary>"Rail Height"</summary>
        STAIRS_RAILING_RAIL_HEIGHT = -1008616, // 0xFFF09C18
        /// <summary>"Rail Structure (Non-Continuous)"</summary>
        STAIRS_RAILING_RAIL_STRUCTURE = -1008615, // 0xFFF09C19
        /// <summary>"Rail Shape"</summary>
        STAIRS_RAILING_SHAPE = -1008614, // 0xFFF09C1A
        /// <summary>"Baluster Length"</summary>
        STAIRS_RAILING_BALUSTER_LENGTH = -1008612, // 0xFFF09C1C
        /// <summary>"Baluster Width"</summary>
        STAIRS_RAILING_BALUSTER_WIDTH = -1008611, // 0xFFF09C1D
        /// <summary>"Balusters Per Tread (Stair Railing Only)"</summary>
        STAIRS_RAILING_BALUSTERS_PER_TREAD = -1008610, // 0xFFF09C1E
        /// <summary>"Baluster Separation"</summary>
        STAIRS_RAILING_BALUSTER_SPACING = -1008609, // 0xFFF09C1F
        /// <summary>"Baluster Spacing Type (Stair Railing Only)"</summary>
        STAIRS_RAILING_BALUSTER_SPACING_TYPE = -1008608, // 0xFFF09C20
        /// <summary>"Baluster Shape"</summary>
        STAIRS_RAILING_BALUSTER_SHAPE = -1008605, // 0xFFF09C23
        /// <summary>"Railing Thickness"</summary>
        STAIRS_RAILING_THICKNESS = -1008604, // 0xFFF09C24
        /// <summary>"Railing Width"</summary>
        STAIRS_RAILING_WIDTH = -1008603, // 0xFFF09C25
        /// <summary>"Railing Height"</summary>
        STAIRS_RAILING_HEIGHT = -1008602, // 0xFFF09C26
        /// <summary>"Text Size"</summary>
        RAMP_ATTR_TEXT_SIZE = -1008310, // 0xFFF09D4A
        /// <summary>"Text Font"</summary>
        RAMP_ATTR_TEXT_FONT = -1008309, // 0xFFF09D4B
        /// <summary>"Ramp Material"</summary>
        RAMP_ATTR_MATERIAL = -1008308, // 0xFFF09D4C
        /// <summary>"Right Baluster Location"</summary>
        RAMP_ATTR_RIGHT_BALUSTER_ATTACH_PT = -1008307, // 0xFFF09D4D
        /// <summary>"Left Baluster Location"</summary>
        RAMP_ATTR_LEFT_BALUSTER_ATTACH_PT = -1008306, // 0xFFF09D4E
        /// <summary>"Shape"</summary>
        RAMP_ATTR_SHAPE = -1008305, // 0xFFF09D4F
        /// <summary>"Thickness"</summary>
        RAMP_ATTR_THICKNESS = -1008304, // 0xFFF09D50
        /// <summary>"Maximum Incline Length"</summary>
        RAMP_MAX_RUN_LENGTH = -1008303, // 0xFFF09D51
        /// <summary>"Ramp Max Slope (1/x)"</summary>
        RAMP_ATTR_MIN_INV_SLOPE = -1008301, // 0xFFF09D53
        /// <summary>"New views are dependent on template"</summary>
        ASSIGN_TEMPLATE_ON_VIEW_CREATION = -1008211, // 0xFFF09DAD
        /// <summary>"View Template applied to new views"</summary>
        DEFAULT_VIEW_TEMPLATE = -1008210, // 0xFFF09DAE
        /// <summary>"View Direction"</summary>
        PLAN_VIEW_VIEW_DIR = -1008209, // 0xFFF09DAF
        /// <summary>"Coarse Poche Material"</summary>
        POCHE_MAT_ID = -1008208, // 0xFFF09DB0
        /// <summary>"Elevation Tag"</summary>
        ELEVATN_TAG = -1008207, // 0xFFF09DB1
        /// <summary>"Callout Tag"</summary>
        CALLOUT_TAG = -1008206, // 0xFFF09DB2
        /// <summary>"Section Tag"</summary>
        SECTION_TAG = -1008205, // 0xFFF09DB3
        /// <summary>"Far Clip Settings"</summary>
        CALLOUT_SYNCRONIZE_BOUND_OFFSET_FAR = -1008203, // 0xFFF09DB5
        /// <summary>"Corner Radius"</summary>
        CALLOUT_CORNER_SHEET_RADIUS = -1008201, // 0xFFF09DB7
        /// <summary>"Callout Head"</summary>
        CALLOUT_ATTR_HEAD_TAG = -1008200, // 0xFFF09DB8
        /// <summary>"Plan View Symbols End 2 (Default)"</summary>
        GRID_BUBBLE_END_2 = -1008005, // 0xFFF09E7B
        /// <summary>"Plan View Symbols End 1 (Default)"</summary>
        GRID_BUBBLE_END_1 = -1008004, // 0xFFF09E7C
        /// <summary>"Non-Plan View Symbols (Default)"</summary>
        DATUM_BUBBLE_LOCATION_IN_ELEV = -1008003, // 0xFFF09E7D
        /// <summary>"Symbol at End 1 Default"</summary>
        DATUM_BUBBLE_END_1 = -1008002, // 0xFFF09E7E
        /// <summary>"Symbol at End 2 Default"</summary>
        DATUM_BUBBLE_END_2 = -1008001, // 0xFFF09E7F
        /// <summary>"Name"</summary>
        DATUM_TEXT = -1008000, // 0xFFF09E80
        /// <summary>"Focus Marks Visible"</summary>
        ELLIPSE_FOCUS_MRK_VISIBLE = -1007905, // 0xFFF09EDF
        /// <summary>"Center Mark Visible"</summary>
        ARC_CURVE_CNTR_MRK_VISIBLE = -1007900, // 0xFFF09EE4
        /// <summary>"Center Mark Visible"</summary>
        ARC_WALL_CNTR_MRK_VISIBLE = -1007900, // 0xFFF09EE4
        /// <summary>"Parameter Name"</summary>
        REF_TABLE_PARAM_NAME = -1007851, // 0xFFF09F15
        /// <summary>"Key Name"</summary>
        REF_TABLE_ELEM_NAME = -1007850, // 0xFFF09F16
        /// <summary>"Appearance"</summary>
        RBS_PANEL_SCHEDULE_SHEET_APPEARANCE_INST_PARAM = -1007808, // 0xFFF09F40
        /// <summary>"Appearance On Sheet"</summary>
        RBS_PANEL_SCHEDULE_SHEET_APPEARANCE_PARAM = -1007807, // 0xFFF09F41
        /// <summary>"Embedded Schedule"</summary>
        SCHEDULE_EMBEDDED_PARAM = -1007806, // 0xFFF09F42
        /// <summary>"Appearance"</summary>
        SCHEDULE_SHEET_APPEARANCE_PARAM = -1007805, // 0xFFF09F43
        /// <summary>"Formatting"</summary>
        SCHEDULE_FORMAT_PARAM = -1007804, // 0xFFF09F44
        /// <summary>"Sorting/Grouping"</summary>
        SCHEDULE_GROUP_PARAM = -1007803, // 0xFFF09F45
        /// <summary>"Filter"</summary>
        SCHEDULE_FILTER_PARAM = -1007801, // 0xFFF09F47
        /// <summary>"Fields"</summary>
        SCHEDULE_FIELDS_PARAM = -1007800, // 0xFFF09F48
        /// <summary>"Link Status"</summary>
        RASTER_SYMBOL_LINKLOAD_STATUS = -1007771, // 0xFFF09F65
        /// <summary>"Enable Snaps"</summary>
        RASTER_ENABLE_SNAPS = -1007770, // 0xFFF09F66
        /// <summary>"Page Number"</summary>
        RASTER_SYMBOL_PAGENUMBER = -1007769, // 0xFFF09F67
        /// <summary>"Horizontal Scale"</summary>
        RASTER_HORIZONTAL_SCALE = -1007768, // 0xFFF09F68
        /// <summary>"Vertical Scale"</summary>
        RASTER_VERTICAL_SCALE = -1007767, // 0xFFF09F69
        /// <summary>"Height"</summary>
        RASTER_SYMBOL_HEIGHT = -1007766, // 0xFFF09F6A
        /// <summary>"Width"</summary>
        RASTER_SYMBOL_WIDTH = -1007765, // 0xFFF09F6B
        /// <summary>"Resolution (dpi)"</summary>
        RASTER_SYMBOL_RESOLUTION = -1007764, // 0xFFF09F6C
        /// <summary>"Loaded from file"</summary>
        RASTER_SYMBOL_FILENAME = -1007763, // 0xFFF09F6D
        /// <summary>"View Name"</summary>
        RASTER_SYMBOL_VIEWNAME = -1007762, // 0xFFF09F6E
        /// <summary>"Height (pixels)"</summary>
        RASTER_SYMBOL_PIXELHEIGHT = -1007761, // 0xFFF09F6F
        /// <summary>"Width (pixels)"</summary>
        RASTER_SYMBOL_PIXELWIDTH = -1007760, // 0xFFF09F70
        /// <summary>"Lock Proportions"</summary>
        RASTER_LOCK_PROPORTIONS = -1007752, // 0xFFF09F78
        /// <summary>"Height"</summary>
        RASTER_SHEETHEIGHT = -1007751, // 0xFFF09F79
        /// <summary>"Width"</summary>
        RASTER_SHEETWIDTH = -1007750, // 0xFFF09F7A
        /// <summary>"Roll"</summary>
        IMPORT_ADT_ENTITY_ROLL = -1007738, // 0xFFF09F86
        /// <summary>"Thickness"</summary>
        IMPORT_ADT_ENTITY_THICKNESS = -1007737, // 0xFFF09F87
        /// <summary>"Length"</summary>
        IMPORT_ADT_ENTITY_LENGTH = -1007736, // 0xFFF09F88
        /// <summary>"Width"</summary>
        IMPORT_ADT_ENTITY_WIDTH = -1007735, // 0xFFF09F89
        /// <summary>"Height"</summary>
        IMPORT_ADT_ENTITY_HEIGHT = -1007734, // 0xFFF09F8A
        /// <summary>"Component Description"</summary>
        IMPORT_ADT_COMPONENTS_DESC = -1007733, // 0xFFF09F8B
        /// <summary>"Style Name"</summary>
        IMPORT_ADT_ENTITY_STYLE = -1007732, // 0xFFF09F8C
        /// <summary>"Structural Type Name"</summary>
        IMPORT_ADT_ENTITY_STRUCT_TYPE = -1007731, // 0xFFF09F8D
        /// <summary>"Type Name"</summary>
        IMPORT_ADT_ENTITY_TYPE = -1007730, // 0xFFF09F8E
        /// <summary>"Phase Mapping"</summary>
        RVT_LINK_PHASE_MAP = -1007728, // 0xFFF09F90
        /// <summary>"Reference Type"</summary>
        RVT_LINK_REFERENCE_TYPE = -1007727, // 0xFFF09F91
        /// <summary>"File Name"</summary>
        RVT_LINK_FILE_NAME_WITHOUT_EXT = -1007726, // 0xFFF09F92
        /// <summary>"Map Levels..."</summary>
        RVT_LEVEL_OFFSET = -1007725, // 0xFFF09F93
        /// <summary>"Map Levels..."</summary>
        RVT_HOST_LEVEL = -1007724, // 0xFFF09F94
        /// <summary>"Map Levels..."</summary>
        RVT_SOURCE_LEVEL = -1007723, // 0xFFF09F95
        /// <summary>"Name"</summary>
        RVT_LINK_INSTANCE_NAME = -1007721, // 0xFFF09F97
        /// <summary>"Shared Site"</summary>
        GEO_LOCATION = -1007720, // 0xFFF09F98
        /// <summary>"Instance Scale"</summary>
        IMPORT_INSTANCE_SCALE = -1007706, // 0xFFF09FA6
        /// <summary>"Draw Layer"</summary>
        IMPORT_BACKGROUND = -1007705, // 0xFFF09FA7
        /// <summary>"Import Units"</summary>
        IMPORT_DISPLAY_UNITS = -1007704, // 0xFFF09FA8
        /// <summary>"Base Offset"</summary>
        IMPORT_BASE_LEVEL_OFFSET = -1007703, // 0xFFF09FA9
        /// <summary>"Base Level"</summary>
        IMPORT_BASE_LEVEL = -1007702, // 0xFFF09FAA
        /// <summary>"Scale Factor"</summary>
        IMPORT_SCALE = -1007701, // 0xFFF09FAB
        /// <summary>"Name"</summary>
        IMPORT_SYMBOL_NAME = -1007700, // 0xFFF09FAC
        /// <summary>"Elevation Mark"</summary>
        ELEV_SYMBOL_ID = -1007610, // 0xFFF0A006
        /// <summary>"Reference Label Position"</summary>
        ELEV_REFERENCE_LABEL_POS = -1007609, // 0xFFF0A007
        /// <summary>"Associated Datum"</summary>
        ELEV_ASSOC_DATUM = -1007608, // 0xFFF0A008
        /// <summary>"View Name Position"</summary>
        ELEV_VIEW_NAME_POS = -1007607, // 0xFFF0A009
        /// <summary>"Show View Name"</summary>
        ELEV_SHOW_VIEW_NAME = -1007605, // 0xFFF0A00B
        /// <summary>"Text Position"</summary>
        ELEV_TEXT_POS = -1007604, // 0xFFF0A00C
        /// <summary>"Filled"</summary>
        ELEV_ARROW_FILLED = -1007603, // 0xFFF0A00D
        /// <summary>"Arrow Angle"</summary>
        ELEV_ARROW_ANGLE = -1007602, // 0xFFF0A00E
        /// <summary>"Shape"</summary>
        ELEV_SHAPE = -1007601, // 0xFFF0A00F
        /// <summary>"Width"</summary>
        ELEV_WIDTH = -1007600, // 0xFFF0A010
        /// <summary>"Swatch Height"</summary>
        COLOR_FILL_SWATCH_HEIGHT_PARAM = -1007504, // 0xFFF0A070
        /// <summary>"Swatch Width"</summary>
        COLOR_FILL_SWATCH_WIDTH_PARAM = -1007503, // 0xFFF0A071
        /// <summary>"Values Displayed"</summary>
        COLOR_FILL_FILTERED_PARAM = -1007502, // 0xFFF0A072
        /// <summary>"Guide Grid"</summary>
        SHEET_GUIDE_GRID = -1007419, // 0xFFF0A0C5
        /// <summary>"Current Revision Issued"</summary>
        SHEET_CURRENT_REVISION_ISSUED = -1007418, // 0xFFF0A0C6
        /// <summary>"Current Revision Issued By"</summary>
        SHEET_CURRENT_REVISION_ISSUED_BY = -1007417, // 0xFFF0A0C7
        /// <summary>"Current Revision Issued To"</summary>
        SHEET_CURRENT_REVISION_ISSUED_TO = -1007416, // 0xFFF0A0C8
        /// <summary>"Current Revision Date"</summary>
        SHEET_CURRENT_REVISION_DATE = -1007415, // 0xFFF0A0C9
        /// <summary>"Current Revision Description"</summary>
        SHEET_CURRENT_REVISION_DESCRIPTION = -1007414, // 0xFFF0A0CA
        /// <summary>"Revisions on Sheet"</summary>
        SHEET_REVISIONS_ON_SHEET = -1007413, // 0xFFF0A0CB
        /// <summary>"Current Revision"</summary>
        SHEET_CURRENT_REVISION = -1007412, // 0xFFF0A0CC
        /// <summary>"Sheet Height"</summary>
        SHEET_HEIGHT = -1007411, // 0xFFF0A0CD
        /// <summary>"Sheet Width"</summary>
        SHEET_WIDTH = -1007410, // 0xFFF0A0CE
        /// <summary>"File Path"</summary>
        SHEET_FILE_PATH = -1007409, // 0xFFF0A0CF
        /// <summary>"Approved By"</summary>
        SHEET_APPROVED_BY = -1007408, // 0xFFF0A0D0
        /// <summary>"Designed By"</summary>
        SHEET_DESIGNED_BY = -1007407, // 0xFFF0A0D1
        /// <summary>"Appears In Sheet List"</summary>
        SHEET_SCHEDULED = -1007406, // 0xFFF0A0D2
        /// <summary>"Checked By"</summary>
        SHEET_CHECKED_BY = -1007405, // 0xFFF0A0D3
        /// <summary>"Drawn By"</summary>
        SHEET_DRAWN_BY = -1007404, // 0xFFF0A0D4
        /// <summary>"Date/Time Stamp"</summary>
        SHEET_DATE = -1007403, // 0xFFF0A0D5
        /// <summary>"Scale"</summary>
        SHEET_SCALE = -1007402, // 0xFFF0A0D6
        /// <summary>"Sheet Number"</summary>
        SHEET_NUMBER = -1007401, // 0xFFF0A0D7
        /// <summary>"Sheet Name"</summary>
        SHEET_NAME = -1007400, // 0xFFF0A0D8
        /// <summary>"Append Position"</summary>
        SPACING_APPEND = -1007398, // 0xFFF0A0DA
        /// <summary>"Join Condition"</summary>
        AUTO_JOIN_CONDITION_WALL = -1007395, // 0xFFF0A0DD
        /// <summary>"Border 2 Type"</summary>
        AUTO_MULLION_BORDER2_HORIZ = -1007394, // 0xFFF0A0DE
        /// <summary>"Border 1 Type"</summary>
        AUTO_MULLION_BORDER1_HORIZ = -1007393, // 0xFFF0A0DF
        /// <summary>"Border 2 Type"</summary>
        AUTO_MULLION_BORDER2_VERT = -1007392, // 0xFFF0A0E0
        /// <summary>"Border 1 Type"</summary>
        AUTO_MULLION_BORDER1_VERT = -1007391, // 0xFFF0A0E1
        /// <summary>"Interior Type"</summary>
        AUTO_MULLION_INTERIOR_HORIZ = -1007390, // 0xFFF0A0E2
        /// <summary>"Interior Type"</summary>
        AUTO_MULLION_INTERIOR_VERT = -1007389, // 0xFFF0A0E3
        /// <summary>"Curtain Panel"</summary>
        AUTO_PANEL_WALL = -1007388, // 0xFFF0A0E4
        /// <summary>"Join Condition"</summary>
        AUTO_JOIN_CONDITION = -1007387, // 0xFFF0A0E5
        /// <summary>"Curtain Panel"</summary>
        AUTO_PANEL = -1007386, // 0xFFF0A0E6
        /// <summary>"Border 2 Type"</summary>
        AUTO_MULLION_BORDER2_GRID2 = -1007385, // 0xFFF0A0E7
        /// <summary>"Border 1 Type"</summary>
        AUTO_MULLION_BORDER1_GRID2 = -1007384, // 0xFFF0A0E8
        /// <summary>"Border 2 Type"</summary>
        AUTO_MULLION_BORDER2_GRID1 = -1007383, // 0xFFF0A0E9
        /// <summary>"Border 1 Type"</summary>
        AUTO_MULLION_BORDER1_GRID1 = -1007382, // 0xFFF0A0EA
        /// <summary>"Interior Type"</summary>
        AUTO_MULLION_INTERIOR_GRID2 = -1007381, // 0xFFF0A0EB
        /// <summary>"Interior Type"</summary>
        AUTO_MULLION_INTERIOR_GRID1 = -1007380, // 0xFFF0A0EC
        /// <summary>"Grid Base Orientation"</summary>
        CURTAIN_GRID_BASE_ORIENTATION = -1007364, // 0xFFF0A0FC
        /// <summary>"Angle"</summary>
        MULLION_ANGLE = -1007363, // 0xFFF0A0FD
        /// <summary>"Position"</summary>
        MULLION_POSITION = -1007362, // 0xFFF0A0FE
        /// <summary>"Profile"</summary>
        MULLION_PROFILE = -1007361, // 0xFFF0A0FF
        /// <summary>"Center Width"</summary>
        TRAP_MULL_WIDTH = -1007359, // 0xFFF0A101
        /// <summary>"Depth 2"</summary>
        MULLION_DEPTH2 = -1007358, // 0xFFF0A102
        /// <summary>"Depth 1"</summary>
        MULLION_DEPTH1 = -1007357, // 0xFFF0A103
        /// <summary>"Depth"</summary>
        MULLION_DEPTH = -1007356, // 0xFFF0A104
        /// <summary>"Leg 2"</summary>
        LV_MULLION_LEG2 = -1007355, // 0xFFF0A105
        /// <summary>"Leg 1"</summary>
        LV_MULLION_LEG1 = -1007354, // 0xFFF0A106
        /// <summary>"Corner Mullion"</summary>
        MULLION_CORNER_TYPE = -1007353, // 0xFFF0A107
        /// <summary>"Mullion Family General Shape"</summary>
        MULLION_FAM_TYPE = -1007352, // 0xFFF0A108
        /// <summary>"Offset"</summary>
        MULLION_OFFSET = -1007351, // 0xFFF0A109
        /// <summary>"Radius"</summary>
        CIRC_MULLION_RADIUS = -1007350, // 0xFFF0A10A
        /// <summary>"Thickness"</summary>
        CUST_MULLION_THICK = -1007322, // 0xFFF0A126
        /// <summary>"Width on side 2"</summary>
        CUST_MULLION_WIDTH2 = -1007321, // 0xFFF0A127
        /// <summary>"Width on side 1"</summary>
        CUST_MULLION_WIDTH1 = -1007320, // 0xFFF0A128
        /// <summary>"Thickness"</summary>
        RECT_MULLION_THICK = -1007304, // 0xFFF0A138
        /// <summary>"Width on side 2"</summary>
        RECT_MULLION_WIDTH2 = -1007301, // 0xFFF0A13B
        /// <summary>"Width on side 1"</summary>
        RECT_MULLION_WIDTH1 = -1007300, // 0xFFF0A13C
        /// <summary>"Show Up arrow in all views"</summary>
        STAIRS_INST_ALWAYS_UP = -1007278, // 0xFFF0A152
        /// <summary>"Trim Stringers at Top"</summary>
        STAIRS_ATTR_TRIM_TOP = -1007277, // 0xFFF0A153
        /// <summary>"Down arrow"</summary>
        STAIRS_INST_DOWN_ARROW_ON = -1007276, // 0xFFF0A154
        /// <summary>"Down text"</summary>
        STAIRS_INST_DOWN_LABEL_TEXT = -1007275, // 0xFFF0A155
        /// <summary>"Down label"</summary>
        STAIRS_INST_DOWN_LABEL_ON = -1007274, // 0xFFF0A156
        /// <summary>"Up arrow"</summary>
        STAIRS_INST_UP_ARROW_ON = -1007273, // 0xFFF0A157
        /// <summary>"Up text"</summary>
        STAIRS_INST_UP_LABEL_TEXT = -1007272, // 0xFFF0A158
        /// <summary>"Up label"</summary>
        STAIRS_INST_UP_LABEL_ON = -1007271, // 0xFFF0A159
        /// <summary>"Text Size"</summary>
        STAIRS_ATTR_TEXT_SIZE = -1007270, // 0xFFF0A15A
        /// <summary>"Text Font"</summary>
        STAIRS_ATTR_TEXT_FONT = -1007269, // 0xFFF0A15B
        /// <summary>"Monolithic Material"</summary>
        STAIRS_ATTR_BODY_MATERIAL = -1007268, // 0xFFF0A15C
        /// <summary>"Landing Carriage Height"</summary>
        STAIRS_ATTR_LANDING_CARRIAGE = -1007267, // 0xFFF0A15D
        /// <summary>"Landing Overlap"</summary>
        STAIRS_ATTR_LANDINGS_OVERLAPPING = -1007266, // 0xFFF0A15E
        /// <summary>"Right Stringer"</summary>
        STAIRS_ATTR_RIGHT_SIDE_STRINGER = -1007265, // 0xFFF0A15F
        /// <summary>"Left Stringer"</summary>
        STAIRS_ATTR_LEFT_SIDE_STRINGER = -1007264, // 0xFFF0A160
        /// <summary>"Apply Nosing Profile"</summary>
        STAIRS_ATTR_NOSING_PLACEMENT = -1007263, // 0xFFF0A161
        /// <summary>"Riser to Tread Connection"</summary>
        STAIRS_ATTR_RISER_TREAD_CONNECT = -1007262, // 0xFFF0A162
        /// <summary>"Riser Thickness"</summary>
        STAIRS_ATTR_RISER_THICKNESS = -1007261, // 0xFFF0A163
        /// <summary>"Middle Stringers"</summary>
        STAIRS_ATTR_NUM_MID_STRINGERS = -1007260, // 0xFFF0A164
        /// <summary>"Extend Below Base"</summary>
        STAIRS_ATTR_STAIRS_CUT_OFFSET = -1007259, // 0xFFF0A165
        /// <summary>"End with Riser"</summary>
        STAIRS_ATTR_LAST_RISER = -1007258, // 0xFFF0A166
        /// <summary>"Begin with Riser"</summary>
        STAIRS_ATTR_FIRST_RISER = -1007257, // 0xFFF0A167
        /// <summary>"Underside of Winder"</summary>
        STAIRS_ATTR_STAIRS_BOTTOM = -1007256, // 0xFFF0A168
        /// <summary>"Monolithic Stairs"</summary>
        STAIRS_ATTR_MONOLITHIC_STAIRS = -1007255, // 0xFFF0A169
        /// <summary>"Calculation Rules"</summary>
        STAIRS_ATTR_CALC_ENABLED = -1007254, // 0xFFF0A16A
        /// <summary>"Calculation Rules"</summary>
        STAIRS_ATTR_CALC_MAX = -1007253, // 0xFFF0A16B
        /// <summary>"Calculation Rules"</summary>
        STAIRS_ATTR_CALC_MIN = -1007252, // 0xFFF0A16C
        /// <summary>"Calculation Rules"</summary>
        STAIRS_ATTR_EQ_RESULT = -1007251, // 0xFFF0A16D
        /// <summary>"Actual Tread Depth"</summary>
        STAIRS_ACTUAL_TREAD_DEPTH = -1007250, // 0xFFF0A16E
        /// <summary>"Tread Multiplier"</summary>
        STAIRS_ATTR_TREAD_MULT = -1007249, // 0xFFF0A16F
        /// <summary>"Riser Multiplier"</summary>
        STAIRS_ATTR_RISER_MULT = -1007248, // 0xFFF0A170
        /// <summary>"Calculation Rules"</summary>
        STAIRS_ATTR_STAIR_CALCULATOR = -1007247, // 0xFFF0A171
        /// <summary>"Actual Number of Risers"</summary>
        STAIRS_ACTUAL_NUM_RISERS = -1007246, // 0xFFF0A172
        /// <summary>"Break Symbol in Plan"</summary>
        STAIRS_ATTR_BREAK_SYM_IN_CUTLINE = -1007245, // 0xFFF0A173
        /// <summary>"Riser Material"</summary>
        STAIRS_ATTR_RISER_MATERIAL = -1007244, // 0xFFF0A174
        /// <summary>"Riser Type"</summary>
        STAIRS_ATTR_RISER_TYPE = -1007243, // 0xFFF0A175
        /// <summary>"Tread Material"</summary>
        STAIRS_ATTR_TREAD_MATERIAL = -1007242, // 0xFFF0A176
        /// <summary>"Nosing Length"</summary>
        STAIRS_ATTR_NOSING_LENGTH = -1007241, // 0xFFF0A177
        /// <summary>"Nosing Profile"</summary>
        STAIRS_ATTR_TREAD_FRONT_PROFILE = -1007240, // 0xFFF0A178
        /// <summary>"Stringer Material"</summary>
        STAIRS_ATTR_STRINGER_MATERIAL = -1007239, // 0xFFF0A179
        /// <summary>"Open Stringer Offset"</summary>
        STAIRS_ATTR_STRINGER_OFFSET = -1007238, // 0xFFF0A17A
        /// <summary>"Stringer Carriage Height"</summary>
        STAIRS_ATTR_STRINGER_CARRIAGE = -1007237, // 0xFFF0A17B
        /// <summary>"Type of Side Stringers"</summary>
        STAIRS_ATTR_SIDE_STRINGER_TYPE_PARAM = -1007236, // 0xFFF0A17C
        /// <summary>"Multistory Top Level"</summary>
        STAIRS_MULTISTORY_TOP_LEVEL_PARAM = -1007235, // 0xFFF0A17D
        /// <summary>"Stringer Position"</summary>
        STAIRS_STRINGERS_PRESENT = -1007234, // 0xFFF0A17E
        /// <summary>"Top Offset"</summary>
        STAIRS_TOP_OFFSET = -1007219, // 0xFFF0A18D
        /// <summary>"Base Offset"</summary>
        STAIRS_BASE_OFFSET = -1007218, // 0xFFF0A18E
        /// <summary>"Riser Angle"</summary>
        STAIRS_ATTR_RISER_ANGLE = -1007212, // 0xFFF0A194
        /// <summary>"Tread Thickness"</summary>
        STAIRS_ATTR_TREAD_THICKNESS = -1007211, // 0xFFF0A195
        /// <summary>"Stringer Thickness"</summary>
        STAIRS_ATTR_STRINGER_THICKNESS = -1007210, // 0xFFF0A196
        /// <summary>"Stringer Height"</summary>
        STAIRS_ATTR_STRINGER_HEIGHT = -1007209, // 0xFFF0A197
        /// <summary>"Risers Present"</summary>
        STAIRS_ATTR_RISERS_PRESENT = -1007208, // 0xFFF0A198
        /// <summary>"Actual Riser Height"</summary>
        STAIRS_ACTUAL_RISER_HEIGHT = -1007206, // 0xFFF0A19A
        /// <summary>"Desired Number of Risers"</summary>
        STAIRS_DESIRED_NUM_RISERS = -1007205, // 0xFFF0A19B
        /// <summary>"Width"</summary>
        STAIRS_ATTR_TREAD_WIDTH = -1007204, // 0xFFF0A19C
        /// <summary>"Minimum Tread Depth"</summary>
        STAIRS_ATTR_MINIMUM_TREAD_DEPTH = -1007203, // 0xFFF0A19D
        /// <summary>"Maximum Riser Height"</summary>
        STAIRS_ATTR_MAX_RISER_HEIGHT = -1007202, // 0xFFF0A19E
        /// <summary>"Top Level"</summary>
        STAIRS_TOP_LEVEL_PARAM = -1007201, // 0xFFF0A19F
        /// <summary>"Base Level"</summary>
        STAIRS_BASE_LEVEL_PARAM = -1007200, // 0xFFF0A1A0
        /// <summary>"Structural"</summary>
        LEVEL_IS_STRUCTURAL = -1007112, // 0xFFF0A1F8
        /// <summary>"Building Story"</summary>
        LEVEL_IS_BUILDING_STORY = -1007111, // 0xFFF0A1F9
        /// <summary>"Story Above"</summary>
        LEVEL_UP_TO_LEVEL = -1007110, // 0xFFF0A1FA
        /// <summary>"Elevation Base"</summary>
        LEVEL_RELATIVE_BASE_TYPE = -1007109, // 0xFFF0A1FB
        /// <summary>"Elevation"</summary>
        LEVEL_ELEV = -1007102, // 0xFFF0A202
        /// <summary>"Level"</summary>
        LEVEL_NAME = -1007101, // 0xFFF0A203
        /// <summary>"Symbol"</summary>
        LEVEL_HEAD_TAG = -1007100, // 0xFFF0A204
        /// <summary>"Show Dimension Text"</summary>
        MULTI_REFERENCE_ANNOTATION_SHOW_DIMENSION_TEXT = -1007054, // 0xFFF0A232
        /// <summary>"Dimension Style"</summary>
        MULTI_REFERENCE_ANNOTATION_DIMENSION_STYLE = -1007053, // 0xFFF0A233
        /// <summary>"Group Matching Tag Heads"</summary>
        MULTI_REFERENCE_ANNOTATION_GROUP_TAG_HEADS = -1007052, // 0xFFF0A234
        /// <summary>"Tag Family"</summary>
        MULTI_REFERENCE_ANNOTATION_TAG_TYPE = -1007051, // 0xFFF0A235
        /// <summary>"Reference Category"</summary>
        MULTI_REFERENCE_ANNOTATION_REFERENCE_CATEGORY = -1007050, // 0xFFF0A236
        /// <summary>"Leader Type"</summary>
        TAG_LEADER_TYPE = -1007006, // 0xFFF0A262
        /// <summary>"Wrap between parameters only"</summary>
        TAG_NO_BREAK_PARAM_STRINGS = -1007005, // 0xFFF0A263
        /// <summary>"Orientation"</summary>
        ROOM_TAG_ORIENTATION_PARAM = -1007004, // 0xFFF0A264
        /// <summary>"Orientation"</summary>
        TAG_ORIENTATION_PARAM = -1007003, // 0xFFF0A265
        /// <summary>"Sample Text"</summary>
        TAG_SAMPLE_TEXT = -1007001, // 0xFFF0A267
        /// <summary>"Label"</summary>
        TAG_TAG = -1007000, // 0xFFF0A268
        /// <summary>"Diameter Symbol Text"</summary>
        DIAMETER_SYMBOL_TEXT = -1006999, // 0xFFF0A269
        /// <summary>"Diameter Symbol Location"</summary>
        DIAMETER_SYMBOL_LOCATION = -1006998, // 0xFFF0A26A
        /// <summary>"Radius Symbol Text"</summary>
        RADIUS_SYMBOL_TEXT = -1006997, // 0xFFF0A26B
        /// <summary>"V/G Overrides Coordination Model"</summary>
        VIS_GRAPHICS_COORDINATION_MODEL = -1006970, // 0xFFF0A286
        /// <summary>"V/G Overrides Point Clouds"</summary>
        VIS_GRAPHICS_POINT_CLOUDS = -1006969, // 0xFFF0A287
        /// <summary>"V/G Overrides Worksets"</summary>
        VIS_GRAPHICS_WORKSETS = -1006968, // 0xFFF0A288
        /// <summary>"V/G Overrides Analytical Model"</summary>
        VIS_GRAPHICS_ANALYTICAL_MODEL = -1006967, // 0xFFF0A289
        /// <summary>"V/G Overrides Design Options"</summary>
        VIS_GRAPHICS_DESIGNOPTIONS = -1006966, // 0xFFF0A28A
        /// <summary>"V/G Overrides RVT Links"</summary>
        VIS_GRAPHICS_RVT_LINKS = -1006965, // 0xFFF0A28B
        /// <summary>"V/G Overrides Filters"</summary>
        VIS_GRAPHICS_FILTERS = -1006964, // 0xFFF0A28C
        /// <summary>"V/G Overrides Import"</summary>
        VIS_GRAPHICS_IMPORT = -1006963, // 0xFFF0A28D
        /// <summary>"V/G Overrides Annotation"</summary>
        VIS_GRAPHICS_ANNOTATION = -1006962, // 0xFFF0A28E
        /// <summary>"V/G Overrides Model"</summary>
        VIS_GRAPHICS_MODEL = -1006961, // 0xFFF0A28F
        /// <summary>"Automatic Room Computation Height"</summary>
        LEVEL_ATTR_ROOM_COMPUTATION_AUTOMATIC = -1006941, // 0xFFF0A2A3
        /// <summary>"Computation Height"</summary>
        LEVEL_ATTR_ROOM_COMPUTATION_HEIGHT = -1006940, // 0xFFF0A2A4
        /// <summary>"Computation Height"</summary>
        LEVEL_ROOM_COMPUTATION_HEIGHT = -1006939, // 0xFFF0A2A5
        /// <summary>"Computation Height"</summary>
        ROOM_COMPUTATION_HEIGHT = -1006928, // 0xFFF0A2B0
        /// <summary>"Base Offset"</summary>
        ALWAYS_ZERO_LENGTH = -1006927, // 0xFFF0A2B1
        /// <summary>"Computation"</summary>
        ROOM_COMPUTATION_METHOD = -1006926, // 0xFFF0A2B2
        /// <summary>"Base Offset"</summary>
        ROOM_LOWER_OFFSET = -1006925, // 0xFFF0A2B3
        /// <summary>"Limit Offset"</summary>
        ROOM_UPPER_OFFSET = -1006924, // 0xFFF0A2B4
        /// <summary>"Upper Limit"</summary>
        ROOM_UPPER_LEVEL = -1006922, // 0xFFF0A2B6
        /// <summary>"Volume"</summary>
        ROOM_VOLUME = -1006921, // 0xFFF0A2B7
        /// <summary>"Unbounded Height"</summary>
        ROOM_HEIGHT = -1006920, // 0xFFF0A2B8
        /// <summary>"Perimeter"</summary>
        ROOM_PERIMETER = -1006917, // 0xFFF0A2BB
        /// <summary>"Level"</summary>
        ROOM_LEVEL_ID = -1006916, // 0xFFF0A2BC
        /// <summary>"Occupancy"</summary>
        ROOM_OCCUPANCY = -1006909, // 0xFFF0A2C3
        /// <summary>"Department"</summary>
        ROOM_DEPARTMENT = -1006907, // 0xFFF0A2C5
        /// <summary>"Base Finish"</summary>
        ROOM_FINISH_BASE = -1006906, // 0xFFF0A2C6
        /// <summary>"Ceiling Finish"</summary>
        ROOM_FINISH_CEILING = -1006905, // 0xFFF0A2C7
        /// <summary>"Wall Finish"</summary>
        ROOM_FINISH_WALL = -1006904, // 0xFFF0A2C8
        /// <summary>"Floor Finish"</summary>
        ROOM_FINISH_FLOOR = -1006903, // 0xFFF0A2C9
        /// <summary>"Area"</summary>
        ROOM_AREA = -1006902, // 0xFFF0A2CA
        /// <summary>"Number"</summary>
        ROOM_NUMBER = -1006901, // 0xFFF0A2CB
        /// <summary>"Name"</summary>
        ROOM_NAME = -1006900, // 0xFFF0A2CC
        /// <summary>"Legend Horizontal Origin Gap"</summary>
        SPATIAL_FIELD_MGR_LEGEND_HOR_ORIGIN_GAP = -1006861, // 0xFFF0A2F3
        /// <summary>"Legend Vertical Origin Gap"</summary>
        SPATIAL_FIELD_MGR_LEGEND_VERT_ORIGIN_GAP = -1006860, // 0xFFF0A2F4
        /// <summary>"Legend Width"</summary>
        SPATIAL_FIELD_MGR_LEGEND_WIDTH = -1006859, // 0xFFF0A2F5
        /// <summary>"Legend Height"</summary>
        SPATIAL_FIELD_MGR_LEGEND_HEIGHT = -1006858, // 0xFFF0A2F6
        /// <summary>"Analysis Display Settings"</summary>
        VIEW_ANALYSIS_RESULTS_VISIBILITY = -1006857, // 0xFFF0A2F7
        /// <summary>"Overall Legend Text"</summary>
        SPATIAL_FIELD_MGR_LEGEND_TEXT_TYPE = -1006856, // 0xFFF0A2F8
        /// <summary>"Results Visibility"</summary>
        SPATIAL_FIELD_MGR_RESULTS_VISIBILITY = -1006855, // 0xFFF0A2F9
        /// <summary>"Show Description"</summary>
        SPATIAL_FIELD_MGR_LEGEND_SHOW_DESCRIPTION = -1006854, // 0xFFF0A2FA
        /// <summary>"Show Configuration Name"</summary>
        SPATIAL_FIELD_MGR_LEGEND_SHOW_CONFIG_NAME = -1006853, // 0xFFF0A2FB
        /// <summary>"Description"</summary>
        SPATIAL_FIELD_MGR_DESCRIPTION = -1006852, // 0xFFF0A2FC
        /// <summary>"Analysis Configuration"</summary>
        SPATIAL_FIELD_MGR_CURRENT_NAME = -1006851, // 0xFFF0A2FD
        /// <summary>"Data Range"</summary>
        SPATIAL_FIELD_MGR_RANGE = -1006850, // 0xFFF0A2FE
        /// <summary>"End Segments Length"</summary>
        GRID_END_SEGMENTS_LENGTH = -1006711, // 0xFFF0A389
        /// <summary>"End Segment Pattern"</summary>
        GRID_END_SEGMENT_PATTERN = -1006710, // 0xFFF0A38A
        /// <summary>"End Segment Color"</summary>
        GRID_END_SEGMENT_COLOR = -1006709, // 0xFFF0A38B
        /// <summary>"End Segment Weight"</summary>
        GRID_END_SEGMENT_WEIGHT = -1006708, // 0xFFF0A38C
        /// <summary>"Center Segment Pattern"</summary>
        GRID_CENTER_SEGMENT_PATTERN = -1006707, // 0xFFF0A38D
        /// <summary>"Center Segment Color"</summary>
        GRID_CENTER_SEGMENT_COLOR = -1006706, // 0xFFF0A38E
        /// <summary>"Center Segment Weight"</summary>
        GRID_CENTER_SEGMENT_WEIGHT = -1006705, // 0xFFF0A38F
        /// <summary>"Center Segment"</summary>
        GRID_CENTER_SEGMENT_STYLE = -1006704, // 0xFFF0A390
        /// <summary>"Bubble Weight Number\n"</summary>
        GRID_BUBBLE_LINE_PEN = -1006703, // 0xFFF0A391
        /// <summary>"Symbol"</summary>
        GRID_HEAD_TAG = -1006700, // 0xFFF0A394
        /// <summary>"Full Step Arrow"</summary>
        STAIRS_PATH_FULL_STEP_ARROW = -1006661, // 0xFFF0A3BB
        /// <summary>"Start Extension"</summary>
        STAIRS_PATH_START_EXTENSION = -1006660, // 0xFFF0A3BC
        /// <summary>"Number Size"</summary>
        NUMBER_SYSTEM_TEXT_SIZE = -1006645, // 0xFFF0A3CB
        /// <summary>"Tag Type"</summary>
        NUMBER_SYSTEM_TAG_TYPE = -1006644, // 0xFFF0A3CC
        /// <summary>"Display Rule"</summary>
        NUMBER_SYSTEM_DISPLAY_RULE = -1006643, // 0xFFF0A3CD
        /// <summary>"Reference"</summary>
        NUMBER_SYSTEM_REFERENCE = -1006642, // 0xFFF0A3CE
        /// <summary>"Justify"</summary>
        NUMBER_SYSTEM_JUSTIFY = -1006641, // 0xFFF0A3CF
        /// <summary>"Orientation"</summary>
        NUMBER_SYSTEM_ORIENTATION = -1006639, // 0xFFF0A3D1
        /// <summary>"Offset from Reference"</summary>
        NUMBER_SYSTEM_REFERENCE_OFFSET = -1006638, // 0xFFF0A3D2
        /// <summary>"Justify Offset"</summary>
        NUMBER_SYSTEM_JUSTIFY_OFFSET = -1006637, // 0xFFF0A3D3
        /// <summary>"Orientation"</summary>
        STAIRS_TEXT_ORIENTATION = -1006636, // 0xFFF0A3D4
        /// <summary>"Text Type"</summary>
        STAIRS_TEXT_TYPE = -1006635, // 0xFFF0A3D5
        /// <summary>"Down Text"</summary>
        STAIRS_DOWN_TEXT = -1006634, // 0xFFF0A3D6
        /// <summary>"Show Down Text"</summary>
        STAIRS_SHOW_DOWN_TEXT = -1006633, // 0xFFF0A3D7
        /// <summary>"Up Text"</summary>
        STAIRS_UP_TEXT = -1006632, // 0xFFF0A3D8
        /// <summary>"Show Up Text"</summary>
        STAIRS_SHOW_UP_TEXT = -1006631, // 0xFFF0A3D9
        /// <summary>"Show Arrowhead to Cut Mark"</summary>
        SHOW_ARROWHEAD_TO_CUT_MARK = -1006630, // 0xFFF0A3DA
        /// <summary>"Draw for Each Run"</summary>
        DRAW_FOR_EACH_RUN = -1006628, // 0xFFF0A3DC
        /// <summary>"End at Riser"</summary>
        ARROWHEAD_END_AT_RISER = -1006627, // 0xFFF0A3DD
        /// <summary>"Start from Riser"</summary>
        STAIRS_PATH_START_FROM_RISER = -1006626, // 0xFFF0A3DE
        /// <summary>"Distance to Cut Mark"</summary>
        DISTANCE_TO_CUT_MARK = -1006625, // 0xFFF0A3DF
        /// <summary>"Line Shape at Landing Corner"</summary>
        LINE_SHAPE_AT_CORNER = -1006624, // 0xFFF0A3E0
        /// <summary>"Arrowhead Type"</summary>
        ARROWHEAD_TYPE = -1006623, // 0xFFF0A3E1
        /// <summary>"Start Symbol Type"</summary>
        START_SYMBOL_TYPE = -1006622, // 0xFFF0A3E2
        /// <summary>"Cut Mark Symbol Size"</summary>
        CUT_MARK_SYMBOL_SIZE = -1006621, // 0xFFF0A3E3
        /// <summary>"Cut Line Type"</summary>
        CUT_LINE_TYPE = -1006620, // 0xFFF0A3E4
        /// <summary>"Cut Line Angle"</summary>
        CUT_LINE_ANGLE = -1006619, // 0xFFF0A3E5
        /// <summary>"Cut Line Extension"</summary>
        CUT_LINE_EXTENSION = -1006618, // 0xFFF0A3E6
        /// <summary>"Cut Line Distance"</summary>
        CUT_LINE_DISTANCE = -1006617, // 0xFFF0A3E7
        /// <summary>"Cut Mark Symbol"</summary>
        CUT_MARK_SYMBOL = -1006616, // 0xFFF0A3E8
        /// <summary>"Broken Section Display Style"</summary>
        SECTION_BROKEN_DISPLAY_STYLE = -1006615, // 0xFFF0A3E9
        /// <summary>"Hide at scales coarser than"</summary>
        SECTION_COARSER_SCALE_PULLDOWN_IMPERIAL = -1006614, // 0xFFF0A3EA
        /// <summary>"Hide at scales coarser than"</summary>
        SECTION_COARSER_SCALE_PULLDOWN_METRIC = -1006613, // 0xFFF0A3EB
        /// <summary>"Parent View"</summary>
        SECTION_PARENT_VIEW_NAME = -1006612, // 0xFFF0A3EC
        /// <summary>"Show in"</summary>
        SECTION_SHOW_IN_ONE_VIEW_ONLY = -1006609, // 0xFFF0A3EF
        /// <summary>"Section Tail"</summary>
        SECTION_ATTR_TAIL_TAG = -1006608, // 0xFFF0A3F0
        /// <summary>"Tail width"</summary>
        SECTION_ATTR_TAIL_WIDTH = -1006604, // 0xFFF0A3F4
        /// <summary>"Tail length"</summary>
        SECTION_ATTR_TAIL_LENGTH = -1006603, // 0xFFF0A3F5
        /// <summary>"Detail Number"</summary>
        VIEWER_DETAIL_NUMBER = -1006602, // 0xFFF0A3F6
        /// <summary>"Sheet Number"</summary>
        VIEWER_SHEET_NUMBER = -1006601, // 0xFFF0A3F7
        /// <summary>"Section Head"</summary>
        SECTION_ATTR_HEAD_TAG = -1006600, // 0xFFF0A3F8
        /// <summary>"Station Value": Currently not in use</summary>
        ALIGNMENT_STATION_LABEL_STATION_VALUE = -1006599, // 0xFFF0A3F9
        /// <summary>"Station Indicator"</summary>
        ALIGNMENT_STATION_LABEL_IND_STATION = -1006598, // 0xFFF0A3FA
        /// <summary>"Include Station"</summary>
        ALIGNMENT_STATION_LABEL_INCLUDE_STATION = -1006597, // 0xFFF0A3FB
        /// <summary>"Leader Line"</summary>
        SPOT_DIM_LEADER_LINE = -1006596, // 0xFFF0A3FC
        /// <summary>"Distance": Currently not in use</summary>
        ALIGNMENT_STATION_LABEL_DISTANCE = -1006595, // 0xFFF0A3FD
        /// <summary>"Tick Mark Centered"</summary>
        ARROW_CENTERED = -1006524, // 0xFFF0A444
        /// <summary>"Interior Tick Mark Display"</summary>
        INTERIOR_TICK_DISPLAY = -1006523, // 0xFFF0A445
        /// <summary>"Witness Line Tick Mark"</summary>
        WITNS_LINE_TICK_MARK = -1006522, // 0xFFF0A446
        /// <summary>"Total Length"</summary>
        DIM_TOTAL_LENGTH = -1006521, // 0xFFF0A447
        /// <summary>"Count"</summary>
        DIM_REFERENCE_COUNT = -1006520, // 0xFFF0A448
        /// <summary>"Alternate Units Suffix"</summary>
        ALTERNATE_UNITS_SUFFIX = -1006519, // 0xFFF0A449
        /// <summary>"Alternate Units Prefix"</summary>
        ALTERNATE_UNITS_PREFIX = -1006518, // 0xFFF0A44A
        /// <summary>"Equality Witness Display"</summary>
        EQUALITY_WITNESS_DISPLAY = -1006517, // 0xFFF0A44B
        /// <summary>"Suppress Spaces"</summary>
        DIM_STYLE_SUPPRESS_SPACES = -1006516, // 0xFFF0A44C
        /// <summary>"Equality Formula"</summary>
        EQUALITY_FORMULA = -1006515, // 0xFFF0A44D
        /// <summary>"Leader Tick Mark"</summary>
        DIM_STYLE_LEADER_TICK_MARK = -1006514, // 0xFFF0A44E
        /// <summary>"Equality Text"</summary>
        EQUALITY_TEXT_FOR_ANGULAR_DIM = -1006513, // 0xFFF0A44F
        /// <summary>"Equality Text"</summary>
        EQUALITY_TEXT_FOR_CONTINUOUS_LINEAR_DIM = -1006512, // 0xFFF0A450
        /// <summary>"Text Location"</summary>
        DIM_TEXT_LOCATION_FOR_LEADER = -1006511, // 0xFFF0A451
        /// <summary>"Show Leader When Text Moves"</summary>
        DIM_LEADER_DISPLAY_CONDITION = -1006510, // 0xFFF0A452
        /// <summary>"Shoulder Length"</summary>
        DIM_LEADER_SHOULDER_LENGTH = -1006509, // 0xFFF0A453
        /// <summary>"Leader Type"</summary>
        DIM_LEADER_TYPE = -1006508, // 0xFFF0A454
        /// <summary>"Dimension To Intersecting Grids"</summary>
        DIM_TO_INTERSECTING_GRIDS = -1006507, // 0xFFF0A455
        /// <summary>"Dimension To Intersecting Walls"</summary>
        DIM_TO_INTERSECTING_WALLS = -1006506, // 0xFFF0A456
        /// <summary>"Dimension To Opening Type"</summary>
        DIM_TO_INSERT_TYPE = -1006505, // 0xFFF0A457
        /// <summary>"Fixed Rotation"</summary>
        FIXED_ROTATION = -1006504, // 0xFFF0A458
        /// <summary>"Keep Readable"</summary>
        KEEP_READABLE = -1006503, // 0xFFF0A459
        /// <summary>"Leader Line"</summary>
        LEADER_LINE = -1006502, // 0xFFF0A45A
        /// <summary>"Leader/Border Offset"</summary>
        LEADER_OFFSET_SHEET = -1006501, // 0xFFF0A45B
        /// <summary>"Dimension To Openings"</summary>
        DIM_TO_INSERTS = -1006500, // 0xFFF0A45C
        /// <summary>"Offset from Reference"</summary>
        SPOT_SLOPE_OFFSET_FROM_REFERENCE = -1006494, // 0xFFF0A462
        /// <summary>"Slope Representation"</summary>
        SPOT_SLOPE_SLOPE_REPRESENTATION = -1006493, // 0xFFF0A463
        /// <summary>"Slope Direction"</summary>
        SPOT_SLOPE_SLOPE_DIRECTION = -1006492, // 0xFFF0A464
        /// <summary>"Lower Value"</summary>
        SPOT_ELEV_LOWER_VALUE = -1006491, // 0xFFF0A465
        /// <summary>"Single/Upper Value"</summary>
        SPOT_ELEV_SINGLE_OR_UPPER_VALUE = -1006490, // 0xFFF0A466
        /// <summary>"Elevation Indicator as Prefix/Suffix"</summary>
        SPOT_ELEV_IND_TYPE_ELEVATION = -1006489, // 0xFFF0A467
        /// <summary>"Include Elevation"</summary>
        SPOT_COORDINATE_INCLUDE_ELEVATION = -1006488, // 0xFFF0A468
        /// <summary>"Elevation Value Suffix"</summary>
        SPOT_COORDINATE_ELEVATION_SUFFIX = -1006487, // 0xFFF0A469
        /// <summary>"Elevation Value Prefix"</summary>
        SPOT_COORDINATE_ELEVATION_PREFIX = -1006486, // 0xFFF0A46A
        /// <summary>"Bottom Value Suffix"</summary>
        SPOT_COORDINATE_BOTTOM_SUFFIX = -1006485, // 0xFFF0A46B
        /// <summary>"Bottom Value Prefix"</summary>
        SPOT_COORDINATE_BOTTOM_PREFIX = -1006484, // 0xFFF0A46C
        /// <summary>"Top Value Suffix"</summary>
        SPOT_COORDINATE_TOP_SUFFIX = -1006483, // 0xFFF0A46D
        /// <summary>"Top Value Prefix"</summary>
        SPOT_COORDINATE_TOP_PREFIX = -1006482, // 0xFFF0A46E
        /// <summary>"Lower Value Suffix"</summary>
        SPOT_ELEV_LOWER_SUFFIX = -1006481, // 0xFFF0A46F
        /// <summary>"Lower Value Prefix"</summary>
        SPOT_ELEV_LOWER_PREFIX = -1006480, // 0xFFF0A470
        /// <summary>"Single/Upper Value Suffix"</summary>
        SPOT_ELEV_SINGLE_OR_UPPER_SUFFIX = -1006479, // 0xFFF0A471
        /// <summary>"Single/Upper Value Prefix"</summary>
        SPOT_ELEV_SINGLE_OR_UPPER_PREFIX = -1006478, // 0xFFF0A472
        /// <summary>"Baseline Offset"</summary>
        BASELINE_DIM_OFFSET = -1006477, // 0xFFF0A473
        /// <summary>"Leader Shoulder"</summary>
        SPOT_ELEV_BEND_LEADER = -1006476, // 0xFFF0A474
        /// <summary>"Bottom Indicator as Prefix/Suffix"</summary>
        SPOT_ELEV_IND_TYPE_BOTTOM = -1006475, // 0xFFF0A475
        /// <summary>"Top Indicator as Prefix/Suffix"</summary>
        SPOT_ELEV_IND_TYPE_TOP = -1006474, // 0xFFF0A476
        /// <summary>"Bottom Indicator"</summary>
        SPOT_ELEV_IND_BOTTOM = -1006473, // 0xFFF0A477
        /// <summary>"Top Indicator"</summary>
        SPOT_ELEV_IND_TOP = -1006472, // 0xFFF0A478
        /// <summary>"Text Location"</summary>
        SPOT_ELEV_TEXT_LOCATION = -1006471, // 0xFFF0A479
        /// <summary>"Rotate with Component"</summary>
        SPOT_ELEV_ROTATE_WITH_COMPONENT = -1006470, // 0xFFF0A47A
        /// <summary>"Display Elevations"</summary>
        SPOT_ELEV_DISPLAY_ELEVATIONS = -1006469, // 0xFFF0A47B
        /// <summary>"Ordinate Dimension Settings"</summary>
        ORDINATE_DIM_SETTING = -1006468, // 0xFFF0A47C
        /// <summary>"Dimension String Type"</summary>
        LINEAR_DIM_TYPE = -1006467, // 0xFFF0A47D
        /// <summary>"Leader"</summary>
        SPOT_DIM_LEADER = -1006466, // 0xFFF0A47E
        /// <summary>"Flipped Dimension Line Extension"</summary>
        DIM_STYLE_FLIPPED_DIM_LINE_EXTENSION = -1006465, // 0xFFF0A47F
        /// <summary>"Interior Tick Mark"</summary>
        DIM_STYLE_INTERIOR_TICK_MARK = -1006464, // 0xFFF0A480
        /// <summary>"Text Offset from Leader"</summary>
        SPOT_TEXT_FROM_LEADER = -1006462, // 0xFFF0A482
        /// <summary>"Coordinate Base"</summary>
        SPOT_COORDINATE_BASE = -1006461, // 0xFFF0A483
        /// <summary>"Alternate Units Format"</summary>
        DIM_STYLE_ANGULAR_UNITS_ALT = -1006460, // 0xFFF0A484
        /// <summary>"Indicator as Prefix / Suffix"</summary>
        SPOT_ELEV_IND_TYPE = -1006458, // 0xFFF0A486
        /// <summary>"Bottom Value"</summary>
        SPOT_ELEV_BOT_VALUE = -1006457, // 0xFFF0A487
        /// <summary>"Alternate Units"</summary>
        ALTERNATE_UNITS = -1006456, // 0xFFF0A488
        /// <summary>"Top Value"</summary>
        SPOT_ELEV_TOP_VALUE = -1006455, // 0xFFF0A489
        /// <summary>"Alternate Units Format"</summary>
        DIM_STYLE_LINEAR_UNITS_ALT = -1006454, // 0xFFF0A48A
        /// <summary>"Text Orientation"</summary>
        SPOT_ELEV_TEXT_ORIENTATION = -1006453, // 0xFFF0A48B
        /// <summary>"Elevation Indicator"</summary>
        SPOT_ELEV_IND_ELEVATION = -1006452, // 0xFFF0A48C
        /// <summary>"East / West Indicator"</summary>
        SPOT_ELEV_IND_EW = -1006451, // 0xFFF0A48D
        /// <summary>"North / South Indicator"</summary>
        SPOT_ELEV_IND_NS = -1006450, // 0xFFF0A48E
        /// <summary>"Arrow Closed"</summary>
        ARROW_CLOSED = -1006449, // 0xFFF0A48F
        /// <summary>"Read Convention"</summary>
        DIM_STYLE_READ_CONVENTION = -1006448, // 0xFFF0A490
        /// <summary>"Heavy End Pen Weight"</summary>
        HEAVY_END_PEN = -1006447, // 0xFFF0A491
        /// <summary>"Dimension Line Snap Distance"</summary>
        DIM_STYLE_DIM_LINE_SNAP_DIST = -1006446, // 0xFFF0A492
        /// <summary>"Centerline Tick Mark"</summary>
        DIM_STYLE_CENTERLINE_TICK_MARK = -1006445, // 0xFFF0A493
        /// <summary>"Leader Line Weight"</summary>
        SPOT_ELEV_LINE_PEN = -1006444, // 0xFFF0A494
        /// <summary>"Leader Arrowhead Line Weight"</summary>
        SPOT_ELEV_TICK_MARK_PEN = -1006443, // 0xFFF0A495
        /// <summary>"Leader Arrowhead"</summary>
        SPOT_ELEV_LEADER_ARROWHEAD = -1006442, // 0xFFF0A496
        /// <summary>"Relative Base"</summary>
        SPOT_ELEV_RELATIVE_BASE = -1006441, // 0xFFF0A497
        /// <summary>"Auto Mirror"</summary>
        SPOT_ELEV_FLIP_TEXT_VERT = -1006440, // 0xFFF0A498
        /// <summary>"Text Offset from Symbol"</summary>
        SPOT_ELEV_TEXT_HORIZ_OFFSET = -1006439, // 0xFFF0A499
        /// <summary>"Elevation Base"</summary>
        SPOT_ELEV_BASE = -1006437, // 0xFFF0A49B
        /// <summary>"Symbol"</summary>
        SPOT_ELEV_SYMBOL = -1006436, // 0xFFF0A49C
        /// <summary>"Show Opening Height"</summary>
        DIM_STYLE_SHOW_OPENING_HT = -1006435, // 0xFFF0A49D
        /// <summary>"Centerline Pattern"</summary>
        DIM_STYLE_CENTERLINE_PATTERN = -1006434, // 0xFFF0A49E
        /// <summary>"Witness Line Length"</summary>
        DIM_WITNS_LINE_EXTENSION_BELOW = -1006433, // 0xFFF0A49F
        /// <summary>"Witness Line Control"</summary>
        DIM_WITNS_LINE_CNTRL = -1006432, // 0xFFF0A4A0
        /// <summary>"Dimension Line Extension"</summary>
        DIM_LINE_EXTENSION = -1006431, // 0xFFF0A4A1
        /// <summary>"Centerline Symbol"</summary>
        DIM_STYLE_CENTERLINE_SYMBOL = -1006430, // 0xFFF0A4A2
        /// <summary>"Text Background"</summary>
        DIM_TEXT_BACKGROUND = -1006429, // 0xFFF0A4A3
        /// <summary>"Units Format"</summary>
        DIM_STYLE_ANGULAR_UNITS = -1006428, // 0xFFF0A4A4
        /// <summary>"Units Format"</summary>
        DIM_STYLE_LINEAR_UNITS = -1006427, // 0xFFF0A4A5
        /// <summary>"Arrow Width Angle"</summary>
        LEADER_ARROW_WIDTH = -1006426, // 0xFFF0A4A6
        /// <summary>"Fill Tick"</summary>
        ARROW_FILLED = -1006425, // 0xFFF0A4A7
        /// <summary>"Heavy End Pen Weight"</summary>
        HEAVY_TICK_MARK_PEN = -1006420, // 0xFFF0A4AC
        /// <summary>"Tick Size"</summary>
        ARROW_SIZE = -1006414, // 0xFFF0A4B2
        /// <summary>"Arrow Style"</summary>
        ARROW_TYPE = -1006413, // 0xFFF0A4B3
        /// <summary>"Tick Mark Line Weight"</summary>
        TICK_MARK_PEN = -1006412, // 0xFFF0A4B4
        /// <summary>"Text Position"</summary>
        TEXT_POSITION = -1006411, // 0xFFF0A4B5
        /// <summary>"Radius Symbol Location"</summary>
        RADIUS_SYMBOL_LOCATION = -1006408, // 0xFFF0A4B8
        /// <summary>"Center Mark Size"</summary>
        CENTER_MARK_SIZE = -1006407, // 0xFFF0A4B9
        /// <summary>"Center Marks"</summary>
        ARC_CENTER_MARK = -1006406, // 0xFFF0A4BA
        /// <summary>"Witness Line Gap to Element"</summary>
        WITNS_LINE_GAP_TO_ELT = -1006405, // 0xFFF0A4BB
        /// <summary>"Witness Line Extension"</summary>
        WITNS_LINE_EXTENSION = -1006404, // 0xFFF0A4BC
        /// <summary>"Text Offset"</summary>
        TEXT_DIST_TO_LINE = -1006401, // 0xFFF0A4BF
        /// <summary>"Text Alignment"</summary>
        TEXT_ALIGNMENT = -1006400, // 0xFFF0A4C0
        /// <summary>"Text Size"</summary>
        MODEL_TEXT_SIZE = -1006336, // 0xFFF0A500
        /// <summary>"Size"</summary>
        TEXT_STYLE_SIZE = -1006335, // 0xFFF0A501
        /// <summary>"Font"</summary>
        TEXT_STYLE_FONT = -1006334, // 0xFFF0A502
        /// <summary>"Show Title"</summary>
        SHOW_TITLE = -1006333, // 0xFFF0A503
        /// <summary>"Underline"</summary>
        TITLE_STYLE_UNDERLINE = -1006332, // 0xFFF0A504
        /// <summary>"Italic"</summary>
        TITLE_STYLE_ITALIC = -1006331, // 0xFFF0A505
        /// <summary>"Bold"</summary>
        TITLE_STYLE_BOLD = -1006330, // 0xFFF0A506
        /// <summary>"Size"</summary>
        TITLE_SIZE = -1006329, // 0xFFF0A507
        /// <summary>"Font"</summary>
        TITLE_FONT = -1006328, // 0xFFF0A508
        /// <summary>"Width Factor"</summary>
        TEXT_WIDTH_SCALE = -1006327, // 0xFFF0A509
        /// <summary>"Tab Size"</summary>
        TEXT_TAB_SIZE = -1006326, // 0xFFF0A50A
        /// <summary>"Arc Leaders"</summary>
        ARC_LEADER_PARAM = -1006325, // 0xFFF0A50B
        /// <summary>"Tick Mark"</summary>
        DIM_LEADER_ARROWHEAD = -1006323, // 0xFFF0A50D
        /// <summary>"Sheet Issue Date"</summary>
        SHEET_ISSUE_DATE = -1006322, // 0xFFF0A50E
        /// <summary>"Project Issue Date"</summary>
        PROJECT_ISSUE_DATE = -1006321, // 0xFFF0A50F
        /// <summary>"Project Status"</summary>
        PROJECT_STATUS = -1006320, // 0xFFF0A510
        /// <summary>"Client Name"</summary>
        CLIENT_NAME = -1006319, // 0xFFF0A511
        /// <summary>"Project Address"</summary>
        PROJECT_ADDRESS = -1006318, // 0xFFF0A512
        /// <summary>"Project Name"</summary>
        PROJECT_NAME = -1006317, // 0xFFF0A513
        /// <summary>"Project Number"</summary>
        PROJECT_NUMBER = -1006316, // 0xFFF0A514
        /// <summary>"Leader Arrowhead"</summary>
        LEADER_ARROWHEAD = -1006315, // 0xFFF0A515
        /// <summary>"Background"</summary>
        TEXT_BACKGROUND = -1006314, // 0xFFF0A516
        /// <summary>"Underline"</summary>
        TEXT_STYLE_UNDERLINE = -1006313, // 0xFFF0A517
        /// <summary>"Italic"</summary>
        TEXT_STYLE_ITALIC = -1006312, // 0xFFF0A518
        /// <summary>"Bold"</summary>
        TEXT_STYLE_BOLD = -1006311, // 0xFFF0A519
        /// <summary>"Filled"</summary>
        CURVE_IS_FILLED = -1006310, // 0xFFF0A51A
        /// <summary>"Vertical Align"</summary>
        TEXT_ALIGN_VERT = -1006309, // 0xFFF0A51B
        /// <summary>"Horizontal Align"</summary>
        TEXT_ALIGN_HORZ = -1006308, // 0xFFF0A51C
        /// <summary>"Text"</summary>
        TEXT_TEXT = -1006307, // 0xFFF0A51D
        /// <summary>"Line Pattern"</summary>
        LINE_PATTERN = -1006305, // 0xFFF0A51F
        /// <summary>"Color"</summary>
        LINE_COLOR = -1006304, // 0xFFF0A520
        /// <summary>"Line Weight"</summary>
        LINE_PEN = -1006303, // 0xFFF0A521
        /// <summary>"Color"</summary>
        TEXT_COLOR = -1006302, // 0xFFF0A522
        /// <summary>"Text Size"</summary>
        TEXT_SIZE = -1006301, // 0xFFF0A523
        /// <summary>"Text Font"</summary>
        TEXT_FONT = -1006300, // 0xFFF0A524
        /// <summary>"Subcategory"</summary>
        REFERENCE_LINE_SUBCATEGORY = -1006221, // 0xFFF0A573
        /// <summary>"Subcategory"</summary>
        CLINE_SUBCATEGORY = -1006220, // 0xFFF0A574
        /// <summary>"Line Style"</summary>
        EDGE_LINEWORK = -1006212, // 0xFFF0A57C
        /// <summary>"Subcategory"</summary>
        BUILDING_CURVE_GSTYLE_PLUS_INVISIBLE = -1006211, // 0xFFF0A57D
        /// <summary>"Line Style"</summary>
        BUILDING_CURVE_GSTYLE = -1006210, // 0xFFF0A57E
        /// <summary>"Subcategory"</summary>
        FAMILY_CURVE_GSTYLE_FOR_2010_MASS = -1006207, // 0xFFF0A581
        /// <summary>"Draw in Foreground"</summary>
        HEAD_ON_PLACEMENT_METHOD = -1006206, // 0xFFF0A582
        /// <summary>"Visible"</summary>
        IS_VISIBLE_PARAM = -1006205, // 0xFFF0A583
        /// <summary>"Subcategory"</summary>
        FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_PLUS_STICK_SYM_MINUS_ANALYTICAL = -1006204, // 0xFFF0A584
        /// <summary>"Subcategory"</summary>
        FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_MINUS_ANALYTICAL = -1006203, // 0xFFF0A585
        /// <summary>"Subcategory"</summary>
        FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE_PLUS_STICK_SYM = -1006202, // 0xFFF0A586
        /// <summary>"Subcategory"</summary>
        FAMILY_CURVE_GSTYLE_PLUS_INVISIBLE = -1006201, // 0xFFF0A587
        /// <summary>"Subcategory"</summary>
        FAMILY_ELEM_SUBCATEGORY = -1006200, // 0xFFF0A588
        /// <summary>"Stairs Line Type"</summary>
        STAIRS_CURVE_TYPE = -1006100, // 0xFFF0A5EC
        /// <summary>"Slope"</summary>
        ROOF_SLOPE = -1006016, // 0xFFF0A640
        /// <summary>"Steel Cantilever"</summary>
        CURVE_PARAM_STEEL_CANTILEVER = -1006015, // 0xFFF0A641
        /// <summary>"Concrete Cantilever"</summary>
        CURVE_PARAM_CONCRETE_CANTILEVER = -1006014, // 0xFFF0A642
        /// <summary>"Number of Full Segments"</summary>
        CURVE_NUMBER_OF_SEGMENTS = -1006013, // 0xFFF0A643
        /// <summary>"Specify "</summary>
        SPECIFY_SLOPE_OR_OFFSET = -1006012, // 0xFFF0A644
        /// <summary>"Level at Head"</summary>
        SLOPE_ARROW_LEVEL_END = -1006011, // 0xFFF0A645
        /// <summary>"Level at Tail"</summary>
        SLOPE_ARROW_LEVEL_START = -1006010, // 0xFFF0A646
        /// <summary>"Level"</summary>
        CURVE_LEVEL = -1006009, // 0xFFF0A647
        /// <summary>"Offset From Base"</summary>
        CURVE_HEIGHT_OFFSET = -1006008, // 0xFFF0A648
        /// <summary>"Defines Slope"</summary>
        CURVE_IS_SLOPE_DEFINING = -1006007, // 0xFFF0A649
        /// <summary>"Defines Constant Height"</summary>
        DEFINES_CONSTANT_HEIGHT = -1006006, // 0xFFF0A64A
        /// <summary>"Plate Offset From Base"</summary>
        ROOF_CURVE_HEIGHT_AT_WALL = -1006005, // 0xFFF0A64B
        /// <summary>"Offset From Roof Base"</summary>
        ROOF_CURVE_HEIGHT_OFFSET = -1006001, // 0xFFF0A64F
        /// <summary>"Defines Roof Slope"</summary>
        ROOF_CURVE_IS_SLOPE_DEFINING = -1006000, // 0xFFF0A650
        /// <summary>"Web Thickness Location"</summary>
        STRUCTURAL_SECTION_ISHAPE_WEBTHICKNESS_LOCATION = -1005567, // 0xFFF0A801
        /// <summary>"Flange Thickness Location"</summary>
        STRUCTURAL_SECTION_ISHAPE_FLANGETHICKNESS_LOCATION = -1005566, // 0xFFF0A802
        /// <summary>"Top Web Fillet"</summary>
        STRUCTURAL_SECTION_TOP_WEB_FILLET = -1005565, // 0xFFF0A803
        /// <summary>"Sloped Web Angle"</summary>
        STRUCTURAL_SECTION_SLOPED_WEB_ANGLE = -1005564, // 0xFFF0A804
        /// <summary>"Sloped Flange Angle"</summary>
        STRUCTURAL_SECTION_SLOPED_FLANGE_ANGLE = -1005563, // 0xFFF0A805
        /// <summary>"Cantilever Height"</summary>
        STRUCTURAL_SECTION_CANTILEVER_HEIGHT = -1005562, // 0xFFF0A806
        /// <summary>"Cantilever Length"</summary>
        STRUCTURAL_SECTION_CANTILEVER_LENGTH = -1005561, // 0xFFF0A807
        /// <summary>"Bottom Cut Height"</summary>
        STRUCTURAL_SECTION_BOTTOM_CUT_HEIGHT = -1005560, // 0xFFF0A808
        /// <summary>"Bottom Cut Width"</summary>
        STRUCTURAL_SECTION_BOTTOM_CUT_WIDTH = -1005559, // 0xFFF0A809
        /// <summary>"Top Cut Height"</summary>
        STRUCTURAL_SECTION_TOP_CUT_HEIGHT = -1005558, // 0xFFF0A80A
        /// <summary>"Top Cut Width"</summary>
        STRUCTURAL_SECTION_TOP_CUT_WIDTH = -1005557, // 0xFFF0A80B
        /// <summary>"Code Name"</summary>
        STRUCTURAL_FAMILY_CODE_NAME = -1005556, // 0xFFF0A80C
        /// <summary>"Family Name Key"</summary>
        STRUCTURAL_FAMILY_NAME_KEY = -1005555, // 0xFFF0A80D
        /// <summary>"Section Name Key"</summary>
        STRUCTURAL_SECTION_NAME_KEY = -1005554, // 0xFFF0A80E
        /// <summary>"Top Bend Length"</summary>
        STRUCTURAL_SECTION_SIGMA_PROFILE_TOP_BEND_WIDTH = -1005553, // 0xFFF0A80F
        /// <summary>"Middle Bend Length"</summary>
        STRUCTURAL_SECTION_SIGMA_PROFILE_MIDDLE_BEND_WIDTH = -1005552, // 0xFFF0A810
        /// <summary>"Bend Width"</summary>
        STRUCTURAL_SECTION_SIGMA_PROFILE_BEND_WIDTH = -1005551, // 0xFFF0A811
        /// <summary>"Bottom Flange Length"</summary>
        STRUCTURAL_SECTION_ZPROFILE_BOTTOM_FLANGE_LENGTH = -1005550, // 0xFFF0A812
        /// <summary>"Fold Length"</summary>
        STRUCTURAL_SECTION_CPROFILE_FOLD_LENGTH = -1005549, // 0xFFF0A813
        /// <summary>"Lip Length"</summary>
        STRUCTURAL_SECTION_LPROFILE_LIP_LENGTH = -1005548, // 0xFFF0A814
        /// <summary>"Bolt Diameter Shorter Flange"</summary>
        STRUCTURAL_SECTION_LANGLE_BOLT_DIAMETER_SHORTER_FLANGE = -1005547, // 0xFFF0A815
        /// <summary>"Bolt Diameter Longer Flange"</summary>
        STRUCTURAL_SECTION_LANGLE_BOLT_DIAMETER_LONGER_FLANGE = -1005546, // 0xFFF0A816
        /// <summary>"Bolt Spacing Shorter Flange"</summary>
        STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_SHORTER_FLANGE = -1005545, // 0xFFF0A817
        /// <summary>"Bolt Spacing 2 Longer Flange"</summary>
        STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_2_LONGER_FLANGE = -1005544, // 0xFFF0A818
        /// <summary>"Bolt Spacing 1 Longer Flange"</summary>
        STRUCTURAL_SECTION_LANGLE_BOLT_SPACING_1_LONGER_FLANGE = -1005543, // 0xFFF0A819
        /// <summary>"Bolt Spacing web"</summary>
        STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_WEB = -1005542, // 0xFFF0A81A
        /// <summary>"Bolt Spacing between Rows"</summary>
        STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_BETWEEN_ROWS = -1005541, // 0xFFF0A81B
        /// <summary>"Bolt Spacing Two Rows"</summary>
        STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING_TWO_ROWS = -1005540, // 0xFFF0A81C
        /// <summary>"Bolt Diameter"</summary>
        STRUCTURAL_SECTION_ISHAPE_BOLT_DIAMETER = -1005539, // 0xFFF0A81D
        /// <summary>"Bolt Spacing"</summary>
        STRUCTURAL_SECTION_ISHAPE_BOLT_SPACING = -1005538, // 0xFFF0A81E
        /// <summary>"Web Toe of Fillet"</summary>
        STRUCTURAL_SECTION_ISHAPE_WEB_TOE_OF_FILLET = -1005537, // 0xFFF0A81F
        /// <summary>"Flange Toe of Fillet"</summary>
        STRUCTURAL_SECTION_ISHAPE_FLANGE_TOE_OF_FILLET = -1005536, // 0xFFF0A820
        /// <summary>"Clear Web Height"</summary>
        STRUCTURAL_SECTION_ISHAPE_CLEAR_WEB_HEIGHT = -1005535, // 0xFFF0A821
        /// <summary>"Bottom Flange Width"</summary>
        STRUCTURAL_SECTION_IWELDED_BOTTOMFLANGEWIDTH = -1005534, // 0xFFF0A822
        /// <summary>"Bottom Flange Thickness"</summary>
        STRUCTURAL_SECTION_IWELDED_BOTTOMFLANGETHICKNESS = -1005533, // 0xFFF0A823
        /// <summary>"Top Flange Width"</summary>
        STRUCTURAL_SECTION_IWELDED_TOPFLANGEWIDTH = -1005532, // 0xFFF0A824
        /// <summary>"Top Flange Thickness"</summary>
        STRUCTURAL_SECTION_IWELDED_TOPFLANGETHICKNESS = -1005531, // 0xFFF0A825
        /// <summary>"Outer Fillet"</summary>
        STRUCTURAL_SECTION_HSS_OUTERFILLET = -1005530, // 0xFFF0A826
        /// <summary>"Inner Fillet"</summary>
        STRUCTURAL_SECTION_HSS_INNERFILLET = -1005529, // 0xFFF0A827
        /// <summary>"Web Fillet"</summary>
        STRUCTURAL_SECTION_ISHAPE_WEBFILLET = -1005528, // 0xFFF0A828
        /// <summary>"Flange Fillet"</summary>
        STRUCTURAL_SECTION_ISHAPE_FLANGEFILLET = -1005527, // 0xFFF0A829
        /// <summary>"Web Height"</summary>
        STRUCTURAL_SECTION_ISHAPE_WEBHEIGHT = -1005526, // 0xFFF0A82A
        /// <summary>"Web Thickness"</summary>
        STRUCTURAL_SECTION_ISHAPE_WEBTHICKNESS = -1005525, // 0xFFF0A82B
        /// <summary>"Flange Thickness"</summary>
        STRUCTURAL_SECTION_ISHAPE_FLANGETHICKNESS = -1005524, // 0xFFF0A82C
        /// <summary>"Shear Area weak axis"</summary>
        STRUCTURAL_SECTION_COMMON_SHEAR_AREA_WEAK_AXIS = -1005523, // 0xFFF0A82D
        /// <summary>"Shear Area strong axis"</summary>
        STRUCTURAL_SECTION_COMMON_SHEAR_AREA_STRONG_AXIS = -1005522, // 0xFFF0A82E
        /// <summary>"Warping Constant"</summary>
        STRUCTURAL_SECTION_COMMON_WARPING_CONSTANT = -1005521, // 0xFFF0A82F
        /// <summary>"Torsional Modulus"</summary>
        STRUCTURAL_SECTION_COMMON_TORSIONAL_MODULUS = -1005520, // 0xFFF0A830
        /// <summary>"Torsional Moment of Inertia"</summary>
        STRUCTURAL_SECTION_COMMON_TORSIONAL_MOMENT_OF_INERTIA = -1005519, // 0xFFF0A831
        /// <summary>"Plastic Modulus weak axis"</summary>
        STRUCTURAL_SECTION_COMMON_PLASTIC_MODULUS_WEAK_AXIS = -1005518, // 0xFFF0A832
        /// <summary>"Plastic Modulus strong axis"</summary>
        STRUCTURAL_SECTION_COMMON_PLASTIC_MODULUS_STRONG_AXIS = -1005517, // 0xFFF0A833
        /// <summary>"Elastic Modulus weak axis"</summary>
        STRUCTURAL_SECTION_COMMON_ELASTIC_MODULUS_WEAK_AXIS = -1005516, // 0xFFF0A834
        /// <summary>"Elastic Modulus strong axis"</summary>
        STRUCTURAL_SECTION_COMMON_ELASTIC_MODULUS_STRONG_AXIS = -1005515, // 0xFFF0A835
        /// <summary>"Moment of Inertia weak axis"</summary>
        STRUCTURAL_SECTION_COMMON_MOMENT_OF_INERTIA_WEAK_AXIS = -1005514, // 0xFFF0A836
        /// <summary>"Moment of Inertia strong axis"</summary>
        STRUCTURAL_SECTION_COMMON_MOMENT_OF_INERTIA_STRONG_AXIS = -1005513, // 0xFFF0A837
        /// <summary>"Nominal Weight"</summary>
        STRUCTURAL_SECTION_COMMON_NOMINAL_WEIGHT = -1005512, // 0xFFF0A838
        /// <summary>"Perimeter"</summary>
        STRUCTURAL_SECTION_COMMON_PERIMETER = -1005511, // 0xFFF0A839
        /// <summary>"Principal Axes Angle"</summary>
        STRUCTURAL_SECTION_COMMON_ALPHA = -1005510, // 0xFFF0A83A
        /// <summary>"Centroid Vertical"</summary>
        STRUCTURAL_SECTION_COMMON_CENTROID_VERTICAL = -1005509, // 0xFFF0A83B
        /// <summary>"Centroid Horizontal"</summary>
        STRUCTURAL_SECTION_COMMON_CENTROID_HORIZ = -1005508, // 0xFFF0A83C
        /// <summary>"Section Area"</summary>
        STRUCTURAL_SECTION_AREA = -1005507, // 0xFFF0A83D
        /// <summary>"Wall Design Thickness"</summary>
        STRUCTURAL_SECTION_PIPESTANDARD_WALLDESIGNTHICKNESS = -1005506, // 0xFFF0A83E
        /// <summary>"Wall Nominal Thickness"</summary>
        STRUCTURAL_SECTION_PIPESTANDARD_WALLNOMINALTHICKNESS = -1005505, // 0xFFF0A83F
        /// <summary>"Diameter"</summary>
        STRUCTURAL_SECTION_COMMON_DIAMETER = -1005504, // 0xFFF0A840
        /// <summary>"Height"</summary>
        STRUCTURAL_SECTION_COMMON_HEIGHT = -1005503, // 0xFFF0A841
        /// <summary>"Width"</summary>
        STRUCTURAL_SECTION_COMMON_WIDTH = -1005502, // 0xFFF0A842
        /// <summary>"Section Shape"</summary>
        STRUCTURAL_SECTION_SHAPE = -1005501, // 0xFFF0A843
        /// <summary>"Structural Material"</summary>
        STRUCTURAL_MATERIAL_PARAM = -1005500, // 0xFFF0A844
        /// <summary>"Define Thermal Properties by"</summary>
        ANALYTICAL_DEFINE_THERMAL_PROPERTIES_BY = -1005439, // 0xFFF0A881
        /// <summary>"Construction Type Id"</summary>
        ANALYTIC_CONSTRUCTION_GBXML_TYPEID = -1005438, // 0xFFF0A882
        /// <summary>"Analytic Construction"</summary>
        ANALYTIC_CONSTRUCTION_LOOKUP_TABLE = -1005437, // 0xFFF0A883
        /// <summary>"Roughness"</summary>
        ANALYTICAL_ROUGHNESS = -1005436, // 0xFFF0A884
        /// <summary>"Absorptance"</summary>
        ANALYTICAL_ABSORPTANCE = -1005435, // 0xFFF0A885
        /// <summary>"Thermal Mass"</summary>
        ANALYTICAL_THERMAL_MASS = -1005434, // 0xFFF0A886
        /// <summary>"Visual Light Transmittance"</summary>
        ANALYTICAL_VISUAL_LIGHT_TRANSMITTANCE = -1005433, // 0xFFF0A887
        /// <summary>"Solar Heat Gain Coefficient"</summary>
        ANALYTICAL_SOLAR_HEAT_GAIN_COEFFICIENT = -1005432, // 0xFFF0A888
        /// <summary>"Thermal Resistance (R)"</summary>
        ANALYTICAL_THERMAL_RESISTANCE = -1005431, // 0xFFF0A889
        /// <summary>"Heat Transfer Coefficient (U)"</summary>
        ANALYTICAL_HEAT_TRANSFER_COEFFICIENT = -1005430, // 0xFFF0A88A
        /// <summary>"Design Option Configuration"</summary>
        VIEW_DESIGN_OPTIONS_CONFIG = -1005400, // 0xFFF0A8A8
        /// <summary>"Range: Top Level"</summary>
        VIEW_UNDERLAY_TOP_ID = -1005335, // 0xFFF0A8E9
        /// <summary>"Sun path size (%)"</summary>
        VIEW_GRAPH_SUN_PATH_SIZE = -1005334, // 0xFFF0A8EA
        /// <summary>"Sun Path"</summary>
        VIEW_GRAPH_SUN_PATH = -1005333, // 0xFFF0A8EB
        /// <summary>"Default Analysis Display Style"</summary>
        VIEW_ANALYSIS_DISPLAY_STYLE = -1005332, // 0xFFF0A8EC
        /// <summary>"Elevation Base for Levels"</summary>
        VIEW_GRAPH_SCHED_LEVEL_RELATIVE_BASE_TYPE = -1005331, // 0xFFF0A8ED
        /// <summary>"Hidden Levels"</summary>
        VIEW_GRAPH_SCHED_HIDDEN_LEVELS = -1005330, // 0xFFF0A8EE
        /// <summary>"Total Segments"</summary>
        VIEW_GRAPH_SCHED_TOTAL_ROWS = -1005329, // 0xFFF0A8EF
        /// <summary>"Segments in Viewport"</summary>
        VIEW_GRAPH_SCHED_ROWS_COUNT = -1005328, // 0xFFF0A8F0
        /// <summary>"Grid Appearance"</summary>
        VIEW_GRAPH_SCHED_GRID_APPEARANCE = -1005327, // 0xFFF0A8F1
        /// <summary>"Text Appearance"</summary>
        VIEW_GRAPH_SCHED_TEXT_APPEARANCE = -1005326, // 0xFFF0A8F2
        /// <summary>"Title"</summary>
        VIEW_GRAPH_SCHED_TITLE = -1005325, // 0xFFF0A8F3
        /// <summary>"Segment Start in Viewport"</summary>
        VIEW_GRAPH_SCHED_ROWS_FROM = -1005319, // 0xFFF0A8F9
        /// <summary>"Group Similar Locations"</summary>
        VIEW_GRAPH_SCHED_GROUP_SIMILAR = -1005318, // 0xFFF0A8FA
        /// <summary>"Material Types"</summary>
        VIEW_GRAPH_SCHED_MATERIAL_TYPES = -1005317, // 0xFFF0A8FB
        /// <summary>"Column Locations End"</summary>
        VIEW_GRAPH_SCHED_LOCATIONS_HIGH = -1005316, // 0xFFF0A8FC
        /// <summary>"Column Locations Start"</summary>
        VIEW_GRAPH_SCHED_LOCATIONS_LOW = -1005315, // 0xFFF0A8FD
        /// <summary>"Bottom Level"</summary>
        VIEW_GRAPH_SCHED_BOTTOM_LEVEL = -1005314, // 0xFFF0A8FE
        /// <summary>"Top Level"</summary>
        VIEW_GRAPH_SCHED_TOP_LEVEL = -1005313, // 0xFFF0A8FF
        /// <summary>"Rotation on Sheet"</summary>
        VIEWPORT_ATTR_ORIENTATION_ON_SHEET = -1005254, // 0xFFF0A93A
        /// <summary>"Show Box"</summary>
        VIEWPORT_ATTR_SHOW_BOX = -1005253, // 0xFFF0A93B
        /// <summary>"Show Extension Line"</summary>
        VIEWPORT_ATTR_SHOW_EXTENSION_LINE = -1005252, // 0xFFF0A93C
        /// <summary>"Show Title"</summary>
        VIEWPORT_ATTR_SHOW_LABEL = -1005251, // 0xFFF0A93D
        /// <summary>"Title"</summary>
        VIEWPORT_ATTR_LABEL_TAG = -1005250, // 0xFFF0A93E
        /// <summary>"Display Name"</summary>
        VIEW_SCALE_HAVENAME = -1005231, // 0xFFF0A951
        /// <summary>"Display Name"</summary>
        VIEW_SCALE_CUSTOMNAME = -1005230, // 0xFFF0A952
        /// <summary>"Include Off-Grid Columns"</summary>
        VIEW_GRAPH_SCHED_OFF_GRID = -1005209, // 0xFFF0A967
        /// <summary>"Off-Grid Units Format"</summary>
        VIEW_GRAPH_SCHED_UNITS_FORMAT = -1005208, // 0xFFF0A968
        /// <summary>"Sheet Name"</summary>
        VIEWPORT_SHEET_NAME = -1005207, // 0xFFF0A969
        /// <summary>"Sheet Number"</summary>
        VIEWPORT_SHEET_NUMBER = -1005206, // 0xFFF0A96A
        /// <summary>"View Scale"</summary>
        VIEWPORT_SCALE = -1005204, // 0xFFF0A96C
        /// <summary>"View Name"</summary>
        VIEWPORT_VIEW_NAME = -1005203, // 0xFFF0A96D
        /// <summary>"Detail Number"</summary>
        VIEWPORT_DETAIL_NUMBER = -1005201, // 0xFFF0A96F
        /// <summary>"View Template"</summary>
        VIEW_TEMPLATE_FOR_SCHEDULE = -1005199, // 0xFFF0A971
        /// <summary>"Render Appearance Properties"</summary>
        RENDER_RPC_PROPERTIES = -1005198, // 0xFFF0A972
        /// <summary>"Symbolic Representation"</summary>
        FAMILY_SYMBOLIC_REP = -1005197, // 0xFFF0A973
        /// <summary>"Render Appearance Source"</summary>
        FAMILY_RENDERING_TYPE = -1005196, // 0xFFF0A974
        /// <summary>"Render Appearance"</summary>
        RENDER_RPC_FILENAME = -1005195, // 0xFFF0A975
        /// <summary>"Plant Trim Height"</summary>
        RENDER_PLANT_TRIM_HEIGHT = -1005194, // 0xFFF0A976
        /// <summary>"Height"</summary>
        RENDER_PLANT_HEIGHT = -1005193, // 0xFFF0A977
        /// <summary>"Plant Name"</summary>
        RENDER_PLANT_NAME = -1005192, // 0xFFF0A978
        /// <summary>"Locked Orientation"</summary>
        VIEW_CAMERA_ORIENTATION = -1005184, // 0xFFF0A980
        /// <summary>"Color Scheme Location"</summary>
        COLOR_SCHEME_LOCATION = -1005183, // 0xFFF0A981
        /// <summary>"Dependency"</summary>
        VIEW_DEPENDENCY = -1005182, // 0xFFF0A982
        /// <summary>"Depth Clipping"</summary>
        VIEW_BACK_CLIPPING = -1005181, // 0xFFF0A983
        /// <summary>"Associated Assembly Instance"</summary>
        VIEW_ASSOCIATED_ASSEMBLY_INSTANCE_ID = -1005179, // 0xFFF0A985
        /// <summary>"Total Column Locations"</summary>
        VIEW_GRAPH_SCHED_TOTAL_COLUMNS = -1005178, // 0xFFF0A986
        /// <summary>"Underlay Orientation"</summary>
        VIEW_UNDERLAY_ORIENTATION = -1005177, // 0xFFF0A987
        /// <summary>"View Template"</summary>
        VIEW_TEMPLATE = -1005176, // 0xFFF0A988
        /// <summary>"Column Locations per Segment"</summary>
        VIEW_GRAPH_SCHED_NUMBER_COLUMNS = -1005175, // 0xFFF0A989
        /// <summary>"Graphic Display Options"</summary>
        GRAPHIC_DISPLAY_OPTIONS = -1005173, // 0xFFF0A98B
        /// <summary>"Visual Style"</summary>
        MODEL_GRAPHICS_STYLE_ANON_DRAFT = -1005172, // 0xFFF0A98C
        /// <summary>"Referencing Detail"</summary>
        VIEW_REFERENCING_DETAIL = -1005171, // 0xFFF0A98D
        /// <summary>"Referencing Sheet"</summary>
        VIEW_REFERENCING_SHEET = -1005170, // 0xFFF0A98E
        /// <summary>"Camera Position"</summary>
        VIEW_CAMERA_POSITION = -1005169, // 0xFFF0A98F
        /// <summary>"Orientation"</summary>
        PLAN_VIEW_NORTH = -1005168, // 0xFFF0A990
        /// <summary>"Walkthrough Frames"</summary>
        WALKTHROUGH_FRAMES_COUNT = -1005167, // 0xFFF0A991
        /// <summary>"Associated Level"</summary>
        PLAN_VIEW_LEVEL = -1005166, // 0xFFF0A992
        /// <summary>"Visual Style"</summary>
        MODEL_GRAPHICS_STYLE = -1005165, // 0xFFF0A993
        /// <summary>"Visibility/Graphics Overrides"</summary>
        VIEW_VISIBLE_CATEGORIES = -1005164, // 0xFFF0A994
        /// <summary>"Discipline"</summary>
        VIEW_DISCIPLINE = -1005163, // 0xFFF0A995
        /// <summary>"View Range"</summary>
        PLAN_VIEW_RANGE = -1005162, // 0xFFF0A996
        /// <summary>"Display Model"</summary>
        VIEW_MODEL_DISPLAY_MODE = -1005161, // 0xFFF0A997
        /// <summary>"Show Mass"</summary>
        VIEW_SHOW_MASSING = -1005160, // 0xFFF0A998
        /// <summary>"Top Clip Height"</summary>
        PLAN_VIEW_TOP_CLIP_HEIGHT = -1005159, // 0xFFF0A999
        /// <summary>"Wall Join Display"</summary>
        VIEW_CLEAN_JOINS = -1005158, // 0xFFF0A99A
        /// <summary>"Viewport"</summary>
        VIEW_SHEET_VIEWPORT_INFO = -1005157, // 0xFFF0A99B
        /// <summary>"Cut Plane Height"</summary>
        PLAN_VIEW_CUT_PLANE_HEIGHT = -1005155, // 0xFFF0A99D
        /// <summary>"View Depth"</summary>
        VIEW_DEPTH = -1005154, // 0xFFF0A99E
        /// <summary>"Range: Base Level"</summary>
        VIEW_UNDERLAY_BOTTOM_ID = -1005153, // 0xFFF0A99F
        /// <summary>"View Scale"</summary>
        VIEW_SCALE_PULLDOWN_IMPERIAL = -1005152, // 0xFFF0A9A0
        /// <summary>"View Scale"</summary>
        VIEW_SCALE_PULLDOWN_METRIC = -1005151, // 0xFFF0A9A1
        /// <summary>"Scale Value    1:"</summary>
        VIEW_SCALE = -1005150, // 0xFFF0A9A2
        /// <summary>"System Color Schemes"</summary>
        VIEW_SCHEMA_SETTING_FOR_SYSTEM = -1005149, // 0xFFF0A9A3
        /// <summary>"Color Scheme"</summary>
        VIEW_SCHEMA_SETTING_FOR_BUILDING = -1005148, // 0xFFF0A9A4
        /// <summary>"None"</summary>
        VIEW_FIXED_SKETCH_PLANE = -1005147, // 0xFFF0A9A5
        /// <summary>"Photographic Exposure"</summary>
        GRAPHIC_DISPLAY_OPTIONS_PHOTO_EXPOSURE = -1005137, // 0xFFF0A9AF
        /// <summary>"Depth Cueing"</summary>
        GRAPHIC_DISPLAY_OPTIONS_FOG = -1005136, // 0xFFF0A9B0
        /// <summary>"Background"</summary>
        GRAPHIC_DISPLAY_OPTIONS_BACKGROUND = -1005135, // 0xFFF0A9B1
        /// <summary>"Sun and Shadow Intensity"</summary>
        GRAPHIC_DISPLAY_OPTIONS_SS_INTENSITY = -1005134, // 0xFFF0A9B2
        /// <summary>"Lighting"</summary>
        GRAPHIC_DISPLAY_OPTIONS_LIGHTING = -1005133, // 0xFFF0A9B3
        /// <summary>"Shadows"</summary>
        GRAPHIC_DISPLAY_OPTIONS_SHADOWS = -1005132, // 0xFFF0A9B4
        /// <summary>"Model Display"</summary>
        GRAPHIC_DISPLAY_OPTIONS_MODEL = -1005131, // 0xFFF0A9B5
        /// <summary>"Rendering Settings"</summary>
        VIEWER3D_RENDER_SETTINGS = -1005124, // 0xFFF0A9BC
        /// <summary>"Far Clipping"</summary>
        VIEWER_BOUND_FAR_CLIPPING = -1005123, // 0xFFF0A9BD
        /// <summary>"Reference Label"</summary>
        VIEWER_REFERENCE_LABEL_TEXT = -1005122, // 0xFFF0A9BE
        /// <summary>"Is a Reference"</summary>
        VIEWER_IS_REFERENCE = -1005121, // 0xFFF0A9BF
        /// <summary>"Reference Label"</summary>
        VIEWER_REFERENCE_LABEL = -1005120, // 0xFFF0A9C0
        /// <summary>"Title on Sheet"</summary>
        VIEW_DESCRIPTION = -1005114, // 0xFFF0A9C6
        /// <summary>"Section Box"</summary>
        VIEWER_MODEL_CLIP_BOX_ACTIVE = -1005113, // 0xFFF0A9C7
        /// <summary>"View Name"</summary>
        VIEW_NAME = -1005112, // 0xFFF0A9C8
        /// <summary>"Near Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_NEAR = -1005111, // 0xFFF0A9C9
        /// <summary>"Far Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_FAR = -1005110, // 0xFFF0A9CA
        /// <summary>"Bottom Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_BOTTOM = -1005109, // 0xFFF0A9CB
        /// <summary>"Top Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_TOP = -1005108, // 0xFFF0A9CC
        /// <summary>"Left Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_LEFT = -1005107, // 0xFFF0A9CD
        /// <summary>"Right Clip Active"</summary>
        VIEWER_BOUND_ACTIVE_RIGHT = -1005106, // 0xFFF0A9CE
        /// <summary>"Near Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_NEAR = -1005105, // 0xFFF0A9CF
        /// <summary>"Far Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_FAR = -1005104, // 0xFFF0A9D0
        /// <summary>"Bottom Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_BOTTOM = -1005103, // 0xFFF0A9D1
        /// <summary>"Top Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_TOP = -1005102, // 0xFFF0A9D2
        /// <summary>"Left Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_LEFT = -1005101, // 0xFFF0A9D3
        /// <summary>"Right Clip Offset"</summary>
        VIEWER_BOUND_OFFSET_RIGHT = -1005100, // 0xFFF0A9D4
        /// <summary>"Annotation Crop"</summary>
        VIEWER_ANNOTATION_CROP_ACTIVE = -1005094, // 0xFFF0A9DA
        /// <summary>"Show uncropped"</summary>
        VIEWER_SHOW_UNCROPPED = -1005093, // 0xFFF0A9DB
        /// <summary>"Crop View"</summary>
        VIEWER_CROP_REGION_DISABLED = -1005092, // 0xFFF0A9DC
        /// <summary>"Crop Region Visible"</summary>
        VIEWER_CROP_REGION_VISIBLE = -1005091, // 0xFFF0A9DD
        /// <summary>"Crop View"</summary>
        VIEWER_CROP_REGION = -1005090, // 0xFFF0A9DE
        /// <summary>"Projection Mode"</summary>
        VIEWER_PERSPECTIVE = -1005050, // 0xFFF0AA06
        /// <summary>"Target Elevation"</summary>
        VIEWER_TARGET_ELEVATION = -1005002, // 0xFFF0AA36
        /// <summary>"Visible In Option"</summary>
        VIEWER_OPTION_VISIBILITY = -1005001, // 0xFFF0AA37
        /// <summary>"Eye Elevation"</summary>
        VIEWER_EYE_ELEVATION = -1005000, // 0xFFF0AA38
        /// <summary>"Is Instance Parameter"</summary>
        DIM_LABEL_IS_INSTANCE = -1004518, // 0xFFF0AC1A
        /// <summary>"Is Reporting"</summary>
        DIM_ISREPORTING = -1004516, // 0xFFF0AC1C
        /// <summary>"Leader"</summary>
        DIM_LEADER = -1004515, // 0xFFF0AC1D
        /// <summary>"Equality Display"</summary>
        DIM_DISPLAY_EQ = -1004514, // 0xFFF0AC1E
        /// <summary>"Non-modifiable"</summary>
        DIM_NOT_MODIFIABLE = -1004513, // 0xFFF0AC1F
        /// <summary>"Label"</summary>
        DIM_LABEL = -1004510, // 0xFFF0AC22
        /// <summary>"Show Label in View"</summary>
        DIM_LABEL_GP_SHOW = -1004502, // 0xFFF0AC2A
        /// <summary>"Value"</summary>
        DIM_VALUE_ANGLE = -1004501, // 0xFFF0AC2B
        /// <summary>"Value"</summary>
        DIM_VALUE_LENGTH = -1004500, // 0xFFF0AC2C
        /// <summary>"Is Reference"</summary>
        ELEM_REFERENCE_NAME_2D_XZ = -1004016, // 0xFFF0AE10
        /// <summary>"Defines Beam System Slope"</summary>
        CURVE_ELEM_DEFINES_SLOPE = -1004015, // 0xFFF0AE11
        /// <summary>"Radius"</summary>
        RADIAL_ARRAY_ARC_RADIUS = -1004014, // 0xFFF0AE12
        /// <summary>"Determines Orientation"</summary>
        CURVE_DETERMINES_ORIENTATION = -1004013, // 0xFFF0AE13
        /// <summary>"Wall Closure"</summary>
        DATUM_PLANE_DEFINES_WALL_CLOSURE = -1004012, // 0xFFF0AE14
        /// <summary>"Detail Line"</summary>
        CURVE_IS_DETAIL = -1004011, // 0xFFF0AE15
        /// <summary>"Radius"</summary>
        CURVE_ELEM_ARC_RADIUS = -1004010, // 0xFFF0AE16
        /// <summary>"Range"</summary>
        CURVE_ELEM_ARC_RANGE = -1004009, // 0xFFF0AE17
        /// <summary>"Angle 2"</summary>
        CURVE_ELEM_ARC_END_ANGLE = -1004008, // 0xFFF0AE18
        /// <summary>"Angle 1"</summary>
        CURVE_ELEM_ARC_START_ANGLE = -1004007, // 0xFFF0AE19
        /// <summary>"Angle"</summary>
        CURVE_ELEM_LINE_ANGLE = -1004006, // 0xFFF0AE1A
        /// <summary>"Length"</summary>
        CURVE_ELEM_LENGTH = -1004005, // 0xFFF0AE1B
        /// <summary>"Deletable"</summary>
        ELEM_DELETABLE_IN_FAMILY = -1004004, // 0xFFF0AE1C
        /// <summary>"Is Reference"</summary>
        ELEM_REFERENCE_NAME = -1004003, // 0xFFF0AE1D
        /// <summary>"Defines Origin"</summary>
        DATUM_PLANE_DEFINES_ORIGIN = -1004002, // 0xFFF0AE1E
        /// <summary>"Reference"</summary>
        ELEM_IS_REFERENCE = -1004001, // 0xFFF0AE1F
        /// <summary>"Column Location Mark"</summary>
        COLUMN_LOCATION_MARK = -1002563, // 0xFFF0B3BD
        /// <summary>"Top Attachment Cut"</summary>
        COLUMN_TOP_ATTACH_CUT_PARAM = -1002562, // 0xFFF0B3BE
        /// <summary>"Base Attachment Cut"</summary>
        COLUMN_BASE_ATTACH_CUT_PARAM = -1002561, // 0xFFF0B3BF
        /// <summary>"Base is Attached"</summary>
        COLUMN_BASE_ATTACHED_PARAM = -1002560, // 0xFFF0B3C0
        /// <summary>"Top is Attached"</summary>
        COLUMN_TOP_ATTACHED_PARAM = -1002559, // 0xFFF0B3C1
        /// <summary>"Offset From Attachment At Base"</summary>
        COLUMN_BASE_ATTACHMENT_OFFSET_PARAM = -1002558, // 0xFFF0B3C2
        /// <summary>"Offset From Attachment At Top"</summary>
        COLUMN_TOP_ATTACHMENT_OFFSET_PARAM = -1002557, // 0xFFF0B3C3
        /// <summary>"Attachment Justification At Base"</summary>
        COLUMN_BASE_ATTACH_JUSTIFICATION_PARAM = -1002556, // 0xFFF0B3C4
        /// <summary>"Attachment Justification At Top"</summary>
        COLUMN_TOP_ATTACH_JUSTIFICATION_PARAM = -1002555, // 0xFFF0B3C5
        /// <summary>"Shininess"</summary>
        MATERIAL_PARAM_SHININESS = -1002554, // 0xFFF0B3C6
        /// <summary>"Smoothness"</summary>
        MATERIAL_PARAM_SMOOTHNESS = -1002553, // 0xFFF0B3C7
        /// <summary>"Glow"</summary>
        MATERIAL_PARAM_GLOW = -1002552, // 0xFFF0B3C8
        /// <summary>"Transparency"</summary>
        MATERIAL_PARAM_TRANSPARENCY = -1002551, // 0xFFF0B3C9
        /// <summary>"Color"</summary>
        MATERIAL_PARAM_COLOR = -1002550, // 0xFFF0B3CA
        /// <summary>"Seek Item ID"</summary>
        SEEK_ITEM_ID = -1002504, // 0xFFF0B3F8
        /// <summary>"OmniClass Title"</summary>
        OMNICLASS_DESCRIPTION = -1002503, // 0xFFF0B3F9
        /// <summary>"OmniClass Number"</summary>
        OMNICLASS_CODE = -1002502, // 0xFFF0B3FA
        /// <summary>"Assembly Description"</summary>
        UNIFORMAT_DESCRIPTION = -1002501, // 0xFFF0B3FB
        /// <summary>"Assembly Code"</summary>
        UNIFORMAT_CODE = -1002500, // 0xFFF0B3FC
        /// <summary>"Height Offset at Head"</summary>
        SLOPE_END_HEIGHT = -1002401, // 0xFFF0B45F
        /// <summary>"Height Offset at Tail"</summary>
        SLOPE_START_HEIGHT = -1002400, // 0xFFF0B460
        /// <summary>"Has Thickness"</summary>
        CEILING_HAS_THICKNESS_PARAM = -1002302, // 0xFFF0B4C2
        /// <summary>"Thickness"</summary>
        CEILING_THICKNESS_PARAM = -1002301, // 0xFFF0B4C3
        /// <summary>"Height Offset From Level"</summary>
        CEILING_HEIGHTABOVELEVEL_PARAM = -1002300, // 0xFFF0B4C4
        /// <summary>"Thickness"</summary>
        CEILING_THICKNESS = -1002206, // 0xFFF0B522
        /// <summary>"System"</summary>
        CEILING_ATTR_SYSTEMNAME_PARAM = -1002204, // 0xFFF0B524
        /// <summary>"Spacing Axis 2"</summary>
        CEILING_ATTR_SPACING2_PARAM = -1002203, // 0xFFF0B525
        /// <summary>"Spacing Axis 1"</summary>
        CEILING_ATTR_SPACING1_PARAM = -1002202, // 0xFFF0B526
        /// <summary>"Pattern"</summary>
        CEILING_ATTR_PATTERN_PARAM = -1002201, // 0xFFF0B527
        /// <summary>"Default Height above level"</summary>
        CEILING_ATTR_DEFAULT_HEIGHT_PARAM = -1002200, // 0xFFF0B528
        /// <summary>"Masking"</summary>
        FILLED_REGION_MASKING = -1002125, // 0xFFF0B573
        /// <summary>"Background Pattern Color"</summary>
        BACKGROUND_PATTERN_COLOR_PARAM = -1002124, // 0xFFF0B574
        /// <summary>"Foreground Pattern Color"</summary>
        FOREGROUND_PATTERN_COLOR_PARAM = -1002123, // 0xFFF0B575
        /// <summary>"Background Fill Pattern"</summary>
        BACKGROUND_DRAFT_PATTERN_ID_PARAM = -1002122, // 0xFFF0B576
        /// <summary>"Foreground Fill Pattern"</summary>
        FOREGROUND_ANY_PATTERN_ID_PARAM = -1002121, // 0xFFF0B577
        /// <summary>"Foreground Fill Pattern"</summary>
        FOREGROUND_DRAFT_PATTERN_ID_PARAM = -1002120, // 0xFFF0B578
        /// <summary>"Structure"</summary>
        BUILIDING_PAD_STRUCTURE_ID_PARAM = -1002119, // 0xFFF0B579
        /// <summary>"Structure"</summary>
        CEILING_STRUCTURE_ID_PARAM = -1002118, // 0xFFF0B57A
        /// <summary>"Structure"</summary>
        ROOF_STRUCTURE_ID_PARAM = -1002117, // 0xFFF0B57B
        /// <summary>"Structure"</summary>
        FLOOR_STRUCTURE_ID_PARAM = -1002116, // 0xFFF0B57C
        /// <summary>"Fill Pattern"</summary>
        ANY_PATTERN_ID_PARAM_NO_NO = -1002115, // 0xFFF0B57D
        /// <summary>"Fill Pattern"</summary>
        FILL_PATTERN_ID_PARAM_NO_NO = -1002114, // 0xFFF0B57E
        /// <summary>"Object Style Material"</summary>
        OBJECT_STYLE_MATERIAL_ID_PARAM = -1002113, // 0xFFF0B57F
        /// <summary>"Wrapping at Inserts"</summary>
        WRAPPING_AT_INSERTS_PARAM = -1002112, // 0xFFF0B580
        /// <summary>"Wrapping at Ends"</summary>
        WRAPPING_AT_ENDS_PARAM = -1002111, // 0xFFF0B581
        /// <summary>"Coarse Scale Fill Color"</summary>
        COARSE_SCALE_FILL_PATTERN_COLOR = -1002110, // 0xFFF0B582
        /// <summary>"Subcategory"</summary>
        MODEL_CATEGORY_ID_PARAM = -1002109, // 0xFFF0B583
        /// <summary>"Host Id"</summary>
        HOST_ID_PARAM = -1002108, // 0xFFF0B584
        /// <summary>"Material"</summary>
        MATERIAL_ID_PARAM = -1002107, // 0xFFF0B585
        /// <summary>"Coarse Scale Fill Pattern"</summary>
        COARSE_SCALE_FILL_PATTERN_ID_PARAM = -1002106, // 0xFFF0B586
        /// <summary>"Fill Pattern"</summary>
        ANY_PATTERN_ID_PARAM = -1002105, // 0xFFF0B587
        /// <summary>"Structure"</summary>
        WALL_STRUCTURE_ID_PARAM = -1002103, // 0xFFF0B589
        /// <summary>"Surface fill pattern"</summary>
        SURFACE_PATTERN_ID_PARAM = -1002102, // 0xFFF0B58A
        /// <summary>"Cut fill pattern"</summary>
        FILL_PATTERN_ID_PARAM = -1002101, // 0xFFF0B58B
        /// <summary>"Id"</summary>
        ID_PARAM = -1002100, // 0xFFF0B58C
        /// <summary>"Editable only"</summary>
        SELECTION_EDITABLE_ONLY = -1002072, // 0xFFF0B5A8
        /// <summary>"Edited by"</summary>
        EDITED_BY = -1002067, // 0xFFF0B5AD
        /// <summary>"Top Offset"</summary>
        SCHEDULE_TOP_LEVEL_OFFSET_PARAM = -1002066, // 0xFFF0B5AE
        /// <summary>"Base Offset"</summary>
        SCHEDULE_BASE_LEVEL_OFFSET_PARAM = -1002065, // 0xFFF0B5AF
        /// <summary>"Top Level"</summary>
        SCHEDULE_TOP_LEVEL_PARAM = -1002064, // 0xFFF0B5B0
        /// <summary>"Base Level"</summary>
        SCHEDULE_BASE_LEVEL_PARAM = -1002063, // 0xFFF0B5B1
        /// <summary>"Level"</summary>
        SCHEDULE_LEVEL_PARAM = -1002062, // 0xFFF0B5B2
        /// <summary>"Room Id"</summary>
        ELEM_ROOM_ID = -1002061, // 0xFFF0B5B3
        /// <summary>"Room Name"</summary>
        ELEM_ROOM_NAME = -1002060, // 0xFFF0B5B4
        /// <summary>"Room Number"</summary>
        ELEM_ROOM_NUMBER = -1002059, // 0xFFF0B5B5
        /// <summary>"Workset"</summary>
        ELEM_PARTITION_PARAM = -1002053, // 0xFFF0B5BB
        /// <summary>"Family and Type"</summary>
        ELEM_FAMILY_AND_TYPE_PARAM = -1002052, // 0xFFF0B5BC
        /// <summary>"Family"</summary>
        ELEM_FAMILY_PARAM = -1002051, // 0xFFF0B5BD
        /// <summary>"Type"</summary>
        ELEM_TYPE_PARAM = -1002050, // 0xFFF0B5BE
        /// <summary>"Label"</summary>
        ELEM_TYPE_LABEL = -1002008, // 0xFFF0B5E8
        /// <summary>"Filter"</summary>
        BR_ORG_FILTER = -1002007, // 0xFFF0B5E9
        /// <summary>"Folders"</summary>
        BR_ORG_FOLDERS = -1002006, // 0xFFF0B5EA
        /// <summary>"Family and Type"</summary>
        SYMBOL_FAMILY_AND_TYPE_NAMES_PARAM = -1002003, // 0xFFF0B5ED
        /// <summary>"Family Name"</summary>
        ALL_MODEL_FAMILY_NAME = -1002002, // 0xFFF0B5EE
        /// <summary>"Family Name"</summary>
        SYMBOL_FAMILY_NAME_PARAM = -1002002, // 0xFFF0B5EE
        /// <summary>"Type Name"</summary>
        ALL_MODEL_TYPE_NAME = -1002001, // 0xFFF0B5EF
        /// <summary>"Type Name"</summary>
        SYMBOL_NAME_PARAM = -1002001, // 0xFFF0B5EF
        /// <summary>"Type Id"</summary>
        SYMBOL_ID_PARAM = -1002000, // 0xFFF0B5F0
        /// <summary>"Display in Hidden Views"</summary>
        STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS = -1001956, // 0xFFF0B61C
        /// <summary>"Span Direction"</summary>
        FLOOR_PARAM_SPAN_DIRECTION = -1001955, // 0xFFF0B61D
        /// <summary>"Structural"</summary>
        FLOOR_PARAM_IS_STRUCTURAL = -1001954, // 0xFFF0B61E
        /// <summary>"Perimeter"</summary>
        HOST_PERIMETER_COMPUTED = -1001953, // 0xFFF0B61F
        /// <summary>"Level"</summary>
        LEVEL_PARAM = -1001952, // 0xFFF0B620
        /// <summary>"Height Offset From Level"</summary>
        FLOOR_HEIGHTABOVELEVEL_PARAM = -1001951, // 0xFFF0B621
        /// <summary>"Default Height above level"</summary>
        FLOOR_ATTR_DEFAULT_HEIGHT_PARAM = -1001903, // 0xFFF0B651
        /// <summary>"Default Thickness"</summary>
        FLOOR_ATTR_DEFAULT_THICKNESS_PARAM = -1001902, // 0xFFF0B652
        /// <summary>"Thickness"</summary>
        FLOOR_ATTR_THICKNESS_PARAM = -1001900, // 0xFFF0B654
        /// <summary>"Orientation"</summary>
        INSERT_ORIENTATION = -1001834, // 0xFFF0B696
        /// <summary>"Parameter along path"</summary>
        PROFILE_PARAM_ALONG_PATH = -1001833, // 0xFFF0B697
        /// <summary>"Profile"</summary>
        PROFILE_FAM_TYPE_PLUS_NONE = -1001832, // 0xFFF0B698
        /// <summary>"Angle"</summary>
        PROFILE2_ANGLE = -1001831, // 0xFFF0B699
        /// <summary>"Profile"</summary>
        PROFILE2_FAM_TYPE = -1001830, // 0xFFF0B69A
        /// <summary>"Profile Is Flipped"</summary>
        PROFILE2_FLIPPED_HOR = -1001829, // 0xFFF0B69B
        /// <summary>"Vertical Profile Offset"</summary>
        PROFILE2_OFFSET_Y = -1001828, // 0xFFF0B69C
        /// <summary>"Horizontal Profile Offset"</summary>
        PROFILE2_OFFSET_X = -1001827, // 0xFFF0B69D
        /// <summary>"Angle"</summary>
        PROFILE1_ANGLE = -1001826, // 0xFFF0B69E
        /// <summary>"Profile"</summary>
        PROFILE1_FAM_TYPE = -1001825, // 0xFFF0B69F
        /// <summary>"Profile Is Flipped"</summary>
        PROFILE1_FLIPPED_HOR = -1001824, // 0xFFF0B6A0
        /// <summary>"Vertical Profile Offset"</summary>
        PROFILE1_OFFSET_Y = -1001823, // 0xFFF0B6A1
        /// <summary>"Horizontal Profile Offset"</summary>
        PROFILE1_OFFSET_X = -1001822, // 0xFFF0B6A2
        /// <summary>"Profile Usage"</summary>
        FAM_PROFILE_USAGE = -1001821, // 0xFFF0B6A3
        /// <summary>"Trajectory Segmentation"</summary>
        SWEEP_TRAJ_SEGMENTED = -1001820, // 0xFFF0B6A4
        /// <summary>"Maximum Segment Angle"</summary>
        SWEEP_MAX_SEG_ANGLE = -1001819, // 0xFFF0B6A5
        /// <summary>"Model or Symbolic"</summary>
        MODEL_OR_SYMBOLIC = -1001818, // 0xFFF0B6A6
        /// <summary>"Angle"</summary>
        PROFILE_ANGLE = -1001817, // 0xFFF0B6A7
        /// <summary>"Profile"</summary>
        PROFILE_FAM_TYPE = -1001816, // 0xFFF0B6A8
        /// <summary>"Profile Is Flipped"</summary>
        PROFILE_FLIPPED_HOR = -1001815, // 0xFFF0B6A9
        /// <summary>"Vertical Profile Offset"</summary>
        PROFILE_OFFSET_Y = -1001814, // 0xFFF0B6AA
        /// <summary>"Horizontal Profile Offset"</summary>
        PROFILE_OFFSET_X = -1001813, // 0xFFF0B6AB
        /// <summary>"Depth"</summary>
        EXTRUSION_LENGTH = -1001812, // 0xFFF0B6AC
        /// <summary>"Visibility/Graphics Overrides"</summary>
        CURVE_VISIBILITY_PARAM = -1001809, // 0xFFF0B6AF
        /// <summary>"Visibility/Graphics Overrides"</summary>
        GEOM_VISIBILITY_PARAM = -1001808, // 0xFFF0B6B0
        /// <summary>"Solid/Void"</summary>
        ELEMENT_IS_CUTTING = -1001807, // 0xFFF0B6B1
        /// <summary>"Auto ends"</summary>
        EXTRUSION_AUTO_PARAMS = -1001806, // 0xFFF0B6B2
        /// <summary>"Second End"</summary>
        BLEND_END_PARAM = -1001805, // 0xFFF0B6B3
        /// <summary>"First End"</summary>
        BLEND_START_PARAM = -1001804, // 0xFFF0B6B4
        /// <summary>"End Angle"</summary>
        REVOLUTION_END_ANGLE = -1001803, // 0xFFF0B6B5
        /// <summary>"Start Angle"</summary>
        REVOLUTION_START_ANGLE = -1001802, // 0xFFF0B6B6
        /// <summary>"Extrusion End"</summary>
        EXTRUSION_END_PARAM = -1001801, // 0xFFF0B6B7
        /// <summary>"Extrusion Start"</summary>
        EXTRUSION_START_PARAM = -1001800, // 0xFFF0B6B8
        /// <summary>"Schedule Type"</summary>
        SCHEDULE_TYPE_FOR_BROWSER = -1001718, // 0xFFF0B70A
        /// <summary>"Category"</summary>
        SCHEDULE_CATEGORY = -1001717, // 0xFFF0B70B
        /// <summary>"Level Offset"</summary>
        FACEROOF_OFFSET_PARAM = -1001716, // 0xFFF0B70C
        /// <summary>"Reference Level"</summary>
        FACEROOF_LEVEL_PARAM = -1001715, // 0xFFF0B70D
        /// <summary>"Picked Faces Location"</summary>
        ROOF_FACES_LOCATION = -1001714, // 0xFFF0B70E
        /// <summary>"Related to Mass"</summary>
        RELATED_TO_MASS = -1001713, // 0xFFF0B70F
        /// <summary>"Fascia Depth"</summary>
        FASCIA_DEPTH_PARAM = -1001711, // 0xFFF0B711
        /// <summary>"Rafter Cut"</summary>
        ROOF_EAVE_CUT_PARAM = -1001710, // 0xFFF0B712
        /// <summary>"Rafter or Truss"</summary>
        ROOF_RAFTER_OR_TRUSS_PARAM = -1001709, // 0xFFF0B713
        /// <summary>"Base Level"</summary>
        ROOF_BASE_LEVEL_PARAM = -1001708, // 0xFFF0B714
        /// <summary>"Overhang"</summary>
        CURVE_WALL_OFFSET_ROOFS = -1001707, // 0xFFF0B715
        /// <summary>"Wall offset"</summary>
        CURVE_WALL_OFFSET = -1001706, // 0xFFF0B716
        /// <summary>"Maximum Ridge Height"</summary>
        ACTUAL_MAX_RIDGE_HEIGHT_PARAM = -1001705, // 0xFFF0B717
        /// <summary>"Cutoff Offset"</summary>
        ROOF_UPTO_LEVEL_OFFSET_PARAM = -1001703, // 0xFFF0B719
        /// <summary>"Cutoff Level"</summary>
        ROOF_UPTO_LEVEL_PARAM = -1001702, // 0xFFF0B71A
        /// <summary>"Base Offset From Level"</summary>
        ROOF_LEVEL_OFFSET_PARAM = -1001701, // 0xFFF0B71B
        /// <summary>"Elevation at Bottom Survey"</summary>
        STRUCTURAL_ELEVATION_AT_BOTTOM_SURVEY = -1001658, // 0xFFF0B746
        /// <summary>"Elevation at Top Survey"</summary>
        STRUCTURAL_ELEVATION_AT_TOP_SURVEY = -1001657, // 0xFFF0B747
        /// <summary>"Core Thickness"</summary>
        STRUCTURAL_FLOOR_CORE_THICKNESS = -1001656, // 0xFFF0B748
        /// <summary>"Elevation at Bottom Core"</summary>
        STRUCTURAL_ELEVATION_AT_BOTTOM_CORE = -1001655, // 0xFFF0B749
        /// <summary>"Elevation at Top Core"</summary>
        STRUCTURAL_ELEVATION_AT_TOP_CORE = -1001654, // 0xFFF0B74A
        /// <summary>"Reference Level Elevation"</summary>
        STRUCTURAL_REFERENCE_LEVEL_ELEVATION = -1001653, // 0xFFF0B74B
        /// <summary>"Level Offset"</summary>
        ROOF_CONSTRAINT_OFFSET_PARAM = -1001652, // 0xFFF0B74C
        /// <summary>"Reference Level"</summary>
        ROOF_CONSTRAINT_LEVEL_PARAM = -1001651, // 0xFFF0B74D
        /// <summary>"Curved Edge Condition"</summary>
        HOST_SSE_CURVED_EDGE_CONDITION_PARAM = -1001603, // 0xFFF0B77D
        /// <summary>"Thickness"</summary>
        ROOF_ATTR_THICKNESS_PARAM = -1001601, // 0xFFF0B77F
        /// <summary>"Default Thickness"</summary>
        ROOF_ATTR_DEFAULT_THICKNESS_PARAM = -1001600, // 0xFFF0B780
        /// <summary>"Elevation at Top"</summary>
        STRUCTURAL_ELEVATION_AT_TOP = -1001598, // 0xFFF0B782
        /// <summary>"Connection Status"</summary>
        NODE_CONNECTION_STATUS = -1001597, // 0xFFF0B783
        /// <summary>"Structural"</summary>
        WALL_STRUCTURAL_SIGNIFICANT = -1001596, // 0xFFF0B784
        /// <summary>"Analytical Links"</summary>
        STRUCTURAL_ANALYTICAL_BEAM_RIGID_LINK = -1001595, // 0xFFF0B785
        /// <summary>"Horizontal Projection"</summary>
        STRUCTURAL_ANALYTICAL_COLUMN_HORIZONTAL_PROJECTION_PLANE = -1001594, // 0xFFF0B786
        /// <summary>"Horizontal Projection"</summary>
        STRUCTURAL_ANALYTICAL_BEAM_HORIZONTAL_PROJECTION_PLANE = -1001593, // 0xFFF0B787
        /// <summary>"Do Not Break At Inserts"</summary>
        CONTINUOUS_FOOTING_BREAK_AT_INSERTS_DISABLE = -1001592, // 0xFFF0B788
        /// <summary>"Default End Extension Length"</summary>
        CONTINUOUS_FOOTING_DEFAULT_END_EXTENSION_LENGTH = -1001591, // 0xFFF0B789
        /// <summary>"Approximate curve"</summary>
        STRUCTURAL_ANALYTICAL_TESSELLATE = -1001589, // 0xFFF0B78B
        /// <summary>"Maximum discretized offset"</summary>
        STRUCTURAL_ANALYTICAL_TESS_DEVIATION = -1001588, // 0xFFF0B78C
        /// <summary>"Use hard-points"</summary>
        STRUCTURAL_ANALYTICAL_HARD_POINTS = -1001587, // 0xFFF0B78D
        /// <summary>"Cross-Section Rotation"</summary>
        STRUCTURAL_BEND_DIR_ANGLE = -1001586, // 0xFFF0B78E
        /// <summary>"Display in Hidden Views"</summary>
        STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS_COLUMN = -1001585, // 0xFFF0B78F
        /// <summary>"Display in Hidden Views"</summary>
        STRUCTURAL_DISPLAY_IN_HIDDEN_VIEWS_FRAMING = -1001584, // 0xFFF0B790
        /// <summary>"Analyze As"</summary>
        STRUCTURAL_FLOOR_ANALYZES_AS = -1001577, // 0xFFF0B797
        /// <summary>"Analyze As"</summary>
        STRUCTURAL_ANALYZES_AS = -1001576, // 0xFFF0B798
        /// <summary>"Beam cutback in plan"</summary>
        STRUCTURAL_BEAM_CUTBACK_FOR_COLUMN = -1001575, // 0xFFF0B799
        /// <summary>"z-Direction Offset Value"</summary>
        BEAM_V_JUSTIFICATION_OTHER_VALUE = -1001574, // 0xFFF0B79A
        /// <summary>"Orientation"</summary>
        STRUCTURAL_BEAM_ORIENTATION = -1001573, // 0xFFF0B79B
        /// <summary>"End Level Offset"</summary>
        STRUCTURAL_BEAM_END1_ELEVATION = -1001572, // 0xFFF0B79C
        /// <summary>"Start Level Offset"</summary>
        STRUCTURAL_BEAM_END0_ELEVATION = -1001571, // 0xFFF0B79D
        /// <summary>"Always export as geometry"</summary>
        FAMILY_EXPORT_AS_GEOMETRY = -1001570, // 0xFFF0B79E
        /// <summary>"Length"</summary>
        STRUCTURAL_FOUNDATION_LENGTH = -1001569, // 0xFFF0B79F
        /// <summary>"Width"</summary>
        STRUCTURAL_FOUNDATION_WIDTH = -1001568, // 0xFFF0B7A0
        /// <summary>"Length"</summary>
        CONTINUOUS_FOOTING_LENGTH = -1001567, // 0xFFF0B7A1
        /// <summary>"Eccentricity"</summary>
        CONTINUOUS_FOOTING_ECCENTRICITY = -1001564, // 0xFFF0B7A4
        /// <summary>"Structural Usage"</summary>
        CONTINUOUS_FOOTING_STRUCTURAL_USAGE = -1001563, // 0xFFF0B7A5
        /// <summary>"Width"</summary>
        CONTINUOUS_FOOTING_BEARING_WIDTH = -1001562, // 0xFFF0B7A6
        /// <summary>"Elevation at Bottom"</summary>
        STRUCTURAL_ELEVATION_AT_BOTTOM = -1001561, // 0xFFF0B7A7
        /// <summary>"Cap"</summary>
        FAMILY_STRUCT_FOOTING_USE_CAP_TOP = -1001560, // 0xFFF0B7A8
        /// <summary>"Coping Distance"</summary>
        STRUCTURAL_COPING_DISTANCE = -1001559, // 0xFFF0B7A9
        /// <summary>"Width"</summary>
        CONTINUOUS_FOOTING_WIDTH = -1001558, // 0xFFF0B7AA
        /// <summary>"Foundation Thickness"</summary>
        STRUCTURAL_FOUNDATION_THICKNESS = -1001557, // 0xFFF0B7AB
        /// <summary>"Bottom Heel Length"</summary>
        CONTINUOUS_FOOTING_BOTTOM_HEEL = -1001556, // 0xFFF0B7AC
        /// <summary>"Heel Length"</summary>
        CONTINUOUS_FOOTING_TOP_HEEL = -1001555, // 0xFFF0B7AD
        /// <summary>"Bottom Toe Length"</summary>
        CONTINUOUS_FOOTING_BOTTOM_TOE = -1001554, // 0xFFF0B7AE
        /// <summary>"Toe Length"</summary>
        CONTINUOUS_FOOTING_TOP_TOE = -1001553, // 0xFFF0B7AF
        /// <summary>"Enable Analytical Model"</summary>
        STRUCTURAL_ANALYTICAL_MODEL = -1001552, // 0xFFF0B7B0
        /// <summary>"Analytical Links"</summary>
        STRUCTURAL_ANALYTICAL_COLUMN_RIGID_LINK = -1001551, // 0xFFF0B7B1
        /// <summary>"Material for Model Behavior"</summary>
        FAMILY_STRUCT_MATERIAL_TYPE = -1001550, // 0xFFF0B7B2
        /// <summary>"Base Mz"</summary>
        STRUCTURAL_BOTTOM_RELEASE_MZ = -1001549, // 0xFFF0B7B3
        /// <summary>"Base My"</summary>
        STRUCTURAL_BOTTOM_RELEASE_MY = -1001548, // 0xFFF0B7B4
        /// <summary>"Base Mx"</summary>
        STRUCTURAL_BOTTOM_RELEASE_MX = -1001547, // 0xFFF0B7B5
        /// <summary>"Base Fz"</summary>
        STRUCTURAL_BOTTOM_RELEASE_FZ = -1001546, // 0xFFF0B7B6
        /// <summary>"Base Fy"</summary>
        STRUCTURAL_BOTTOM_RELEASE_FY = -1001545, // 0xFFF0B7B7
        /// <summary>"Base Fx"</summary>
        STRUCTURAL_BOTTOM_RELEASE_FX = -1001544, // 0xFFF0B7B8
        /// <summary>"Top Mz"</summary>
        STRUCTURAL_TOP_RELEASE_MZ = -1001543, // 0xFFF0B7B9
        /// <summary>"Top My"</summary>
        STRUCTURAL_TOP_RELEASE_MY = -1001542, // 0xFFF0B7BA
        /// <summary>"Top Mx"</summary>
        STRUCTURAL_TOP_RELEASE_MX = -1001541, // 0xFFF0B7BB
        /// <summary>"Top Fz"</summary>
        STRUCTURAL_TOP_RELEASE_FZ = -1001540, // 0xFFF0B7BC
        /// <summary>"Top Fy"</summary>
        STRUCTURAL_TOP_RELEASE_FY = -1001539, // 0xFFF0B7BD
        /// <summary>"Top Fx"</summary>
        STRUCTURAL_TOP_RELEASE_FX = -1001538, // 0xFFF0B7BE
        /// <summary>"Base Release"</summary>
        STRUCTURAL_BOTTOM_RELEASE_TYPE = -1001537, // 0xFFF0B7BF
        /// <summary>"Top Release"</summary>
        STRUCTURAL_TOP_RELEASE_TYPE = -1001536, // 0xFFF0B7C0
        /// <summary>"Bottom Vertical Projection"</summary>
        STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE_COLUMN_BOTTOM = -1001535, // 0xFFF0B7C1
        /// <summary>"Top Vertical Projection"</summary>
        STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE_COLUMN_TOP = -1001534, // 0xFFF0B7C2
        /// <summary>"Structural Material Type"</summary>
        STRUCTURAL_MATERIAL_TYPE = -1001531, // 0xFFF0B7C5
        /// <summary>"Camber Size"</summary>
        STRUCTURAL_CAMBER = -1001530, // 0xFFF0B7C6
        /// <summary>"Number of studs"</summary>
        STRUCTURAL_NUMBER_OF_STUDS = -1001529, // 0xFFF0B7C7
        /// <summary>"End Mz"</summary>
        STRUCTURAL_END_RELEASE_MZ = -1001528, // 0xFFF0B7C8
        /// <summary>"End My"</summary>
        STRUCTURAL_END_RELEASE_MY = -1001527, // 0xFFF0B7C9
        /// <summary>"End Mx"</summary>
        STRUCTURAL_END_RELEASE_MX = -1001526, // 0xFFF0B7CA
        /// <summary>"End Fz"</summary>
        STRUCTURAL_END_RELEASE_FZ = -1001525, // 0xFFF0B7CB
        /// <summary>"End Fy"</summary>
        STRUCTURAL_END_RELEASE_FY = -1001524, // 0xFFF0B7CC
        /// <summary>"End Fx"</summary>
        STRUCTURAL_END_RELEASE_FX = -1001523, // 0xFFF0B7CD
        /// <summary>"Start Mz"</summary>
        STRUCTURAL_START_RELEASE_MZ = -1001522, // 0xFFF0B7CE
        /// <summary>"Start My"</summary>
        STRUCTURAL_START_RELEASE_MY = -1001521, // 0xFFF0B7CF
        /// <summary>"Start Mx"</summary>
        STRUCTURAL_START_RELEASE_MX = -1001520, // 0xFFF0B7D0
        /// <summary>"Start Fz"</summary>
        STRUCTURAL_START_RELEASE_FZ = -1001519, // 0xFFF0B7D1
        /// <summary>"Start Fy"</summary>
        STRUCTURAL_START_RELEASE_FY = -1001518, // 0xFFF0B7D2
        /// <summary>"Start Fx"</summary>
        STRUCTURAL_START_RELEASE_FX = -1001517, // 0xFFF0B7D3
        /// <summary>"End Release"</summary>
        STRUCTURAL_END_RELEASE_TYPE = -1001516, // 0xFFF0B7D4
        /// <summary>"Start Release"</summary>
        STRUCTURAL_START_RELEASE_TYPE = -1001515, // 0xFFF0B7D5
        /// <summary>"Bottom Vertical Projection"</summary>
        STRUCTURAL_WALL_BOTTOM_PROJECTION_PLANE = -1001514, // 0xFFF0B7D6
        /// <summary>"Top Vertical Projection"</summary>
        STRUCTURAL_WALL_TOP_PROJECTION_PLANE = -1001513, // 0xFFF0B7D7
        /// <summary>"Horizontal Projection"</summary>
        STRUCTURAL_WALL_PROJECTION_SURFACE = -1001512, // 0xFFF0B7D8
        /// <summary>"Vertical Projection"</summary>
        STRUCTURAL_ANALYTICAL_PROJECT_FLOOR_PLANE = -1001510, // 0xFFF0B7DA
        /// <summary>"Vertical Projection"</summary>
        STRUCTURAL_ANALYTICAL_PROJECT_MEMBER_PLANE = -1001508, // 0xFFF0B7DC
        /// <summary>"Representation Type"</summary>
        STRUCTURAL_BRACE_REPRESENTATION = -1001507, // 0xFFF0B7DD
        /// <summary>"Stick Symbol Location"</summary>
        STRUCTURAL_STICK_SYMBOL_LOCATION = -1001503, // 0xFFF0B7E1
        /// <summary>"Beam End Pocket Seat"</summary>
        STRUCTURAL_BEAM_END_SUPPORT = -1001502, // 0xFFF0B7E2
        /// <summary>"Beam Start Pocket Seat"</summary>
        STRUCTURAL_BEAM_START_SUPPORT = -1001501, // 0xFFF0B7E3
        /// <summary>"Type Mark"</summary>
        ALL_MODEL_TYPE_MARK = -1001405, // 0xFFF0B843
        /// <summary>"Type Mark"</summary>
        WINDOW_TYPE_ID = -1001405, // 0xFFF0B843
        /// <summary>"Orientation"</summary>
        WALL_SWEEP_ORIENTATION = -1001399, // 0xFFF0B849
        /// <summary>"End Attachment Elevation"</summary>
        STRUCTURAL_ATTACHMENT_END_VALUE_ELEVATION = -1001398, // 0xFFF0B84A
        /// <summary>"Start Attachment Elevation"</summary>
        STRUCTURAL_ATTACHMENT_START_VALUE_ELEVATION = -1001397, // 0xFFF0B84B
        /// <summary>"End Attachment Level Reference"</summary>
        STRUCTURAL_ATTACHMENT_END_LEVEL_REFERENCE = -1001396, // 0xFFF0B84C
        /// <summary>"Start Attachment Level Reference"</summary>
        STRUCTURAL_ATTACHMENT_START_LEVEL_REFERENCE = -1001395, // 0xFFF0B84D
        /// <summary>"End attachment ratio"</summary>
        STRUCTURAL_ATTACHMENT_END_VALUE_RATIO = -1001393, // 0xFFF0B84F
        /// <summary>"Start Attachment Ratio"</summary>
        STRUCTURAL_ATTACHMENT_START_VALUE_RATIO = -1001392, // 0xFFF0B850
        /// <summary>"End of Attachment to Reference Element"</summary>
        STRUCTURAL_ATTACHMENT_END_REFELEMENT_END = -1001391, // 0xFFF0B851
        /// <summary>"Wall Closure"</summary>
        TYPE_WALL_CLOSURE = -1001390, // 0xFFF0B852
        /// <summary>"Start of Attachment to Reference Element"</summary>
        STRUCTURAL_ATTACHMENT_START_REFELEMENT_END = -1001389, // 0xFFF0B853
        /// <summary>"End Attachment Distance"</summary>
        STRUCTURAL_ATTACHMENT_END_VALUE_DISTANCE = -1001388, // 0xFFF0B854
        /// <summary>"Start Attachment Distance"</summary>
        STRUCTURAL_ATTACHMENT_START_VALUE_DISTANCE = -1001387, // 0xFFF0B855
        /// <summary>"End Attachment Type"</summary>
        STRUCTURAL_ATTACHMENT_END_TYPE = -1001386, // 0xFFF0B856
        /// <summary>"Start Attachment Type"</summary>
        STRUCTURAL_ATTACHMENT_START_TYPE = -1001385, // 0xFFF0B857
        /// <summary>"Cut Length"</summary>
        STRUCTURAL_FRAME_CUT_LENGTH = -1001384, // 0xFFF0B858
        /// <summary>"Reference Level"</summary>
        INSTANCE_REFERENCE_LEVEL_PARAM = -1001383, // 0xFFF0B859
        /// <summary>"Structural Usage"</summary>
        INSTANCE_STRUCT_USAGE_PARAM = -1001381, // 0xFFF0B85B
        /// <summary>"Work Plane"</summary>
        SKETCH_PLANE_PARAM = -1001380, // 0xFFF0B85C
        /// <summary>"Length"</summary>
        INSTANCE_LENGTH_PARAM = -1001375, // 0xFFF0B861
        /// <summary>"Moves With Grids"</summary>
        INSTANCE_MOVES_WITH_GRID_PARAM = -1001371, // 0xFFF0B865
        /// <summary>"Moves With Nearby Elements"</summary>
        INSTANCE_OFFSET_POS_PARAM = -1001370, // 0xFFF0B866
        /// <summary>"Schedule Level"</summary>
        INSTANCE_SCHEDULE_ONLY_LEVEL_PARAM = -1001365, // 0xFFF0B86B
        /// <summary>"Offset from Host"</summary>
        INSTANCE_FREE_HOST_OFFSET_PARAM = -1001364, // 0xFFF0B86C
        /// <summary>"Host"</summary>
        INSTANCE_FREE_HOST_PARAM = -1001363, // 0xFFF0B86D
        /// <summary>"Head Height"</summary>
        INSTANCE_HEAD_HEIGHT_PARAM = -1001362, // 0xFFF0B86E
        /// <summary>"Sill Height"</summary>
        INSTANCE_SILL_HEIGHT_PARAM = -1001361, // 0xFFF0B86F
        /// <summary>"Elevation from Level"</summary>
        INSTANCE_ELEVATION_PARAM = -1001360, // 0xFFF0B870
        /// <summary>"Top Offset"</summary>
        FAMILY_TOP_LEVEL_OFFSET_PARAM = -1001358, // 0xFFF0B872
        /// <summary>"Base Offset"</summary>
        FAMILY_BASE_LEVEL_OFFSET_PARAM = -1001357, // 0xFFF0B873
        /// <summary>"Level"</summary>
        FAMILY_LEVEL_PARAM = -1001352, // 0xFFF0B878
        /// <summary>"Top Level"</summary>
        FAMILY_TOP_LEVEL_PARAM = -1001351, // 0xFFF0B879
        /// <summary>"Base Level"</summary>
        FAMILY_BASE_LEVEL_PARAM = -1001350, // 0xFFF0B87A
        /// <summary>"File Path"</summary>
        FAMILY_RFA_PATH_PSEUDO_PARAM = -1001338, // 0xFFF0B886
        /// <summary>"Category"</summary>
        FAMILY_CATEGORY_PSEUDO_PARAM = -1001337, // 0xFFF0B887
        /// <summary>"Family"</summary>
        FAMILY_NAME_PSEUDO_PARAM = -1001336, // 0xFFF0B888
        /// <summary>"Usage"</summary>
        FAMILY_USAGE_PSEUDO_PARAM = -1001335, // 0xFFF0B889
        /// <summary>"Default Elevation"</summary>
        FAMILY_WPB_DEFAULT_ELEVATION = -1001320, // 0xFFF0B898
        /// <summary>"Length"</summary>
        FAMILY_LINE_LENGTH_PARAM = -1001306, // 0xFFF0B8A6
        /// <summary>"Rough Width"</summary>
        FAMILY_ROUGH_WIDTH_PARAM = -1001305, // 0xFFF0B8A7
        /// <summary>"Rough Height"</summary>
        FAMILY_ROUGH_HEIGHT_PARAM = -1001304, // 0xFFF0B8A8
        /// <summary>"Inset"</summary>
        FAMILY_WINDOW_INSET_PARAM = -1001303, // 0xFFF0B8A9
        /// <summary>"Inset"</summary>
        WINDOW_INSET = -1001303, // 0xFFF0B8A9
        /// <summary>"Thickness"</summary>
        DOOR_THICKNESS = -1001302, // 0xFFF0B8AA
        /// <summary>"Thickness"</summary>
        FAMILY_THICKNESS_PARAM = -1001302, // 0xFFF0B8AA
        /// <summary>"Thickness"</summary>
        FURNITURE_THICKNESS = -1001302, // 0xFFF0B8AA
        /// <summary>"Thickness"</summary>
        GENERIC_THICKNESS = -1001302, // 0xFFF0B8AA
        /// <summary>"Thickness"</summary>
        WINDOW_THICKNESS = -1001302, // 0xFFF0B8AA
        /// <summary>"Width"</summary>
        CASEWORK_WIDTH = -1001301, // 0xFFF0B8AB
        /// <summary>"Width"</summary>
        DOOR_WIDTH = -1001301, // 0xFFF0B8AB
        /// <summary>"Width"</summary>
        FAMILY_WIDTH_PARAM = -1001301, // 0xFFF0B8AB
        /// <summary>"Width"</summary>
        FURNITURE_WIDTH = -1001301, // 0xFFF0B8AB
        /// <summary>"Width"</summary>
        GENERIC_WIDTH = -1001301, // 0xFFF0B8AB
        /// <summary>"Width"</summary>
        WINDOW_WIDTH = -1001301, // 0xFFF0B8AB
        /// <summary>"Height"</summary>
        CASEWORK_HEIGHT = -1001300, // 0xFFF0B8AC
        /// <summary>"Height"</summary>
        DOOR_HEIGHT = -1001300, // 0xFFF0B8AC
        /// <summary>"Height"</summary>
        FAMILY_HEIGHT_PARAM = -1001300, // 0xFFF0B8AC
        /// <summary>"Height"</summary>
        FURNITURE_HEIGHT = -1001300, // 0xFFF0B8AC
        /// <summary>"Height"</summary>
        GENERIC_HEIGHT = -1001300, // 0xFFF0B8AC
        /// <summary>"Height"</summary>
        WINDOW_HEIGHT = -1001300, // 0xFFF0B8AC
        /// <summary>"Exit Access"</summary>
        DOOR_EVACUATION_EXIT_TYPE = -1001212, // 0xFFF0B904
        /// <summary>"Operation"</summary>
        DOOR_OPERATION_TYPE = -1001211, // 0xFFF0B905
        /// <summary>"Operation"</summary>
        WINDOW_OPERATION_TYPE = -1001211, // 0xFFF0B905
        /// <summary>"Frame Material"</summary>
        DOOR_FRAME_MATERIAL = -1001210, // 0xFFF0B906
        /// <summary>"Frame Type"</summary>
        DOOR_FRAME_TYPE = -1001209, // 0xFFF0B907
        /// <summary>"Finish"</summary>
        CASEWORK_FINISH = -1001208, // 0xFFF0B908
        /// <summary>"Finish"</summary>
        CURTAIN_WALL_PANELS_FINISH = -1001208, // 0xFFF0B908
        /// <summary>"Finish"</summary>
        DOOR_FINISH = -1001208, // 0xFFF0B908
        /// <summary>"Finish"</summary>
        GENERIC_FINISH = -1001208, // 0xFFF0B908
        /// <summary>"Construction Type"</summary>
        CASEWORK_CONSTRUCTION_TYPE = -1001207, // 0xFFF0B909
        /// <summary>"Construction Type"</summary>
        CURTAIN_WALL_PANELS_CONSTRUCTION_TYPE = -1001207, // 0xFFF0B909
        /// <summary>"Construction Type"</summary>
        DOOR_CONSTRUCTION_TYPE = -1001207, // 0xFFF0B909
        /// <summary>"Construction Type"</summary>
        GENERIC_CONSTRUCTION_TYPE = -1001207, // 0xFFF0B909
        /// <summary>"Construction Type"</summary>
        WINDOW_CONSTRUCTION_TYPE = -1001207, // 0xFFF0B909
        /// <summary>"Fire Rating"</summary>
        DOOR_FIRE_RATING = -1001206, // 0xFFF0B90A
        /// <summary>"Fire Rating"</summary>
        FIRE_RATING = -1001206, // 0xFFF0B90A
        /// <summary>"Cost"</summary>
        ALL_MODEL_COST = -1001205, // 0xFFF0B90B
        /// <summary>"Cost"</summary>
        DOOR_COST = -1001205, // 0xFFF0B90B
        /// <summary>"Mark"</summary>
        ALL_MODEL_MARK = -1001203, // 0xFFF0B90D
        /// <summary>"Mark"</summary>
        DOOR_NUMBER = -1001203, // 0xFFF0B90D
        /// <summary>"Original Category"</summary>
        DPART_ORIGINAL_CATEGORY_ID = -1001140, // 0xFFF0B94C
        /// <summary>"Construction"</summary>
        DPART_LAYER_CONSTRUCTION = -1001139, // 0xFFF0B94D
        /// <summary>"Phase Demolished By Original"</summary>
        DPART_PHASE_DEMOLISHED_BY_ORIGINAL = -1001138, // 0xFFF0B94E
        /// <summary>"Phase Created By Original"</summary>
        DPART_PHASE_CREATED_BY_ORIGINAL = -1001137, // 0xFFF0B94F
        /// <summary>"Length"</summary>
        DPART_LENGTH_COMPUTED = -1001136, // 0xFFF0B950
        /// <summary>"Height"</summary>
        DPART_HEIGHT_COMPUTED = -1001135, // 0xFFF0B951
        /// <summary>"Thickness"</summary>
        DPART_LAYER_WIDTH = -1001134, // 0xFFF0B952
        /// <summary>"Area"</summary>
        DPART_AREA_COMPUTED = -1001133, // 0xFFF0B953
        /// <summary>"Original Type"</summary>
        DPART_ORIGINAL_TYPE = -1001132, // 0xFFF0B954
        /// <summary>"Show Shape Handles"</summary>
        OFFSETFACES_SHOW_SHAPE_HANDLES = -1001131, // 0xFFF0B955
        /// <summary>"Layer Function"</summary>
        DPART_LAYER_FUNCTION = -1001130, // 0xFFF0B956
        /// <summary>"Volume"</summary>
        DPART_VOLUME_COMPUTED = -1001129, // 0xFFF0B957
        /// <summary>"Material By Original"</summary>
        DPART_MATERIAL_BY_ORIGINAL = -1001128, // 0xFFF0B958
        /// <summary>"Material"</summary>
        DPART_MATERIAL_ID_PARAM = -1001127, // 0xFFF0B959
        /// <summary>"Original Family"</summary>
        DPART_ORIGINAL_FAMILY = -1001126, // 0xFFF0B95A
        /// <summary>"Original Category"</summary>
        DPART_ORIGINAL_CATEGORY = -1001125, // 0xFFF0B95B
        /// <summary>"Categorize as"</summary>
        HOST_PANEL_SCHEDULE_AS_PANEL_PARAM = -1001124, // 0xFFF0B95C
        /// <summary>"Location Line Offset"</summary>
        WALL_LOCATION_LINE_OFFSET_PARAM = -1001123, // 0xFFF0B95D
        /// <summary>"Location Line"</summary>
        WALL_KEY_REF_PARAM = -1001122, // 0xFFF0B95E
        /// <summary>"Extend into wall (to core)"</summary>
        MEASURE_FROM_STRUCTURE = -1001120, // 0xFFF0B960
        /// <summary>"Structural Usage"</summary>
        WALL_STRUCTURAL_USAGE_PARAM = -1001119, // 0xFFF0B961
        /// <summary>"Base is Attached"</summary>
        WALL_BOTTOM_IS_ATTACHED = -1001118, // 0xFFF0B962
        /// <summary>"Top is Attached"</summary>
        WALL_TOP_IS_ATTACHED = -1001117, // 0xFFF0B963
        /// <summary>"Top Offset"</summary>
        WALL_TOP_OFFSET = -1001109, // 0xFFF0B96B
        /// <summary>"Base Offset"</summary>
        WALL_BASE_OFFSET = -1001108, // 0xFFF0B96C
        /// <summary>"Base Constraint"</summary>
        WALL_BASE_CONSTRAINT = -1001107, // 0xFFF0B96D
        /// <summary>"Unconnected Height"</summary>
        WALL_USER_HEIGHT_PARAM = -1001105, // 0xFFF0B96F
        /// <summary>"Top Constraint"</summary>
        WALL_HEIGHT_TYPE = -1001103, // 0xFFF0B971
        /// <summary>"Base height"</summary>
        WALL_BASE_HEIGHT_PARAM = -1001102, // 0xFFF0B972
        /// <summary>"Automatically Embed"</summary>
        ALLOW_AUTO_EMBED = -1001009, // 0xFFF0B9CF
        /// <summary>"Room Bounding"</summary>
        WALL_ATTR_ROOM_BOUNDING = -1001007, // 0xFFF0B9D1
        /// <summary>"Function"</summary>
        FUNCTION_PARAM = -1001006, // 0xFFF0B9D2
        /// <summary>"Default height"</summary>
        WALL_ATTR_DEFHEIGHT_PARAM = -1001002, // 0xFFF0B9D6
        /// <summary>"Height"</summary>
        WALL_ATTR_HEIGHT_PARAM = -1001001, // 0xFFF0B9D7
        /// <summary>"Width"</summary>
        WALL_ATTR_WIDTH_PARAM = -1001000, // 0xFFF0B9D8
        INVALID = -1, // 0xFFFFFFFF
    }
}
