namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter
{
	private readonly BsonBinaryWriter _writer; //Field offset: 0x60
	private BsonToken _root; //Field offset: 0x68
	private BsonToken _parent; //Field offset: 0x70
	private string _propertyName; //Field offset: 0x78

	public DateTimeKind DateTimeKindHandling
	{
		 get { } //Length: 26
		 set { } //Length: 26
	}

	public BsonWriter(Stream stream) { }

	public BsonWriter(BinaryWriter writer) { }

	private void AddParent(BsonToken container) { }

	internal void AddToken(BsonToken token) { }

	private void AddValue(object value, BsonType type) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public DateTimeKind get_DateTimeKindHandling() { }

	private void RemoveParent() { }

	public void set_DateTimeKindHandling(DateTimeKind value) { }

	public virtual void WriteComment(string text) { }

	protected virtual void WriteEnd(JsonToken token) { }

	public virtual void WriteNull() { }

	public void WriteObjectId(Byte[] value) { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WriteRaw(string json) { }

	public virtual void WriteRawValue(string json) { }

	public void WriteRegex(string pattern, string options) { }

	public virtual void WriteStartArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteStartObject() { }

	public virtual void WriteUndefined() { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(Byte[] value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(decimal value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(short value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(float value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(string value) { }

}

