namespace Mono.Security.Cryptography;

public sealed class PKCS8
{
	internal class EncryptedPrivateKeyInfo
	{
		private string _algorithm; //Field offset: 0x10
		private Byte[] _salt; //Field offset: 0x18
		private int _iterations; //Field offset: 0x20
		private Byte[] _data; //Field offset: 0x28

		public string Algorithm
		{
			 get { } //Length: 5
			 set { } //Length: 13
		}

		public Byte[] EncryptedData
		{
			 get { } //Length: 121
			 set { } //Length: 152
		}

		public int IterationCount
		{
			 get { } //Length: 4
			 set { } //Length: 126
		}

		public Byte[] Salt
		{
			 get { } //Length: 200
		}

		public EncryptedPrivateKeyInfo() { }

		public EncryptedPrivateKeyInfo(Byte[] data) { }

		private void Decode(Byte[] data) { }

		public string get_Algorithm() { }

		public Byte[] get_EncryptedData() { }

		public int get_IterationCount() { }

		public Byte[] get_Salt() { }

		public Byte[] GetBytes() { }

		public void set_Algorithm(string value) { }

		public void set_EncryptedData(Byte[] value) { }

		public void set_IterationCount(int value) { }

	}

	internal class PrivateKeyInfo
	{
		private int _version; //Field offset: 0x10
		private string _algorithm; //Field offset: 0x18
		private Byte[] _key; //Field offset: 0x20
		private ArrayList _list; //Field offset: 0x28

		public string Algorithm
		{
			 get { } //Length: 5
			 set { } //Length: 13
		}

		public Byte[] PrivateKey
		{
			 get { } //Length: 123
			 set { } //Length: 252
		}

		public PrivateKeyInfo() { }

		public PrivateKeyInfo(Byte[] data) { }

		private void Decode(Byte[] data) { }

		public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

		public static RSA DecodeRSA(Byte[] keypair) { }

		public static Byte[] Encode(RSA rsa) { }

		public static Byte[] Encode(DSA dsa) { }

		public static Byte[] Encode(AsymmetricAlgorithm aa) { }

		public string get_Algorithm() { }

		public Byte[] get_PrivateKey() { }

		public Byte[] GetBytes() { }

		private static Byte[] Normalize(Byte[] bigInt, int length) { }

		private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

		public void set_Algorithm(string value) { }

		public void set_PrivateKey(Byte[] value) { }

	}


}

