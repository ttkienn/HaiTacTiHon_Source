namespace System;

internal class ReflectionOnlyType : RuntimeType
{

	public virtual RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 95
	}

	private ReflectionOnlyType() { }

	public virtual RuntimeTypeHandle get_TypeHandle() { }

}

