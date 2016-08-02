# validation-framework
This code was written just for practice




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

