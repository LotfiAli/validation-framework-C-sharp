using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace freamWorkValidation.BaseClass
{
    public abstract class Validator
    {
        public Validator()
        {}

        public Validator(string messageTrue, string messageaAfter, string messageFalse)
            :this()
        {
            this.Message= messageFalse;
            this.Tag = messageTrue;
            this.MessageFalse = messageaAfter;
        }

        public abstract void DoValid(object objectToValidate,ValidationResults validationResults);

        public string Message { get; set; }
        public string Tag { get; set; }
        public string MessageFalse { get; set; }

        public void isValid(object objectToValidate,ValidationResults valiadationResult)
        {
            ValidationResults validationResults=new ValidationResults();
            Debug.WriteLine(Tag);
            this.DoValid(objectToValidate, valiadationResult);
            
        }

        public ValidationResults isValid(object objectToValidate)
        {
            ValidationResults validationResults = new ValidationResults();
            Debug.WriteLine(Tag);
            this.DoValid(objectToValidate, validationResults);
            return validationResults;

        }

        public void LogValidator(ValidationResults validatonResult, string message, string key, IEnumerable<ValidationResult> nestedValidationResults)
        {

           validatonResult.Add(new ValidationResult(key,message, nestedValidationResults,this)); 
            
        }
        public void LogValidator(ValidationResults validatonResult, string message, string key)
        {

            validatonResult.Add(new ValidationResult(key, message, this));

        }
        
    }
}
