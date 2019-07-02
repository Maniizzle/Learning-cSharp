using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ContactWriters
{   
    [DebuggerDisplay("FirstName={FirstName}, Age in Years={AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    public class Contact
    {
        public string  FirstName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public int AgeInYears { get; set; }
    }
}
