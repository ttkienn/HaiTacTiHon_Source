namespace Unity.Services.Analytics;

public abstract class Event
{
	readonly Dictionary<String, String> m_Strings; //Field offset: 0x10
	readonly Dictionary<String, Int64> m_Integers; //Field offset: 0x18
	readonly Dictionary<String, Boolean> m_Booleans; //Field offset: 0x20
	readonly Dictionary<String, Double> m_Floats; //Field offset: 0x28
	internal readonly string Name; //Field offset: 0x30
	internal readonly bool StandardEvent; //Field offset: 0x38
	internal readonly int EventVersion; //Field offset: 0x3C

	protected Event(string name) { }

	internal Event(string name, bool standardEvent, int eventVersion) { }

	internal static String[] BakeEnum2String(bool toUpper = false) { }

	protected bool ParameterHasBeenSet(string name) { }

	public override void Reset() { }

	internal override void Serialize(IBuffer buffer) { }

	protected void SetParameter(string name, string value) { }

	protected void SetParameter(string name, bool value) { }

	protected void SetParameter(string name, int value) { }

	protected void SetParameter(string name, long value) { }

	protected void SetParameter(string name, float value) { }

	protected void SetParameter(string name, double value) { }

	public override void Validate() { }

}

