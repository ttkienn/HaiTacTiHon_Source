namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class BidirectionalDictionary
{
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; //Field offset: 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; //Field offset: 0x0
	private readonly string _duplicateFirstErrorMessage; //Field offset: 0x0
	private readonly string _duplicateSecondErrorMessage; //Field offset: 0x0

	public BidirectionalDictionary`2() { }

	public BidirectionalDictionary`2(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) { }

	public BidirectionalDictionary`2(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	public void Set(TFirst first, TSecond second) { }

	public bool TryGetByFirst(TFirst first, out TSecond second) { }

	public bool TryGetBySecond(TSecond second, out TFirst first) { }

}

