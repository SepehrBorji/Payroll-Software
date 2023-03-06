class PayCheque 
{
    // FIELDS AND PROPERTIES

    private int month;
    private int year;

    enum MonthsOfYear 
    {
        JAN, FEB, MAR, APR, MAY, JUNE, JULY, AUG, SEPT, OCT, NOV, DEC
    }

    // CONSTRUCTOR

    public PayCheque(int payMonth, int payYear) 
    {
        month = payMonth;
        year = payYear;
    }

    // METHODS

    public void GeneratePayCheque(List<Staff> myStaff) 
    {
        string path;

        foreach (Staff staffMember in myStaff) 
        {
            path = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Pay Cheques" + Path.DirectorySeparatorChar + staffMember.NameOfStaff + ".txt";

            using (StreamWriter sw = new StreamWriter(path)) 
            {
                MonthsOfYear monthOfYear = (MonthsOfYear)month;
                sw.WriteLine("PAY CHEQUE FOR " + monthOfYear + " " + year);
                sw.WriteLine("==========================================");
                sw.WriteLine("Hours Worked: " + staffMember.HoursWorked);
                sw.WriteLine();
                sw.WriteLine("Basic Pay: $" + staffMember.BasicPay);
                
                if (staffMember.GetType() == typeof(Manager)) 
                {
                    sw.WriteLine("Allowance: $" + ((Manager)staffMember).allowance);
                }
                else if (staffMember.GetType() == typeof(Admin)) 
                {
                    sw.WriteLine("Overtime: $" + ((Admin)staffMember).Overtime);
                }
                else 
                {
                    sw.WriteLine();
                }
                sw.WriteLine("\n==========================================");
                sw.WriteLine("Total Pay: $" + staffMember.TotalPay);
                sw.WriteLine("==========================================");

                sw.Close();   
            }
        }
        
    }

    public override string ToString()
    {
        return "Month: " + month + "\nYear: " + year;
    }

}