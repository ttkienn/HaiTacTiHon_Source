namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
internal class MonoLimitationAttribute : MonoTODOAttribute
{

	public MonoLimitationAttribute(string comment) { }

}

