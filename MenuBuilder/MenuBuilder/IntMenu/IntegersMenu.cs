using MenuBuilder.IntMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class IntegersMenu : BasicMenu<int>
    {
        private const string ERROR_MSG = "Invalid input";
        private readonly List<string> _inputOptions = new List<string> { "1", "2", "3", "4" };
        private readonly List<string> _requaiersInput = new List<string> { "1", "2" };
        private BasicValidator _validator;
        private ConsoleDisplayer _consoleDisplayer;

        private Dictionary<string, IActions<int>> _options;

        private Dictionary<string, string> _displayOptions;

        public IntegersMenu()
        {
            _displayOptions = new Dictionary<string, string>
            {
                {"1", "Add Numbers" },
                {"2", "Reduce Numbers" },
                {"3", "Go To String Menu" },
                {"4", "Exit" }
            };
            _consoleDisplayer = new ConsoleDisplayer(_displayOptions);
            _options = new Dictionary<string, IActions<int>>
            {
                {"1", new AddAction() },
                {"2", new ReduceAction() },
                {"3", new GoToMenuAction(new StringMenu.StringMenu())},
                {"4", new IntExitAction(null) }
            };

            _validator = new IntValidator(_inputOptions);
        }

        public override void Main()
        {
            string input = string.Empty;
            while (input != "4")
            {
                _consoleDisplayer.ShowOptions();
                input = Console.ReadLine();
                bool isInputValid = _validator.Validate(input);
                if(isInputValid)
                {
                    if(_requaiersInput.Contains(input))
                    {
                        int[] variables = Console.ReadLine().Split(',').Select(v => Int32.Parse(v)).ToArray();
                        RunOption(input, variables);
                    }
                    else
                    {
                        RunOption(input);
                    }
                }
                else
                {
                    _consoleDisplayer.PrintValueToConsole(ERROR_MSG);
                }
            }
        }

        public override void RunOption(string option, params int[] variables)
        {
            _options[option].Action(variables);
        }
    }
}
