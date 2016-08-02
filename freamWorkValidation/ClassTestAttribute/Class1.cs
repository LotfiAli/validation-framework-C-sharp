using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.PropertyChange;

namespace freamWorkValidation.ClassTestAttribute
{
    class Class1:IPropertyChangeValue
    {
        public event PropertyChangeValue propertyChange;

        public void propertyChangeValidation(String Name)
        {
            propertyChange(this,new propertyChangrArges(Name));
        }

      


        
    }
}
