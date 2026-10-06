namespace System.Runtime.Serialization;

internal class ObjectHolderList
{
	internal ObjectHolder[] m_values; //Field offset: 0x10
	internal int m_count; //Field offset: 0x18

	internal int Count
	{
		internal get { } //Length: 4
	}

	internal int Version
	{
		internal get { } //Length: 4
	}

	internal ObjectHolderList() { }

	internal ObjectHolderList(int startingSize) { }

	internal override void Add(ObjectHolder value) { }

	private void EnlargeArray() { }

	internal int get_Count() { }

	internal int get_Version() { }

	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

}

