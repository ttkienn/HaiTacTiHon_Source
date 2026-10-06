namespace System.Security.Principal;

[ComVisible(True)]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
{
	private static IntPtr invalidWindows; //Field offset: 0x0
	private IntPtr _token; //Field offset: 0x78
	private string _type; //Field offset: 0x80
	private WindowsAccountType _account; //Field offset: 0x88
	private bool _authenticated; //Field offset: 0x8C
	private string _name; //Field offset: 0x90
	private SerializationInfo _info; //Field offset: 0x98

	public virtual string AuthenticationType
	{
		 get { } //Length: 8
	}

	public virtual string Name
	{
		 get { } //Length: 125
	}

	private static WindowsIdentity() { }

	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	public WindowsIdentity(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	public override void Dispose() { }

	public virtual string get_AuthenticationType() { }

	public virtual string get_Name() { }

	public static WindowsIdentity GetCurrent() { }

	internal static IntPtr GetCurrentToken() { }

	private static string GetTokenName(IntPtr token) { }

	public override WindowsImpersonationContext Impersonate() { }

	private void SetToken(IntPtr token) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

