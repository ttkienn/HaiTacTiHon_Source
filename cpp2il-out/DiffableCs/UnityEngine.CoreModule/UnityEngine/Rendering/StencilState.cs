namespace UnityEngine.Rendering;

public struct StencilState : IEquatable<StencilState>
{
	private byte m_Enabled; //Field offset: 0x0
	private byte m_ReadMask; //Field offset: 0x1
	private byte m_WriteMask; //Field offset: 0x2
	private byte m_Padding; //Field offset: 0x3
	private byte m_CompareFunctionFront; //Field offset: 0x4
	private byte m_PassOperationFront; //Field offset: 0x5
	private byte m_FailOperationFront; //Field offset: 0x6
	private byte m_ZFailOperationFront; //Field offset: 0x7
	private byte m_CompareFunctionBack; //Field offset: 0x8
	private byte m_PassOperationBack; //Field offset: 0x9
	private byte m_FailOperationBack; //Field offset: 0xA
	private byte m_ZFailOperationBack; //Field offset: 0xB

	public CompareFunction compareFunctionBack
	{
		 set { } //Length: 4
	}

	public CompareFunction compareFunctionFront
	{
		 set { } //Length: 4
	}

	public bool enabled
	{
		 set { } //Length: 88
	}

	public StencilOp failOperationBack
	{
		 set { } //Length: 4
	}

	public StencilOp failOperationFront
	{
		 set { } //Length: 4
	}

	public StencilOp passOperationBack
	{
		 set { } //Length: 4
	}

	public StencilOp passOperationFront
	{
		 set { } //Length: 4
	}

	public byte readMask
	{
		 set { } //Length: 4
	}

	public byte writeMask
	{
		 set { } //Length: 4
	}

	public StencilOp zFailOperationBack
	{
		 set { } //Length: 4
	}

	public StencilOp zFailOperationFront
	{
		 set { } //Length: 4
	}

	public override bool Equals(StencilState other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void set_compareFunctionBack(CompareFunction value) { }

	public void set_compareFunctionFront(CompareFunction value) { }

	public void set_enabled(bool value) { }

	public void set_failOperationBack(StencilOp value) { }

	public void set_failOperationFront(StencilOp value) { }

	public void set_passOperationBack(StencilOp value) { }

	public void set_passOperationFront(StencilOp value) { }

	public void set_readMask(byte value) { }

	public void set_writeMask(byte value) { }

	public void set_zFailOperationBack(StencilOp value) { }

	public void set_zFailOperationFront(StencilOp value) { }

}

