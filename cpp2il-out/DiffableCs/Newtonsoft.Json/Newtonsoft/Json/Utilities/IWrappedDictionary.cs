namespace Newtonsoft.Json.Utilities;

internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
{

	[Nullable(1)]
	public object UnderlyingDictionary
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	[NullableContext(1)]
	public object get_UnderlyingDictionary() { }

}

