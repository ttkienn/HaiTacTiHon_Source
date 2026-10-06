namespace UnityEngine.Purchasing.Models;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePurchase : IGooglePurchase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<AndroidJavaObject, ProductDescription> <>9__35_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<ProductDescription, String> <>9__35_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal ProductDescription <.ctor>b__35_0(AndroidJavaObject productDetails) { }

		[NullableContext(0)]
		internal string <.ctor>b__35_1(ProductDescription productDescription) { }

	}

	[CompilerGenerated]
	private readonly bool <isAcknowledged>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <purchaseState>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly List<String> <skus>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <orderId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <receipt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <signature>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <originalJson>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly string <purchaseToken>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <obfuscatedAccountId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <obfuscatedProfileId>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly IEnumerable<ProductDescription> <productDescriptions>k__BackingField; //Field offset: 0x58

	public bool isAcknowledged
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public override string obfuscatedAccountId
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public override string obfuscatedProfileId
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public override string orderId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string originalJson
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override IEnumerable<ProductDescription> productDescriptions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override int purchaseState
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override string purchaseToken
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string receipt
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string signature
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public override string sku
	{
		[NullableContext(2)]
		 get { } //Length: 58
	}

	public override List<String> skus
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal GooglePurchase(AndroidJavaObject purchase, IEnumerable<AndroidJavaObject> productDetailsEnum) { }

	[CompilerGenerated]
	public bool get_isAcknowledged() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override string get_obfuscatedAccountId() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override string get_obfuscatedProfileId() { }

	[CompilerGenerated]
	public override string get_orderId() { }

	[CompilerGenerated]
	public override string get_originalJson() { }

	[CompilerGenerated]
	public override IEnumerable<ProductDescription> get_productDescriptions() { }

	[CompilerGenerated]
	public override int get_purchaseState() { }

	[CompilerGenerated]
	public override string get_purchaseToken() { }

	[CompilerGenerated]
	public override string get_receipt() { }

	[CompilerGenerated]
	public override string get_signature() { }

	[NullableContext(2)]
	public override string get_sku() { }

	[CompilerGenerated]
	public override List<String> get_skus() { }

	public override bool IsAcknowledged() { }

	public override bool IsPending() { }

	public override bool IsPurchased() { }

}

