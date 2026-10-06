namespace UnityEngine.UIElements;

public interface INotifyValueChanged
{

	public T value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public T get_value() { }

	public void set_value(T value) { }

	public void SetValueWithoutNotify(T newValue) { }

}

