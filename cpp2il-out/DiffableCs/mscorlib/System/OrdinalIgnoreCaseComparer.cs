namespace System;

internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
{

	public OrdinalIgnoreCaseComparer() { }

	public virtual int Compare(string x, string y) { }

	public virtual bool Equals(string x, string y) { }

	public virtual int GetHashCode(string obj) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

