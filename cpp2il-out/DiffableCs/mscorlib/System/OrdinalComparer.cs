namespace System;

public class OrdinalComparer : StringComparer
{
	private readonly bool _ignoreCase; //Field offset: 0x10

	internal OrdinalComparer(bool ignoreCase) { }

	public virtual int Compare(string x, string y) { }

	public virtual bool Equals(string x, string y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(string obj) { }

	public virtual int GetHashCode() { }

}

