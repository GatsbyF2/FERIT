public class BankAccount
{
    private string ownerName;
    private string ownerAddress;
    private decimal balance;
    public BankAccount(string ownerName, string ownerAddress, decimal balance)
    {
        this.ownerName = ownerName;
        this.ownerAddress = ownerAddress;
        this.balance = balance;
    }
    public void ChangeOwnerAddress(string address)
    {
        this.ownerAddress = address;
    }
    public void UpdateBalance(decimal amount) { this.balance += amount; }
    public string OwnerName { get { return this.ownerName; } }
    public string OwnerAddress { get { return this.ownerAddress; } }
    public decimal Balance { get { return this.balance; } }

    public override String ToString()
    {
        return $"{OwnerName}, {OwnerAddress}: {Balance}";
    }

    public BankAccountMemento StoreState()
    {
        return new BankAccountMemento(ownerName, ownerAddress, balance);
    }
    public void RestoreState(BankAccountMemento previous)
    {
        if (previous == null) return;
        this.ownerName = previous.ownerName;
        this.ownerAddress= previous.ownerAddress;
        this.balance= previous.balance;
    }
}
