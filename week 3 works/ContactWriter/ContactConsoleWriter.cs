﻿
using static System.Console;

namespace ContactWriter
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }
        public void Write()
        {
            WriteFirstName();
            WriteAge();

        }
        private void WriteFirstName()
        {
            WriteLine(_contact.FirstName);
        }

        private void WriteAge()
        {
            WriteLine();
        }

    }
}
