namespace System.Collections.Generic;

internal class ByteEqualityComparer : EqualityComparer<Byte>
{

	public ByteEqualityComparer() { }

	public virtual bool Equals(byte x, byte y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(byte b) { }

	public virtual int GetHashCode() { }

	internal virtual int IndexOf(Byte[] array, byte value, int startIndex, int count) { }

	internal virtual int LastIndexOf(Byte[] array, byte value, int startIndex, int count) { }

}

