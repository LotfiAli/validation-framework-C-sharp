using System.Collections.Generic;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    internal class AndCompositeValidator : Validator
    {
        public AndCompositeValidator(params Validator[] listValidator) : base(null, null, null)
        {
            ListValidator = listValidator;
        }

        public IEnumerable<Validator> ListValidator { get; private set; }

        public override void DoValid(object objectToValidate, ValidationResults validationResults)
        {
            foreach (Validator validatorObject in ListValidator)
            {
                validatorObject.DoValid(objectToValidate, validationResults);
            }
        }

    }
}