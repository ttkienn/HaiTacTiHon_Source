namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class IntegerField : TextValueField<Int32>
{
	private class IntegerInput : TextValueInput<Int32>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 79
		}

		private IntegerField parentIntegerField
		{
			private get { } //Length: 113
		}

		internal IntegerInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

		protected virtual string get_allowedCharacters() { }

		private IntegerField get_parentIntegerField() { }

		protected virtual int StringToValue(string str) { }

		protected virtual string ValueToString(int v) { }

	}

	internal class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<Int32, UxmlIntAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private IntegerInput integerInput
	{
		private get { } //Length: 122
	}

	private static IntegerField() { }

	public IntegerField() { }

	public IntegerField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private IntegerInput get_integerInput() { }

	protected virtual int StringToValue(string str) { }

	protected virtual string ValueToString(int v) { }

}

