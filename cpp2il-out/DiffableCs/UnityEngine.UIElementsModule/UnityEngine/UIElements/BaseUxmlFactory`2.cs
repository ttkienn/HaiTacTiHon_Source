namespace UnityEngine.UIElements;

public abstract class BaseUxmlFactory
{
	internal TTraits m_Traits; //Field offset: 0x0

	public override string uxmlName
	{
		 get { } //Length: 121
	}

	public override string uxmlNamespace
	{
		 get { } //Length: 156
	}

	public override string uxmlQualifiedName
	{
		 get { } //Length: 121
	}

	public override Type uxmlType
	{
		 get { } //Length: 88
	}

	protected BaseUxmlFactory`2() { }

	public override bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

	public override string get_uxmlName() { }

	public override string get_uxmlNamespace() { }

	public override string get_uxmlQualifiedName() { }

	public override Type get_uxmlType() { }

}

