namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FloatField : TextValueField<Single>
{
	private class FloatInput : TextValueInput<Single>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 78
		}

		private FloatField parentFloatField
		{
			private get { } //Length: 113
		}

		internal FloatInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

		protected virtual string get_allowedCharacters() { }

		private FloatField get_parentFloatField() { }

		protected virtual float StringToValue(string str) { }

		protected virtual string ValueToString(float v) { }

	}

	internal class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<Single, UxmlFloatAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private FloatInput floatInput
	{
		private get { } //Length: 122
	}

	private static FloatField() { }

	public FloatField() { }

	public FloatField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private FloatInput get_floatInput() { }

	protected virtual float StringToValue(string str) { }

	protected virtual string ValueToString(float v) { }

}

