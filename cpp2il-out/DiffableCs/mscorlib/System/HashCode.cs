namespace System;

public struct HashCode
{
	private static readonly uint s_seed; //Field offset: 0x0
	private uint _v1; //Field offset: 0x0
	private uint _v2; //Field offset: 0x4
	private uint _v3; //Field offset: 0x8
	private uint _v4; //Field offset: 0xC
	private uint _queue1; //Field offset: 0x10
	private uint _queue2; //Field offset: 0x14
	private uint _queue3; //Field offset: 0x18
	private uint _length; //Field offset: 0x1C

	private static HashCode() { }

	public void Add(T value) { }

	private void Add(int value) { }

	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4) { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	public virtual bool Equals(object obj) { }

	private static uint GenerateGlobalSeed() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	public virtual int GetHashCode() { }

	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	private static uint MixEmptyState() { }

	private static uint MixFinal(uint hash) { }

	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	private static uint QueueRound(uint hash, uint queuedValue) { }

	private static uint Rol(uint value, int count) { }

	private static uint Round(uint hash, uint input) { }

	public int ToHashCode() { }

}

