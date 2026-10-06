namespace System;

[NonVersionable]
public struct Nullable
{
	private readonly bool hasValue; //Field offset: 0x0
	internal T value; //Field offset: 0x0

	public bool HasValue
	{
		[NonVersionable]
		 get { } //Length: 4
	}

	public T Value
	{
		 get { } //Length: 49
	}

	[NonVersionable]
	public Nullable`1(T value) { }

	private static object Box(Nullable<T> o) { }

	public virtual bool Equals(object other) { }

	[NonVersionable]
	public bool get_HasValue() { }

	public T get_Value() { }

	public virtual int GetHashCode() { }

	[NonVersionable]
	public T GetValueOrDefault() { }

	[NonVersionable]
	public T GetValueOrDefault(T defaultValue) { }

	public virtual string ToString() { }

	private static Nullable<T> Unbox(object o) { }

	private static Nullable<T> UnboxExact(object o) { }

}

