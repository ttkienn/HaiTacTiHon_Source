namespace System.Runtime.Serialization;

internal sealed class MemberHolder
{
	internal readonly Type _memberType; //Field offset: 0x10
	internal readonly StreamingContext _context; //Field offset: 0x18

	internal MemberHolder(Type type, StreamingContext ctx) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

