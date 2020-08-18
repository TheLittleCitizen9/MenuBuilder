using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringValidator : BasicValidator
    {
        public StringValidator(List<string> options) : base(options)
        {

        }

        public override bool Validate(string option)
        {
            if(!string.IsNullOrEmpty(option) && !string.IsNullOrWhiteSpace(option))
            {
                return true && base.Validate(option);
            }
            return false;   
        }
    }
}
