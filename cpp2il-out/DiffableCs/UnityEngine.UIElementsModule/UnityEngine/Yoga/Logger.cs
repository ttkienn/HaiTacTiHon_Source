namespace UnityEngine.Yoga;

internal sealed class Logger : MulticastDelegate
{

	public Logger(object object, IntPtr method) { }

	public override void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message) { }

}

