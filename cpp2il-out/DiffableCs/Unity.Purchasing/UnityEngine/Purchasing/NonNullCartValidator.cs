namespace UnityEngine.Purchasing;

public class NonNullCartValidator : ICartValidator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CartItem, Boolean> <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Validate>b__0_0(CartItem cartItem) { }

	}


	public NonNullCartValidator() { }

	[NullableContext(1)]
	public override void Validate(ICart cart) { }

}

