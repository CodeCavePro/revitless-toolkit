using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeCave.Revit.Toolkit
{
    public class EmbeddedResources
    {
        private Assembly assembly;

        private string[] resources;

        public EmbeddedResources(Assembly assembly)
        {
            this.assembly = assembly;
            resources = assembly.GetManifestResourceNames();
        }

        public static EmbeddedResources callingResources;

        public static EmbeddedResources entryResources;

        public static EmbeddedResources executingResources;

        public static EmbeddedResources CallingResources
        {
            get
            {
                if (callingResources == null)
                {
                    callingResources = new EmbeddedResources(Assembly.GetCallingAssembly());
                }

                return callingResources;
            }
        }

        public static EmbeddedResources EntryResources
        {
            get
            {
                if (entryResources == null)
                {
                    entryResources = new EmbeddedResources(Assembly.GetEntryAssembly());
                }

                return entryResources;
            }
        }

        public static EmbeddedResources ExecutingResources
        {
            get
            {
                if (executingResources == null)
                {
                    executingResources = new EmbeddedResources(Assembly.GetExecutingAssembly());
                }

                return executingResources;
            }
        }

        public Stream GetStream(string resName)
        {
            string[] possibleCandidates = resources.Where(s => s.Contains(resName)).ToArray();
            if (possibleCandidates.Length == 0)
            {
                return null;
            }
            else if (possibleCandidates.Length == 1)
            {
                return assembly.GetManifestResourceStream(possibleCandidates[0]);
            }
            else
            {
                throw new ArgumentException("Ambiguous name, cannot identify resource", "resName");
            }
        }
    }
}
