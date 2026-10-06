namespace Unity.Properties;

public class HashSetPropertyBag : SetPropertyBagBase<HashSet`1<TElement>, TElement>
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public HashSetPropertyBag`1() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual HashSet<TElement> Instantiate() { }

}

