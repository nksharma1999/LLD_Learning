class LInitialization
{
    public void Initialization()
    {
        // Initialization code here
        Console.WriteLine("Initializing bank violated accounts...");
        List<ILAccount> accounts = new List<ILAccount>
        {
            new LSavingAccount_Violated(1000),
            new LCurrentAccount_Violated(500, 200),
            new LFixedDepositAccount_Violated(2000)
        };
        var bankAccount = new LBankAccount_Violated(accounts);
        bankAccount.ProcessTrasations();
        Console.WriteLine("Bank violated accounts initialized successfully End.");

        Console.WriteLine("Initializing bank followed Wrongly accounts...");
        List<ILAccount> accountsFollowedWrongly = new List<ILAccount>
        {
            new LSavingAccount_Followed_Wrongly(1000),
            new LCurrentAccount_Followed_Wrongly(500, 200),
            new LFixedDepositAccount_Followed_Wrongly(2000)
        };
        var bankAccount2 = new LBankAccount_Followed_Wrongly(accountsFollowedWrongly);
        bankAccount2.ProcessTrasations();
        Console.WriteLine("Bank followed wrongly accounts initialized successfully End.");  

        Console.WriteLine("Initializing bank followed accounts...");
        List<IWithdrawableAccount> withdrawableAccounts = new List<IWithdrawableAccount>
        {
            new LCurrentAccount(500),
            new LSavingsAccount(1000)
        };
        List<IDepositOnlyAccount> depositOnlyAccounts = new List<IDepositOnlyAccount>
        {
            new LFixedDepositAccount(2000)
        };
        var bankClient3 = new LBankClient(withdrawableAccounts, depositOnlyAccounts);    
        bankClient3.ProcessTransactions();
        Console.WriteLine("Bank followed accounts initialized successfully End.");
    }
}