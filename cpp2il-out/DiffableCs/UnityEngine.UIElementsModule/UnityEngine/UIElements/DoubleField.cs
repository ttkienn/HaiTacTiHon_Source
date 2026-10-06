namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class DoubleField : TextValueField<Double>
{
	private class DoubleInput : TextValueInput<Double>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 78
		}

		private DoubleField parentDoubleField
		{
			private get { } //Length: 113
		}

		internal DoubleInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue) { }

		protected virtual string get_allowedCharacters() { }

		private DoubleField get_parentDoubleField() { }

		protected virtual double StringToValue(string str) { }

		protected virtual string ValueToString(double v) { }

	}

	internal class UxmlFactory : UxmlFactory<DoubleField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<Double, UxmlDoubleAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private DoubleInput doubleInput
	{
		private get { } //Length: 122
	}

	private static DoubleField() { }

	public DoubleField() { }

	public DoubleField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private DoubleInput get_doubleInput() { }

	protected virtual double StringToValue(string str) { }

	protected virtual string ValueToString(double v) { }

}

