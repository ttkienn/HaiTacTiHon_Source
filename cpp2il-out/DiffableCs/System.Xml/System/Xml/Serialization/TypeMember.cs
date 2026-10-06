namespace System.Xml.Serialization;

internal sealed class TypeMember
{
	private Type type; //Field offset: 0x10
	private string member; //Field offset: 0x18

	internal TypeMember(Type type, string member) { }

	public virtual bool Equals(object obj) { }

	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

