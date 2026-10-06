namespace UnityEngine.Purchasing;

public class SingleProductCartValidator : ICartValidator
{

	public SingleProductCartValidator() { }

	[NullableContext(1)]
	public override void Validate(ICart cart) { }

}

