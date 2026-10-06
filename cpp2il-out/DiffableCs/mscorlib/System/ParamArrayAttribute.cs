namespace System;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = True, AllowMultiple = False)]
public sealed class ParamArrayAttribute : Attribute
{

	public ParamArrayAttribute() { }

}

