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
            int result;
            if(Int32.TryParse(option, out result))
            {
                return true && base.Validate(option);
            }
            return false;
        }
    }
}
