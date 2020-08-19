using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.IntMenu
{
    public class IntValidator : BasicValidator
    {
        public IntValidator(List<string> options):base(options)
        {
        }

        public override bool Validate(string option)
        {
            if (int.TryParse(option, out _))
            {
                return true && base.Validate(option);
            }
            return false;
        }
    }
}
