namespace Newtonsoft.Json.Bson;

internal abstract class BsonToken
{
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <CalculatedSize>k__BackingField; //Field offset: 0x18

	public int CalculatedSize
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BsonToken Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public abstract BsonType Type
	{
		 get { } //Length: 0
	}

	protected BsonToken() { }

	[CompilerGenerated]
	public int get_CalculatedSize() { }

	[CompilerGenerated]
	public BsonToken get_Parent() { }

	public abstract BsonType get_Type() { }

	[CompilerGenerated]
	public void set_CalculatedSize(int value) { }

	[CompilerGenerated]
	public void set_Parent(BsonToken value) { }

}

