using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_VersionAttributes
{
    [AttributeUsage(AttributeTargets.Struct |
 AttributeTargets.Class | AttributeTargets.Interface
| AttributeTargets.Enum | AttributeTargets.Method,
 AllowMultiple = true)]

    class Version_Attributes : System.Attribute
    {

        public string Version { get; private set; }

        public Version_Attributes(string version)
        {
            this.Version = version;
        }
    }
}
