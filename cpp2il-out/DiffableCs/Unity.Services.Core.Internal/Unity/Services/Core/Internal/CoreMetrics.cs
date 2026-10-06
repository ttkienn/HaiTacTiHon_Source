namespace Unity.Services.Core.Internal;

internal class CoreMetrics
{
	internal const string PackageInitTimeMetricName = "package_init_time"; //Field offset: 0x0
	internal const string AllPackagesInitSuccessMetricName = "all_packages_init_success"; //Field offset: 0x0
	internal const string AllPackagesInitTimeMetricName = "all_packages_init_time"; //Field offset: 0x0
	internal const string PackageInitializerNamesKeyFormat = "{0}.initializer-assembly-qualified-names"; //Field offset: 0x0
	internal const char PackageInitializerNamesSeparator = '\u3B'; //Field offset: 0x0
	internal const string AllPackageNamesKey = "com.unity.services.core.all-package-names"; //Field offset: 0x0
	internal const char AllPackageNamesSeparator = '\u3B'; //Field offset: 0x0
	[CompilerGenerated]
	private static CoreMetrics <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IMetrics <Metrics>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IDictionary<Type, IMetrics> <AllPackageMetrics>k__BackingField; //Field offset: 0x18

	internal IDictionary<Type, IMetrics> AllPackageMetrics
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public internal static CoreMetrics Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		internal set { } //Length: 81
	}

	internal IMetrics Metrics
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public CoreMetrics() { }

	internal void FindAndCacheAllPackageMetrics(IProjectConfiguration configuration, IMetricsFactory factory) { }

	[CompilerGenerated]
	internal IDictionary<Type, IMetrics> get_AllPackageMetrics() { }

	[CompilerGenerated]
	public static CoreMetrics get_Instance() { }

	[CompilerGenerated]
	internal IMetrics get_Metrics() { }

	public void Initialize(IProjectConfiguration configuration, IMetricsFactory factory, Type corePackageType) { }

	public void SendAllPackagesInitSuccessMetric() { }

	public void SendAllPackagesInitTimeMetric(double initTimeSeconds) { }

	public void SendInitTimeMetricForPackage(Type packageType, double initTimeSeconds) { }

	[CompilerGenerated]
	internal static void set_Instance(CoreMetrics value) { }

	[CompilerGenerated]
	internal void set_Metrics(IMetrics value) { }

}

