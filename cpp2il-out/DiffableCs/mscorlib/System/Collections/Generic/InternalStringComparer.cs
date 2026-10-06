namespace System.Collections.Generic;

internal sealed class InternalStringComparer : EqualityComparer<String>
{

	public InternalStringComparer() { }

	public virtual bool Equals(string x, string y) { }

	public virtual int GetHashCode(string obj) { }

	internal virtual int IndexOf(String[] array, string value, int startIndex, int count) { }

}

