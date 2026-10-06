namespace Mono;

internal struct RuntimeGenericParamInfoHandle
{
	private GenericParamInfo* value; //Field offset: 0x0

	internal GenericParameterAttributes Attributes
	{
		internal get { } //Length: 26
	}

	internal Type[] Constraints
	{
		internal get { } //Length: 7
	}

	internal RuntimeGenericParamInfoHandle(IntPtr ptr) { }

	internal GenericParameterAttributes get_Attributes() { }

	internal Type[] get_Constraints() { }

	private Type[] GetConstraints() { }

	private int GetConstraintsCount() { }

}

