namespace Mono;

internal struct MonoAssemblyName
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <public_key_token>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	internal IntPtr name; //Field offset: 0x0
	internal IntPtr culture; //Field offset: 0x8
	internal IntPtr hash_value; //Field offset: 0x10
	internal IntPtr public_key; //Field offset: 0x18
	[FixedBuffer(typeof(byte, 17)]
	internal <public_key_token>e__FixedBuffer public_key_token; //Field offset: 0x20
	internal uint hash_alg; //Field offset: 0x34
	internal uint hash_len; //Field offset: 0x38
	internal uint flags; //Field offset: 0x3C
	internal ushort major; //Field offset: 0x40
	internal ushort minor; //Field offset: 0x42
	internal ushort build; //Field offset: 0x44
	internal ushort revision; //Field offset: 0x46
	internal ushort arch; //Field offset: 0x48

}

