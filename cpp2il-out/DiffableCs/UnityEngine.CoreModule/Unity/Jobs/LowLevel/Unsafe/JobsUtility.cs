namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public static class JobsUtility
{
	internal struct JobScheduleParameters
	{
		public JobHandle Dependency; //Field offset: 0x0
		public int ScheduleMode; //Field offset: 0x10
		public IntPtr ReflectionData; //Field offset: 0x18
		public IntPtr JobDataPtr; //Field offset: 0x20

		public JobScheduleParameters(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

	}

	public sealed class PanicFunction_ : MulticastDelegate
	{

		public PanicFunction_(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal static PanicFunction_ PanicFunction; //Field offset: 0x0

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[RequiredByNativeCode]
	private static void InvokePanicFunction() { }

	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

}

