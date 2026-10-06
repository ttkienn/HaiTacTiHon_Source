namespace Unity.Properties;

[Extension]
public static class TypeUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal StringBuilder <.cctor>b__11_0() { }

		internal void <.cctor>b__11_1(StringBuilder sb) { }

		internal string <.cctor>b__11_2() { }

	}

	private struct Cache
	{
		public static ITypeConstructor<T> TypeConstructor; //Field offset: 0x0

	}

	private interface ITypeConstructor
	{

		public bool CanBeInstantiated
		{
			 get { } //Length: 0
		}

		public bool get_CanBeInstantiated() { }

		public object Instantiate() { }

	}

	private interface ITypeConstructor : ITypeConstructor
	{

		public T Instantiate() { }

		public void SetExplicitConstructor(Func<T> constructor) { }

	}

	private class NonConstructable : ITypeConstructor
	{

		private override bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
		{
			private get { } //Length: 3
		}

		public NonConstructable() { }

		public override object Instantiate() { }

		private override bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	}

	private class TypeConstructor : ITypeConstructor<T>, ITypeConstructor
	{
		private Func<T> m_ExplicitConstructor; //Field offset: 0x0
		private Func<T> m_ImplicitConstructor; //Field offset: 0x0
		private IConstructor<T> m_OverrideConstructor; //Field offset: 0x0

		private override bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated
		{
			private get { } //Length: 137
		}

		public TypeConstructor`1() { }

		private static T CreateClassInstance() { }

		private static T CreateScriptableObjectInstance() { }

		private static T CreateValueTypeInstance() { }

		public override void SetExplicitConstructor(Func<T> constructor) { }

		private void SetImplicitConstructor() { }

		private override bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

		private override object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

		private override T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	}

	private class TypeConstructorVisitor : ITypeVisitor
	{
		public ITypeConstructor TypeConstructor; //Field offset: 0x10

		public TypeConstructorVisitor() { }

		public override void Visit() { }

	}

	private static readonly ConcurrentDictionary<Type, ITypeConstructor> s_TypeConstructors; //Field offset: 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; //Field offset: 0x8
	private static readonly ConcurrentDictionary<Type, String> s_CachedResolvedName; //Field offset: 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; //Field offset: 0x18
	private static readonly object syncedPoolObject; //Field offset: 0x20

	private static TypeUtility() { }

	public static bool CanBeInstantiated() { }

	public static bool CanBeInstantiated(Type type) { }

	private static void CheckCanBeInstantiated(ITypeConstructor<T> constructor) { }

	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	private static ITypeConstructor<T> CreateTypeConstructor() { }

	[Preserve]
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	[Extension]
	public static Type GetRootType(Type type) { }

	private static ITypeConstructor GetTypeConstructor(Type type) { }

	private static ITypeConstructor<T> GetTypeConstructor() { }

	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	public static string GetTypeDisplayName(Type type) { }

	public static T Instantiate() { }

	public static T Instantiate(Type derivedType) { }

	public static TArray InstantiateArray(int count = 0) { }

	public static TArray InstantiateArray(Type derivedType, int count = 0) { }

	public static void SetExplicitInstantiationMethod(Func<T> constructor) { }

	public static bool TryInstantiate(out T instance) { }

	public static bool TryInstantiate(Type derivedType, out T value) { }

	public static bool TryInstantiateArray(int count, out TArray instance) { }

}

