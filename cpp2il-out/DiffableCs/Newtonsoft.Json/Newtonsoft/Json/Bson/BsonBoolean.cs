namespace Newtonsoft.Json.Bson;

internal class BsonBoolean : BsonValue
{
	public static readonly BsonBoolean False; //Field offset: 0x0
	public static readonly BsonBoolean True; //Field offset: 0x8

	private static BsonBoolean() { }

	private BsonBoolean(bool value) { }

}

