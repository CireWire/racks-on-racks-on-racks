using System;

namespace bankMachine
{
  class bankAccount
  {
    private double balance = 0;
    public void deposit (double n)
    {
      balance += n;
    }
    public void withdrawal (double n)
    {
      balance -= n;
    }
    public double getBalance ()
    {
      return balance;
    }
  }

  class MainClass 
  {
    public static void Main () 
    {
      bankAccount b = new bankAccount();

      b.deposit(250.26);
      b.withdrawal(60);
      Console.WriteLine(b.getBalance());
    }
  }
}
