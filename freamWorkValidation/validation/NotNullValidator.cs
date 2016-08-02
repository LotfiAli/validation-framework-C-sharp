using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    public class NotNullValidator : ValueValidator
    {
        public NotNullValidator()
            :this("True","After","False")
        {}

        public NotNullValidator(string messageTrue, string messageaAfter, string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {
        }

        public override void DoValid(object objectToValidate,ValidationResults validationResults)
        {
            if (objectToValidate == null)
               LogValidator(validationResults,"error","noNull");
        }

     
       
    }
}
