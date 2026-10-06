namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class Cart : ICart
{
	private readonly HashSet<CartItem> m_CartItems; //Field offset: 0x10
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private IReadOnlyList<CartItem> m_CachedItemsList; //Field offset: 0x18

	public Cart(CartItem cartItem) { }

	public void AddItem(CartItem item) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public override IReadOnlyList<CartItem> Items() { }

	public void RemoveItem(CartItem item) { }

}

