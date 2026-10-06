namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class AggregateCartValidator : ICartValidator
{
	private readonly List<ICartValidator> m_CartValidators; //Field offset: 0x10

	public AggregateCartValidator(List<ICartValidator> cartValidators) { }

	public AggregateCartValidator(ICartValidator[] cartValidators) { }

	public override void Validate(ICart cart) { }

}

