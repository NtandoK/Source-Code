using System;
class Bank
{
    public double Balance {get; set;}
    public Bank(double cash)
    {
        Balance=cash;
    }
    public void WithDraw(double amount)
    {
        if(amount>Balance)
        {
            Console.WriteLine("Insuffient funds!!!");
        }
        else if(amount<Balance)
        {
            Balance-=amount;
        }
    }
    public void Deposit(double amount)
    {
        Balance+=amount;
    }
    public void WriteBalance()
    {
        Console.WriteLine("Available balance: R"+Balance);
    }
}
class Saving:Bank
{
    public Saving(double cash):base (cash){}
    public void AddInterest(double rate)
    {
        double interest=Balance*rate;
        Balance+=interest;
    }
}
class Credit:Bank
{
    public Credit(double cash):base (cash){}
    public void Charge(double rate)
    {
        double c=Balance*rate;
        Balance-=c;
    }
}
class Program
{
    public static void Main(string[]args)
    {
       double Balance=1000;
        Saving s=new Saving(Balance);
        Credit cr=new Credit(Balance);
        s.AddInterest(0.10);
        s.WriteBalance();
        cr.Charge(0.20);
        cr.WriteBalance();
        s.Deposit(3000);
        s.WriteBalance();
        s.WithDraw(5000);
    }
}