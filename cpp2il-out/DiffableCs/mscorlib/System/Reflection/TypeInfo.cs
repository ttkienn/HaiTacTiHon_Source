namespace System.Reflection;

public abstract class TypeInfo : Type, IReflectableType
{

	public override IEnumerable<Type> ImplementedInterfaces
	{
		 get { } //Length: 20
	}

	protected TypeInfo() { }

	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

