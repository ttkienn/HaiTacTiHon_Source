namespace UnityEngine.Bindings;

[AttributeUsage(28)]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Header>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <IntermediateScriptingStructName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private CodegenOptions <CodegenOptions>k__BackingField; //Field offset: 0x20

	public override CodegenOptions CodegenOptions
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string Header
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public string IntermediateScriptingStructName
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public NativeTypeAttribute() { }

	public NativeTypeAttribute(CodegenOptions codegenOptions) { }

	public NativeTypeAttribute(string header) { }

	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName) { }

	[CompilerGenerated]
	public override void set_CodegenOptions(CodegenOptions value) { }

	[CompilerGenerated]
	public override void set_Header(string value) { }

	[CompilerGenerated]
	public void set_IntermediateScriptingStructName(string value) { }

}

