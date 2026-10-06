namespace Unity.Services.Analytics.Internal;

internal interface IBuffer
{

	public int Length
	{
		 get { } //Length: 0
	}

	public void ClearBuffer(long upTo) { }

	public void ClearBuffer() { }

	public void ClearDiskCache() { }

	public void FlushToDisk() { }

	public int get_Length() { }

	public void LoadFromDisk() { }

	public void PushBool(string name, bool value) { }

	public void PushCustomEventStart(string name) { }

	public void PushDouble(string name, double value) { }

	public void PushEndEvent() { }

	public void PushFloat(string name, float value) { }

	public void PushInt(string name, int value) { }

	public void PushInt64(string name, long value) { }

	public void PushObject(string name, object value) { }

	public void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items) { }

	public void PushStandardEventStart(string name, int version) { }

	public void PushString(string name, string value) { }

	public Byte[] Serialize() { }

}

