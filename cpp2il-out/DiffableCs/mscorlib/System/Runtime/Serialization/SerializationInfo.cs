namespace System.Runtime.Serialization;

[ComVisible(True)]
public sealed class SerializationInfo
{
	private const int defaultSize = 4; //Field offset: 0x0
	private const string s_mscorlibAssemblySimpleName = "mscorlib"; //Field offset: 0x0
	private const string s_mscorlibFileName = "mscorlib.dll"; //Field offset: 0x0
	internal String[] m_members; //Field offset: 0x10
	internal Object[] m_data; //Field offset: 0x18
	internal Type[] m_types; //Field offset: 0x20
	private Dictionary<String, Int32> m_nameToIndex; //Field offset: 0x28
	internal int m_currMember; //Field offset: 0x30
	internal IFormatterConverter m_converter; //Field offset: 0x38
	private string m_fullTypeName; //Field offset: 0x40
	private string m_assemName; //Field offset: 0x48
	private Type objectType; //Field offset: 0x50
	private bool isFullTypeNameSetExplicit; //Field offset: 0x58
	private bool isAssemblyNameSetExplicit; //Field offset: 0x59
	private bool requireSameTokenInPartialTrust; //Field offset: 0x5A

	public string AssemblyName
	{
		 get { } //Length: 5
	}

	public string FullTypeName
	{
		 get { } //Length: 5
	}

	public bool IsAssemblyNameSetExplicit
	{
		 get { } //Length: 5
	}

	public bool IsFullTypeNameSetExplicit
	{
		 get { } //Length: 5
	}

	public int MemberCount
	{
		 get { } //Length: 4
	}

	public Type ObjectType
	{
		 get { } //Length: 5
	}

	[CLSCompliant(False)]
	public SerializationInfo(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	public void AddValue(string name, DateTime value) { }

	public void AddValue(string name, float value) { }

	[CLSCompliant(False)]
	public void AddValue(string name, ulong value) { }

	public void AddValue(string name, long value) { }

	public void AddValue(string name, int value) { }

	public void AddValue(string name, short value) { }

	public void AddValue(string name, bool value) { }

	public void AddValue(string name, object value) { }

	public void AddValue(string name, object value, Type type) { }

	public void AddValue(string name, byte value) { }

	internal void AddValueInternal(string name, object value, Type type) { }

	private static bool Compare(Byte[] a, Byte[] b) { }

	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	private void ExpandArrays() { }

	private int FindElement(string name) { }

	public string get_AssemblyName() { }

	public string get_FullTypeName() { }

	public bool get_IsAssemblyNameSetExplicit() { }

	public bool get_IsFullTypeNameSetExplicit() { }

	public int get_MemberCount() { }

	public Type get_ObjectType() { }

	public bool GetBoolean(string name) { }

	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	private object GetElementNoThrow(string name, out Type foundType) { }

	public SerializationInfoEnumerator GetEnumerator() { }

	public int GetInt32(string name) { }

	public long GetInt64(string name) { }

	public float GetSingle(string name) { }

	public string GetString(string name) { }

	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	internal object GetValueNoThrow(string name, Type type) { }

	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	public void SetType(Type type) { }

	internal void UpdateValue(string name, object value, Type type) { }

}

