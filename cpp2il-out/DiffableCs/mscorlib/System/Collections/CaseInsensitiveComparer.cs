namespace System.Collections;

public class CaseInsensitiveComparer : IComparer
{
	private CompareInfo _compareInfo; //Field offset: 0x10

	public static CaseInsensitiveComparer Default
	{
		 get { } //Length: 236
	}

	public CaseInsensitiveComparer() { }

	public CaseInsensitiveComparer(CultureInfo culture) { }

	public override int Compare(object a, object b) { }

	public static CaseInsensitiveComparer get_Default() { }

}

