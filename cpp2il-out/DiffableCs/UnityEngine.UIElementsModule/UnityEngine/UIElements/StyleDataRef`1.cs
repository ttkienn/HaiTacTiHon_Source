namespace UnityEngine.UIElements;

internal struct StyleDataRef : IEquatable<StyleDataRef`1<T>>
{
	private class RefCounted
	{
		private static uint m_NextId; //Field offset: 0x0
		private int m_RefCount; //Field offset: 0x0
		private readonly uint m_Id; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public int refCount
		{
			 get { } //Length: 191
		}

		private static RefCounted() { }

		public RefCounted() { }

		public void Acquire() { }

		public RefCounted<T> Copy() { }

		public int get_refCount() { }

		public void Release() { }

	}

	private RefCounted<T> m_Ref; //Field offset: 0x0

	public StyleDataRef<T> Acquire() { }

	public void CopyFrom(StyleDataRef<T> other) { }

	public static StyleDataRef<T> Create() { }

	public override bool Equals(StyleDataRef<T> other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }

	public T Read() { }

	public bool ReferenceEquals(StyleDataRef<T> other) { }

	public void Release() { }

	public T Write() { }

}

