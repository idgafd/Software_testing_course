using System;

// Base class for all bank accounts
public class BankAccount
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual bool Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public virtual void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}

// Branch of inheritance for savings accounts
public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(int accountNumber, decimal interestRate) : base(accountNumber)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        decimal interest = Balance * InterestRate;
        Deposit(interest);
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Savings Account");
        base.DisplayAccountInfo();
    }
}

// Branch of inheritance for checking accounts
public class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CheckingAccount(int accountNumber, decimal overdraftLimit) : base(accountNumber)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override bool Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Checking Account");
        base.DisplayAccountInfo();
        Console.WriteLine("Overdraft Limit: " + OverdraftLimit);
    }
}

// Main program
public class Program
{
    public static void Main()
    {
        // Create a savings account and a checking account
        SavingsAccount savings = new SavingsAccount(1234, 0.02m);
        CheckingAccount checking = new CheckingAccount(5678, 1000m);

        // Deposit some money into each account
        savings.Deposit(500m);
        checking.Deposit(1000m);

        // Display account information
        savings.DisplayAccountInfo();
        checking.DisplayAccountInfo();

        // Withdraw some money from each account
        savings.Withdraw(100m);
        checking.Withdraw(1500m);

        // Display account information again
        savings.DisplayAccountInfo();
        checking.DisplayAccountInfo();

        // Apply interest to the savings account
        savings.ApplyInterest();
        savings.DisplayAccountInfo();
    }
}
