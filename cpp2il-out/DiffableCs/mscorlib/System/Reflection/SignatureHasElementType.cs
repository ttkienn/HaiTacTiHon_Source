namespace System.Reflection;

internal abstract class SignatureHasElementType : SignatureType
{
	private readonly SignatureType _elementType; //Field offset: 0x18

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 42
	}

	internal virtual SignatureType ElementType
	{
		internal get { } //Length: 5
	}

	public virtual int GenericParameterPosition
	{
		 get { } //Length: 78
	}

	public virtual Type[] GenericTypeArguments
	{
		 get { } //Length: 48
	}

	public virtual bool IsConstructedGenericType
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericMethodParameter
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericParameter
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericTypeDefinition
	{
		 get { } //Length: 3
	}

	public abstract bool IsSZArray
	{
		 get { } //Length: 0
	}

	public abstract bool IsVariableBoundArray
	{
		 get { } //Length: 0
	}

	public virtual string Name
	{
		 get { } //Length: 97
	}

	public virtual string Namespace
	{
		 get { } //Length: 42
	}

	protected abstract string Suffix
	{
		 get { } //Length: 0
	}

	protected SignatureHasElementType(SignatureType elementType) { }

	public virtual bool get_ContainsGenericParameters() { }

	internal virtual SignatureType get_ElementType() { }

	public virtual int get_GenericParameterPosition() { }

	public virtual Type[] get_GenericTypeArguments() { }

	public virtual bool get_IsConstructedGenericType() { }

	public virtual bool get_IsGenericMethodParameter() { }

	public virtual bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericTypeDefinition() { }

	public abstract bool get_IsSZArray() { }

	public abstract bool get_IsVariableBoundArray() { }

	public virtual string get_Name() { }

	public virtual string get_Namespace() { }

	protected abstract string get_Suffix() { }

	public abstract int GetArrayRank() { }

	public virtual Type[] GetGenericArguments() { }

	public virtual Type GetGenericTypeDefinition() { }

	protected virtual bool HasElementTypeImpl() { }

	protected abstract bool IsArrayImpl() { }

	protected abstract bool IsByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	public virtual string ToString() { }

}

