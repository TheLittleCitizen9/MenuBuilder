using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IValidator
    {
        bool Validate(string option);
    }
}
