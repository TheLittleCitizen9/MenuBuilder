using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder_Example.StringMenu
{
    public class ReverseAction : IActions<string>
    {
        public void Action(params string[] parameters)
        {
            Console.WriteLine(ReverseString(parameters));
        }

        public string ReverseString(params string[] parameters)
        {
            string result = string.Empty;
            if (parameters.Length == 0)
            {
                return "Invalid Input";
            }
            for(int i=parameters.Length-1; i>=0; i--)
            {
                string tempReversed = new string(parameters[i].ToCharArray().Reverse().ToArray());
                result += $"{tempReversed} ";
            }
            return result;
        }
    }
}
