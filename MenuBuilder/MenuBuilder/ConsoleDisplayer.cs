using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class ConsoleDisplayer
    {
        private Dictionary<string, string> _options;

        public ConsoleDisplayer(Dictionary<string, string> options)
        {
            _options = options;
        }

        public void ShowOptions()
        {
            Console.WriteLine("Welcome to Menu");
            foreach (KeyValuePair<string, string> item in _options)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        public void PrintValueToConsole(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
