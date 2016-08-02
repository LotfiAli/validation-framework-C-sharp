using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.Reflector
{
  public abstract class ValueAccess
  {
      protected ValueAccess()
      {
          
      }

      public abstract bool GetValue(object source, out object valueOut,out  string outMessage);


  }
}
