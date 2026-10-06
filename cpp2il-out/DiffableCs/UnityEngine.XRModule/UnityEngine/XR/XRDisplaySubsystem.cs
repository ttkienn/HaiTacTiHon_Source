namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRBlitParams
	{
		public RenderTexture srcTex; //Field offset: 0x0
		public int srcTexArraySlice; //Field offset: 0x8
		public Rect srcRect; //Field offset: 0xC
		public Rect destRect; //Field offset: 0x1C
		public IntPtr foveatedRenderingInfo; //Field offset: 0x30
		public bool srcHdrEncoded; //Field offset: 0x38
		public ColorGamut srcHdrColorGamut; //Field offset: 0x3C
		public int srcHdrMaxLuminance; //Field offset: 0x40

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	internal struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public bool nativeBlitAvailable; //Field offset: 0x8
		public bool nativeBlitInvalidStates; //Field offset: 0x9
		public int blitParamsCount; //Field offset: 0xC

	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	internal struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance; //Field offset: 0x0
		public int renderPassIndex; //Field offset: 0x8
		public RenderTargetIdentifier renderTarget; //Field offset: 0x10
		public RenderTextureDescriptor renderTargetDesc; //Field offset: 0x38
		public bool hasMotionVectorPass; //Field offset: 0x6C
		public RenderTargetIdentifier motionVectorRenderTarget; //Field offset: 0x70
		public RenderTextureDescriptor motionVectorRenderTargetDesc; //Field offset: 0x98
		public bool shouldFillOutDepth; //Field offset: 0xCC
		public int cullingPassIndex; //Field offset: 0xD0
		public IntPtr foveatedRenderingInfo; //Field offset: 0xD8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> displayFocusChanged; //Field offset: 0x20

	public XRDisplaySubsystem() { }

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus) { }

}

