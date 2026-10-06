namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Activator))]
[ComVisible(True)]
public sealed class Activator
{

	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture) { }

	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes) { }

	public static object CreateInstance(Type type, Object[] args) { }

	public static object CreateInstance(Type type, Object[] args, Object[] activationAttributes) { }

	public static object CreateInstance(Type type) { }

	public static object CreateInstance(Type type, bool nonPublic) { }

	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	public static T CreateInstance() { }

}

