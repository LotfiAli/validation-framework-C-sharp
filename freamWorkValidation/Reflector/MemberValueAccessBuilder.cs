using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace freamWorkValidation.Reflector
{
public abstract   class   MemberValueAccessBuilder
    {
        // Methods
        protected MemberValueAccessBuilder()
        {
        }

        protected abstract ValueAccess DoGetFieldValueAccess(FieldInfo fieldInfo);
        protected abstract ValueAccess DoGetMethodValueAccess(MethodInfo methodInfo);
        protected abstract ValueAccess DoGetPropertyValueAccess(PropertyInfo propertyInfo);
        public ValueAccess GetFieldValueAccess(FieldInfo fieldInfo)
        {
            if (fieldInfo == null)
            {
                throw new ArgumentNullException("fieldInfo");
            }
            return this.DoGetFieldValueAccess(fieldInfo);
        }

        public ValueAccess GetMethodValueAccess(MethodInfo methodInfo)
        {
            if (methodInfo == null)
            {
                throw new ArgumentNullException("methodInfo");
            }
            if (typeof(void) == methodInfo.ReturnType)
            {
                throw new ArgumentException("error");
            }
            if (0 < methodInfo.GetParameters().Length)
            {
                throw new ArgumentException("erroe");
            }
            return this.DoGetMethodValueAccess(methodInfo);
        }

        public ValueAccess GetPropertyValueAccess(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                throw new ArgumentNullException("propertyInfo");
            }
            return this.DoGetPropertyValueAccess(propertyInfo);
        }

    }
}
