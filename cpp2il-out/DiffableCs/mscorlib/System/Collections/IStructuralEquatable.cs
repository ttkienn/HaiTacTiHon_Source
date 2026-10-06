namespace System.Collections;

public interface IStructuralEquatable
{

	public bool Equals(object other, IEqualityComparer comparer) { }

	public int GetHashCode(IEqualityComparer comparer) { }

}

