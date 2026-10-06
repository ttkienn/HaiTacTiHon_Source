namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyList : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

