namespace HomeworkDefiningClassesPart1
{
    using System;
    class Entrance
    {
        public static void Main()
        {
        GSM phoneOne = new GSM("Galaxy S6", "Samsung");

        Call first = new Call(phoneOne, DateTime.Now, "0876050549", 123);
        phoneOne.AddCall(first);
            

        Call second = new Call(phoneOne, DateTime.Now, "0876050548", 200);
        phoneOne.AddCall(second);

        Call third = new Call(phoneOne, DateTime.Now, "0876980549", 250);
        phoneOne.AddCall(third);

        phoneOne.PrintCallHistory();
            
            Console.WriteLine("--");
            Console.WriteLine("Total price: {0}", phoneOne.CallPrice(0.37M));
            
            Console.WriteLine("--");

            phoneOne.DeleteCallHistory(2);
            phoneOne.PrintCallHistory();
            Console.WriteLine("--");
            Console.WriteLine("Total price: {0}",phoneOne.CallPrice(0.37M));
            
            Console.WriteLine("--");

            phoneOne.ClearCallHistory();
            Console.WriteLine("---");
            Console.WriteLine("No History:");
            phoneOne.PrintCallHistory();
            Console.WriteLine("---");
        }
    }
}
