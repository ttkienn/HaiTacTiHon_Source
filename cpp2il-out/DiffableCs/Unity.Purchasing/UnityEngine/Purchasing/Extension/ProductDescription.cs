namespace UnityEngine.Purchasing.Extension;

public class ProductDescription
{
	[CompilerGenerated]
	private string <storeSpecificId>k__BackingField; //Field offset: 0x10
	public ProductType type; //Field offset: 0x18
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <receipt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <transactionId>k__BackingField; //Field offset: 0x30

	public private ProductMetadata metadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private string receipt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private string storeSpecificId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public string transactionId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	public ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) { }

	public ProductDescription(string id, ProductMetadata metadata) { }

	[CompilerGenerated]
	public ProductMetadata get_metadata() { }

	[CompilerGenerated]
	public string get_receipt() { }

	[CompilerGenerated]
	public string get_storeSpecificId() { }

	[CompilerGenerated]
	public string get_transactionId() { }

	[CompilerGenerated]
	private void set_metadata(ProductMetadata value) { }

	[CompilerGenerated]
	private void set_receipt(string value) { }

	[CompilerGenerated]
	private void set_storeSpecificId(string value) { }

	[CompilerGenerated]
	public void set_transactionId(string value) { }

	public virtual string ToString() { }

}

