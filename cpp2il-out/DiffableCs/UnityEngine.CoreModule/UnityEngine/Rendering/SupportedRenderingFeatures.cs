namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures
{
	[Flags]
	internal enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	[Flags]
	internal enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1,
	}

	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enlightenLightmapper>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <enlighten>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <motionVectors>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <receiveShadows>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <reflectionProbesBlendDistance>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendererPriority>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendersUIOverlay>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesFog>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; //Field offset: 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesLODBias>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesMaximumLODLevel>k__BackingField; //Field offset: 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesEnableLODCrossFade>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <rendererProbes>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <particleSystemInstancing>k__BackingField; //Field offset: 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <autoAmbientProbeBaking>k__BackingField; //Field offset: 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesShadowmask>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <overridesLightProbeSystem>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <supportsHDR>k__BackingField; //Field offset: 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; //Field offset: 0x40

	public static SupportedRenderingFeatures active
	{
		 get { } //Length: 219
		 set { } //Length: 105
	}

	public bool autoAmbientProbeBaking
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool autoDefaultReflectionProbeBaking
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool enlighten
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Obsolete("Bake with the Progressive Lightmapper. The backend that uses Enlighten to bake is deprecated.", False)]
	public bool enlightenLightmapper
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LightmapBakeType lightmapBakeTypes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public LightmapsMode lightmapsModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public LightmapMixedBakeModes mixedLightingModes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool overridesLightProbeSystem
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool rendersUIOverlay
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static SupportedRenderingFeatures() { }

	public SupportedRenderingFeatures() { }

	[RequiredByNativeCode]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	[RequiredByNativeCode]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	public static SupportedRenderingFeatures get_active() { }

	[CompilerGenerated]
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGenerated]
	public bool get_autoDefaultReflectionProbeBaking() { }

	[CompilerGenerated]
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	public bool get_enlighten() { }

	[CompilerGenerated]
	public bool get_enlightenLightmapper() { }

	[CompilerGenerated]
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	public bool get_overridesLightProbeSystem() { }

	[CompilerGenerated]
	public bool get_rendersUIOverlay() { }

	[RequiredByNativeCode]
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	public static void set_active(SupportedRenderingFeatures value) { }

}

