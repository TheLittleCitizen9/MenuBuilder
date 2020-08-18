using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringMenu : BasicMenu<string>
    {
        private const string ERROR_MSG = "Invalid input";
        private readonly List<string> _inputOptions = new List<string> { "Reverse"};
        private readonly List<string> _requaiersInput = new List<string> { "Reverse"};
        private BasicValidator _validator;
        private ConsoleDisplayer _consoleDisplayer;

        private Dictionary<string, IActions<string>> _options;

        private Dictionary<string, string> _displayOptions;

        public StringMenu()
        {
            _displayOptions = new Dictionary<string, string>
            {
                {"Reverse", "Reverse a word" },
                {"Exit", "Exit from String Menu" }
            };
            _consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            _options = new Dictionary<string, IActions<string>>
            {
                {"Reverse", new ReverseAction() }
                //{"Exit", new StringExitAction(new IntegersMenu()) }
            };

            _validator = new StringValidator(_inputOptions);
        }
        public override void Main()
        {
            string input = string.Empty;
            while (input != "Exit")
            {
                _consoleDisplayer.ShowOptions();
                input = Console.ReadLine();
                bool isInputValid = _validator.Validate(input);
                if (isInputValid)
                {
                    if (_requaiersInput.Contains(input))
                    {
                        string[] variables = Console.ReadLine().Split(',');
                        RunOption(input, variables);
                    }
                    else
                    {
                        RunOption(input);
                    }
                }
                else if(input != "Exit")
                {
                    _consoleDisplayer.PrintValueToConsole(ERROR_MSG);
                }
            }
        }

        public override void RunOption(string option, params string[] variables)
        {
            string result = _options[option].Action(variables);
            _consoleDisplayer.PrintValueToConsole(result);
        }
    }
}
