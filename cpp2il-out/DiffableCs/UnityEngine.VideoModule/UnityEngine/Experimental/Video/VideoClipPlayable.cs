namespace UnityEngine.Experimental.Video;

[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct VideoClipPlayable : IEquatable<VideoClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(VideoClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

