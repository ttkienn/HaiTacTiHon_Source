namespace System.Collections.Specialized;

internal class CompatibleComparer : IEqualityComparer
{
	private static IComparer defaultComparer; //Field offset: 0x0
	private static IHashCodeProvider defaultHashProvider; //Field offset: 0x8
	private IComparer _comparer; //Field offset: 0x10
	private IHashCodeProvider _hcp; //Field offset: 0x18

	public IComparer Comparer
	{
		 get { } //Length: 5
	}

	public static IComparer DefaultComparer
	{
		 get { } //Length: 229
	}

	public static IHashCodeProvider DefaultHashCodeProvider
	{
		 get { } //Length: 236
	}

	public IHashCodeProvider HashCodeProvider
	{
		 get { } //Length: 5
	}

	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	public override bool Equals(object a, object b) { }

	public IComparer get_Comparer() { }

	public static IComparer get_DefaultComparer() { }

	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

	public IHashCodeProvider get_HashCodeProvider() { }

	public override int GetHashCode(object obj) { }

}

