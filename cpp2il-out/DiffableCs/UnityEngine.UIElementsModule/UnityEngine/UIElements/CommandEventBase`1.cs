namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Command (14))]
public abstract class CommandEventBase : EventBase<T>, ICommandEvent
{
	private string m_CommandName; //Field offset: 0x0

	public override string commandName
	{
		 get { } //Length: 79
		 set { } //Length: 19
	}

	protected CommandEventBase`1() { }

	public override string get_commandName() { }

	public static T GetPooled(Event systemEvent) { }

	public static T GetPooled(string commandName) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected void set_commandName(string value) { }

}

