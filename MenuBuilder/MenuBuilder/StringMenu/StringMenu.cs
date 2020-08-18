using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringMenu : BasicMenu<string>
    {
        private readonly List<string> _inputOptions = new List<string> { "1", "2", "3", "4" };
        private readonly List<string> _requaiersInput = new List<string> { "1", "2" };
        private BasicValidator _validator;
        private ConsoleDisplayer _consoleDisplayer;

        private Dictionary<string, IActions<string>> _options;

        private Dictionary<string, string> _displayOptions;

        public StringMenu()
        {
            _displayOptions = new Dictionary<string, string>
            {
                {"1", "Add Numbers" },
                {"2", "Reduce Numbers" },
                {"3", "Go To String Menu" },
                {"4", "Exit" }
            };
            _consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            _options = new Dictionary<string, IActions<string>>
            {
                {"Reverse", new ReverseAction() },
                {"Combine", new ReduceAction() },
                {"Exit", new ExitAction(null) }
            };

            var options = _options.Keys.ToList();
            _validator = new IntValidator(_inputOptions);
        }
        public override void Main()
        {
            throw new NotImplementedException();
        }

        public override void RunOption(string option, params string[] variables)
        {
            throw new NotImplementedException();
        }
    }
}
