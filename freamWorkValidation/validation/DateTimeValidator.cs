using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;

namespace freamWorkValidation.validation
{
    public class DateTimeValidator : RangeValueValidator<DateTime>
    {
        public DateTimeValidator(DateTime dt1,DateTime dt2)
            :base(dt1,dt2)
        {}
    }
}
