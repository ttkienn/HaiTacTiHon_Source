namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class EnumInfo
{
	public readonly bool IsFlags; //Field offset: 0x10
	public readonly UInt64[] Values; //Field offset: 0x18
	public readonly String[] Names; //Field offset: 0x20
	public readonly String[] ResolvedNames; //Field offset: 0x28

	public EnumInfo(bool isFlags, UInt64[] values, String[] names, String[] resolvedNames) { }

}

