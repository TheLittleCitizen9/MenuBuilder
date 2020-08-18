using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.IntMenu
{
    public class AddAction : IActions<int>
    {
        public void Action(params int[] parameters)
        {
            Console.WriteLine(AddNumbers(parameters));
        }

        private int AddNumbers(params int[] parameters)
        {
            if (parameters.Length > 0)
            {
                return parameters.Sum();
            }
            return -1;
        }
    }
}
