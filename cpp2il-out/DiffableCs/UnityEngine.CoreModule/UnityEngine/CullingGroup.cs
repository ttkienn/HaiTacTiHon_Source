namespace UnityEngine;

[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup
{
	internal sealed class StateChanged : MulticastDelegate
	{

		public StateChanged(object object, IntPtr method) { }

		public override void Invoke(CullingGroupEvent sphere) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	private StateChanged m_OnStateChanged; //Field offset: 0x18

	[RequiredByNativeCode]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

}

