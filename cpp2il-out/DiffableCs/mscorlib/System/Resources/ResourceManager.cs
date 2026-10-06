namespace System.Resources;

[ComVisible(True)]
public class ResourceManager
{
	public class CultureNameResourceSetPair
	{

		public CultureNameResourceSetPair() { }

	}

	public class ResourceManagerMediator
	{
		private ResourceManager _rm; //Field offset: 0x10

		internal ResourceManagerMediator(ResourceManager rm) { }

	}

	public static readonly int MagicNumber; //Field offset: 0x0
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	private static readonly Type _minResourceSet; //Field offset: 0x8
	internal static readonly string ResReaderTypeName; //Field offset: 0x10
	internal static readonly string ResSetTypeName; //Field offset: 0x18
	internal static readonly string MscorlibName; //Field offset: 0x20
	internal static readonly int DEBUG; //Field offset: 0x28
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; //Field offset: 0x10
	private Dictionary<String, ResourceSet> _resourceSets; //Field offset: 0x18
	protected Assembly MainAssembly; //Field offset: 0x20
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x28
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x30
	private bool UseManifest; //Field offset: 0x38
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; //Field offset: 0x39
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x3C
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; //Field offset: 0x40
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x48
	private IResourceGroveler resourceGroveler; //Field offset: 0x50

	private static ResourceManager() { }

	protected ResourceManager() { }

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	private void Init() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

}

