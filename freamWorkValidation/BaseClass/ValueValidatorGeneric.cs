using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
 public abstract  class ValueValidatorGeneric<T>:GenericValidator<T>
    {
      public ValueValidatorGeneric(string messageTrue, string messageaAfter, string messageFalse): 
          base( messageTrue,  messageaAfter,  messageFalse)
      {
          
      }
    }
}
