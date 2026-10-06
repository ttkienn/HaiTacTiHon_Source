namespace System;

[ComVisible(True)]
public sealed class LocalDataStoreSlot
{
	private LocalDataStoreMgr m_mgr; //Field offset: 0x10
	private int m_slot; //Field offset: 0x18
	private long m_cookie; //Field offset: 0x20

	internal long Cookie
	{
		internal get { } //Length: 5
	}

	internal LocalDataStoreMgr Manager
	{
		internal get { } //Length: 5
	}

	internal int Slot
	{
		internal get { } //Length: 4
	}

	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) { }

	protected virtual void Finalize() { }

	internal long get_Cookie() { }

	internal LocalDataStoreMgr get_Manager() { }

	internal int get_Slot() { }

}

