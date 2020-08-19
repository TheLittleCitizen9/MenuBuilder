using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder_Example.IntMenu
{
    public class AddAction : IActions<int>
    {
        public void Action(params int[] parameters)
        {
            Console.WriteLine(AddNumbers(parameters));
        }

        private int AddNumbers(params int[] parameters)
        {
            int sum = 0;
            if (parameters.Length > 0)
            {
                sum += parameters.Sum();
            }
            return sum;
        }
    }
}
