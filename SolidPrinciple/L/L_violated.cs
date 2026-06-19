
class LSavingAccount_Violated : ILAccount
{
    private decimal balance;

    public LSavingAccount_Violated(decimal initialBalance = 0)
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

class LCurrentAccount_Violated : ILAccount
{
    private decimal balance;
    private decimal overdraftLimit;

    public LCurrentAccount_Violated(decimal initialBalance = 0, decimal overdraftLimit = 0)
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

class LFixedDepositAccount_Violated : ILAccount
{
    private decimal balance;

    public LFixedDepositAccount_Violated(decimal initialBalance= 0)
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

// This class violates the Liskov Substitution Principle because it treats different account types differently in the ProcessTransactions method, which can lead to unexpected behavior when substituting one account type for another.
class LBankAccount_Violated
{
    private List<ILAccount> accounts = new List<ILAccount>();

    public LBankAccount_Violated(List<ILAccount> accounts)
    {
        this.accounts = accounts;
    } 

    public void ProcessTrasations()
    {
        foreach (var account in accounts)
        {
            account.Deposit(100);
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