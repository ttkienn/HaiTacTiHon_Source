namespace UnityEngine.Purchasing;

public class ProductCatalogPayout
{
	internal enum ProductCatalogPayoutType
	{
		Other = 0,
		Currency = 1,
		Item = 2,
		Resource = 3,
	}

	public const int MaxSubtypeLength = 64; //Field offset: 0x0
	public const int MaxDataLength = 1024; //Field offset: 0x0
	[SerializeField]
	private string t; //Field offset: 0x10
	[SerializeField]
	private string st; //Field offset: 0x18
	[SerializeField]
	private double q; //Field offset: 0x20
	[SerializeField]
	private string d; //Field offset: 0x28

	public string data
	{
		 get { } //Length: 5
		 set { } //Length: 186
	}

	public double quantity
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public string subtype
	{
		 get { } //Length: 5
		 set { } //Length: 183
	}

	public ProductCatalogPayoutType type
	{
		 get { } //Length: 322
		 set { } //Length: 107
	}

	public string typeString
	{
		 get { } //Length: 5
	}

	public ProductCatalogPayout() { }

	public string get_data() { }

	public double get_quantity() { }

	public string get_subtype() { }

	public ProductCatalogPayoutType get_type() { }

	public string get_typeString() { }

	public void set_data(string value) { }

	public void set_quantity(double value) { }

	public void set_subtype(string value) { }

	public void set_type(ProductCatalogPayoutType value) { }

}

