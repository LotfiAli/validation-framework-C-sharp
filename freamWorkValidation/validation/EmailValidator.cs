using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    public class EmailValidator : RegexValidator
    {
        private static readonly string DefaultPattern = @"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b";
        public EmailValidator(string messageTrue, string messageaAfter, string messageFalse)
            : base(RegexOptions.None, DefaultPattern, messageTrue, messageaAfter, messageFalse)
        {}
    }
}
