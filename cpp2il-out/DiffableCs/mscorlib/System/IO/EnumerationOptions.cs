namespace System.IO;

public class EnumerationOptions
{
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private int <BufferSize>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; //Field offset: 0x24

	public FileAttributes AttributesToSkip
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int BufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal static EnumerationOptions Compatible
	{
		[CompilerGenerated]
		internal get { } //Length: 78
	}

	internal static EnumerationOptions Default
	{
		[CompilerGenerated]
		internal get { } //Length: 79
	}

	public bool IgnoreInaccessible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MatchCasing MatchCasing
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public MatchType MatchType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool RecurseSubdirectories
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool ReturnSpecialDirectories
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static EnumerationOptions() { }

	public EnumerationOptions() { }

	[CompilerGenerated]
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	public int get_BufferSize() { }

	[CompilerGenerated]
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	internal static EnumerationOptions get_Default() { }

	[CompilerGenerated]
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	public bool get_ReturnSpecialDirectories() { }

	[CompilerGenerated]
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	public void set_RecurseSubdirectories(bool value) { }

}

