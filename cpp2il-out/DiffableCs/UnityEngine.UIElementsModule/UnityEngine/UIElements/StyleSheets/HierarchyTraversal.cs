namespace UnityEngine.UIElements.StyleSheets;

internal abstract class HierarchyTraversal
{

	protected HierarchyTraversal() { }

	protected void Recurse(VisualElement element, int depth) { }

	public override void Traverse(VisualElement element) { }

	public abstract void TraverseRecursive(VisualElement element, int depth) { }

}

