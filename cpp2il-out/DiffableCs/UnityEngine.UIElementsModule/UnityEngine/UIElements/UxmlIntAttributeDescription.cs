namespace UnityEngine.UIElements;

public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<Int32>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Int32, Int32> <>9__3_0; //Field offset: 0x8
		public static Func<String, Int32, Int32> <>9__4_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <GetValueFromBag>b__3_0(string s, int i) { }

		internal int <TryGetValueFromBag>b__4_0(string s, int i) { }

	}


	public UxmlIntAttributeDescription() { }

	private static int ConvertValueToInt(string v, int defaultValue) { }

	public virtual int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) { }

}

