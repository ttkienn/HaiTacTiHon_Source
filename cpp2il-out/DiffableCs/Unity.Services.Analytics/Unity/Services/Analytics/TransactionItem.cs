namespace Unity.Services.Analytics;

public class TransactionItem
{
	public string ItemName; //Field offset: 0x10
	public string ItemType; //Field offset: 0x18
	public long ItemAmount; //Field offset: 0x20

	public TransactionItem() { }

	internal void Serialize(IBuffer buffer) { }

}

