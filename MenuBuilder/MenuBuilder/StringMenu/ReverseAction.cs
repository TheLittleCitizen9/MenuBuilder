using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class ReverseAction : IActions<string>
    {
        public string Action(params string[] parameters)
        {
            if(parameters.Length > 1 || parameters.Length == 0)
            {
                return "Invalid Input";
            }
            return new string(parameters[0].ToCharArray().Reverse().ToArray());
        }
    }
}
