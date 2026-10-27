
using System.Text;
namespace BankAccount;
class Program
{
   static void Main()
    {
        BankAccount acc = new BankAccount("Rishan", 2500);
        acc.ShowInfo();
        acc.Deposit(1000);
        acc.ShowInfo();
        acc.Withdraw(1500);
        acc.ShowInfo();
    }
}

