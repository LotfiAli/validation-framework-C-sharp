using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace freamWorkValidation.Reflector
{
    class MethodValueAcsess:ValueAccess
    {
        private MethodInfo methodInfo;

        public MethodValueAcsess(MethodInfo methodInfo)
        {
            this.methodInfo = methodInfo;

        }
        public override bool GetValue(object source, out object valueOut, out string outMessage)
        {
            valueOut = null;
            outMessage = null;
            if (source == null)
            {
                outMessage = "error in getValue";
                return false;
            }
            if (!this.methodInfo.DeclaringType.IsAssignableFrom(source.GetType()))
            {
                outMessage = "error in getValue";
                return false;
            }
            else
            {
                valueOut = methodInfo.Invoke(source, null);
                return true;
            }

        }
    }
}
