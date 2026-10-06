namespace System.Collections;

internal sealed class CompatibleComparer : IEqualityComparer
{
	private readonly IHashCodeProvider _hcp; //Field offset: 0x10
	private readonly IComparer _comparer; //Field offset: 0x18

	internal IComparer Comparer
	{
		internal get { } //Length: 5
	}

	internal IHashCodeProvider HashCodeProvider
	{
		internal get { } //Length: 5
	}

	internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	public int Compare(object a, object b) { }

	public override bool Equals(object a, object b) { }

	internal IComparer get_Comparer() { }

	internal IHashCodeProvider get_HashCodeProvider() { }

	public override int GetHashCode(object obj) { }

}

