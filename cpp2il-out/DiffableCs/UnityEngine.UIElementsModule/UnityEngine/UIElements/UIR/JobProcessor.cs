namespace UnityEngine.UIElements.UIR;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRendererJobProcessor.h")]
internal static class JobProcessor
{

	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	internal static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	private static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

}

