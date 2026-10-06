namespace Unity.Properties;

internal interface IConstructorWithCount : IConstructor
{

	public T InstantiateWithCount(int count) { }

}

