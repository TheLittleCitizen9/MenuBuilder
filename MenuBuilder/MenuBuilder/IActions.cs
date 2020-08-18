using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IActions<T>
    {
        T Action(params T[] parameters);
    }
}
