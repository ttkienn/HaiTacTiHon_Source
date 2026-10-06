namespace UnityEngine.Purchasing;

internal class MultipleConsumableQuantityCartValidator : ICartValidator
{

	public MultipleConsumableQuantityCartValidator() { }

	[NullableContext(1)]
	public override void Validate(ICart cart) { }

	[NullableContext(1)]
	private void ValidateItem(CartItem cartItem) { }

}

