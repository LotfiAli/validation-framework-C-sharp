using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.PropertyChange
{
  public  class propertyChangrArges:EventArgs
    {
        private string name;

        public propertyChangrArges(string name)
        {
            this.name = name;
        }
    }
}
