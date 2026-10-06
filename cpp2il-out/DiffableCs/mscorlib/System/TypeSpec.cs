namespace System;

internal class TypeSpec
{
	[Flags]
	public enum DisplayNameFormat
	{
		Default = 0,
		WANT_ASSEMBLY = 1,
		NO_MODIFIERS = 2,
	}

	private TypeIdentifier name; //Field offset: 0x10
	private string assembly_name; //Field offset: 0x18
	private List<TypeIdentifier> nested; //Field offset: 0x20
	private List<TypeSpec> generic_params; //Field offset: 0x28
	private List<ModifierSpec> modifier_spec; //Field offset: 0x30
	private bool is_byref; //Field offset: 0x38
	private string display_fullname; //Field offset: 0x40

	internal string DisplayFullName
	{
		internal get { } //Length: 62
	}

	internal bool HasModifiers
	{
		internal get { } //Length: 9
	}

	public TypeSpec() { }

	private void AddModifier(ModifierSpec md) { }

	private void AddName(string type_name) { }

	private static void BoundCheck(int idx, string s) { }

	internal string get_DisplayFullName() { }

	internal bool get_HasModifiers() { }

	private string GetDisplayFullName(DisplayNameFormat flags) { }

	private StringBuilder GetModifierString(StringBuilder sb) { }

	internal static TypeSpec Parse(string typeName) { }

	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	private static void SkipSpace(string name, ref int pos) { }

	internal static string UnescapeInternalName(string displayName) { }

}

