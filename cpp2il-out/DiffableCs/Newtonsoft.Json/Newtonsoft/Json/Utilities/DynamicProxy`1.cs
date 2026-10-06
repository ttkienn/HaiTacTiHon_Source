namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class DynamicProxy
{

	public DynamicProxy`1() { }

	public override IEnumerable<String> GetDynamicMemberNames(T instance) { }

	public override bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }

	public override bool TryConvert(T instance, ConvertBinder binder, out object result) { }

	public override bool TryCreateInstance(T instance, CreateInstanceBinder binder, Object[] args, out object result) { }

	public override bool TryDeleteIndex(T instance, DeleteIndexBinder binder, Object[] indexes) { }

	public override bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	public override bool TryGetIndex(T instance, GetIndexBinder binder, Object[] indexes, out object result) { }

	public override bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }

	public override bool TryInvoke(T instance, InvokeBinder binder, Object[] args, out object result) { }

	public override bool TryInvokeMember(T instance, InvokeMemberBinder binder, Object[] args, out object result) { }

	public override bool TrySetIndex(T instance, SetIndexBinder binder, Object[] indexes, object value) { }

	public override bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	public override bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }

}

