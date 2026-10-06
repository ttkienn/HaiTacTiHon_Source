namespace System.Data.Common;

internal sealed class SqlUdtStorage : DataStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal object <GetStaticNullForUdtType>b__0(Type t) { }

	}

	private static readonly ConcurrentDictionary<Type, Object> s_typeToNull; //Field offset: 0x0
	private Object[] _values; //Field offset: 0x50
	private readonly bool _implementsIXmlSerializable; //Field offset: 0x58
	private readonly bool _implementsIComparable; //Field offset: 0x59

	private static SqlUdtStorage() { }

	public SqlUdtStorage(DataColumn column, Type type) { }

	private SqlUdtStorage(DataColumn column, Type type, object nullValue) { }

	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	public virtual int Compare(int recordNo1, int recordNo2) { }

	public virtual int CompareValueTo(int recordNo1, object value) { }

	public virtual string ConvertObjectToXml(object value) { }

	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	public virtual object ConvertXmlToObject(string s) { }

	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	public virtual void Copy(int recordNo1, int recordNo2) { }

	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	public virtual object Get(int recordNo) { }

	protected virtual object GetEmptyStorage(int recordCount) { }

	internal static object GetStaticNullForUdtType(Type type) { }

	public virtual bool IsNull(int record) { }

	public virtual void Set(int recordNo, object value) { }

	public virtual void SetCapacity(int capacity) { }

	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

