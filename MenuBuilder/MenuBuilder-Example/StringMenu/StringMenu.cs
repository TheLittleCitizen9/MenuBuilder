using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MenuBuilder_Example.StringMenu
{
    public class StringMenu : BasicMenu<string>
    {
        private const string ENTER_VARIABLES = "Enter variables - format X Y";
        private const string ERROR_MSG = "Invalid input";
        private readonly List<string> _requaiersInput = new List<string>();

        private Dictionary<string, IActions<string>> _options;

        private Dictionary<string, string> _displayOptions;

        public StringMenu()
        {
            _displayOptions = new Dictionary<string, string>();
            _options = new Dictionary<string, IActions<string>>();
        }

        public override void AddAction(string option, string description, IActions<string> action, bool requiersInput=false)
        {
            _options.Add(option, action);
            _displayOptions.Add(option, description);
            if(requiersInput)
            {
                _requaiersInput.Add(option);
            }
        }

        public override void Main()
        {
            BasicValidator validator = new BasicValidator(_options.Keys.ToList());
            ConsoleDisplayer consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            string input;
            while (true)
            {
                consoleDisplayer.ShowOptions();
                input = Console.ReadLine();
                bool isInputValid = validator.Validate(input);
                if (isInputValid)
                {
                    if (_requaiersInput.Contains(input))
                    {
                        consoleDisplayer.PrintValueToConsole(ENTER_VARIABLES);
                        string userInput = Console.ReadLine();
                        string[] variables = userInput.Split(' ');
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
