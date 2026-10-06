namespace System;

internal static class SecurityUtils
{

	private static void DemandGrantSet(Assembly assembly) { }

	private static void DemandReflectionAccess(Type type) { }

	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	private static bool HasReflectionPermission(Type type) { }

	internal static object MethodInfoInvoke(MethodInfo method, object target, Object[] args) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	internal static object SecureCreateInstance(Type type) { }

	internal static object SecureCreateInstance(Type type, Object[] args, bool allowNonPublic) { }

	internal static object SecureCreateInstance(Type type, Object[] args) { }

}

