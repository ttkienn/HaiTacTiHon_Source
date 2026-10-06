namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface IValueProvider
{

	public object GetValue(object target) { }

	public void SetValue(object target, object value) { }

}

