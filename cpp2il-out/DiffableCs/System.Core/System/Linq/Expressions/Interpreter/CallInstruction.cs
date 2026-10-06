namespace System.Linq.Expressions.Interpreter;

internal abstract class CallInstruction : Instruction
{

	public abstract int ArgumentCount
	{
		 get { } //Length: 0
	}

	public virtual int ConsumedStack
	{
		 get { } //Length: 20
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	protected CallInstruction() { }

	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	public static CallInstruction Create(MethodInfo info) { }

	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	public abstract int get_ArgumentCount() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	protected object InterpretLambdaInvoke(LightLambda targetLambda, Object[] args) { }

	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

}

