class Manager : Staff
{
    // FIELDS

    public int allowance = 0;

    // CONSTRUCTOR
    public Manager(string name) : base(name)
    {
        // manager gets paid $50 an hour
        hourlyRate = 50m;
    }

    // METHODS

    public override void CalculatePay() 
    {
        base.CalculatePay();
        if (HoursWorked > 160) 
        {
            allowance = 1000;
            TotalPay += allowance;
        }
    }

    public override string ToString()
    {
        return base.ToString() + "\nAllowance: " + allowance;
    }

}