namespace System.Collections.Generic;

internal sealed class BitHelper
{
	private readonly int _length; //Field offset: 0x10
	private readonly Int32* _arrayPtr; //Field offset: 0x18
	private readonly Int32[] _array; //Field offset: 0x20
	private readonly bool _useStackAlloc; //Field offset: 0x28

	internal BitHelper(Int32* bitArrayPtr, int length) { }

	internal BitHelper(Int32[] bitArray, int length) { }

	internal bool IsMarked(int bitPosition) { }

	internal void MarkBit(int bitPosition) { }

	internal static int ToIntArrayLength(int n) { }

}

