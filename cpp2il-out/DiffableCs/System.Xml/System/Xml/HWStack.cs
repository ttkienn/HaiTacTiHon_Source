namespace System.Xml;

[DefaultMember("Item")]
internal class HWStack : ICloneable
{
	private Object[] stack; //Field offset: 0x10
	private int growthRate; //Field offset: 0x18
	private int used; //Field offset: 0x1C
	private int size; //Field offset: 0x20
	private int limit; //Field offset: 0x24

	internal object Item
	{
		internal get { } //Length: 117
		internal set { } //Length: 196
	}

	internal int Length
	{
		internal get { } //Length: 4
	}

	internal HWStack(int GrowthRate) { }

	internal HWStack(int GrowthRate, int limit) { }

	private HWStack(Object[] stack, int growthRate, int used, int size) { }

	internal void AddToTop(object o) { }

	public override object Clone() { }

	internal object get_Item(int index) { }

	internal int get_Length() { }

	internal object Peek() { }

	internal object Pop() { }

	internal object Push() { }

	internal void set_Item(int index, object value) { }

}

