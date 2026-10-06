namespace System;

internal interface TypeName : IEquatable<TypeName>
{

	public string DisplayName
	{
		 get { } //Length: 0
	}

	public string get_DisplayName() { }

}

