
class LSavingsAccount : IWithdrawableAccount
{
    private decimal balance;
    public LSavingsAccount(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }
    public void Withdraw(decimal amount)
    {
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
        return balance;
    }
}

class LCurrentAccount : IWithdrawableAccount
{
    private decimal balance;
    public LCurrentAccount(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }
    public void Withdraw(decimal amount)
    {
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
        return balance;
    }
}

class LFixedDepositAccount : IDepositOnlyAccount
{
    private decimal balance;
    public LFixedDepositAccount(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class LBankClient
{
    List<IWithdrawableAccount> withdrawableAccounts = new List<IWithdrawableAccount>();
    List<IDepositOnlyAccount> depositOnlyAccounts = new List<IDepositOnlyAccount>();
    public LBankClient(List<IWithdrawableAccount> withdrawableAccounts, List<IDepositOnlyAccount> depositOnlyAccounts)
    {
        this.withdrawableAccounts = withdrawableAccounts;
        this.depositOnlyAccounts = depositOnlyAccounts;
    }

    public void ProcessTransactions()
    {
        foreach (var account in withdrawableAccounts)
        {
            account.Deposit(1000);
            account.Withdraw(100); // Example withdrawal
        }
        foreach (var account in depositOnlyAccounts)
        {
            account.Deposit(1000); // Example deposit
        }
    }
}