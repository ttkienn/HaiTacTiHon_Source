namespace System.Security;

[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback
{
	private static Object[] psUnrestricted; //Field offset: 0x0
	private static Object[] action; //Field offset: 0x8
	private PermissionState state; //Field offset: 0x10
	private ArrayList list; //Field offset: 0x18
	private bool _declsec; //Field offset: 0x20
	private Boolean[] _ignored; //Field offset: 0x28

	public override int Count
	{
		 get { } //Length: 42
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 42
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private static PermissionSet() { }

	internal PermissionSet(IPermission perm) { }

	internal PermissionSet() { }

	public PermissionSet(PermissionState state) { }

	internal void CasOnlyDemand(int skip) { }

	public override void CopyTo(Array array, int index) { }

	public override void Demand() { }

	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public bool IsEmpty() { }

	public bool IsUnrestricted() { }

	[MonoTODO("may not be required")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public virtual string ToString() { }

	public override SecurityElement ToXml() { }

}

