using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
 public   abstract class BaseValidationAttribute : System.Attribute

    {
        public BaseValidationAttribute():this(null,null,null)
        {
            
        }

        private BaseValidationAttribute(string message, string tag, string messageFalse)
        {
            

        }

        public string Message { get; set; }
        public string Tag { get; set; }
        public string MessageFalse { get; set; }
    }
}
