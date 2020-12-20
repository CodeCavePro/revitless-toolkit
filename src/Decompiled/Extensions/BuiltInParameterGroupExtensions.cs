using System.Collections.Generic;
using System.Linq;

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    /// Contains extension methods for <see cref="BuiltInParameterGroup"/>.
    /// </summary>
    public static class BuiltInParameterGroupExtensions
    {
        private static readonly Dictionary<BuiltInParameterGroup, string> builtInParameterGroup;

        /// <summary>
        /// Initializes static members of the <see cref="BuiltInParameterGroupExtensions"/> class.
        /// Initializes the <see cref="BuiltInParameterGroupExtensions"/> class.
        /// </summary>
        static BuiltInParameterGroupExtensions()
        {
            builtInParameterGroup = new Dictionary<BuiltInParameterGroup, string>
            {
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BLDG_CONS_MTL_THERMAL_PROPS, "Material Thermal Properties"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ROOM_SPACE_DATA, "Room/Space Data"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BUILDING_DATA, "Building Data"},
                {BuiltInParameterGroup.PG_COUPLER_ARRAY, "Set"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ADVANCED, "Advanced"},
                {BuiltInParameterGroup.PG_RELEASES_MEMBER_FORCES, "Releases / Member Forces"},
                {BuiltInParameterGroup.PG_SECONDARY_END, "Secondary End"},
                {BuiltInParameterGroup.PG_PRIMARY_END, "Primary End"},
                {BuiltInParameterGroup.PG_MOMENTS, "Moments"},
                {BuiltInParameterGroup.PG_FORCES, "Forces"},
                {BuiltInParameterGroup.PG_FABRICATION_PRODUCT_DATA, "Fabrication Product Data"},
                {BuiltInParameterGroup.PG_REFERENCE, "Reference"},
                {BuiltInParameterGroup.PG_GEOMETRY_POSITIONING, "Geometric Position"},
                {BuiltInParameterGroup.PG_DIVISION_GEOMETRY, "Division Geometry"},
                {BuiltInParameterGroup.PG_SEGMENTS_FITTINGS, "Segments and Fittings"},
                {BuiltInParameterGroup.PG_CONTINUOUSRAIL_END_TOP_EXTENSION, "Extension (End/Top)"},
                {BuiltInParameterGroup.PG_CONTINUOUSRAIL_BEGIN_BOTTOM_EXTENSION, "Extension (Beginning/Bottom)"},
                {BuiltInParameterGroup.PG_STAIRS_WINDERS, "Winders"},
                {BuiltInParameterGroup.PG_STAIRS_SUPPORTS, "Supports"},
                {BuiltInParameterGroup.PG_STAIRS_OPEN_END_CONNECTION, "End Connection"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SECONDARY_FAMILY_HANDRAILS, "Handrail 2"},
                {BuiltInParameterGroup.PG_TERMINTATION, "Terminations"},
                {BuiltInParameterGroup.PG_STAIRS_TREADS_RISERS, "Threads/Risers"},
                {BuiltInParameterGroup.PG_STAIRS_CALCULATOR_RULES, "Calculation Rules"},
                {BuiltInParameterGroup.PG_SPLIT_PROFILE_DIMENSIONS, "Dimensions     (linear units or % of thickness)"},
                {BuiltInParameterGroup.PG_LENGTH, "Length"},
                {BuiltInParameterGroup.PG_NODES, "Nodes"},
                {BuiltInParameterGroup.PG_ANALYTICAL_PROPERTIES, "Analytical Properties"},
                {BuiltInParameterGroup.PG_ANALYTICAL_ALIGNMENT, "Analytical Alignment"},
                {BuiltInParameterGroup.PG_SYSTEMTYPE_RISEDROP, "Rise / Drop"},
                {BuiltInParameterGroup.PG_LINING, "Lining"},
                {BuiltInParameterGroup.PG_INSULATION, "Insulation"},
                {BuiltInParameterGroup.PG_OVERALL_LEGEND, "Overall Legend"},
                {BuiltInParameterGroup.PG_VISIBILITY, "Visibility"},
                {BuiltInParameterGroup.PG_SUPPORT, "Supports"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_V_GRID, "V Grid"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_U_GRID, "U Grid"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_POSTS, "Posts"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REMAINDER, "Pattern Remainder"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REPEAT, "Pattern Repeat"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_SEGMENT_PATTERN, "Segment Pattern (default)"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_HANDRAILS, "Handrail 1"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_TOP_RAIL, "Top Rail"},
                {BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA_BUILDING_SERVICES, "Energy Model - Building Services"},
                {BuiltInParameterGroup.PG_DATA, "Data"},
                {BuiltInParameterGroup.PG_ELECTRICAL_CIRCUITING, "Electrical - Circuiting"},
                {BuiltInParameterGroup.PG_GENERAL, "General"},
                {BuiltInParameterGroup.PG_FLEXIBLE, "Adaptive Component"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_CONCEPTUAL_MODEL, "Energy Analytical Model"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_MODEL, "Detailed Model"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_AND_CONCEPTUAL_MODELS, "Essential"},
                {BuiltInParameterGroup.PG_FITTING, "Fittings"},
                {BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA, "Conceptual Energy Data"},
                {BuiltInParameterGroup.PG_AREA, "Area"},
                {BuiltInParameterGroup.PG_ADSK_MODEL_PROPERTIES, "Model Properties"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_V, "V Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_U, "U Grid"},
                {BuiltInParameterGroup.PG_DISPLAY, "Display"},
                {BuiltInParameterGroup.PG_ANALYSIS_RESULTS, "Analysis Results"},
                {BuiltInParameterGroup.PG_SLAB_SHAPE_EDIT, "Slab Shape Edit"},
                {BuiltInParameterGroup.PG_LIGHT_PHOTOMETRICS, "Photometrics"},
                {BuiltInParameterGroup.PG_PATTERN_APPLICATION, "Pattern Application"},
                {BuiltInParameterGroup.PG_GREEN_BUILDING, "Green Building Properties"},
                {BuiltInParameterGroup.PG_PROFILE_2, "Profile 2"},
                {BuiltInParameterGroup.PG_PROFILE_1, "Profile 1"},
                {BuiltInParameterGroup.PG_PROFILE, "Profile"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_BOTTOM_CHORD, "Bottom Chords"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_TOP_CHORD, "Top Chords"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_DIAG_WEB, "Diagonal Webs"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_VERT_WEB, "Vertical Webs"},
                {BuiltInParameterGroup.PG_TITLE, "Title Text"},
                {BuiltInParameterGroup.PG_FIRE_PROTECTION, "Fire Protection"},
                {BuiltInParameterGroup.PG_ROTATION_ABOUT, "Rotation about"},
                {BuiltInParameterGroup.PG_TRANSLATION_IN, "Translation in"},
                {BuiltInParameterGroup.PG_ANALYTICAL_MODEL, "Analytical Model"},
                {BuiltInParameterGroup.PG_REBAR_ARRAY, "Rebar Set"},
                {BuiltInParameterGroup.PG_REBAR_SYSTEM_LAYERS, "Layers"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID, "Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_2, "Grid 2 Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_HORIZ, "Horizontal Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_1, "Grid 1 Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_VERT, "Vertical Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_2, "Grid 2"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_HORIZ, "Horizontal Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_1, "Grid 1"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_VERT, "Vertical Grid"},
                {BuiltInParameterGroup.PG_IFC, "IFC Parameters"},
                {BuiltInParameterGroup.PG_AELECTRICAL, "Electrical"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS, "Energy Analysis"},
                {BuiltInParameterGroup.PG_STRUCTURAL_ANALYSIS, "Structural Analysis"},
                {BuiltInParameterGroup.PG_MECHANICAL_AIRFLOW, "Mechanical - Flow"},
                {BuiltInParameterGroup.PG_MECHANICAL_LOADS, "Mechanical - Loads"},
                {BuiltInParameterGroup.PG_ELECTRICAL_LOADS, "Electrical - Loads"},
                {BuiltInParameterGroup.PG_ELECTRICAL_LIGHTING, "Electrical - Lighting"},
                {BuiltInParameterGroup.PG_TEXT, "Text"},
                {BuiltInParameterGroup.PG_VIEW_CAMERA, "Camera"},
                {BuiltInParameterGroup.PG_VIEW_EXTENTS, "Extents"},
                {BuiltInParameterGroup.PG_PATTERN, "Pattern"},
                {BuiltInParameterGroup.PG_CONSTRAINTS, "Constraints"},
                {BuiltInParameterGroup.PG_PHASING, "Phasing"},
                {BuiltInParameterGroup.PG_MECHANICAL, "Mechanical"},
                {BuiltInParameterGroup.PG_STRUCTURAL, "Structural"},
                {BuiltInParameterGroup.PG_PLUMBING, "Plumbing"},
                {BuiltInParameterGroup.PG_ELECTRICAL, "Electrical Engineering"},
                {BuiltInParameterGroup.PG_STAIR_STRINGERS, "Stringers"},
                {BuiltInParameterGroup.PG_STAIR_RISERS, "Risers"},
                {BuiltInParameterGroup.PG_STAIR_TREADS, "Treads"},
                {BuiltInParameterGroup.PG_UNDERLAY, "Underlay"},
                {BuiltInParameterGroup.PG_MATERIALS, "Materials and Finishes"},
                {BuiltInParameterGroup.PG_GRAPHICS, "Graphics"},
                {BuiltInParameterGroup.PG_CONSTRUCTION, "Construction"},
                {BuiltInParameterGroup.PG_GEOMETRY, "Dimensions"},
                {BuiltInParameterGroup.PG_IDENTITY_DATA, "Identity Data"},
                {BuiltInParameterGroup.INVALID, "Other"},
            };
        }

        /// <summary>
        /// Tries to convert <see cref="BuiltInParameterGroup"/> value to a human-readable English label.
        /// </summary>
        /// <param name="builtInParameterGroup">Built in parameter group value.</param>
        /// <param name="builtInParameterGroupString">Human-readable English label for the given <see cref="BuiltInParameterGroup"/> value.</param>
        /// <returns></returns>
        public static bool ToEnglishLabel(
            this BuiltInParameterGroup builtInParameterGroup,
            out string builtInParameterGroupString)
        {
            return BuiltInParameterGroupExtensions.builtInParameterGroup.TryGetValue(builtInParameterGroup, out builtInParameterGroupString);
        }

        /// <summary>
        /// Tries to convert <see cref="string"/> label to <see cref="BuiltInParameterGroup"/> enum value.
        /// </summary>
        /// <param name="builtInParameterGroupString">The built in parameter group string.</param>
        /// <param name="builtInParameterGroup">The built in parameter group.</param>
        /// <returns></returns>
        public static bool FromEnglishLabel(
            this string builtInParameterGroupString,
            out BuiltInParameterGroup builtInParameterGroup)
        {
            builtInParameterGroup = BuiltInParameterGroup.INVALID;
            if (!BuiltInParameterGroupExtensions.builtInParameterGroup.ContainsValue(builtInParameterGroupString))
                return false;

            builtInParameterGroup = BuiltInParameterGroupExtensions.builtInParameterGroup.FirstOrDefault(kp => Equals(kp.Value, builtInParameterGroupString)).Key;
            return true;
        }
    }
}
