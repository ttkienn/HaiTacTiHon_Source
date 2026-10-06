namespace System.Xml.Schema;

internal sealed class ConstraintStruct
{
	internal CompiledIdentityConstraint constraint; //Field offset: 0x10
	internal SelectorActiveAxis axisSelector; //Field offset: 0x18
	internal ArrayList axisFields; //Field offset: 0x20
	internal Hashtable qualifiedTable; //Field offset: 0x28
	internal Hashtable keyrefTable; //Field offset: 0x30
	private int tableDim; //Field offset: 0x38

	internal int TableDim
	{
		internal get { } //Length: 4
	}

	internal ConstraintStruct(CompiledIdentityConstraint constraint) { }

	internal int get_TableDim() { }

}

