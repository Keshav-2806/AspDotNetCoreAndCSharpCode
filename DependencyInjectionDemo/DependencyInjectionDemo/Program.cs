// See https://aka.ms/new-console-template for more information




public interface IAccount
{
    void PrintDetails();
}
public class SavingAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Saving Account data");
    }
}

public class CurrentAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Current Account data");
    }
}

class Account
{
    private IAccount account;

    public Account(IAccount account)
    {
        this.account = account;    
    }

    public void PrintAccounts()
    {
        account.PrintDetails();
    }

}
class Program
{
    static void Main(string[] args)
    {
        IAccount ca = new CurrentAccount(); 
        Account a = new Account(ca);
        a.PrintAccounts();

        IAccount sa = new SavingAccount(); ;
        Account a1 = new Account(sa);
        a1.PrintAccounts();


    }
}