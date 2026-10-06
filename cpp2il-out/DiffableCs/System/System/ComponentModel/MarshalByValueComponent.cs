namespace System.ComponentModel;

[DesignerCategory("Component")]
[TypeConverter(typeof(ComponentConverter))]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
{
	private static readonly object s_eventDisposed; //Field offset: 0x0
	private ISite _site; //Field offset: 0x10
	private EventHandlerList _events; //Field offset: 0x18

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public override ISite Site
	{
		 get { } //Length: 5
	}

	private static MarshalByValueComponent() { }

	public MarshalByValueComponent() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public override ISite get_Site() { }

	public override object GetService(Type service) { }

	public virtual string ToString() { }

}

