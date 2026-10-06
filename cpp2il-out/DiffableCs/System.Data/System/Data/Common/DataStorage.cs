namespace System.Data.Common;

internal abstract class DataStorage
{
	private static readonly Type[] s_storageClassType; //Field offset: 0x0
	private static readonly Func<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_inspectTypeForInterfaces; //Field offset: 0x8
	private static readonly ConcurrentDictionary<Type, Tuple`4<Boolean, Boolean, Boolean, Boolean>> s_typeImplementsInterface; //Field offset: 0x10
	internal readonly DataColumn _column; //Field offset: 0x10
	internal readonly DataTable _table; //Field offset: 0x18
	internal readonly Type _dataType; //Field offset: 0x20
	internal readonly StorageType _storageTypeCode; //Field offset: 0x28
	private BitArray _dbNullBits; //Field offset: 0x30
	private readonly object _defaultValue; //Field offset: 0x38
	internal readonly object _nullValue; //Field offset: 0x40
	internal readonly bool _isCloneable; //Field offset: 0x48
	internal readonly bool _isCustomDefinedType; //Field offset: 0x49
	internal readonly bool _isStringType; //Field offset: 0x4A
	internal readonly bool _isValueType; //Field offset: 0x4B

	internal DataSetDateTime DateTimeMode
	{
		internal get { } //Length: 26
	}

	internal IFormatProvider FormatProvider
	{
		internal get { } //Length: 29
	}

	private static DataStorage() { }

	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	protected DataStorage(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	protected DataStorage(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	public override object Aggregate(Int32[] recordNos, AggregateType kind) { }

	public object AggregateCount(Int32[] recordNos) { }

	public abstract int Compare(int recordNo1, int recordNo2) { }

	protected int CompareBits(int recordNo1, int recordNo2) { }

	public abstract int CompareValueTo(int recordNo1, object value) { }

	public abstract string ConvertObjectToXml(object value) { }

	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	public override object ConvertValue(object value) { }

	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	public abstract object ConvertXmlToObject(string s) { }

	public abstract void Copy(int recordNo1, int recordNo2) { }

	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	public abstract object Get(int recordNo) { }

	internal DataSetDateTime get_DateTimeMode() { }

	internal IFormatProvider get_FormatProvider() { }

	protected object GetBits(int recordNo) { }

	protected abstract object GetEmptyStorage(int recordCount) { }

	internal object GetEmptyStorageInternal(int recordCount) { }

	internal static string GetQualifiedName(Type type) { }

	internal static StorageType GetStorageType(Type dataType) { }

	public override int GetStringLength(int record) { }

	internal static Type GetType(string value) { }

	internal static Type GetTypeStorage(StorageType storageType) { }

	protected bool HasValue(int recordNo) { }

	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	private static Tuple<Boolean, Boolean, Boolean, Boolean> InspectTypeForInterfaces(Type dataType) { }

	public override bool IsNull(int recordNo) { }

	public static bool IsObjectNull(object value) { }

	public static bool IsObjectSqlNull(object value) { }

	internal static bool IsSqlType(StorageType storageType) { }

	public static bool IsSqlType(Type dataType) { }

	internal static bool IsTypeCustomType(StorageType typeCode) { }

	internal static bool IsTypeCustomType(Type type) { }

	public abstract void Set(int recordNo, object value) { }

	public override void SetCapacity(int capacity) { }

	protected void SetNullBit(int recordNo, bool flag) { }

	protected void SetNullStorage(BitArray nullbits) { }

	protected abstract void SetStorage(object store, BitArray nullbits) { }

	internal void SetStorageInternal(object store, BitArray nullbits) { }

}

