namespace UnityEngine.UIElements.UIR;

internal class BasicNodePool : LinkedPool<BasicNode`1<T>>
{

	public BasicNodePool`1() { }

	private static BasicNode<T> Create() { }

	private static void Reset(BasicNode<T> node) { }

}

