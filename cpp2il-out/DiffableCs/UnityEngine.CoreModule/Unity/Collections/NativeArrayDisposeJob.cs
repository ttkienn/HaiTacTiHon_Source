namespace Unity.Collections;

[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob
{
	internal NativeArrayDispose Data; //Field offset: 0x0

	public override void Execute() { }

	[RequiredByNativeCode]
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

