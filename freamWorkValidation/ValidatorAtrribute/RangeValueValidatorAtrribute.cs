using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.Attribute;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;
using freamWorkValidation.BaseClass;
namespace freamWorkValidation.ValidatorAtrribute
{
    public class RangeValueValidatorAtrribute : ValidatorAttribute
    {
        public int Low;
        public int Hight;
        public RangeValueValidatorAtrribute(int low,int hight )
        {
            this.Low = low;
            this.Hight = hight;

        }
        protected override Validator GenerateValidator()
        {
            return new RangeValidator(Low,Hight);
        }
    }
}
