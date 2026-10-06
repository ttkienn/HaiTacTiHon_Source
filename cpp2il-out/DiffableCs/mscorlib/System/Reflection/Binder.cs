namespace System.Reflection;

public abstract class Binder
{

	protected Binder() { }

	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture) { }

	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] names, out object state) { }

	public abstract object ChangeType(object value, Type type, CultureInfo culture) { }

	public abstract void ReorderArgumentArray(ref Object[] args, object state) { }

	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

