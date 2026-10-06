namespace UnityEngine.UIElements;

internal static class UIEventRegistration
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__1_0() { }

		internal void <.cctor>b__1_1() { }

		internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

		internal void <.cctor>b__1_3() { }

		internal bool <.cctor>b__1_4(Exception exception) { }

		internal void <.cctor>b__1_5() { }

	}

	private static List<IUIElementsUtility> s_Utilities; //Field offset: 0x0

	private static UIEventRegistration() { }

	private static void CleanupRoots() { }

	private static bool EndContainerGUIFromException(Exception exception) { }

	internal static void MakeCurrentIMGUIContainerDirty() { }

	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	private static void ReleaseCapture() { }

	private static void TakeCapture() { }

}

