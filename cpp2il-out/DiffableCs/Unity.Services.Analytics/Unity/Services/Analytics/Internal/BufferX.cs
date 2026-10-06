namespace Unity.Services.Analytics.Internal;

internal class BufferX : IBuffer, IBufferDebug
{
	private const long k_UploadBatchMaximumSizeInBytes = 4194304; //Field offset: 0x0
	private const string k_MillisecondDateFormat = "yyyy-MM-dd HH:mm:ss.fff zzz"; //Field offset: 0x0
	private readonly Byte[] k_WorkingBuffer; //Field offset: 0x10
	private readonly Char[] k_WorkingCharacterBuffer; //Field offset: 0x18
	private readonly Byte[] k_PayloadHeader; //Field offset: 0x20
	private readonly Byte[] k_HeaderEventName; //Field offset: 0x28
	private readonly Byte[] k_HeaderUserName; //Field offset: 0x30
	private readonly Byte[] k_HeaderSessionID; //Field offset: 0x38
	private readonly Byte[] k_HeaderEventUUID; //Field offset: 0x40
	private readonly Byte[] k_HeaderTimestamp; //Field offset: 0x48
	private readonly Byte[] k_HeaderEventVersion; //Field offset: 0x50
	private readonly Byte[] k_HeaderInstallationID; //Field offset: 0x58
	private readonly Byte[] k_HeaderPlayerID; //Field offset: 0x60
	private readonly Byte[] k_HeaderOpenEventParams; //Field offset: 0x68
	private readonly Byte[] k_CloseEvent; //Field offset: 0x70
	private readonly byte k_Quote; //Field offset: 0x78
	private readonly Byte[] k_QuoteColon; //Field offset: 0x80
	private readonly Byte[] k_QuoteComma; //Field offset: 0x88
	private readonly Byte[] k_Comma; //Field offset: 0x90
	private readonly Byte[] k_OpenBrace; //Field offset: 0x98
	private readonly Byte[] k_CloseBraceComma; //Field offset: 0xA0
	private readonly Byte[] k_OpenBracket; //Field offset: 0xA8
	private readonly Byte[] k_CloseBracketComma; //Field offset: 0xB0
	private readonly byte k_Colon; //Field offset: 0xB8
	private readonly byte k_Dash; //Field offset: 0xB9
	private readonly byte k_Space; //Field offset: 0xBA
	private readonly byte k_Point; //Field offset: 0xBB
	private readonly byte k_Positive; //Field offset: 0xBC
	private readonly byte k_Negative; //Field offset: 0xBD
	private readonly Byte[] k_True; //Field offset: 0xC0
	private readonly Byte[] k_False; //Field offset: 0xC8
	private readonly Byte[] k_Int2CharacterByte; //Field offset: 0xD0
	private readonly Int64[] k_Order; //Field offset: 0xD8
	private readonly IBufferSystemCalls m_SystemCalls; //Field offset: 0xE0
	private readonly IDiskCache m_DiskCache; //Field offset: 0xE8
	private readonly IIdentityManager m_UserIdentity; //Field offset: 0xF0
	private readonly ISessionManager m_Session; //Field offset: 0xF8
	private readonly List<EventSummary> m_EventSummaries; //Field offset: 0x100
	private string m_CurrentEventId; //Field offset: 0x108
	private string m_CurrentEventName; //Field offset: 0x110
	private DateTime m_CurrentEventTimestamp; //Field offset: 0x118
	private MemoryStream m_SpareBuffer; //Field offset: 0x120
	private MemoryStream m_Buffer; //Field offset: 0x128
	[CompilerGenerated]
	private Action<String, String, DateTime, Byte[]> EventRecorded; //Field offset: 0x130
	[CompilerGenerated]
	private Action<HashSet`1<String>> EventsClearing; //Field offset: 0x138
	[CompilerGenerated]
	private Action<HashSet`1<String>> EventsCleared; //Field offset: 0x140

	public override event Action<String, String, DateTime, Byte[]> EventRecorded
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public override event Action<HashSet`1<String>> EventsCleared
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public override event Action<HashSet`1<String>> EventsClearing
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	internal int EventsRecorded
	{
		internal get { } //Length: 63
	}

	internal IReadOnlyList<EventSummary> EventSummaries
	{
		internal get { } //Length: 8
	}

	public override int Length
	{
		 get { } //Length: 45
	}

	internal Byte[] RawContents
	{
		internal get { } //Length: 45
	}

	public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session) { }

	[CompilerGenerated]
	public override void add_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public override void add_EventsCleared(Action<HashSet`1<String>> value) { }

	[CompilerGenerated]
	public override void add_EventsClearing(Action<HashSet`1<String>> value) { }

	public override void ClearBuffer(long upTo) { }

	public override void ClearBuffer() { }

	public override void ClearDiskCache() { }

	public override void FlushToDisk() { }

	internal int get_EventsRecorded() { }

	internal IReadOnlyList<EventSummary> get_EventSummaries() { }

	public override int get_Length() { }

	internal Byte[] get_RawContents() { }

	public override void LoadFromDisk() { }

	private int ProcessCharacterOntoWorkingBuffer(int index, char character) { }

	public void PushArrayEnd() { }

	public void PushArrayStart(string name) { }

	public override void PushBool(string name, bool value) { }

	private void PushCommonEventStart(string name) { }

	public override void PushCustomEventStart(string name) { }

	public override void PushDouble(string name, double value) { }

	public override void PushEndEvent() { }

	public override void PushFloat(string name, float value) { }

	public override void PushInt(string name, int value) { }

	public override void PushInt64(string name, long value) { }

	public override void PushObject(string name, object value) { }

	public void PushObjectEnd() { }

	public void PushObjectStart(string name) { }

	public override void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items) { }

	public override void PushStandardEventStart(string name, int version) { }

	public override void PushString(string name, string value) { }

	public void PushTimestamp(string name, DateTime value) { }

	[CompilerGenerated]
	public override void remove_EventRecorded(Action<String, String, DateTime, Byte[]> value) { }

	[CompilerGenerated]
	public override void remove_EventsCleared(Action<HashSet`1<String>> value) { }

	[CompilerGenerated]
	public override void remove_EventsClearing(Action<HashSet`1<String>> value) { }

	public override Byte[] Serialize() { }

	internal static string SerializeDateTime(DateTime dateTime) { }

	private int SerializeLong(in long number, in Byte[] buffer, in int startIndex, in int minimumLength) { }

	private void StripTrailingCommaIfNecessary() { }

	private void WriteByte(in byte value) { }

	private void WriteBytes(in Byte[] bytes) { }

	private void WriteDateTime(DateTime dateTime) { }

	private void WriteLong(in long value) { }

	private void WriteName(string name) { }

	private void WriteString(in string value) { }

}

