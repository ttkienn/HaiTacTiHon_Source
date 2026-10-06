namespace UnityEngine.UIElements;

public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
{

	public virtual string uxmlName
	{
		 get { } //Length: 44
	}

	public virtual string uxmlQualifiedName
	{
		 get { } //Length: 120
	}

	public UxmlAttributeOverridesFactory() { }

	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	public virtual string get_uxmlName() { }

	public virtual string get_uxmlQualifiedName() { }

}

