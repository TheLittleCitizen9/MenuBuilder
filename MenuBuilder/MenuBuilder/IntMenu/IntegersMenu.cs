using MenuBuilder.IntMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class IntegersMenu : BasicMenu<int>
    {
        private const string ERROR_MSG = "Invalid input";
        private const string ENTER_VARIABLES = "Enter variables, if you don't need - press enter";
        private readonly List<string> _inputOptions = new List<string> { "1", "2", "3", "4" };
        private readonly List<string> _requaiersInput = new List<string> { "1", "2" };
        private BasicValidator _validator;
        private ConsoleDisplayer _consoleDisplayer;

        private Dictionary<string, IActions<int>> _options;

        private Dictionary<string, string> _displayOptions;

        public IntegersMenu()
        {
            
            _consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            _options = new Dictionary<string, IActions<int>>();
            _displayOptions = new Dictionary<string, string>();
            
        }

        public override void AddAction(string num, string description, IActions<int> action)
        {
            _options.Add(num, action);
            _displayOptions.Add(num, description);
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
                    if(true)
                    {
                        consoleDisplayer.PrintValueToConsole(ENTER_VARIABLES);
                        string userInput = Console.ReadLine();
                        if (userInput != string.Empty)
                        {
                            int[] variables = userInput.Split(',').Select(v => Int32.Parse(v)).ToArray();
                            RunOption(input, variables);
                        }
                        else
                        {
                            RunOption(input);
                        }
                        
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
