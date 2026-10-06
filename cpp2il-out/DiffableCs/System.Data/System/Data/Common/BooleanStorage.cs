namespace System.Data.Common;

internal sealed class BooleanStorage : DataStorage
{
	private Boolean[] _values; //Field offset: 0x50

	internal BooleanStorage(DataColumn column) { }

	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	public virtual int Compare(int recordNo1, int recordNo2) { }

	public virtual int CompareValueTo(int recordNo, object value) { }

	public virtual string ConvertObjectToXml(object value) { }

	public virtual object ConvertValue(object value) { }

	public virtual object ConvertXmlToObject(string s) { }

	public virtual void Copy(int recordNo1, int recordNo2) { }

	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	public virtual object Get(int record) { }

	protected virtual object GetEmptyStorage(int recordCount) { }

	public virtual void Set(int record, object value) { }

	public virtual void SetCapacity(int capacity) { }

	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

