public class BankAccountMemento
{
    public string ownerName { get; private set; }
    public string ownerAddress { get; private set; }
    public decimal balance { get; private set; }
    public BankAccountMemento(string ownerName, string ownerAddress, decimal balance)
    {
        this.ownerName = ownerName;
        this.ownerAddress = ownerAddress;
        this.balance = balance;
    }
}
