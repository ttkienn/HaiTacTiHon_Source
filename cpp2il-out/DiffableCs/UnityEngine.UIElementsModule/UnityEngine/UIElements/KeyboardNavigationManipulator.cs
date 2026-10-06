namespace UnityEngine.UIElements;

public class KeyboardNavigationManipulator : Manipulator
{
	[CompilerGenerated]
	private struct <>c__DisplayClass4_0
	{
		public KeyDownEvent evt; //Field offset: 0x0

	}

	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; //Field offset: 0x18

	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) { }

	[CompilerGenerated]
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref <>c__DisplayClass4_0 unnamed_param_0) { }

	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	internal void OnKeyDown(KeyDownEvent evt) { }

	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	private void OnNavigationMove(NavigationMoveEvent evt) { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	protected virtual void RegisterCallbacksOnTarget() { }

	protected virtual void UnregisterCallbacksFromTarget() { }

}

