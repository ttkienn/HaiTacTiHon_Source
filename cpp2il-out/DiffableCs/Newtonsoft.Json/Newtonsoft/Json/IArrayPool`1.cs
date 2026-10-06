namespace Newtonsoft.Json;

[NullableContext(1)]
public interface IArrayPool
{

	public T[] Rent(int minimumLength) { }

	public void Return(T[] array) { }

}

