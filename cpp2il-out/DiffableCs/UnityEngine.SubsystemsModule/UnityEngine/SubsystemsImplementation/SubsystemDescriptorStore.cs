namespace UnityEngine.SubsystemsImplementation;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore
{
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; //Field offset: 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; //Field offset: 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; //Field offset: 0x10

	private static SubsystemDescriptorStore() { }

	[RequiredByNativeCode]
	internal static void ClearManagedDescriptors() { }

	[RequiredByNativeCode]
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	internal static void RegisterDescriptor(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }

	private static void ReportSingleSubsystemAnalytics(string id) { }

}

