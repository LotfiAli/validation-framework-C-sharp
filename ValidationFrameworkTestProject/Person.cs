using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using freamWorkValidation.Attribute;
using freamWorkValidation.Reflector.RelectiationClass;
using freamWorkValidation.ValidatorAtrribute;
using freamWorkValidation.BaseClass;

namespace ValidationFrameworkTestProject
{
    public class Person
    {
        [NotNullValidator]
        public string Name { get; set; }

        [RangeValueValidatorAtrribute(10, 20)]
        public int Age { get; set; }
    }

    public class Client : BaseDTO
    {
        private string name;

        [NotNullValidator]
        public string Name
        {
            get { return name; }
            set
            {
                CheckValidation("Name");
                name = value;
            }
        }

       

    }
}
