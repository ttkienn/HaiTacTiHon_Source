namespace UnityEngine.UIElements;

public class UxmlEnumAttributeDescription : TypedUxmlAttributeDescription<T>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<String, T, T> <>9__3_0; //Field offset: 0x0
		public static Func<String, T, T> <>9__4_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <GetValueFromBag>b__3_0(string s, T convertible) { }

		internal T <TryGetValueFromBag>b__4_0(string s, T convertible) { }

	}


	public UxmlEnumAttributeDescription`1() { }

	private static U ConvertValueToEnum(string v, U defaultValue) { }

	private static string GetEnumNameErrorMessage(string v, Type enumType) { }

	private static string GetEnumRangeErrorMessage(string v, Type enumType) { }

	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value) { }

}

