namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class NoThrowSetBinderMember : SetMemberBinder
{
	private readonly SetMemberBinder _innerBinder; //Field offset: 0x28

	public NoThrowSetBinderMember(SetMemberBinder innerBinder) { }

	public virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

