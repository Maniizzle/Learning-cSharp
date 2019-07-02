
using static System.Console;
using System;
using System.Diagnostics;

namespace ContactWriters
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

        [Obsolete("This will become obsolete in the latest release") ]
        public void Write()
        {
            WriteFirstName();
            WriteAge();

        }
        //this attributes makes the method Wrong() give a Compile error
        //[Obsolete("This method is obsolete",true)]
        public void Wrong() { }
        private void WriteFirstName()
        {
            WriteLine(_contact.FirstName);
        }

        
        private void WriteAge()
        {
            OutputDebugInfo();
            WriteLine(_contact.AgeInYears);
        }
        [Conditional("CONSOLE")]
        private void OutputDebugInfo()
        {
            Console.WriteLine("*** MODE*****"); ;
        }
    }
}
