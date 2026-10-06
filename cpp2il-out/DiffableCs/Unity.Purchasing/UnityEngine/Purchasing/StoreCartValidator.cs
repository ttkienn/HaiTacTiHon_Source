namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreCartValidator : ICartValidator
{
	private readonly string m_StoreName; //Field offset: 0x10
	private readonly ICartValidator m_CartValidator; //Field offset: 0x18

	public StoreCartValidator(string storeName, ICartValidator cartValidator) { }

	public override void Validate(ICart cart) { }

}

