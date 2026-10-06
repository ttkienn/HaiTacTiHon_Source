namespace UnityEngine.UIElements;

public abstract class TypedUxmlAttributeDescription : UxmlAttributeDescription
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <defaultValue>k__BackingField; //Field offset: 0x0

	public T defaultValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected TypedUxmlAttributeDescription`1() { }

	[CompilerGenerated]
	public T get_defaultValue() { }

	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[CompilerGenerated]
	public void set_defaultValue(T value) { }

}

