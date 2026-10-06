namespace System;

[ComVisible(True)]
public abstract class ValueType
{

	protected ValueType() { }

	internal static bool DefaultEquals(object o1, object o2) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	private static bool InternalEquals(object o1, object o2, out Object[] fields) { }

	internal static int InternalGetHashCode(object o, out Object[] fields) { }

	public virtual string ToString() { }

}

