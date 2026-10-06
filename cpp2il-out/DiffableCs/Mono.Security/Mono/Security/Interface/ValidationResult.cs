namespace Mono.Security.Interface;

public class ValidationResult
{
	private bool trusted; //Field offset: 0x10
	private bool user_denied; //Field offset: 0x11
	private int error_code; //Field offset: 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; //Field offset: 0x18

	public bool Trusted
	{
		 get { } //Length: 5
	}

	public bool UserDenied
	{
		 get { } //Length: 5
	}

	public ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	public bool get_Trusted() { }

	public bool get_UserDenied() { }

}

