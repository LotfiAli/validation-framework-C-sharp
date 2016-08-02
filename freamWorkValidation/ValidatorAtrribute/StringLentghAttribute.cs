using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.Attribute;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;

namespace freamWorkValidation.ValidatorAtrribute
{
    public class StringLentghAttribute : ValidatorAttribute
    {
        private int lentght;

        public StringLentghAttribute(int lentght)
        {
            this.lentght = lentght;

        }
        protected override Validator GenerateValidator()
        {
            return  new StringLentghValidator(lentght);
        }
    }
}
