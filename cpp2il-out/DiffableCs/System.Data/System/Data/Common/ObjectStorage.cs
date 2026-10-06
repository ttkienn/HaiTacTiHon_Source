namespace System.Data.Common;

internal sealed class ObjectStorage : DataStorage
{
	private enum Families
	{
		DATETIME = 0,
		NUMBER = 1,
		STRING = 2,
		BOOLEAN = 3,
		ARRAY = 4,
	}

	private class TempAssemblyComparer : IEqualityComparer<KeyValuePair`2<Type, XmlRootAttribute>>
	{
		internal static readonly IEqualityComparer<KeyValuePair`2<Type, XmlRootAttribute>> s_default; //Field offset: 0x0

		private static TempAssemblyComparer() { }

		private TempAssemblyComparer() { }

		public override bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

		public override int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	}

	private static readonly object s_defaultValue; //Field offset: 0x0
	private static readonly object s_tempAssemblyCacheLock; //Field offset: 0x8
	private static Dictionary<KeyValuePair`2<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; //Field offset: 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; //Field offset: 0x18
	private Object[] _values; //Field offset: 0x50
	private readonly bool _implementsIXmlSerializable; //Field offset: 0x58

	private static ObjectStorage() { }

	internal ObjectStorage(DataColumn column, Type type) { }

	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	public virtual int Compare(int recordNo1, int recordNo2) { }

	private int CompareTo(object valueNo1, object valueNo2) { }

	public virtual int CompareValueTo(int recordNo1, object value) { }

	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	public virtual string ConvertObjectToXml(object value) { }

	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	public virtual object ConvertXmlToObject(string s) { }

	public virtual void Copy(int recordNo1, int recordNo2) { }

	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	public virtual object Get(int recordNo) { }

	protected virtual object GetEmptyStorage(int recordCount) { }

	private Families GetFamily(Type dataType) { }

	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	internal static XmlSerializer GetXmlSerializer(Type type) { }

	public virtual bool IsNull(int record) { }

	public virtual void Set(int recordNo, object value) { }

	public virtual void SetCapacity(int capacity) { }

	protected virtual void SetStorage(object store, BitArray nullbits) { }

	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

}

