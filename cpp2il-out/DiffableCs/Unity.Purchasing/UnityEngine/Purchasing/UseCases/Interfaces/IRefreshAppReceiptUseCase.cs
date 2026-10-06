namespace UnityEngine.Purchasing.UseCases.Interfaces;

internal interface IRefreshAppReceiptUseCase
{

	public void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	public void SetRefreshAppReceipt(bool refreshAppReceipt) { }

}

