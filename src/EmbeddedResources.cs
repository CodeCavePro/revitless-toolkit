using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeCave.Revit.Toolkit
{
    /// <summary>
    /// Embedded resource manager helper class, used in order to access resources embedded into this and other assemblies
    /// </summary>
    public class EmbeddedResourceManager
    {
        /// <summary>
        /// The assembly
        /// </summary>
        private readonly Assembly _assembly;

        /// <summary>
        /// The resources object
        /// </summary>
        private readonly string[] _resources;

        /// <summary>
        /// The calling, entry and executing resources
        /// </summary>
        private static EmbeddedResourceManager _callingResources, _entryResources, _executingResources;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedResourceManager"/> class.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        public EmbeddedResourceManager(Assembly assembly)
        {
            _assembly = assembly;
            _resources = assembly.GetManifestResourceNames();
        }

        /// <summary>
        /// Gets the calling resources.
        /// </summary>
        /// <value>
        /// The calling resources.
        /// </value>
        public static EmbeddedResourceManager CallingResources => _callingResources ?? (_callingResources = new EmbeddedResourceManager(Assembly.GetCallingAssembly()));

        /// <summary>
        /// Gets the entry resources.
        /// </summary>
        /// <value>
        /// The entry resources.
        /// </value>
        public static EmbeddedResourceManager EntryResources => _entryResources ?? (_entryResources = new EmbeddedResourceManager(Assembly.GetEntryAssembly()));

        /// <summary>
        /// Gets the executing resources.
        /// </summary>
        /// <value>
        /// The executing resources.
        /// </value>
        public static EmbeddedResourceManager ExecutingResources => _executingResources ?? (_executingResources = new EmbeddedResourceManager(Assembly.GetExecutingAssembly()));

        /// <summary>
        /// Gets the resource stream.
        /// </summary>
        /// <param name="resourceName">Name of the resource to get stream for.</param>
        /// <returns>Steam representing the given resource</returns>
        /// <exception cref="ArgumentException">Ambiguous name, cannot identify resource - resName</exception>
        public Stream GetStream(string resourceName)
        {
            var possibleCandidates = _resources.Where(s => s.Contains(resourceName)).ToArray();
            switch (possibleCandidates.Length)
            {
                case 0:
                    return null;
                case 1:
                    return _assembly.GetManifestResourceStream(possibleCandidates[0]);
                default:
                    throw new ArgumentException("Ambiguous name, cannot identify resource", "resName");
            }
        }
    }
}
