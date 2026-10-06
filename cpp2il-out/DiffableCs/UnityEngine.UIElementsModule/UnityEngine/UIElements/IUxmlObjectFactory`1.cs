namespace UnityEngine.UIElements;

internal interface IUxmlObjectFactory : IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	public T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

