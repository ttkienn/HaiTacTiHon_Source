namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal abstract class JsonSerializerInternalBase
{
	[NullableContext(0)]
	private class ReferenceEqualsEqualityComparer : IEqualityComparer<Object>
	{

		public ReferenceEqualsEqualityComparer() { }

		[NullableContext(2)]
		private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

		[NullableContext(1)]
		private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	}

	[Nullable(2)]
	private ErrorContext _currentErrorContext; //Field offset: 0x10
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private BidirectionalDictionary<String, Object> _mappings; //Field offset: 0x18
	internal readonly JsonSerializer Serializer; //Field offset: 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; //Field offset: 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; //Field offset: 0x30

	internal BidirectionalDictionary<String, Object> DefaultReferenceMappings
	{
		internal get { } //Length: 497
	}

	protected JsonSerializerInternalBase(JsonSerializer serializer) { }

	protected void ClearErrorContext() { }

	internal BidirectionalDictionary<String, Object> get_DefaultReferenceMappings() { }

	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	[NullableContext(2)]
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

}

