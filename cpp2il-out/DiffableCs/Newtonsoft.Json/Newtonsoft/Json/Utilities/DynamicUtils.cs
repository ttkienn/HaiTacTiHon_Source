namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class DynamicUtils
{
	[Nullable(0)]
	public static class BinderWrapper
	{
		public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Nullable(2)]
		private static object _getCSharpArgumentInfoArray; //Field offset: 0x0
		[Nullable(2)]
		private static object _setCSharpArgumentInfoArray; //Field offset: 0x8
		[Nullable(2)]
		private static MethodCall<Object, Object> _getMemberCall; //Field offset: 0x10
		[Nullable(2)]
		private static MethodCall<Object, Object> _setMemberCall; //Field offset: 0x18
		private static bool _init; //Field offset: 0x20

		private static void CreateMemberCalls() { }

		private static object CreateSharpArgumentInfoArray(Int32[] values) { }

		public static CallSiteBinder GetMember(string name, Type context) { }

		private static void Init() { }

		public static CallSiteBinder SetMember(string name, Type context) { }

	}


	[Extension]
	public static IEnumerable<String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

