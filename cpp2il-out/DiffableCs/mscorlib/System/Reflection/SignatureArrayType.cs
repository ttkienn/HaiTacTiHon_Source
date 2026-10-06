namespace System.Reflection;

internal sealed class SignatureArrayType : SignatureHasElementType
{
	private readonly int _rank; //Field offset: 0x20
	private readonly bool _isMultiDim; //Field offset: 0x24

	public virtual bool IsSZArray
	{
		 get { } //Length: 8
	}

	public virtual bool IsVariableBoundArray
	{
		 get { } //Length: 5
	}

	protected virtual string Suffix
	{
		 get { } //Length: 163
	}

	internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) { }

	public virtual bool get_IsSZArray() { }

	public virtual bool get_IsVariableBoundArray() { }

	protected virtual string get_Suffix() { }

	public virtual int GetArrayRank() { }

	protected virtual bool IsArrayImpl() { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsPointerImpl() { }

}

