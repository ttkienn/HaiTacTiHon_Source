namespace System.Runtime.Serialization;

internal class ObjectHolderListEnumerator
{
	private bool m_isFixupEnumerator; //Field offset: 0x10
	private ObjectHolderList m_list; //Field offset: 0x18
	private int m_startingVersion; //Field offset: 0x20
	private int m_currPos; //Field offset: 0x24

	internal ObjectHolder Current
	{
		internal get { } //Length: 52
	}

	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator) { }

	internal ObjectHolder get_Current() { }

	internal bool MoveNext() { }

}

