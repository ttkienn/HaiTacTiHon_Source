namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal abstract class ReflectionDelegateFactory
{

	protected ReflectionDelegateFactory() { }

	public abstract Func<T> CreateDefaultConstructor(Type type) { }

	public Func<T, Object> CreateGet(MemberInfo memberInfo) { }

	public abstract Func<T, Object> CreateGet(PropertyInfo propertyInfo) { }

	public abstract Func<T, Object> CreateGet(FieldInfo fieldInfo) { }

	public abstract MethodCall<T, Object> CreateMethodCall(MethodBase method) { }

	public abstract ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method) { }

	public Action<T, Object> CreateSet(MemberInfo memberInfo) { }

	public abstract Action<T, Object> CreateSet(FieldInfo fieldInfo) { }

	public abstract Action<T, Object> CreateSet(PropertyInfo propertyInfo) { }

}

