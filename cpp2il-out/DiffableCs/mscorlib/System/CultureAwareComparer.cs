namespace System;

public sealed class CultureAwareComparer : StringComparer, ISerializable
{
	private readonly CompareInfo _compareInfo; //Field offset: 0x10
	private CompareOptions _options; //Field offset: 0x18

	internal CultureAwareComparer(CultureInfo culture, CompareOptions options) { }

	internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options) { }

	private CultureAwareComparer(SerializationInfo info, StreamingContext context) { }

	public virtual int Compare(string x, string y) { }

	public virtual bool Equals(string x, string y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(string obj) { }

	public virtual int GetHashCode() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

