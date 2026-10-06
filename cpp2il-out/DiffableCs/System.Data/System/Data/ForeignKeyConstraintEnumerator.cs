namespace System.Data;

internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
{

	public ForeignKeyConstraintEnumerator(DataSet dataSet) { }

	public ForeignKeyConstraint GetForeignKeyConstraint() { }

	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

