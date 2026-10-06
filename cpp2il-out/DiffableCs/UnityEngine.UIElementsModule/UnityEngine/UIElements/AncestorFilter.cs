namespace UnityEngine.UIElements;

internal class AncestorFilter
{
	private CountingBloomFilter m_CountingBloomFilter; //Field offset: 0x10
	private Stack<Int32> m_HashStack; //Field offset: 0x4010

	public AncestorFilter() { }

	private void AddHash(int hash) { }

	public bool IsCandidate(StyleComplexSelector complexSel) { }

	public void PopElement() { }

	public void PushElement(VisualElement element) { }

}

