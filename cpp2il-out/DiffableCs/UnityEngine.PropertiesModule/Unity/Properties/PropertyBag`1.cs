namespace Unity.Properties;

public abstract class PropertyBag : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; //Field offset: 0x0

	protected override InstantiationKind InstantiationKind
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	private override InstantiationKind Unity.Properties.IConstructor.InstantiationKind
	{
		private get { } //Length: 20
	}

	private static PropertyBag`1() { }

	protected PropertyBag`1() { }

	public override void Accept(ITypeVisitor visitor) { }

	[CompilerGenerated]
	protected override InstantiationKind get_InstantiationKind() { }

	protected override TContainer Instantiate() { }

	private override InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	private override TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	private override void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

}

