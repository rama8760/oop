using System;

class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private double balance;
    private string accountType;
    private string branchName;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string AccountHolderName
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Error: Balance cannot be negative");
        }
    }

    public string AccountType
    {
        get { return accountType; }
        set { accountType = value; }
    }

    public string BranchName
    {
        get { return branchName; }
        set { branchName = value; }
    }

    public BankAccount(string accNum, string holder, double bal, string type, string branch)
    {
        accountNumber = accNum;
        accountHolderName = holder;

        if (bal >= 0)
            balance = bal;
        else
        {
            balance = 0;
            Console.WriteLine("Error: Initial balance cannot be negative");
        }

        accountType = type;
        branchName = branch;
    }

   
    ~BankAccount()
    {
        Console.WriteLine("BankAccount object destroyed");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposit successful");
        }
        else
        {
            Console.WriteLine("Error: Invalid deposit amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdraw successful");
        }
        else
        {
            Console.WriteLine("Error: Insufficient balance");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolderName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Branch Name: " + branchName);
    }
}

class Program
{
    static void Main(string[] args)
    {
   
        BankAccount account1 = new BankAccount(
            "A1001", "Ali Ahmad", 100, "Saving", "Amman"
        );

        BankAccount account2 = new BankAccount(
            "A2002", "Sara Khaled", 50, "Checking", "Irbid"
        );

        
        account1.Deposit(300);
        account1.Withdraw(200);
        account1.DisplayInfo();

        Console.WriteLine();

        account2.Withdraw(800);  
        account2.Deposit(150);
        account2.DisplayInfo();
    }
}

