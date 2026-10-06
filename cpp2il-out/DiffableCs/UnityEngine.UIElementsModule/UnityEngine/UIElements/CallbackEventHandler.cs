namespace UnityEngine.UIElements;

public abstract class CallbackEventHandler : IEventHandler
{
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction"; //Field offset: 0x0
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget"; //Field offset: 0x0
	internal bool isIMGUIContainer; //Field offset: 0x10
	private EventCallbackRegistry m_CallbackRegistry; //Field offset: 0x18

	protected CallbackEventHandler() { }

	private void AddEventCategories() { }

	[EventInterest(EventInterestOptions::Inherit (0))]
	protected override void ExecuteDefaultAction(EventBase evt) { }

	[EventInterest(EventInterestOptions::Inherit (0))]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	[EventInterest(EventInterestOptions::Inherit (0))]
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	[EventInterest(EventInterestOptions::Inherit (0))]
	internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	[Obsolete("The virtual method CallbackEventHandler.HandleEvent is deprecated and will be removed in a future release. Please override ExecuteDefaultAction instead.")]
	public override void HandleEvent(EventBase evt) { }

	internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) { }

	internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) { }

	internal void HandleEventAtTargetPhase(EventBase evt) { }

	public override bool HasBubbleUpHandlers() { }

	public override bool HasTrickleDownHandlers() { }

	internal void RegisterCallback(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = 0) { }

	public void RegisterCallback(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = 0) { }

	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	public abstract void SendEvent(EventBase e) { }

	private override void UnityEngine.UIElements.IEventHandler.HandleEvent(EventBase evt) { }

	public void UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

}

