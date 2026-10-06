namespace Newtonsoft.Json.Bson;

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
{
	private readonly List<BsonProperty> _children; //Field offset: 0x20

	public virtual BsonType Type
	{
		 get { } //Length: 3
	}

	public BsonObject() { }

	public void Add(string name, BsonToken token) { }

	public virtual BsonType get_Type() { }

	public override IEnumerator<BsonProperty> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

