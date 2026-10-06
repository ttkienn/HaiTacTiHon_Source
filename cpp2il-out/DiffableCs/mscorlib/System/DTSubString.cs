namespace System;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DTSubString
{
	internal ReadOnlySpan<Char> s; //Field offset: 0x0
	internal int index; //Field offset: 0x10
	internal int length; //Field offset: 0x14
	internal DTSubStringType type; //Field offset: 0x18
	internal int value; //Field offset: 0x1C

	internal char Item
	{
		internal get { } //Length: 37
	}

	internal char get_Item(int relativeIndex) { }

}

