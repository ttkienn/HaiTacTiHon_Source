namespace System.Linq.Expressions;

internal static class Error
{

	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	internal static Exception AmbiguousJump(object p0) { }

	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	internal static Exception ArgumentMustBeArray(string paramName) { }

	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	private static Exception ArgumentMustBeInteger(string paramName) { }

	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	internal static Exception ArgumentOutOfRange(string paramName) { }

	internal static Exception ArgumentTypesMustMatch() { }

	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	internal static Exception BindingCannotBeNull() { }

	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	internal static Exception CoalesceUsedOnNonNullType() { }

	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	internal static Exception CollectionModifiedWhileEnumerating() { }

	internal static Exception CollectionReadOnly() { }

	internal static Exception ControlCannotEnterExpression() { }

	internal static Exception ControlCannotEnterTry() { }

	internal static Exception ControlCannotLeaveFilterTest() { }

	internal static Exception ControlCannotLeaveFinally() { }

	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	private static Exception DuplicateVariable(object p0, string paramName) { }

	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) { }

	internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	internal static Exception EnumerationIsDone() { }

	internal static Exception ExpressionMustBeReadable(string paramName) { }

	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	internal static Exception FirstArgumentMustBeCallSite() { }

	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	private static string GetParamName(string paramName, int index) { }

	internal static Exception IncorrectNumberOfConstructorArguments() { }

	internal static Exception IncorrectNumberOfIndexes() { }

	internal static Exception IncorrectNumberOfLambdaArguments() { }

	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	internal static Exception InvalidArgumentValue(string paramName) { }

	internal static Exception InvalidLvalue(ExpressionType p0) { }

	internal static Exception InvalidMetaObjectCreated(object p0) { }

	internal static Exception InvalidNullValue(Type type, string paramName) { }

	internal static Exception InvalidProgram() { }

	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	internal static Exception InvalidUnboxType(string paramName) { }

	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	internal static Exception LabelTargetUndefined(object p0) { }

	internal static Exception LabelTypeMustBeVoid(string paramName) { }

	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	internal static Exception MustBeReducible() { }

	internal static Exception MustReduceToDifferent() { }

	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	internal static Exception NonAbstractConstructorRequired() { }

	internal static Exception NonLocalJumpWithValue(object p0) { }

	internal static Exception NoOrInvalidRuleProduced() { }

	internal static Exception NotSupported() { }

	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	internal static Exception OutOfRange(string paramName, object p1) { }

	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	internal static Exception ReducedNotCompatible() { }

	internal static Exception ReducibleMustOverrideReduce() { }

	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	internal static Exception RethrowRequiresCatch() { }

	internal static Exception SameKeyExistsInExpando(object key) { }

	internal static Exception SetterHasNoParams(string paramName) { }

	internal static Exception SetterMustBeVoid(string paramName) { }

	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	internal static Exception TypeMustBeDerivedFromSystemDelegate() { }

	internal static Exception TypeMustNotBeByRef(string paramName) { }

	internal static Exception TypeMustNotBePointer(string paramName) { }

	internal static Exception TypeParameterIsNotDelegate(object p0) { }

	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	internal static Exception UnhandledBinary(object p0, string paramName) { }

	internal static Exception UnhandledUnary(object p0, string paramName) { }

	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

}

