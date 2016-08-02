using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    internal class DomainValidator<T> : GenericValidator<T>
    {
        private IEnumerable<T> listInput;

        public DomainValidator(IEnumerable<T> listInput) : this(listInput, null, null, null)
        {
        }

        public DomainValidator(IEnumerable<T> listInput, string messageTrue, string messageaAfter, string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {
            this.listInput = listInput;
        }

        protected override void doValid(T objectToValidate, ValidationResults validationResults)
        {
            bool flag = true;
            if (objectToValidate != null)
                foreach (T conunterDomain in this.listInput)
                    if (conunterDomain.Equals(objectToValidate))
                    {
                        flag = false;
                        break;
                    }
            if (flag)
                LogValidator(validationResults, "error", "Not Domain");
        }
    }
}