using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    class EnumConversionValidator : GenericValidator<String>
    {
        private Type type;

        public EnumConversionValidator(Type type):this(type,null,null,null)
        {
            
        }
        public EnumConversionValidator(Type type,string messageTrue, string messageaAfter, string messageFalse) : base( messageTrue, messageaAfter, messageFalse)
        {
            this.type = type;
        }

        protected override void doValid(string objectToValidate, ValidationResults validationResults)
        {
            bool flag = false;
            bool flag2 = objectToValidate == null;
            if (!flag2)
            {
                flag = !Enum.IsDefined(this.type, objectToValidate);
            }
            if (flag2 || (flag ))
            {
                base.LogValidator(validationResults,"asas","assas");
            }

        }
    }
}
