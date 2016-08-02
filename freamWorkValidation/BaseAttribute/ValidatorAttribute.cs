using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;
using freamWorkValidation.Reflector;

namespace freamWorkValidation.Attribute
{
    public abstract class ValidatorAttribute : BaseValidationAttribute, IValidatorDescriptor
    {
        protected abstract Validator GenerateValidator();

        //public Validator CreateValidator(Type targetType, Type ownerType, MemberValueAccessBuilder memberValueAccessBuilder)
        // {
        //     Validator validator = this.DoValidator(targetType, ownerType, memberValueAccessBuilder);
        //     validator.Message = base.Message;
        //     validator.Tag = base.Tag;
        //     validator.MessageFalse = base.MessageFalse;
        //     return validator;

        // }

        public Validator CreateValidator()
        {
            return GenerateValidator();
        }
    }
}
