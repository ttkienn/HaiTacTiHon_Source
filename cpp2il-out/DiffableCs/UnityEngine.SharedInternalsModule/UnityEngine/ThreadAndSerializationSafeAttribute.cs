namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64))]
[VisibleToOtherModules]
internal class ThreadAndSerializationSafeAttribute : Attribute
{

	public ThreadAndSerializationSafeAttribute() { }

}

