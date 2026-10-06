namespace UnityEngine.Purchasing;

public class Price : ISerializationCallbackReceiver
{
	public decimal value; //Field offset: 0x10
	[SerializeField]
	private Int32[] data; //Field offset: 0x20
	[SerializeField]
	private double num; //Field offset: 0x28

	public Price() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

