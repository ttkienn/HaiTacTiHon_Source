namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class CartItem
{
	[CompilerGenerated]
	private readonly Product <Product>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Quantity>k__BackingField; //Field offset: 0x18

	public Product Product
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int Quantity
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public CartItem(Product product) { }

	internal CartItem(Product product, int quantity) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Product get_Product() { }

	[CompilerGenerated]
	public int get_Quantity() { }

	public virtual int GetHashCode() { }

	public static CartItem op_Implicit(Product product) { }

}

