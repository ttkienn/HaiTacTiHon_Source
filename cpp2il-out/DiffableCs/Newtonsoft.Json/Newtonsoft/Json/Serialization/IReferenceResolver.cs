namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface IReferenceResolver
{

	public void AddReference(object context, string reference, object value) { }

	public string GetReference(object context, object value) { }

	public bool IsReferenced(object context, object value) { }

	public object ResolveReference(object context, string reference) { }

}

