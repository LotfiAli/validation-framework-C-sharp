using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.Attribute;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;
namespace freamWorkValidation.ValidatorAtrribute
{
    public sealed class NotNullValidatorAttribute : ValidatorAttribute
    {
        protected override Validator GenerateValidator()
        {
            return new NotNullValidator();
        }
    }
}
