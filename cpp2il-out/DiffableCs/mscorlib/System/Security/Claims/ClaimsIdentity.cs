namespace System.Security.Claims;

[ComVisible(True)]
public class ClaimsIdentity : IIdentity
{
	[CompilerGenerated]
	private sealed class <get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Claim <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ClaimsIdentity <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30
		private IEnumerator<Claim> <>7__wrap2; //Field offset: 0x38

		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_Claims>d__51(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

		[DebuggerHidden]
		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private Byte[] m_userSerializationData; //Field offset: 0x10
	private List<Claim> m_instanceClaims; //Field offset: 0x18
	private Collection<IEnumerable`1<Claim>> m_externalClaims; //Field offset: 0x20
	private string m_nameType; //Field offset: 0x28
	private string m_roleType; //Field offset: 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; //Field offset: 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; //Field offset: 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; //Field offset: 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; //Field offset: 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; //Field offset: 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; //Field offset: 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; //Field offset: 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; //Field offset: 0x70

	public ClaimsIdentity Actor
	{
		 get { } //Length: 5
		 set { } //Length: 180
	}

	public override string AuthenticationType
	{
		 get { } //Length: 5
	}

	public override IEnumerable<Claim> Claims
	{
		[IteratorStateMachine(typeof(<get_Claims>d__51))]
		 get { } //Length: 113
	}

	public override string Name
	{
		 get { } //Length: 46
	}

	public ClaimsIdentity() { }

	public ClaimsIdentity(IEnumerable<Claim> claims) { }

	public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	protected ClaimsIdentity(SerializationInfo info, StreamingContext context) { }

	public override ClaimsIdentity Clone() { }

	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

	private void DeserializeClaims(string serializedClaims) { }

	public override Claim FindFirst(string type) { }

	public ClaimsIdentity get_Actor() { }

	public override string get_AuthenticationType() { }

	[IteratorStateMachine(typeof(<get_Claims>d__51))]
	public override IEnumerable<Claim> get_Claims() { }

	public override string get_Name() { }

	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private bool IsCircular(ClaimsIdentity subject) { }

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	private void OnDeserializingMethod(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializingMethod(StreamingContext context) { }

	private void SafeAddClaim(Claim claim) { }

	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	private string SerializeClaims() { }

	public void set_Actor(ClaimsIdentity value) { }

}

