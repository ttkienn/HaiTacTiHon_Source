namespace System.Data;

internal sealed class TypeLimiter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DataColumn, Type> <>9__10_0; //Field offset: 0x8
		public static Func<DataTable, IEnumerable`1<Type>> <>9__11_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

		internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

	}

	private sealed class Scope : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Type, Boolean> <>9__3_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <.ctor>b__3_0(Type type) { }

		}

		private static readonly HashSet<Type> s_allowedTypes; //Field offset: 0x0
		private HashSet<Type> m_allowedTypes; //Field offset: 0x10
		[Nullable(2)]
		private readonly Scope m_previousScope; //Field offset: 0x18

		private static Scope() { }

		internal Scope(Scope previousScope, IEnumerable<Type> allowedTypes) { }

		public override void Dispose() { }

		public bool IsAllowedType(Type type) { }

		private static bool IsTypeUnconditionallyAllowed(Type type) { }

	}

	[Nullable(2)]
	[ThreadStatic]
	private static Scope s_activeScope; //Field offset: 0x80000000
	private Scope m_instanceScope; //Field offset: 0x10

	private static bool IsTypeLimitingDisabled
	{
		private get { } //Length: 98
	}

	private TypeLimiter(Scope scope) { }

	[NullableContext(2)]
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter = null) { }

	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	private static bool get_IsTypeLimitingDisabled() { }

	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }

}

