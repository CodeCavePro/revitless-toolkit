using System.Collections.Generic;
using System.Linq;

namespace CodeCave.Revit.Toolkit
{
    public class OmniClassTaxonomy
    {
        /// <summary>
        /// OmniClass taxonomies from the latest vanilla OmniClassTaxonomy.txt
        /// http://download.autodesk.com/us/revit/OmniClassTaxonomy.txt
        /// Read more here:
        /// https://knowledge.autodesk.com/support/revit-products/learn-explore/caas/CloudHelp/cloudhelp/2015/ENU/Revit-Troubleshooting/files/GUID-BA0B2713-ADA0-4E51-A7CD-85D85511F3ED-htm.html
        /// </summary>
        public static readonly List<OmniClassTaxonomyItem> Vanilla;

        /// <summary>
        /// OmniClass taxonomies containing Food Service types
        /// https://forums.autodesk.com/autodesk/attachments/autodesk/133/88630/1/OmniClassTaxonomy.txt
        /// </summary>
        public static readonly List<OmniClassTaxonomyItem> FoodService;

        /// <summary>
        /// Contains the superset of all the OmniClass taxonomy definitions from all the files
        /// </summary>
        public static readonly List<OmniClassTaxonomyItem> Merged;

        /// <summary>
        /// Static constructor, initializes static read-only fields of OmniClassTaxonomy class
        /// </summary>
        static OmniClassTaxonomy()
        {
            Vanilla = OmniClassTaxonomyItem.ReadFromResource("OmniClassTaxonomy_Vanilla.txt");
            FoodService = OmniClassTaxonomyItem.ReadFromResource("OmniClassTaxonomy_FoodService.txt");
            Merged = Vanilla.Union(FoodService).Distinct().OrderBy(i => i.ID).ToList();
        }
    }
}
