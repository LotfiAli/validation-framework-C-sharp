using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;
using freamWorkValidation.Reflector;

namespace freamWorkValidation.Attribute
{
    interface IValidatorDescriptor
    {
        Validator CreateValidator();
    }
}
