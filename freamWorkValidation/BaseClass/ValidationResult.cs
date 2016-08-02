using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
    public class ValidationResult
    {
        public string Key { get;  set;}
        public string Message { get;  set; }
        public IEnumerable<ValidationResult> NestedValidationResults;
        public Validator ValidatorInut;
        public ValidationResult():this(null,null,null,null)
        {
            
        }

        public ValidationResult(  IEnumerable<ValidationResult> nestedValidationResults, Validator validatorInut)
            : this(null, null, nestedValidationResults, validatorInut)
        {
            

        }
        public ValidationResult(string key, string message, Validator validatorInut)
            : this(null, null,null,  validatorInut)
        {


        }

        public ValidationResult(string key, string message, IEnumerable<ValidationResult> nestedValidationResults, Validator validatorInut)
        {
            this.Key = key;
            this.Message = message;
            this.NestedValidationResults = nestedValidationResults;
            this.ValidatorInut = validatorInut;


        }

    }
}
