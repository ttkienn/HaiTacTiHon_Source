namespace System;

internal class DelegateSerializationHolder : ISerializable, IObjectReference
{
	private class DelegateEntry
	{
		private string type; //Field offset: 0x10
		private string assembly; //Field offset: 0x18
		private object target; //Field offset: 0x20
		private string targetTypeAssembly; //Field offset: 0x28
		private string targetTypeName; //Field offset: 0x30
		private string methodName; //Field offset: 0x38
		public DelegateEntry delegateEntry; //Field offset: 0x40

		public DelegateEntry(Delegate del, string targetLabel) { }

		public Delegate DeserializeDelegate(SerializationInfo info, int index) { }

	}

	private Delegate _delegate; //Field offset: 0x10

	private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx) { }

	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override object GetRealObject(StreamingContext context) { }

}

