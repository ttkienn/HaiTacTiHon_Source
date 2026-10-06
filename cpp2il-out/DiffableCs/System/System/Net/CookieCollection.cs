namespace System.Net;

[DefaultMember("Item")]
public class CookieCollection : ICollection, IEnumerable
{
	private class CookieCollectionEnumerator : IEnumerator
	{
		private CookieCollection m_cookies; //Field offset: 0x10
		private int m_count; //Field offset: 0x18
		private int m_index; //Field offset: 0x1C
		private int m_version; //Field offset: 0x20

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 247
		}

		internal CookieCollectionEnumerator(CookieCollection cookies) { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override bool System.Collections.IEnumerator.MoveNext() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	public enum Stamp
	{
		Check = 0,
		Set = 1,
		SetToUnused = 2,
		SetToMaxUsed = 3,
	}

	internal int m_version; //Field offset: 0x10
	private ArrayList m_list; //Field offset: 0x18
	private DateTime m_TimeStamp; //Field offset: 0x20
	private bool m_has_other_versions; //Field offset: 0x28
	[OptionalField]
	private bool m_IsReadOnly; //Field offset: 0x29

	public override int Count
	{
		 get { } //Length: 42
	}

	internal bool IsOtherVersionSeen
	{
		internal get { } //Length: 5
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public Cookie Item
	{
		 get { } //Length: 243
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public CookieCollection() { }

	public void Add(Cookie cookie) { }

	public void Add(CookieCollection cookies) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	internal bool get_IsOtherVersionSeen() { }

	public override bool get_IsSynchronized() { }

	public Cookie get_Item(int index) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	internal int IndexOf(Cookie cookie) { }

	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	internal void RemoveAt(int idx) { }

	internal DateTime TimeStamp(Stamp how) { }

}

