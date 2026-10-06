namespace Unity.Services.Analytics.Data;

internal class CommonDataWrapper : ICommonData
{
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <GameBundleId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <ProjectId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Platform>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <BuildGUID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Idfv>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly string <GameStoreId>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <HasVolume>k__BackingField; //Field offset: 0x48

	public override string AnalyticsRegionLanguageCode
	{
		 get { } //Length: 143
	}

	public override double BatteryLevel
	{
		 get { } //Length: 20
	}

	public override string BuildGUID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string GameBundleId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string GameStoreId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool HasVolume
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string Idfv
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string Platform
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string ProjectId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string Version
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override float Volume
	{
		 get { } //Length: 4
	}

	public CommonDataWrapper(string cloudProjectId) { }

	public override string get_AnalyticsRegionLanguageCode() { }

	public override double get_BatteryLevel() { }

	[CompilerGenerated]
	public override string get_BuildGUID() { }

	[CompilerGenerated]
	public override string get_GameBundleId() { }

	[CompilerGenerated]
	public override string get_GameStoreId() { }

	[CompilerGenerated]
	public override bool get_HasVolume() { }

	[CompilerGenerated]
	public override string get_Idfv() { }

	[CompilerGenerated]
	public override string get_Platform() { }

	[CompilerGenerated]
	public override string get_ProjectId() { }

	[CompilerGenerated]
	public override string get_Version() { }

	public override float get_Volume() { }

	private static string GetPlatform() { }

}

