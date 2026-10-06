namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class ImmutableCollectionsUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__24_1; //Field offset: 0x8
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[Nullable(0)]
	public class ImmutableCollectionTypeInfo
	{
		[CompilerGenerated]
		private string <ContractTypeName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <CreatedTypeName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <BuilderTypeName>k__BackingField; //Field offset: 0x20

		public string BuilderTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public string ContractTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public string CreatedTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName) { }

		[CompilerGenerated]
		public string get_BuilderTypeName() { }

		[CompilerGenerated]
		public string get_ContractTypeName() { }

		[CompilerGenerated]
		public string get_CreatedTypeName() { }

		[CompilerGenerated]
		public void set_BuilderTypeName(string value) { }

		[CompilerGenerated]
		public void set_ContractTypeName(string value) { }

		[CompilerGenerated]
		public void set_CreatedTypeName(string value) { }

	}

	private const string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1"; //Field offset: 0x0
	private const string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary"; //Field offset: 0x0
	private const string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2"; //Field offset: 0x0
	private const string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary"; //Field offset: 0x0
	private const string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2"; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; //Field offset: 0x0
	private const string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1"; //Field offset: 0x0
	private const string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet"; //Field offset: 0x0
	private const string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1"; //Field offset: 0x0
	private const string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet"; //Field offset: 0x0
	private const string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2"; //Field offset: 0x0
	private const string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1"; //Field offset: 0x0
	private const string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1"; //Field offset: 0x0
	private const string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue"; //Field offset: 0x0
	private const string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1"; //Field offset: 0x0
	private const string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList"; //Field offset: 0x0
	private const string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1"; //Field offset: 0x0
	private const string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray"; //Field offset: 0x0
	private const string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1"; //Field offset: 0x0
	private const string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1"; //Field offset: 0x0
	private const string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1"; //Field offset: 0x0
	private const string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack"; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; //Field offset: 0x8

	private static ImmutableCollectionsUtils() { }

	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

}

