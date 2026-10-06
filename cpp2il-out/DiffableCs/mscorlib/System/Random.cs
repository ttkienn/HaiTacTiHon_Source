namespace System;

public class Random
{
	[ThreadStatic]
	private static Random t_threadRandom; //Field offset: 0x80000000
	private static readonly Random s_globalRandom; //Field offset: 0x0
	private int _inext; //Field offset: 0x10
	private int _inextp; //Field offset: 0x14
	private Int32[] _seedArray; //Field offset: 0x18

	private static Random() { }

	public Random() { }

	public Random(int Seed) { }

	private static int GenerateGlobalSeed() { }

	private static int GenerateSeed() { }

	private double GetSampleForLargeRange() { }

	private int InternalSample() { }

	public override int Next() { }

	public override int Next(int minValue, int maxValue) { }

	public override int Next(int maxValue) { }

	protected override double Sample() { }

}

