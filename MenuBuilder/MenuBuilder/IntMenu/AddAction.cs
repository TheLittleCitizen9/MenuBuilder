using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.IntMenu
{
    public class AddAction : IActions<int>
    {
        public int Action(params int[] parameters)
        {
            if(parameters.Length > 0)
            {
                return parameters.Sum();
            }
            return 0;
        }
    }
}
