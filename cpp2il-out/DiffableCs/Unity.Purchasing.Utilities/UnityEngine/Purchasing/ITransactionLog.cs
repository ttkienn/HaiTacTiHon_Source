namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface ITransactionLog
{

	public void Clear() { }

	public bool HasRecordOf(string transactionID) { }

	public void Record(string transactionID) { }

}

