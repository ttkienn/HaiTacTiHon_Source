namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Nullable(0)]
		public ConstructorInfo c; //Field offset: 0x10
		[Nullable(0)]
		public MethodBase method; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal object <CreateParameterizedConstructor>b__0(Object[] a) { }

		internal object <CreateParameterizedConstructor>b__1(Object[] a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(0)]
		public ConstructorInfo c; //Field offset: 0x0
		[Nullable(0)]
		public MethodBase method; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		[NullableContext(0)]
		internal object <CreateMethodCall>b__0(T o, Object[] a) { }

		[NullableContext(0)]
		internal object <CreateMethodCall>b__1(T o, Object[] a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(0)]
		public Type type; //Field offset: 0x0
		[Nullable(0)]
		public ConstructorInfo constructorInfo; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		[NullableContext(0)]
		internal T <CreateDefaultConstructor>b__0() { }

		[NullableContext(0)]
		internal T <CreateDefaultConstructor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		[Nullable(0)]
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		[NullableContext(0)]
		internal object <CreateGet>b__0(T o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		[Nullable(0)]
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

		[NullableContext(0)]
		internal object <CreateGet>b__0(T o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		[Nullable(0)]
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass8_0`1() { }

		[NullableContext(0)]
		internal void <CreateSet>b__0(T o, object v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass9_0`1() { }

		[NullableContext(0)]
		internal void <CreateSet>b__0(T o, object v) { }

	}

	private static readonly LateBoundReflectionDelegateFactory _instance; //Field offset: 0x0

	internal static ReflectionDelegateFactory Instance
	{
		internal get { } //Length: 78
	}

	private static LateBoundReflectionDelegateFactory() { }

	public LateBoundReflectionDelegateFactory() { }

	public virtual Func<T> CreateDefaultConstructor(Type type) { }

	public virtual Func<T, Object> CreateGet(PropertyInfo propertyInfo) { }

	public virtual Func<T, Object> CreateGet(FieldInfo fieldInfo) { }

	public virtual MethodCall<T, Object> CreateMethodCall(MethodBase method) { }

	public virtual ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method) { }

	public virtual Action<T, Object> CreateSet(FieldInfo fieldInfo) { }

	public virtual Action<T, Object> CreateSet(PropertyInfo propertyInfo) { }

	internal static ReflectionDelegateFactory get_Instance() { }

}

