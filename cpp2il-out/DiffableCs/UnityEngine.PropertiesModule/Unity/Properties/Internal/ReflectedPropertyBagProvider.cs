namespace Unity.Properties.Internal;

internal class ReflectedPropertyBagProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MethodInfo, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<MemberInfo, Int32> <>9__22_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__10_0(MethodInfo x) { }

		internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MemberInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Type type; //Field offset: 0x28
		public Type <>3__type; //Field offset: 0x30
		private IOrderedEnumerable<MemberInfo> <members>5__1; //Field offset: 0x38
		private IEnumerator<MemberInfo> <>s__2; //Field offset: 0x40
		private MemberInfo <member>5__3; //Field offset: 0x48
		private bool <hasDontCreatePropertyAttribute>5__4; //Field offset: 0x50
		private bool <hasCreatePropertyAttribute>5__5; //Field offset: 0x51
		private bool <hasNonSerializedAttribute>5__6; //Field offset: 0x52
		private bool <hasSerializedFieldAttribute>5__7; //Field offset: 0x53
		private FieldInfo <field>5__8; //Field offset: 0x58

		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetPropertyMembers>d__22(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly MethodInfo m_CreatePropertyMethod; //Field offset: 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; //Field offset: 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; //Field offset: 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; //Field offset: 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; //Field offset: 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; //Field offset: 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; //Field offset: 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; //Field offset: 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; //Field offset: 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; //Field offset: 0x58

	public ReflectedPropertyBagProvider() { }

	[Preserve]
	private IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	[Preserve]
	private IPropertyBag<Dictionary`2<TKey, TValue>> CreateDictionaryPropertyBag() { }

	[Preserve]
	private IPropertyBag<HashSet`1<TElement>> CreateHashSetPropertyBag() { }

	[Preserve]
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	[Preserve]
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	[Preserve]
	private IPropertyBag<KeyValuePair`2<TKey, TValue>> CreateKeyValuePairPropertyBag() { }

	[Preserve]
	private IPropertyBag<List`1<TElement>> CreateListPropertyBag() { }

	[Preserve]
	private void CreateProperty(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }

	public IPropertyBag CreatePropertyBag(Type type) { }

	public IPropertyBag<TContainer> CreatePropertyBag() { }

	[Preserve]
	private IPropertyBag<TSet> CreateSetPropertyBag() { }

	[IteratorStateMachine(typeof(<GetPropertyMembers>d__22))]
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	private static bool IsValidMember(MemberInfo memberInfo) { }

	private static bool IsValidPropertyType(Type type) { }

}

