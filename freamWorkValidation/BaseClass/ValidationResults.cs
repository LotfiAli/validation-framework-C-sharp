using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freamWorkValidation.BaseClass
{
  public  class ValidationResults:IEnumerable<ValidationResult>
    {
        private List<ValidationResult> validationResults = new List<ValidationResult>();
         public  void Add(ValidationResult validationResult)
         {
            validationResults.Add(validationResult); 

         }
        public  void AddTorRange(IEnumerable<ValidationResult> vaalidationResult)
        {
           validationResults.AddRange(validationResults); 
        }
        
        public IEnumerator<ValidationResult> GetEnumerator()
        {
            return this.validationResults.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.validationResults.GetEnumerator();
        }
        public  bool Isvalid
        {
            get { return validationResults.Count == 0; }
        }
        public int Count
        {
            get
            {
                return this.validationResults.Count;
            }
        }

      public ValidationResult GetValidationResult(int index)
      {
          return validationResults[index];
      }


    }
}
