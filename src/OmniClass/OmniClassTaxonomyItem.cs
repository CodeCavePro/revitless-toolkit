using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeCave.Revit.Toolkit
{
    public class OmniClassTaxonomyItem
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public int Category { get; set; }

        public override string ToString()
        {
            return $"{ID}\t{Name}\t{Category}\t";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ ID.GetHashCode();
                result = (result * 397) ^ Name.GetHashCode();
                result = (result * 397) ^ Category;
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var item = obj as OmniClassTaxonomyItem;
            return ID.Equals(item.ID) &&
                Name.Equals(item.Name) &&
                Category.Equals(item.Category);
        }

        public static List<OmniClassTaxonomyItem> ReadFromResource(string omniclassFile)
        {
            if (string.IsNullOrWhiteSpace(omniclassFile))
            {
                throw new ArgumentException($"{nameof(omniclassFile)} must be a non empty string");
            }

            using (Stream stream = EmbeddedResources.ExecutingResources.GetStream(omniclassFile))
            {
                using (var reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    return ReadFromText(result);
                }
            }
        }

        public static List<OmniClassTaxonomyItem> ReadFromText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{nameof(text)} must be a non empty string");
            }

            var omniClassItems = new List<OmniClassTaxonomyItem>();
            using (var csvReader = new StringReader(text))
            {
                var csvCofig = new CsvConfiguration
                {
                    HasHeaderRecord = false,
                    Delimiter = "\t",
                };

                using (var csv = new CsvReader(csvReader, csvCofig))
                {
                    while (csv.Read())
                    {
                        var omniItem = csv.GetRecord<OmniClassTaxonomyItem>();
                        if (omniItem == null)
                        {
                            throw new InvalidDataException($"Failed to parse the following row of OmniClassTaxonomy file: {csv.Row}");
                        }
                        omniClassItems.Add(omniItem);
                    }
                }
            }
                
            return omniClassItems;
        }
    }

    public static class OmniClassTaxonomyItemExtensions
    {
        public static string ToText(this List<OmniClassTaxonomyItem> items)
        {
            return string.Join(Environment.NewLine, items.Select(i => i.ToString()));
        }
    }
}
