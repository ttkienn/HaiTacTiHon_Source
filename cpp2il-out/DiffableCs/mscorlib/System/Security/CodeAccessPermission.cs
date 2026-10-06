namespace System.Security;

[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
{

	protected CodeAccessPermission() { }

	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	[Conditional("MONO_FEATURE_CAS")]
	public override void Demand() { }

	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public abstract bool IsSubsetOf(IPermission target) { }

	private override void System.Security.IPermission.Demand() { }

	public virtual string ToString() { }

	public abstract SecurityElement ToXml() { }

}

