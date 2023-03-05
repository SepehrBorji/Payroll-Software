class Staff 
{
    // FIELDS AND PROPERTIES
    private decimal hourlyRate;

    private int _hoursWorked;
    public int HoursWorked 
    {
        get { return _hoursWorked; }
        set 
        {
            if (value > 0) 
            {
                _hoursWorked = value;
            }
            else 
            {
                _hoursWorked = 0;
            }
        }
    }

    public decimal TotalPay {get; protected set;}
    public decimal BasicPay {get; private set;}
    public string NameOfStaff {get; private set;}

    // CONSTRUCTOR
    public Staff(string name) 
    {
        NameOfStaff = name;

        // regular staff member gets paid $20 an hour
        hourlyRate = 20m;
    }

    // METHODS

    public virtual void CalculatePay() 
    {
        Console.WriteLine("Calulating Pay...");
        BasicPay = HoursWorked * hourlyRate;
        TotalPay = BasicPay;
    }

    public override string ToString()
    {
        string result = "\nName of Staff: " + NameOfStaff + "\nHourly rate: " + hourlyRate
            + "\n_hoursWorked: " + _hoursWorked + "\nHours Worked: " + HoursWorked + "\nBasic Pay: " + BasicPay
            + "\nTotal Pay: " + TotalPay;
        return result;
    }

}