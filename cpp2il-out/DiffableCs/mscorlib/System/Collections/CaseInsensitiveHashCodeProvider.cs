namespace System.Collections;

[Obsolete("Please use StringComparer instead.")]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
{
	private readonly CompareInfo _compareInfo; //Field offset: 0x10

	public static CaseInsensitiveHashCodeProvider Default
	{
		 get { } //Length: 173
	}

	public CaseInsensitiveHashCodeProvider() { }

	public CaseInsensitiveHashCodeProvider(CultureInfo culture) { }

	public static CaseInsensitiveHashCodeProvider get_Default() { }

	public override int GetHashCode(object obj) { }

}

