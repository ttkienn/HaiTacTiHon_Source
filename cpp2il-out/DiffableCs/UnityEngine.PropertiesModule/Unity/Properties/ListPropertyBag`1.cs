namespace Unity.Properties;

public class ListPropertyBag : IndexedCollectionPropertyBag<List`1<TElement>, TElement>
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public ListPropertyBag`1() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual List<TElement> Instantiate() { }

	protected virtual List<TElement> InstantiateWithCount(int count) { }

}

