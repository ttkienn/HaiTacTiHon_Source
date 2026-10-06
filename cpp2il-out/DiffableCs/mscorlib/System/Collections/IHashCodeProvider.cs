namespace System.Collections;

[Obsolete("Please use IEqualityComparer instead.")]
public interface IHashCodeProvider
{

	public int GetHashCode(object obj) { }

}

