namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public interface IValueField
{

	public T value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue) { }

	public T get_value() { }

	public void set_value(T value) { }

	public void StartDragging() { }

	public void StopDragging() { }

}

