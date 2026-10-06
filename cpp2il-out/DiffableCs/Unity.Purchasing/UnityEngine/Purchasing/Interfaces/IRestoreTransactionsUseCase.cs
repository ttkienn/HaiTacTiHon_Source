namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(2)]
internal interface IRestoreTransactionsUseCase
{

	public void RestoreTransactions(Action<Boolean, String> callback) { }

}

