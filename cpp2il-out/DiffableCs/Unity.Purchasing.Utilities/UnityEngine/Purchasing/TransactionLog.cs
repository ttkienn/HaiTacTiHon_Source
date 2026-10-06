namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class TransactionLog : ITransactionLog
{
	[Nullable(2)]
	private readonly string m_PersistentDataPath; //Field offset: 0x10

	public TransactionLog(string persistentDataPath) { }

	public override void Clear() { }

	private static string ComputeHash(string transactionID) { }

	private static string GetRecordPath(string dataPath, string transactionID) { }

	public override bool HasRecordOf(string transactionID) { }

	public override void Record(string transactionID) { }

}

