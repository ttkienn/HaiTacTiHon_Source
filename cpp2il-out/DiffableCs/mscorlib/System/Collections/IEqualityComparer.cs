namespace System.Collections;

public interface IEqualityComparer
{

	public bool Equals(object x, object y) { }

	public int GetHashCode(object obj) { }

}

