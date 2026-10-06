namespace UnityEngine.Purchasing;

[NullableContext(2)]
public interface IGoogleOrderInfo
{

	public string ObfuscatedAccountId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string ObfuscatedProfileId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_ObfuscatedAccountId() { }

	public string get_ObfuscatedProfileId() { }

	public void set_ObfuscatedAccountId(string value) { }

	public void set_ObfuscatedProfileId(string value) { }

}

