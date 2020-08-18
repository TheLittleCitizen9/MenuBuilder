using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public abstract class BasicMenu : IMenu
    {
        public abstract BasicValidator Validator { get; set; }

        public abstract ConsoleDisplayer ConsoleDisplayer { get; set; }

        public abstract Dictionary<string, Func<string>> Options { get; set; }

        public abstract Dictionary<string, string> displayOptions { get; set; }

        public abstract void Main();

        public abstract void RunOption(string option, string input = null);
    }
}
