namespace UnityEngine;

[MovedFrom(True, "UnityEditor", "UnityEditor", null)]
public class ExpressionEvaluator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ExpressionToTokens>b__14_0(string f) { }

	}

	private enum Associativity
	{
		Left = 0,
		Right = 1,
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"}])]
	public class Expression
	{
		internal readonly String[] rpnTokens; //Field offset: 0x10
		internal readonly bool hasVariables; //Field offset: 0x18

		internal Expression(string expression) { }

		public virtual bool Equals(object obj) { }

		public bool Evaluate(ref T value, int index = 0, int count = 1) { }

		public virtual int GetHashCode() { }

		public virtual string ToString() { }

	}

	private enum Op
	{
		Add = 0,
		Sub = 1,
		Mul = 2,
		Div = 3,
		Mod = 4,
		Neg = 5,
		Pow = 6,
		Sqrt = 7,
		Sin = 8,
		Cos = 9,
		Tan = 10,
		Floor = 11,
		Ceil = 12,
		Round = 13,
		Rand = 14,
		Linear = 15,
	}

	private class Operator
	{
		public readonly Op op; //Field offset: 0x10
		public readonly int precedence; //Field offset: 0x14
		public readonly Associativity associativity; //Field offset: 0x18
		public readonly int inputs; //Field offset: 0x1C

		public Operator(Op op, int precedence, int inputs, Associativity associativity) { }

	}

	private struct PcgRandom
	{
		private readonly ulong increment; //Field offset: 0x0
		private ulong state; //Field offset: 0x8

		public PcgRandom(ulong state = 0, ulong sequence = 0) { }

		public uint GetUInt() { }

		private static uint RotateRight(uint v, int rot) { }

		private void Step() { }

		private static uint XshRr(ulong s) { }

	}

	private static PcgRandom s_Random; //Field offset: 0x0
	private static Dictionary<String, Operator> s_Operators; //Field offset: 0x10

	private static ExpressionEvaluator() { }

	internal static bool Evaluate(string expression, out T value, out Expression delayed) { }

	private static bool EvaluateDouble(String[] tokens, ref double value, int index, int count) { }

	private static double EvaluateOp(Double[] values, Op op, int index, int count) { }

	private static bool EvaluateTokens(String[] tokens, ref T value, int index, int count) { }

	private static String[] ExpressionToTokens(string expression, out bool hasVariables) { }

	private static String[] FixUnaryOperators(String[] tokens) { }

	private static String[] InfixToRPN(String[] tokens) { }

	private static bool IsCommand(string token) { }

	private static bool IsDelayedFunction(string token) { }

	private static bool IsOperator(string token) { }

	private static bool IsVariable(string token) { }

	private static bool NeedToPop(Stack<String> operatorStack, Operator newOperator) { }

	private static string PreFormatExpression(string expression) { }

	private static Operator TokenToOperator(string token) { }

	private static bool TryParse(string expression, out T result) { }

}

