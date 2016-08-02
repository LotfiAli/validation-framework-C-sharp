using System;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validationHelp;

namespace freamWorkValidation.validation
{
    public class ContinueStringValidator<String> : ValueValidatorGeneric<string>
    {
        private SerachTextEnum flagSerach = SerachTextEnum.Equal;
        private string serachString;

        public ContinueStringValidator(string serachString, SerachTextEnum flagSerach)
            : this(serachString, flagSerach, null, null, null)
        {
        }

        public ContinueStringValidator(string serachString, SerachTextEnum flagSerach, string messageTrue, string messageaAfter,
                              string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {
            this.serachString = serachString;
            this.flagSerach = flagSerach;
        }

        public SerachTextEnum FlagSerach
        {
            get { return flagSerach; }
            set { flagSerach = value; }
        }

        public string ContinueString
        {
            get { return serachString; }
            set { serachString = value; }
        }

        protected override void doValid(string objectToValidate,ValidationResults validationResults)
        {
            bool flagResult = false;

            switch (flagSerach)
            {
                case SerachTextEnum.Equal:
                   if (!(objectToValidate == serachString))
                       LogValidator(validationResults, "error", "note equla in the list");
                    break;
                case SerachTextEnum.NotEqual: 
                   if (!(objectToValidate != serachString))
                       LogValidator(validationResults, "error", "is equla in the list");
                   break;
                case SerachTextEnum.ContinueText:
                   bool returnValue= objectToValidate.Contains(serachString);
                    if (!returnValue)
                        LogValidator(validationResults, "error", "no continue this word");

                    break;
                default:
                    throw new ArgumentException("error in ths validation");
                    break;
            }
        }
    }
}