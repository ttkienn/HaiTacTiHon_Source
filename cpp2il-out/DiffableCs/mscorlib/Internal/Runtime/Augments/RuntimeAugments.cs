namespace Internal.Runtime.Augments;

internal class RuntimeAugments
{
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; //Field offset: 0x0

	internal static ReflectionExecutionDomainCallbacks Callbacks
	{
		internal get { } //Length: 78
	}

	private static RuntimeAugments() { }

	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	public static void ReportUnhandledException(Exception exception) { }

}

