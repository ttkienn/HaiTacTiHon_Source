namespace UnityEngine.Events;

internal class ArgumentCache : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private object m_ObjectArgument; //Field offset: 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; //Field offset: 0x18
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	private int m_IntArgument; //Field offset: 0x20
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	private float m_FloatArgument; //Field offset: 0x24
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	private string m_StringArgument; //Field offset: 0x28
	[SerializeField]
	private bool m_BoolArgument; //Field offset: 0x30

	public bool boolArgument
	{
		 get { } //Length: 7
	}

	public float floatArgument
	{
		 get { } //Length: 8
	}

	public int intArgument
	{
		 get { } //Length: 6
	}

	public string stringArgument
	{
		 get { } //Length: 7
	}

	public object unityObjectArgument
	{
		 get { } //Length: 7
	}

	public string unityObjectArgumentAssemblyTypeName
	{
		 get { } //Length: 7
	}

	public ArgumentCache() { }

	public bool get_boolArgument() { }

	public float get_floatArgument() { }

	public int get_intArgument() { }

	public string get_stringArgument() { }

	public object get_unityObjectArgument() { }

	public string get_unityObjectArgumentAssemblyTypeName() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

