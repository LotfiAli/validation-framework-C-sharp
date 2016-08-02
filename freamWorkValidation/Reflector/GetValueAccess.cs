using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace freamWorkValidation.Reflector
{
    internal class GetValueAccess : ValueAccess
    {
        private FieldInfo filedInfo;

        public GetValueAccess(FieldInfo fieldInfo)
        {
            this.filedInfo = filedInfo;
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
            if (!this.filedInfo.DeclaringType.IsAssignableFrom(source.GetType()))
            {
                outMessage = "error in getValue";
                return false;
            }
            else
            {
                valueOut = filedInfo.GetValue(source);
                return true;
            }
        }
    }
}