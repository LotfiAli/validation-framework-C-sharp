using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
 public abstract class ValueValidator:Validator
    {
      public ValueValidator(string messageTrue, string messageaAfter, string messageFalse): 
          base(messageTrue, messageaAfter, messageFalse)
      {}
    }
}
