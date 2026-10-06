namespace UnityEngine.UIElements;

public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<String>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String, String> <>9__3_0; //Field offset: 0x8
		public static Func<String, String, String> <>9__4_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetValueFromBag>b__3_0(string s, string t) { }

		internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

	}


	public UxmlStringAttributeDescription() { }

	public virtual string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }

}

