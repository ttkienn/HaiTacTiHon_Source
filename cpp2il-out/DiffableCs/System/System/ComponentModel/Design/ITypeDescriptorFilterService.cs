namespace System.ComponentModel.Design;

public interface ITypeDescriptorFilterService
{

	public bool FilterAttributes(IComponent component, IDictionary attributes) { }

	public bool FilterEvents(IComponent component, IDictionary events) { }

	public bool FilterProperties(IComponent component, IDictionary properties) { }

}

