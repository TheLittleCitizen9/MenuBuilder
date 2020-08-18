using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.IntMenu
{
    public class ReduceAction : IActions<int>
    {
        public int Action(params int[] parameters)
        {
            int reduced = 0;
            if (parameters.Length > 0)
            {
                reduced = parameters[0];
                for (int i = 1; i < parameters.Length; i++)
                {
                    reduced -= parameters[i];
                }
            }
            return reduced;
        }
    }
}
