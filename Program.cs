class Program 
{
    public static void Main(string[] args) 
    {
        List<Staff> myStaff = new List<Staff>();
        FileReader fileReader = new FileReader();

        int month = 0;
        int year = 0;

        // prompt users to enter year
        while (year == 0) 
        {
            Console.Write("\nPlease enter the year: ");

            try 
            {
                string input = Console.ReadLine();
                year = Int32.Parse(input);
                
            }
            catch (FormatException ) 
            {
                Console.WriteLine("Please enter valid input");
                continue;
            }
        }

        // prompt users to enter month
        while (month == 0) 
        {
            Console.Write("\nPlease enter the month: (1-12) ");

            try 
            {
                string input = Console.ReadLine();
                month = Int32.Parse(input);
                
                if (month < 1 || month > 12) 
                {
                    Console.WriteLine("Please ensure that the number is within the proper range");
                    month = 0;
                }
                
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter valid integer");
                continue;
            }

            // get the staff information from the input file
            myStaff = fileReader.ReadFile();

            // calculate pay for each staff member
            for (int i = 0; i < myStaff.Count; i++) 
            {
                var currentStaff = myStaff[i];
                try 
                {
                    Console.Write("Enter hours worked for " + currentStaff.NameOfStaff + ": ");
                    int hoursWorkedInput = Int32.Parse(Console.ReadLine());
                    currentStaff.HoursWorked = hoursWorkedInput;

                    currentStaff.CalculatePay();
                    Console.WriteLine(currentStaff.ToString());
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            // generate pay cheques
            PayCheque payCheque = new PayCheque(month,year);
            payCheque.GeneratePayCheque(myStaff);
            
            Console.Read();
        }
    } 
}