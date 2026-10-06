namespace UnityEngine.Purchasing;

public class PayoutDefinition
{
	public const int MaxSubtypeLength = 64; //Field offset: 0x0
	public const int MaxDataLength = 1024; //Field offset: 0x0
	[SerializeField]
	private PayoutType m_Type; //Field offset: 0x10
	[SerializeField]
	private string m_Subtype; //Field offset: 0x18
	[SerializeField]
	private double m_Quantity; //Field offset: 0x20
	[SerializeField]
	private string m_Data; //Field offset: 0x28

	public private string data
	{
		 get { } //Length: 5
		private set { } //Length: 186
	}

	public private double quantity
	{
		 get { } //Length: 6
		private set { } //Length: 6
	}

	public private string subtype
	{
		 get { } //Length: 5
		private set { } //Length: 183
	}

	public private PayoutType type
	{
		 get { } //Length: 191
		private set { } //Length: 4
	}

	public string typeString
	{
		 get { } //Length: 83
	}

	public PayoutDefinition() { }

	public PayoutDefinition(string typeString, string subtype, double quantity) { }

	public PayoutDefinition(string typeString, string subtype, double quantity, string data) { }

	public PayoutDefinition(string subtype, double quantity) { }

	public PayoutDefinition(string subtype, double quantity, string data) { }

	public PayoutDefinition(PayoutType type, string subtype, double quantity) { }

	public PayoutDefinition(PayoutType type, string subtype, double quantity, string data) { }

	public string get_data() { }

	public double get_quantity() { }

	public string get_subtype() { }

	public PayoutType get_type() { }

	public string get_typeString() { }

	private void set_data(string value) { }

	private void set_quantity(double value) { }

	private void set_subtype(string value) { }

	private void set_type(PayoutType value) { }

}

