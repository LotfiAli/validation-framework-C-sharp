using System.Collections.Generic;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    internal class OrCompositeValidator : ValueValidator
    {
        public OrCompositeValidator(params Validator[] listValidator) : this(null, null, null, listValidator)
        {
        }

        public OrCompositeValidator(string messageTrue, string messageaAfter, string messageFalse,
                                    params Validator[] listValidator) : base(messageTrue, messageaAfter, messageFalse)
        {
            ListValidator = listValidator;
        }

        protected IEnumerable<Validator> ListValidator { get; private set; }

        public override void DoValid(object objectToValidate, ValidationResults validationResults)
        {
            var nestedValidationResults = new List<ValidationResult>();
            foreach (Validator validator in ListValidator)
            {
                var result = new ValidationResults();
                validator.DoValid(objectToValidate, validationResults);
                if (validationResults.Isvalid)
                    return;
                else
                {
                    nestedValidationResults.AddRange(result);
                }
            }
            base.LogValidator(validationResults, "error In Or comand", "Or", nestedValidationResults);
        }
    }
}

