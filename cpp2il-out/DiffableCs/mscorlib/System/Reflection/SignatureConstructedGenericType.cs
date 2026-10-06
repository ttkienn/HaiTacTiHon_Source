namespace System.Reflection;

internal sealed class SignatureConstructedGenericType : SignatureType
{
	private readonly Type _genericTypeDefinition; //Field offset: 0x18
	private readonly Type[] _genericTypeArguments; //Field offset: 0x20

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 139
	}

	internal virtual SignatureType ElementType
	{
		internal get { } //Length: 3
	}

	public virtual int GenericParameterPosition
	{
		 get { } //Length: 78
	}

	public virtual Type[] GenericTypeArguments
	{
		 get { } //Length: 119
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

	public virtual bool IsSZArray
	{
		 get { } //Length: 3
	}

	public virtual bool IsVariableBoundArray
	{
		 get { } //Length: 3
	}

	public virtual string Name
	{
		 get { } //Length: 42
	}

	public virtual string Namespace
	{
		 get { } //Length: 42
	}

	internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments) { }

	public virtual bool get_ContainsGenericParameters() { }

	internal virtual SignatureType get_ElementType() { }

	public virtual int get_GenericParameterPosition() { }

	public virtual Type[] get_GenericTypeArguments() { }

	public virtual bool get_IsConstructedGenericType() { }

	public virtual bool get_IsGenericMethodParameter() { }

	public virtual bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericTypeDefinition() { }

	public virtual bool get_IsSZArray() { }

	public virtual bool get_IsVariableBoundArray() { }

	public virtual string get_Name() { }

	public virtual string get_Namespace() { }

	public virtual int GetArrayRank() { }

	public virtual Type[] GetGenericArguments() { }

	public virtual Type GetGenericTypeDefinition() { }

	protected virtual bool HasElementTypeImpl() { }

	protected virtual bool IsArrayImpl() { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsPointerImpl() { }

	public virtual string ToString() { }

}

