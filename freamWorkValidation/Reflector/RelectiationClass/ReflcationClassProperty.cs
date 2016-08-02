using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using freamWorkValidation.Attribute;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;

namespace freamWorkValidation.Reflector.RelectiationClass
{
    internal class ReflcationClassProperty
    {
        //private T content;
        private string propertyName;

        //public ReflcationClassProperty(T Content) : this(Content, string.Empty)
        //{
            
        //}

        //public ReflcationClassProperty(T Content, string PropertyName)
        //{
        //    if (Content == null) throw new ArgumentNullException("Content");
        //    if (PropertyName == null) throw new ArgumentNullException("PropertyName");
        //    this.content = Content;
        //    this.propertyName = PropertyName;
        //}

        public static Validator GetValidator(Type type, string propertyName)
        {
            var validators = new List<Validator>();

            PropertyInfo propertyInfos = type.GetProperty(propertyName);

            var attributes = propertyInfos.GetCustomAttributes(false);

            foreach (var ca in attributes)
            {
                if (ca is ValidatorAttribute)
                {
                    validators.Add((ca as ValidatorAttribute).CreateValidator());
                }
            }

            return new AndCompositeValidator(validators.ToArray());
        }
    }

    
}