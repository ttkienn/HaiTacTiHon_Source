namespace System.Threading.Tasks;

[Extension]
internal static class TaskAwaiters
{

	[Extension]
	public static ForceAsyncAwaiter ForceAsync(Task task) { }

}

