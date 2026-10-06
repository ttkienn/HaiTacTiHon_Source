namespace UnityEngine;

[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter
{

	public virtual Encoding Encoding
	{
		 get { } //Length: 9
	}

	public UnityLogWriter() { }

	public virtual Encoding get_Encoding() { }

	public static void Init() { }

	public virtual void Write(char value) { }

	public virtual void Write(string s) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	[ThreadAndSerializationSafe]
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	private static void WriteStringToUnityLogImpl(string s) { }

}

