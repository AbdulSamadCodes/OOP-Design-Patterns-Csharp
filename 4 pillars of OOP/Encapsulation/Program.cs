//Encapsulation is the phenomenon of restricting the direct acess of class components from the users.
class BankAccount()
{
    // We want that user cannot be able to access the balance directly.
    private float balance;
    
    public void deposit(int amount)
    {
      this.balance += amount;
    }

    public void withdrawl(int amount)
    {
      this.balance -= amount;
    }
    
    //Here we didnt allow the user to set balance
    public float Balance
    {
       get{return balance;}
    }

}
class Program
{
  public static void Main(string[] args)
  {
    BankAccount savingAccount = new BankAccount();
    savingAccount.deposit(150000);
    Console.WriteLine(savingAccount.Balance);
    savingAccount.withdrawl(50000);
    Console.WriteLine(savingAccount.Balance);
  }
}
