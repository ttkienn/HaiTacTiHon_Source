namespace UnityEngine.Purchasing.Security;

public class CrossPlatformValidator
{

	public CrossPlatformValidator(Byte[] googlePublicKey, string googleBundleId) { }

	public CrossPlatformValidator(Byte[] googlePublicKey, Byte[] appleRootCert, string appBundleId) { }

	public CrossPlatformValidator(Byte[] googlePublicKey, Byte[] appleRootCert, string googleBundleId, string appleBundleId) { }

	public IPurchaseReceipt[] Validate(string unityIAPReceipt) { }

}

