using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    /// Represents a row of an OmniClass file
    /// </summary>
    public class OmniClassTaxonomyItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmniClassTaxonomyItem"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="category">The category.</param>
        internal OmniClassTaxonomyItem(string id, string name, int category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; }

        /// <summary>
        /// Gets or sets taxonomy's name.
        /// </summary>
        /// <value>
        /// Taxonomy's name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Gets or sets taxonomy's category.
        /// </summary>
        /// <value>
        /// Taxonomy's category.
        /// </value>
        public int Category { get; }

        /// <summary>
        /// Returns a <see cref="String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Category}\t";
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ Id.GetHashCode();
                result = (result * 397) ^ Name.GetHashCode();
                result = (result * 397) ^ Category;
                return result;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is OmniClassTaxonomyItem))
                return false;

            var item = (OmniClassTaxonomyItem) obj;
            return Id.Equals(item.Id) &&
                Name.Equals(item.Name) &&
                Category.Equals(item.Category);
        }

        /// <summary>
        /// Reads a list of <see cref="OmniClassTaxonomyItem"/> items from the embedded resources.
        /// </summary>
        /// <param name="omniclassResName">Name of the embedded resource representing OmniClass text file.</param>
        /// <returns>The list of <see cref="OmniClassTaxonomyItem"/></returns>
        /// <exception cref="System.ArgumentException">omniclassResName</exception>
        public static List<OmniClassTaxonomyItem> ReadFromResource(string omniclassResName)
        {
            if (string.IsNullOrWhiteSpace(omniclassResName))
            {
                throw new ArgumentException($"{nameof(omniclassResName)} must be a non empty string");
            }

            using (var stream = typeof(OmniClassTaxonomyItem).GetTypeInfo().GetTypesAssemblyResource(omniclassResName))
            {
                using (var reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    return ReadFromText(result);
                }
            }
        }

        /// <summary>
        /// Reads a list of <see cref="OmniClassTaxonomyItem"/> items from string.
        /// </summary>
        /// <param name="text">String containing <see cref="OmniClassTaxonomyItem"/> items.</param>
        /// <returns>The list of <see cref="OmniClassTaxonomyItem"/></returns>
        /// <exception cref="ArgumentException">text is an empty string</exception>
        /// <exception cref="InvalidDataException"></exception>
        public static List<OmniClassTaxonomyItem> ReadFromText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException($"{nameof(text)} must be a non empty string");
            }

            var omniClassItems = new List<OmniClassTaxonomyItem>();
            using (var csvReader = new StringReader(text))
            {
                var csvCofig = new Configuration
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
                            throw new InvalidDataException($"Failed to parse the following row of OmniClassTaxonomy file: {csv.Context.Row}");
                        }
                        omniClassItems.Add(omniItem);
                    }
                }
            }

            return omniClassItems;
        }
    }

    /// <summary>
    /// Contains <see cref="OmniClassTaxonomyItem"/> extension methods
    /// </summary>
    public static class OmniClassTaxonomyItemExtensions
    {
        /// <summary>
        /// Converts a list of <see cref="OmniClassTaxonomyItem"/> items to string (OmniClass text file)
        /// </summary>
        /// <param name="items">The list of <see cref="OmniClassTaxonomyItem"/></param>
        /// <returns></returns>
        public static string ToText(this List<OmniClassTaxonomyItem> items)
        {
            return string.Join(Environment.NewLine, items.Select(i => i.ToString()));
        }
    }
}
