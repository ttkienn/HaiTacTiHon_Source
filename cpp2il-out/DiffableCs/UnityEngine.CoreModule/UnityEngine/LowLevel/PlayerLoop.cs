namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop
{

	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	[NativeMethod(IsFreeFunction = True)]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal>& internalSys) { }

	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	[NativeMethod(IsFreeFunction = True)]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

