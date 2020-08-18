using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IActions<T>
    {
        void Action(params T[] parameters);
    }
}
