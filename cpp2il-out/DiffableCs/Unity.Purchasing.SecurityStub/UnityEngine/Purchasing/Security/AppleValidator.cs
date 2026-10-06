namespace UnityEngine.Purchasing.Security;

[Obsolete("AppleValidator is a stub and does not perform any validation. Do not use this class. Use UnityEngine.Purchasing.Security.CrossPlatformValidator with a valid Apple certificate for receipt validation.", False)]
public class AppleValidator
{

	public AppleValidator(Byte[] appleRootCertificate) { }

	public AppleReceipt Validate(Byte[] receiptData) { }

}

