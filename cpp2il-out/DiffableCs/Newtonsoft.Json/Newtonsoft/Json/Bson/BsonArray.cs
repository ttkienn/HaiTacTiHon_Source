namespace Newtonsoft.Json.Bson;

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
{
	private readonly List<BsonToken> _children; //Field offset: 0x20

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public BsonArray() { }

	public void Add(BsonToken token) { }

	public virtual BsonType get_Type() { }

	public override IEnumerator<BsonToken> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

