class LSavingAccount_Followed_Wrongly : ILAccount
{
    private decimal balance;

    public LSavingAccount_Followed_Wrongly(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        // Implementation for depositing money
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        // Implementation for withdrawing money
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
    }

    public decimal GetBalance()
    {
        // Implementation for getting the account balance
        return balance;
    }

}

class LCurrentAccount_Followed_Wrongly : ILAccount
{
    private decimal balance;
    private decimal overdraftLimit;

    public LCurrentAccount_Followed_Wrongly(decimal initialBalance = 0, decimal overdraftLimit = 0)
    {
        balance = initialBalance;
        this.overdraftLimit = overdraftLimit;
    }

    public void Deposit(decimal amount)
    {
        // Implementation for depositing money
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        // Implementation for withdrawing money with overdraft limit
        if (amount > balance + overdraftLimit)
        {
            Console.WriteLine("Insufficient funds including overdraft limit.");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
    }

    public decimal GetBalance()
    {
        // Implementation for getting the account balance
        return balance;
    }
}

class LFixedDepositAccount_Followed_Wrongly : ILAccount
{
    private decimal balance;

    public LFixedDepositAccount_Followed_Wrongly(decimal initialBalance= 0)
    {
        balance = initialBalance;
    }  

    public void Deposit(decimal amount)
    {
        // Implementation for depositing money
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        throw new InvalidOperationException("Withdrawals are not allowed from a fixed deposit account.");
    }

    public decimal GetBalance()
    {
        // Implementation for getting the account balance
        return balance;
    }
}

class LBankAccount_Followed_Wrongly 
{
    private List<ILAccount> accounts = new List<ILAccount>();

    public LBankAccount_Followed_Wrongly(List<ILAccount> accounts)
    {
        this.accounts = accounts;
    } 

// Method to process transactions for all accounts is not following Liskov Substitution Principle correctly, as it checks for specific account types and handles them differently, which violates the principle of substitutability.
    public void ProcessTrasations()
    {
        foreach (var account in accounts)
        {
            account.Deposit(100);
            
            if(account is LFixedDepositAccount_Followed_Wrongly)
            {
                Console.WriteLine("Withdrawals are not allowed from a fixed deposit account.");
                continue;
            }else
            {
                try
                {
                    account.Withdraw(50);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}