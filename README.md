# validation-framework
This code was written just for practice

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
