namespace Mono;

internal static class DependencyInjector
{
	private static object locker; //Field offset: 0x0
	private static ISystemDependencyProvider systemDependency; //Field offset: 0x8

	internal static ISystemDependencyProvider SystemProvider
	{
		internal get { } //Length: 869
	}

	private static DependencyInjector() { }

	internal static ISystemDependencyProvider get_SystemProvider() { }

	private static ISystemDependencyProvider ReflectionLoad() { }

	internal static void Register(ISystemDependencyProvider provider) { }

}

