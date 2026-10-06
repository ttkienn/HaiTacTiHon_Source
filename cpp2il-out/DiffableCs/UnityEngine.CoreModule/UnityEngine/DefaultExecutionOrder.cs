namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4))]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	private int m_Order; //Field offset: 0x10

	public int order
	{
		 get { } //Length: 6
	}

	public DefaultExecutionOrder(int order) { }

	public int get_order() { }

}

