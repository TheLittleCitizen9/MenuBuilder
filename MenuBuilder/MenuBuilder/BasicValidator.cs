using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class BasicValidator : IValidator
    {
        public virtual bool Validate(string option)
        {
            return true;
        }
    }
}
