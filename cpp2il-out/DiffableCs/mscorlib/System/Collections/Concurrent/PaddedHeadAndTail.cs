namespace System.Collections.Concurrent;

[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
internal struct PaddedHeadAndTail
{
	public int Head; //Field offset: 0x80
	public int Tail; //Field offset: 0x100

}

