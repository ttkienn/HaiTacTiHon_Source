namespace System.Reflection;

internal sealed class SignaturePointerType : SignatureHasElementType
{

	public virtual bool IsSZArray
	{
		 get { } //Length: 3
	}

	public virtual bool IsVariableBoundArray
	{
		 get { } //Length: 3
	}

	protected virtual string Suffix
	{
		 get { } //Length: 44
	}

	internal SignaturePointerType(SignatureType elementType) { }

	public virtual bool get_IsSZArray() { }

	public virtual bool get_IsVariableBoundArray() { }

	protected virtual string get_Suffix() { }

	public virtual int GetArrayRank() { }

	protected virtual bool IsArrayImpl() { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsPointerImpl() { }

}

