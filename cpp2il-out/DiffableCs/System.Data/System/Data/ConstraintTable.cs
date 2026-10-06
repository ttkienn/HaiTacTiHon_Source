namespace System.Data;

internal sealed class ConstraintTable
{
	public DataTable table; //Field offset: 0x10
	public XmlSchemaIdentityConstraint constraint; //Field offset: 0x18

	public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c) { }

}

