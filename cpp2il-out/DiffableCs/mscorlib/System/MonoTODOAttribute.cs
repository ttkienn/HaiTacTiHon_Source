namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
internal class MonoTODOAttribute : Attribute
{
	private string comment; //Field offset: 0x10

	public MonoTODOAttribute() { }

	public MonoTODOAttribute(string comment) { }

}

