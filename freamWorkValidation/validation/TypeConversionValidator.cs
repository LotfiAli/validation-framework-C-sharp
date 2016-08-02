using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    internal class TypeConversionValidator : GenericValidator<string>
    {
        private Type type;

        public TypeConversionValidator(Type type, string messageTrue, string messageaAfter, string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {
            this.type = type;
        }

        protected override void doValid(string objectToValidate, ValidationResults validationResults)
        {
            bool flag = false;
            bool flag2 = objectToValidate == null;
            if (!flag2)
            {
                if (string.Empty.Equals(objectToValidate))
                {
                    flag = true;
                }
                else
                {
                    try
                    {
                        TypeConverter typeConverter = TypeDescriptor.GetConverter(this.type);

                        if (typeConverter != null &&
                            typeConverter.ConvertFromString(null, CultureInfo.CurrentCulture, objectToValidate) == null)
                        {
                            flag = true;
                        }
                    }
                    catch (Exception)
                    {
                        flag = true;
                    }
                }
            }
            if (flag2 || (flag))
            {
                base.LogValidator(validationResults, "error", "TypeConversionValidator");
            }
        }
    }
}