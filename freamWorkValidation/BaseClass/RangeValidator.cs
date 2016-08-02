using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
    class RangeValidator:RangeValueValidator<IComparable>
    {
        public RangeValidator(IComparable low, IComparable oper) :this(low,oper,null,null,null)
        {

        }

        public RangeValidator(IComparable low, IComparable oper, string messageTrue, string messageaAfter, string messageFalse) : base(low, oper, messageTrue, messageaAfter, messageFalse)
        {

        }
    }
}
