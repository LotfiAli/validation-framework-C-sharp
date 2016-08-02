using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.validation;

namespace freamWorkValidation.BaseClass
{
    class CompositValidator
    {
        public List<Validator> ListValidator { private get; set; }
        public CompositaionType CompositType { private get; set; }
        
        public void AddToList(Validator valueValidator)
        {
            this.ListValidator.Add(valueValidator);
        }

        public CompositValidator(CompositaionType compositType)
        {
            this.CompositType = compositType;
            ListValidator=new List<Validator>();
        }

        public Validator GetValidator()
        {
            Validator valiator = null;
            if (ListValidator.Count == 1)
                valiator = ListValidator[0];
            else
                if (CompositType == CompositaionType.AND)
                    valiator = new AndCompositeValidator(ListValidator.ToArray());
             else
                if (CompositType == CompositaionType.OR)
                    valiator = new OrCompositeValidator(ListValidator.ToArray());
            return valiator;


        }

    }
}
