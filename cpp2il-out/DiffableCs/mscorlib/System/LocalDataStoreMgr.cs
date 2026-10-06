namespace System;

internal sealed class LocalDataStoreMgr
{
	private Boolean[] m_SlotInfoTable; //Field offset: 0x10
	private int m_FirstAvailableSlot; //Field offset: 0x18
	private List<LocalDataStore> m_ManagedLocalDataStores; //Field offset: 0x20
	private Dictionary<String, LocalDataStoreSlot> m_KeyToSlotMap; //Field offset: 0x28
	private long m_CookieGenerator; //Field offset: 0x30

	public LocalDataStoreMgr() { }

	public LocalDataStoreSlot AllocateDataSlot() { }

	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	public LocalDataStoreHolder CreateLocalDataStore() { }

	public void DeleteLocalDataStore(LocalDataStore store) { }

	internal void FreeDataSlot(int slot, long cookie) { }

	public void FreeNamedDataSlot(string name) { }

	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	internal int GetSlotTableLength() { }

	public void ValidateSlot(LocalDataStoreSlot slot) { }

}

