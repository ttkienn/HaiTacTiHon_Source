namespace System.Drawing;

[DebuggerDisplay("{NameAndARGBValue}")]
[IsReadOnly]
public struct Color : IEquatable<Color>
{
	private readonly string name; //Field offset: 0x0
	private readonly long value; //Field offset: 0x8
	private readonly short knownColor; //Field offset: 0x10
	private readonly short state; //Field offset: 0x12

	public byte A
	{
		 get { } //Length: 20
	}

	public byte B
	{
		 get { } //Length: 7
	}

	public byte G
	{
		 get { } //Length: 20
	}

	public bool IsKnownColor
	{
		 get { } //Length: 8
	}

	public string Name
	{
		 get { } //Length: 247
	}

	public byte R
	{
		 get { } //Length: 20
	}

	private long Value
	{
		private get { } //Length: 182
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Color other) { }

	public byte get_A() { }

	public byte get_B() { }

	public byte get_G() { }

	public bool get_IsKnownColor() { }

	public string get_Name() { }

	public byte get_R() { }

	private long get_Value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Color left, Color right) { }

	public virtual string ToString() { }

}

