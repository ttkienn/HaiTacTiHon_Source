namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct JEnumerable : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable`1<T>>
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
	public static readonly JEnumerable<T> Empty; //Field offset: 0x0
	private readonly IEnumerable<T> _enumerable; //Field offset: 0x0

	public override IJEnumerable<JToken> Item
	{
		 get { } //Length: 287
	}

	private static JEnumerable`1() { }

	public JEnumerable`1(IEnumerable<T> enumerable) { }

	public override bool Equals(JEnumerable<T> other) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public override IJEnumerable<JToken> get_Item(object key) { }

	public override IEnumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

