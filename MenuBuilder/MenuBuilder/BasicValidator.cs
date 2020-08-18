using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class BasicValidator : IValidator
    {
        protected List<string> _options;

        public BasicValidator(List<string> options)
        {
            _options = options;
        }
        public virtual bool Validate(string option)
        {
            if(!string.IsNullOrEmpty(option) && !string.IsNullOrWhiteSpace(option))
            {
                if (_options.Contains(option))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
