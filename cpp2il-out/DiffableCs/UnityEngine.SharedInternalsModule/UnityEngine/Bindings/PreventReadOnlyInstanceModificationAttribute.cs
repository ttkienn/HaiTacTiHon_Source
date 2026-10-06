namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
[VisibleToOtherModules]
internal class PreventReadOnlyInstanceModificationAttribute : Attribute
{

	public PreventReadOnlyInstanceModificationAttribute() { }

}

