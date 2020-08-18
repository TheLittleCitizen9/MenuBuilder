using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringMenu : BasicMenu<string>
    {
        private const string ENTER_VARIABLES = "Enter variables, if you don't need - press enter";
        private const string ERROR_MSG = "Invalid input";
        private readonly List<string> _requaiersInput = new List<string> { "Reverse"};

        private Dictionary<string, IActions<string>> _options;

        private Dictionary<string, string> _displayOptions;

        public StringMenu()
        {
            _displayOptions = new Dictionary<string, string>();
            _options = new Dictionary<string, IActions<string>>();
        }

        public override void AddAction(string option, string description, IActions<string> action)
        {
            _options.Add(option, action);
            _displayOptions.Add(option, description);
        }

        public override void Main()
        {
            StringValidator validator = new StringValidator(_options.Keys.ToList());
            ConsoleDisplayer consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            string input = string.Empty;
            while (true)
            {
                consoleDisplayer.ShowOptions();
                input = Console.ReadLine();
                bool isInputValid = validator.Validate(input);
                if (isInputValid)
                {
                    consoleDisplayer.PrintValueToConsole(ENTER_VARIABLES);
                    string userInput = Console.ReadLine();
                    if (userInput != string.Empty)
                    {
                        string[] variables = userInput.Split(',');
                        RunOption(input, variables);
                    }
                    else
                    {
                        RunOption(input);
                    }
                }
                else
                {
                    consoleDisplayer.PrintValueToConsole(ERROR_MSG);
                }
            }
        }

        public override void RunOption(string option, params string[] variables)
        {
            _options[option].Action(variables);
        }
    }
}
