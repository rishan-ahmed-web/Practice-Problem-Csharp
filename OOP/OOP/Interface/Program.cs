

using Interface;
try
{
    IPayable[] payments =
{
    new Cardpayment(),
    new Cashpayment()
};

    foreach (IPayable payment in payments)
    {
        payment.Pay(1000);
        
    }
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("");

List<Employee> employees = new List<Employee>
{
    new Employee("Rishan",25000),
    new Manager("Pekul",42000,5000,12000)
};

foreach (Employee employee in employees)
{
    employee.DisplayInfo();
}





