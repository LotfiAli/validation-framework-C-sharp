using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.Reflector.RelectiationClass;
using System.ComponentModel;

namespace ValidationFrameworkTestProject
{
    public class BaseDTO : IDataErrorInfo
    {
        protected string CheckValidation(string pName)
        {
            var type = this.GetType();
            var p = type.GetProperty(pName);
            var value = p.GetValue(this, null);
            var validator = ReflcationClassProperty.GetValidator(type, pName);
            var result = validator.isValid(value);
            if (!result.Isvalid)
            {
                return result.GetValidationResult(0).Message;
            }

            return null;
        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get { return CheckValidation(columnName); }
        }
    }
}
