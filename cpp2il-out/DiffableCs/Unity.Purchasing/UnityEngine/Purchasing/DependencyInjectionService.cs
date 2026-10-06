namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class DependencyInjectionService : IDependencyInjectionService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<CustomAttributeData, Boolean> <>9__13_1; //Field offset: 0x8
		[Nullable(0)]
		public static Func<ConstructorInfo, Boolean> <>9__13_0; //Field offset: 0x10
		[Nullable(0)]
		public static Func<ParameterInfo, Type> <>9__14_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal bool <FindInjectableConstructors>b__13_0(ConstructorInfo constructor) { }

		[NullableContext(0)]
		internal bool <FindInjectableConstructors>b__13_1(CustomAttributeData attribute) { }

		[NullableContext(0)]
		internal Type <GetParameterInstancesForConstructor>b__14_0(ParameterInfo paramInfo) { }

	}

	private readonly HashSet<Object> m_ServiceInstances; //Field offset: 0x10
	private readonly HashSet<Type> m_ServiceConcreteTypes; //Field offset: 0x18

	public DependencyInjectionService() { }

	public override void AddInstance(object instance) { }

	public override void AddService() { }

	private object CreateServiceInstance(Type concreteType) { }

	private Type FindConcreteServiceType(Type type) { }

	private ConstructorInfo FindConstructorForType(Type concreteType) { }

	private List<ConstructorInfo> FindInjectableConstructors(ConstructorInfo[] constructors) { }

	private object FindServiceInstance(Type type) { }

	public override T GetInstance() { }

	private object GetInstance(Type type) { }

	private Object[] GetParameterInstancesForConstructor(ConstructorInfo constructor) { }

	private ConstructorInfo HandleMultipleConstructors(ConstructorInfo[] constructors, Type concreteType) { }

	private void ValidateTypeIsNotADuplicate(Type type) { }

	private void ValidateTypeIsNotAnInterface(Type type) { }

}

