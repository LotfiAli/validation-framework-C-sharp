using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    public class RegexValidator : ValueValidatorGeneric<String>
    {
        private RegexOptions options;
        private string pattern;

        public RegexValidator(RegexOptions options, string pattern, string messageTrue, string messageaAfter, string messageFalse)
            : base(messageTrue, messageaAfter, messageFalse)
        {
            this.options = options;
            this.pattern = pattern;
        }

        internal RegexOptions? Options
        {
            get
            {
                return new RegexOptions?(this.options);
            }
        }

        internal string Pattern
        {
            get
            {
                return this.pattern;
            }
        }

        internal string PatternResourceName { get; private set; }

        internal Type PatternResourceType { get; private set; }


        protected override void doValid(String objectToValidate, ValidationResults validationResults)
        {
            bool flag = false;
            bool flag2 = objectToValidate == null;
            if (!flag2)
            {
                Regex regex = new Regex(pattern, this.options);
                string castObjectToValidate = objectToValidate as string;
                flag = !regex.IsMatch(castObjectToValidate);
                if (!flag)
                    LogValidator(validationResults, "error", "RegeuralExp");


            }



        }


        
    }
}
