namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class NoThrowGetBinderMember : GetMemberBinder
{
	private readonly GetMemberBinder _innerBinder; //Field offset: 0x28

	public NoThrowGetBinderMember(GetMemberBinder innerBinder) { }

	public virtual DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

