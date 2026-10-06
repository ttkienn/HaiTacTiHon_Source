namespace System;

internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
{

	public string InternalName
	{
		 get { } //Length: 0
	}

	public string get_InternalName() { }

}

