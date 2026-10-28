

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
    new Employee("Rishan",25000,"IT"),
    new Developer("Abir",32000,"Software",2000,3000),
    new Manager("Pekul",42000,"Manager",5000,12000)
};

foreach (Employee employee in employees)
{
    employee.DisplayInfo();
}

Console.WriteLine("====================================");

// LINQ here

decimal highestSalary = employees.Max(e => e.CalculateSalary());
var topEmployee = employees
                 .Where(e => e.CalculateSalary() == highestSalary)
                 .ToList();

foreach(var emp in topEmployee)
{
    Console.WriteLine($"Employee Name: {emp.Name} | Salary: {emp.CalculateSalary()}");
}

Console.WriteLine("");

// Department 
var empbydept = employees.GroupBy(e => e.Department);
foreach(var group in empbydept)
{
    Console.WriteLine($"Department: {group.Key}");

    foreach (var emp in group)
    {
        Console.WriteLine($"Name: {emp.Name}");
    }
}




