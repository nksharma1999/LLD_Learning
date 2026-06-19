interface IWithdrawableAccount : IDepositOnlyAccount
{
    void Withdraw(decimal amount);
}