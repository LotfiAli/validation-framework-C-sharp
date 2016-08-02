using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;
using freamWorkValidation.validationHelp;

namespace freamWorkValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = "b";
            string continueString = "a2li";
            ContinueStringValidator<string> h=new ContinueStringValidator<string>(word,SerachTextEnum.ContinueText);
          //  NotNullValidator h=new NotNullValidator("","","");
            
            ValidationResults f=new ValidationResults();
            f = h.isValid(continueString);
            if (f.Isvalid)
                Console.WriteLine("valid");
            else
                Console.WriteLine("not valid");
            Console.ReadKey();

            //     continueString<string> test = new continueString<string>(continueString, SerachText.Equal, "ali", "aa", "aaa");
            //   test.isValid(word,new ValidationResults());
            //Console.WriteLine(resul);
            //Console.ReadKey();
        }
    }
}
