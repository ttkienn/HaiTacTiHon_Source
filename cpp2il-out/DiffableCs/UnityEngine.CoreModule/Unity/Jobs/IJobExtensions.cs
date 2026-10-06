namespace Unity.Jobs;

[Extension]
public static class IJobExtensions
{
	public struct JobStruct
	{
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			public ExecuteJobFunction(object object, IntPtr method) { }

			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		private static JobStruct`1() { }

		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		internal static void Initialize() { }

	}


	public static void EarlyJobInit() { }

}

