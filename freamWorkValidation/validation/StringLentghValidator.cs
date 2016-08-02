using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    class StringLentghValidator : GenericValidator<string>
    {
        private int stringLentgh = 10;

        public StringLentghValidator(int stringLentgh):this(stringLentgh,null,null,null)
        {

            

        }
        public StringLentghValidator(int stringLentgh,string messageTrue, string messageaAfter, string messageFalse) : base( messageTrue, messageaAfter, messageFalse)
        {
            this.stringLentgh = stringLentgh;
        }

        protected override void doValid(string objectToValidate, ValidationResults validationResults)
        {
            if (objectToValidate.Length !=stringLentgh)
                LogValidator(validationResults, "error", "noNull");
           
        }
    }
}
