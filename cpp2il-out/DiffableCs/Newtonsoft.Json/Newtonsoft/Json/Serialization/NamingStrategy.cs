namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class NamingStrategy
{
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; //Field offset: 0x12

	public bool OverrideSpecifiedNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool ProcessDictionaryKeys
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool ProcessExtensionDataNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected NamingStrategy() { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	[NullableContext(2)]
	protected bool Equals(NamingStrategy other) { }

	[CompilerGenerated]
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	public bool get_ProcessExtensionDataNames() { }

	public override string GetDictionaryKey(string key) { }

	public override string GetExtensionDataName(string name) { }

	public virtual int GetHashCode() { }

	public override string GetPropertyName(string name, bool hasSpecifiedName) { }

	protected abstract string ResolvePropertyName(string name) { }

	[CompilerGenerated]
	public void set_OverrideSpecifiedNames(bool value) { }

	[CompilerGenerated]
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	public void set_ProcessExtensionDataNames(bool value) { }

}

