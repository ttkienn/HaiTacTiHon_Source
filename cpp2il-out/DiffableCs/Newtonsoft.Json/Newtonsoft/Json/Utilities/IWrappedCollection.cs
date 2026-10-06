namespace Newtonsoft.Json.Utilities;

internal interface IWrappedCollection : IList, ICollection, IEnumerable
{

	[Nullable(1)]
	public object UnderlyingCollection
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	[NullableContext(1)]
	public object get_UnderlyingCollection() { }

}

