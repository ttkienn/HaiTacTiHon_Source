namespace UnityEngine.UIElements;

public interface IUxmlFactory : IBaseUxmlFactory
{

	public VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

