namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
internal sealed class InstructionList
{
	public sealed class DebugView
	{
		[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
		[IsReadOnly]
		public struct InstructionView
		{
			private readonly int _index; //Field offset: 0x0
			private readonly int _stackDepth; //Field offset: 0x4
			private readonly int _continuationsDepth; //Field offset: 0x8
			private readonly string _name; //Field offset: 0x10
			private readonly Instruction _instruction; //Field offset: 0x18

			public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }

			internal string GetValue() { }

		}


		internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<Object> objects, Func<Int32, Int32> labelIndexer, IReadOnlyList<KeyValuePair`2<Int32, Object>> debugCookies) { }

	}

	private static Instruction s_null; //Field offset: 0x0
	private static Instruction s_true; //Field offset: 0x8
	private static Instruction s_false; //Field offset: 0x10
	private static Instruction[] s_Ints; //Field offset: 0x18
	private static Instruction[] s_loadObjectCached; //Field offset: 0x20
	private static Instruction[] s_loadLocal; //Field offset: 0x28
	private static Instruction[] s_loadLocalBoxed; //Field offset: 0x30
	private static Instruction[] s_loadLocalFromClosure; //Field offset: 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; //Field offset: 0x40
	private static Instruction[] s_assignLocal; //Field offset: 0x48
	private static Instruction[] s_storeLocal; //Field offset: 0x50
	private static Instruction[] s_assignLocalBoxed; //Field offset: 0x58
	private static Instruction[] s_storeLocalBoxed; //Field offset: 0x60
	private static Instruction[] s_assignLocalToClosure; //Field offset: 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; //Field offset: 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; //Field offset: 0x78
	private readonly List<Instruction> _instructions; //Field offset: 0x10
	private List<Object> _objects; //Field offset: 0x18
	private int _currentStackDepth; //Field offset: 0x20
	private int _maxStackDepth; //Field offset: 0x24
	private int _currentContinuationsDepth; //Field offset: 0x28
	private int _maxContinuationDepth; //Field offset: 0x2C
	private int _runtimeLabelCount; //Field offset: 0x30
	private List<BranchLabel> _labels; //Field offset: 0x38
	private List<KeyValuePair`2<Int32, Object>> _debugCookies; //Field offset: 0x40

	public int Count
	{
		 get { } //Length: 60
	}

	public int CurrentContinuationsDepth
	{
		 get { } //Length: 4
	}

	public int CurrentStackDepth
	{
		 get { } //Length: 4
	}

	private static InstructionList() { }

	public InstructionList() { }

	internal static Instruction AssignLocalBoxed(int index) { }

	private RuntimeLabel[] BuildRuntimeLabels() { }

	public void Emit(Instruction instruction) { }

	public void EmitAdd(Type type, bool checked) { }

	public void EmitAnd(Type type) { }

	public void EmitArrayLength() { }

	public void EmitAssignLocal(int index) { }

	public void EmitAssignLocalBoxed(int index) { }

	public void EmitAssignLocalToClosure(int index) { }

	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	public void EmitBranch(BranchLabel label) { }

	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	public void EmitBranchFalse(BranchLabel elseLabel) { }

	public void EmitBranchTrue(BranchLabel elseLabel) { }

	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	public void EmitCall(MethodInfo method) { }

	public void EmitCast(Type toType) { }

	public void EmitCastReferenceToEnum(Type toType) { }

	public void EmitCastToEnum(Type toType) { }

	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	public void EmitDecrement(Type type) { }

	public void EmitDefaultValue(Type type) { }

	public void EmitDiv(Type type) { }

	public void EmitDup() { }

	public void EmitEnterExceptionFilter() { }

	public void EmitEnterExceptionHandlerNonVoid() { }

	public void EmitEnterExceptionHandlerVoid() { }

	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	public void EmitEnterTryCatch() { }

	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	public void EmitEqual(Type type, bool liftedToNull = false) { }

	public void EmitExclusiveOr(Type type) { }

	public void EmitGetArrayItem() { }

	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	public void EmitIncrement(Type type) { }

	public void EmitInitializeLocal(int index, Type type) { }

	internal void EmitInitializeParameter(int index) { }

	public void EmitIntSwitch(Dictionary<T, Int32> cases) { }

	public void EmitLeaveExceptionFilter() { }

	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	public void EmitLeaveFault() { }

	public void EmitLeaveFinally() { }

	public void EmitLeftShift(Type type) { }

	public void EmitLessThan(Type type, bool liftedToNull) { }

	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	public void EmitLoad(object value, Type type) { }

	public void EmitLoad(bool value) { }

	public void EmitLoad(object value) { }

	public void EmitLoadField(FieldInfo field) { }

	public void EmitLoadLocal(int index) { }

	public void EmitLoadLocalBoxed(int index) { }

	public void EmitLoadLocalFromClosure(int index) { }

	public void EmitLoadLocalFromClosureBoxed(int index) { }

	public void EmitModulo(Type type) { }

	public void EmitMul(Type type, bool checked) { }

	public void EmitNegate(Type type) { }

	public void EmitNegateChecked(Type type) { }

	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	public void EmitNewArray(Type elementType) { }

	public void EmitNewArrayBounds(Type elementType, int rank) { }

	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	public void EmitNewRuntimeVariables(int count) { }

	public void EmitNot(Type type) { }

	public void EmitNotEqual(Type type, bool liftedToNull = false) { }

	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	public void EmitOr(Type type) { }

	public void EmitPop() { }

	public void EmitRethrow() { }

	public void EmitRethrowVoid() { }

	public void EmitRightShift(Type type) { }

	public void EmitSetArrayItem() { }

	public void EmitStoreField(FieldInfo field) { }

	public void EmitStoreLocal(int index) { }

	public void EmitStoreLocalBoxed(int index) { }

	public void EmitStoreLocalToClosure(int index) { }

	public void EmitStringSwitch(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	public void EmitSub(Type type, bool checked) { }

	public void EmitThrow() { }

	public void EmitThrowVoid() { }

	public void EmitTypeAs(Type type) { }

	public void EmitTypeEquals() { }

	public void EmitTypeIs(Type type) { }

	private int EnsureLabelIndex(BranchLabel label) { }

	internal void FixupBranch(int branchIndex, int offset) { }

	public int get_Count() { }

	public int get_CurrentContinuationsDepth() { }

	public int get_CurrentStackDepth() { }

	internal Instruction GetInstruction(int index) { }

	private Instruction GetLoadField(FieldInfo field) { }

	internal static Instruction InitImmutableRefBox(int index) { }

	internal static Instruction InitReference(int index) { }

	internal static Instruction LoadLocalBoxed(int index) { }

	public BranchLabel MakeLabel() { }

	public void MarkLabel(BranchLabel label) { }

	public int MarkRuntimeLabel() { }

	internal static Instruction Parameter(int index) { }

	internal static Instruction ParameterBox(int index) { }

	internal static Instruction StoreLocalBoxed(int index) { }

	internal void SwitchToBoxed(int index, int instructionIndex) { }

	public InstructionArray ToArray() { }

	public void UnEmit() { }

	private void UpdateStackDepth(Instruction instruction) { }

}

