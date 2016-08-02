using System;

namespace freamWorkValidation.BaseClass
{
    public abstract class RangeValueValidator<T> : GenericValidator<T> where T : IComparable
    {
        public RangeValueValidator(T low, T oper)
            : this(low, oper, null, null, null)
        {
        }

        public RangeValueValidator(T low, T oper, string messageTrue, string messageaAfter, string messageFalse)
            : base( messageTrue, messageaAfter, messageFalse)
        {
            if (low == null)
                throw new ArgumentException("not null must be null");
            if (oper == null)
                throw new ArgumentException("ot null must be null");

            lower = low;
            upper = oper;
        }

        protected T lower { get; private set; }
        protected T upper { get; private set; }

        protected override void doValid(T objectToValidate, ValidationResults validationResults)
        {
            int compareLow = lower.CompareTo(objectToValidate);
            if (compareLow < 0)
                LogValidator(validationResults, "error", "o this ie ");
            else if (compareLow > 0)
            {
                int compareBig = upper.CompareTo(objectToValidate);
                if (compareBig > 0)
                    LogValidator(validationResults, "error", "no this renge can read");
            }
        }
    }
}