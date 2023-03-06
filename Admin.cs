class Admin : Staff
{
    // FIELDS

    private const decimal overtimeRate = 15;
    public decimal Overtime {get; private set;}


    // CONSTRUCTOR
    public Admin(string name) : base(name)
    {
        // admins get paid $30 an hour
        hourlyRate = 30m;
    }

    // METHODS

    public override void CalculatePay()
    {
        base.CalculatePay();
        if (HoursWorked > 160) 
        {
            Overtime = overtimeRate * (HoursWorked - 160);
            TotalPay += Overtime;
        }
    }

    public override string ToString()
    {
        return base.ToString() + "\nOvertime Rate: " + overtimeRate + "\nOvertime: " + Overtime;
    }
}