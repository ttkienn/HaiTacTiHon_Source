namespace Unity.Services.Core;

public class InitializationOptions
{
	[CompilerGenerated]
	private readonly IDictionary<String, Object> <Values>k__BackingField; //Field offset: 0x10

	internal IDictionary<String, Object> Values
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public InitializationOptions() { }

	internal InitializationOptions(IDictionary<String, Object> values) { }

	internal InitializationOptions(InitializationOptions source) { }

	[CompilerGenerated]
	internal IDictionary<String, Object> get_Values() { }

	public InitializationOptions SetOption(string key, bool value) { }

	public InitializationOptions SetOption(string key, int value) { }

	public InitializationOptions SetOption(string key, float value) { }

	public InitializationOptions SetOption(string key, string value) { }

	public bool TryGetOption(string key, out bool option) { }

	public bool TryGetOption(string key, out int option) { }

	public bool TryGetOption(string key, out float option) { }

	public bool TryGetOption(string key, out string option) { }

	private bool TryGetOption(string key, out T option) { }

}

