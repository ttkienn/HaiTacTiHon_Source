namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(True)]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	private string name; //Field offset: 0x10
	private string codebase; //Field offset: 0x18
	private int major; //Field offset: 0x20
	private int minor; //Field offset: 0x24
	private int build; //Field offset: 0x28
	private int revision; //Field offset: 0x2C
	private CultureInfo cultureinfo; //Field offset: 0x30
	private AssemblyNameFlags flags; //Field offset: 0x38
	private AssemblyHashAlgorithm hashalg; //Field offset: 0x3C
	private StrongNameKeyPair keypair; //Field offset: 0x40
	private Byte[] publicKey; //Field offset: 0x48
	private Byte[] keyToken; //Field offset: 0x50
	private AssemblyVersionCompatibility versioncompat; //Field offset: 0x58
	private Version version; //Field offset: 0x60
	private ProcessorArchitecture processor_architecture; //Field offset: 0x68
	private AssemblyContentType contentType; //Field offset: 0x6C

	public CultureInfo CultureInfo
	{
		 get { } //Length: 5
	}

	public AssemblyNameFlags Flags
	{
		 get { } //Length: 4
	}

	public string FullName
	{
		 get { } //Length: 1030
	}

	private bool IsPublicKeyValid
	{
		private get { } //Length: 160
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public Version Version
	{
		 get { } //Length: 5
		 set { } //Length: 112
	}

	public AssemblyName() { }

	public AssemblyName(string assemblyName) { }

	internal AssemblyName(SerializationInfo si, StreamingContext sc) { }

	public override object Clone() { }

	private Byte[] ComputePublicKeyToken() { }

	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	public CultureInfo get_CultureInfo() { }

	public AssemblyNameFlags get_Flags() { }

	public string get_FullName() { }

	private bool get_IsPublicKeyValid() { }

	public string get_Name() { }

	private static void get_public_token(Byte* token, Byte* pubkey, int len) { }

	public Version get_Version() { }

	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public Byte[] GetPublicKeyToken() { }

	private Byte[] InternalGetPublicKeyToken() { }

	public override void OnDeserialization(object sender) { }

	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	public void set_Version(Version value) { }

	public virtual string ToString() { }

}

