namespace System.Linq.Expressions.Interpreter;

internal class LightLambda
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public MethodInfo targetMethod; //Field offset: 0x10
		public Type delegateType; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }

	}

	private class DebugViewPrinter
	{
		private readonly Interpreter _interpreter; //Field offset: 0x10
		private readonly Dictionary<Int32, Int32> _tryStart; //Field offset: 0x18
		private readonly Dictionary<Int32, String> _handlerEnter; //Field offset: 0x20
		private readonly Dictionary<Int32, Int32> _handlerExit; //Field offset: 0x28
		private string _indent; //Field offset: 0x30

		public DebugViewPrinter(Interpreter interpreter) { }

		private void AddHandlerExit(int index) { }

		private void AddTryStart(int index) { }

		private void Analyze() { }

		private void Dedent() { }

		private void EmitExits(StringBuilder sb, int index) { }

		private void Indent() { }

		public virtual string ToString() { }

	}

	private static readonly CacheDict<Type, Func`2<LightLambda, Delegate>> _runCache; //Field offset: 0x0
	private readonly IStrongBox[] _closure; //Field offset: 0x10
	private readonly Interpreter _interpreter; //Field offset: 0x18
	private readonly LightDelegateCreator _delegateCreator; //Field offset: 0x20

	internal string DebugView
	{
		internal get { } //Length: 380
	}

	private static LightLambda() { }

	internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	private Delegate CreateCustomDelegate(Type delegateType) { }

	internal string get_DebugView() { }

	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	internal Delegate MakeDelegate(Type delegateType) { }

	private InterpretedFrame MakeFrame() { }

	internal static Delegate MakeRun0(LightLambda lambda) { }

	internal static Delegate MakeRun1(LightLambda lambda) { }

	internal static Delegate MakeRun10(LightLambda lambda) { }

	internal static Delegate MakeRun11(LightLambda lambda) { }

	internal static Delegate MakeRun12(LightLambda lambda) { }

	internal static Delegate MakeRun13(LightLambda lambda) { }

	internal static Delegate MakeRun14(LightLambda lambda) { }

	internal static Delegate MakeRun15(LightLambda lambda) { }

	internal static Delegate MakeRun2(LightLambda lambda) { }

	internal static Delegate MakeRun3(LightLambda lambda) { }

	internal static Delegate MakeRun4(LightLambda lambda) { }

	internal static Delegate MakeRun5(LightLambda lambda) { }

	internal static Delegate MakeRun6(LightLambda lambda) { }

	internal static Delegate MakeRun7(LightLambda lambda) { }

	internal static Delegate MakeRun8(LightLambda lambda) { }

	internal static Delegate MakeRun9(LightLambda lambda) { }

	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	internal static Delegate MakeRunVoid1(LightLambda lambda) { }

	internal static Delegate MakeRunVoid10(LightLambda lambda) { }

	internal static Delegate MakeRunVoid11(LightLambda lambda) { }

	internal static Delegate MakeRunVoid12(LightLambda lambda) { }

	internal static Delegate MakeRunVoid13(LightLambda lambda) { }

	internal static Delegate MakeRunVoid14(LightLambda lambda) { }

	internal static Delegate MakeRunVoid15(LightLambda lambda) { }

	internal static Delegate MakeRunVoid2(LightLambda lambda) { }

	internal static Delegate MakeRunVoid3(LightLambda lambda) { }

	internal static Delegate MakeRunVoid4(LightLambda lambda) { }

	internal static Delegate MakeRunVoid5(LightLambda lambda) { }

	internal static Delegate MakeRunVoid6(LightLambda lambda) { }

	internal static Delegate MakeRunVoid7(LightLambda lambda) { }

	internal static Delegate MakeRunVoid8(LightLambda lambda) { }

	internal static Delegate MakeRunVoid9(LightLambda lambda) { }

	public object Run(Object[] arguments) { }

	internal TRet Run0() { }

	internal TRet Run1(T0 arg0) { }

	internal TRet Run10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	internal TRet Run11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	internal TRet Run12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	internal TRet Run13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	internal TRet Run14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	internal TRet Run15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	internal TRet Run2(T0 arg0, T1 arg1) { }

	internal TRet Run3(T0 arg0, T1 arg1, T2 arg2) { }

	internal TRet Run4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	internal TRet Run5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	internal TRet Run6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	internal TRet Run7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	internal TRet Run8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	internal TRet Run9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	public object RunVoid(Object[] arguments) { }

	internal void RunVoid0() { }

	internal void RunVoid1(T0 arg0) { }

	internal void RunVoid10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	internal void RunVoid11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	internal void RunVoid12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	internal void RunVoid13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	internal void RunVoid14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	internal void RunVoid15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	internal void RunVoid2(T0 arg0, T1 arg1) { }

	internal void RunVoid3(T0 arg0, T1 arg1, T2 arg2) { }

	internal void RunVoid4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	internal void RunVoid5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	internal void RunVoid6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	internal void RunVoid7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	internal void RunVoid8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	internal void RunVoid9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	internal void RunVoidRef2(ref T0 arg0, ref T1 arg1) { }

}

