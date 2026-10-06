namespace System.Resources;

[ComVisible(True)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	public sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ResourceReader _reader; //Field offset: 0x10
		private bool _currentIsValid; //Field offset: 0x18
		private int _currentName; //Field offset: 0x1C
		private int _dataPosition; //Field offset: 0x20

		public override object Current
		{
			 get { } //Length: 84
		}

		internal int DataPosition
		{
			internal get { } //Length: 4
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 998
		}

		public override object Key
		{
			 get { } //Length: 340
		}

		public override object Value
		{
			 get { } //Length: 336
		}

		internal ResourceEnumerator(ResourceReader reader) { }

		public override object get_Current() { }

		internal int get_DataPosition() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private BinaryReader _store; //Field offset: 0x10
	internal Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x18
	private long _nameSectionOffset; //Field offset: 0x20
	private long _dataSectionOffset; //Field offset: 0x28
	private Int32[] _nameHashes; //Field offset: 0x30
	private Int32* _nameHashesPtr; //Field offset: 0x38
	private Int32[] _namePositions; //Field offset: 0x40
	private Int32* _namePositionsPtr; //Field offset: 0x48
	private RuntimeType[] _typeTable; //Field offset: 0x50
	private Int32[] _typeNamePositions; //Field offset: 0x58
	private BinaryFormatter _objFormatter; //Field offset: 0x60
	private int _numResources; //Field offset: 0x68
	private UnmanagedMemoryStream _ums; //Field offset: 0x70
	private int _version; //Field offset: 0x78

	private object _LoadObjectV1(int pos) { }

	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	private void _ReadResources() { }

	internal ResourceReader(Stream stream, Dictionary<String, ResourceLocator> resCache) { }

	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	public override void Close() { }

	private bool CompareStringEqualsName(string name) { }

	private object DeserializeObject(int typeIndex) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	internal int FindPosForResource(string name) { }

	private RuntimeType FindType(int typeIndex) { }

	public override IDictionaryEnumerator GetEnumerator() { }

	internal ResourceEnumerator GetEnumeratorInternal() { }

	private int GetNameHash(int index) { }

	private int GetNamePosition(int index) { }

	private object GetValueForNameIndex(int index) { }

	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	internal object LoadObject(int pos) { }

	internal object LoadObjectV1(int pos) { }

	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	internal string LoadString(int pos) { }

	private void ReadResources() { }

	internal static int ReadUnalignedI4(Int32* p) { }

	private void SkipString() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

