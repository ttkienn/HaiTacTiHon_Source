namespace Unity.Properties;

public interface IPropertyBag
{

	public void Accept(ITypeVisitor visitor) { }

}

