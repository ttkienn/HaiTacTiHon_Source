namespace System.Xml;

public abstract class XmlResolver
{

	protected XmlResolver() { }

	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	public override Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	public override bool SupportsType(Uri absoluteUri, Type type) { }

}

