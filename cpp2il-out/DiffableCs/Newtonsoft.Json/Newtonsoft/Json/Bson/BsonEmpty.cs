namespace Newtonsoft.Json.Bson;

internal class BsonEmpty : BsonToken
{
	public static readonly BsonToken Null; //Field offset: 0x0
	public static readonly BsonToken Undefined; //Field offset: 0x8
	[CompilerGenerated]
	private readonly BsonType <Type>k__BackingField; //Field offset: 0x20

	public virtual BsonType Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static BsonEmpty() { }

	private BsonEmpty(BsonType type) { }

	[CompilerGenerated]
	public virtual BsonType get_Type() { }

}

