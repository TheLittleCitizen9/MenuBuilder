using MenuBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MenuBuilder_Example.IntMenu
{
    public class IntegersMenu : BasicMenu<int>
    {
        private const string ERROR_MSG = "Invalid input";
        private const string ENTER_VARIABLES = "Enter variables";
        private readonly List<string> _requaiersInput = new List<string> { "1", "2" };

        private Dictionary<string, IActions<int>> _options;

        private Dictionary<string, string> _displayOptions;

        public IntegersMenu()
        {
            _options = new Dictionary<string, IActions<int>>();
            _displayOptions = new Dictionary<string, string>();
            
        }

        public override void AddAction(string option, string description, IActions<int> action, bool requiersInput=false)
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
            ConsoleDisplayer consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            IntValidator validator = new IntValidator(_options.Keys.ToList());
            string input = string.Empty;
            while (true)
            {
                consoleDisplayer.ShowOptions();
                input = Console.ReadLine();
                bool isInputValid = validator.Validate(input);
                if(isInputValid)
                {
                    if (_requaiersInput.Contains(input))
                    {
                        consoleDisplayer.PrintValueToConsole(ENTER_VARIABLES);
                        string userInput = Console.ReadLine();
                        int[] variables = userInput.Split(',').Select(v => Int32.Parse(v)).ToArray();
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

        public override void RunOption(string option, params int[] variables)
        {
            _options[option].Action(variables);
        }
    }
}
