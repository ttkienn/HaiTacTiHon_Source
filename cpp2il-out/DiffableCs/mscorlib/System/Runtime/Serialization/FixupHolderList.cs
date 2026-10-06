namespace System.Runtime.Serialization;

internal class FixupHolderList
{
	internal FixupHolder[] m_values; //Field offset: 0x10
	internal int m_count; //Field offset: 0x18

	internal FixupHolderList() { }

	internal FixupHolderList(int startingSize) { }

	internal override void Add(FixupHolder fixup) { }

	private void EnlargeArray() { }

}

