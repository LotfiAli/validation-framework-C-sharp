using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace freamWorkValidation.Reflector
{
    class PropertyValueAccess:ValueAccess
    {
        private PropertyInfo propertyInfo;

        public PropertyValueAccess(PropertyInfo propertyInfo)
        {
            this.propertyInfo = propertyInfo;
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
            if (!this.propertyInfo.DeclaringType.IsAssignableFrom(source.GetType()))
            {
                outMessage = "error in getValue";
                return false;
            }
            else
            {
                valueOut = propertyInfo.GetValue(source,null);
                return true;
            }
        }
    }
}
