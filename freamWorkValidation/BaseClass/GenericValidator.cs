using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
    public abstract class GenericValidator<T> : Validator
    {
        public override void DoValid(object objectToValidate,ValidationResults validationResults)
        {
            this.doValid((T)objectToValidate, validationResults);
        }

        protected abstract void doValid(T objectToValidate, ValidationResults validationResults);

        public GenericValidator( string messageTrue, string messageaAfter, string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {}
    }
}
