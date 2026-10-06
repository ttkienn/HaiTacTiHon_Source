namespace System.Data;

internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	private readonly DataTable _table; //Field offset: 0x28

	public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) { }

	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

