namespace System.ComponentModel;

internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
{
	private static readonly Type[] argsNone; //Field offset: 0x0
	private static readonly object noValue; //Field offset: 0x8
	private static TraceSwitch PropDescCreateSwitch; //Field offset: 0x10
	private static TraceSwitch PropDescUsageSwitch; //Field offset: 0x18
	private static readonly int BitDefaultValueQueried; //Field offset: 0x20
	private static readonly int BitGetQueried; //Field offset: 0x24
	private static readonly int BitSetQueried; //Field offset: 0x28
	private static readonly int BitShouldSerializeQueried; //Field offset: 0x2C
	private static readonly int BitResetQueried; //Field offset: 0x30
	private static readonly int BitChangedQueried; //Field offset: 0x34
	private static readonly int BitIPropChangedQueried; //Field offset: 0x38
	private static readonly int BitReadOnlyChecked; //Field offset: 0x3C
	private static readonly int BitAmbientValueQueried; //Field offset: 0x40
	private static readonly int BitSetOnDemand; //Field offset: 0x44
	private BitVector32 state; //Field offset: 0x88
	private Type componentClass; //Field offset: 0x90
	private Type type; //Field offset: 0x98
	private object defaultValue; //Field offset: 0xA0
	private object ambientValue; //Field offset: 0xA8
	private PropertyInfo propInfo; //Field offset: 0xB0
	private MethodInfo getMethod; //Field offset: 0xB8
	private MethodInfo setMethod; //Field offset: 0xC0
	private MethodInfo shouldSerializeMethod; //Field offset: 0xC8
	private MethodInfo resetMethod; //Field offset: 0xD0
	private EventDescriptor realChangedEvent; //Field offset: 0xD8
	private Type receiverType; //Field offset: 0xE0

	private object AmbientValue
	{
		private get { } //Length: 444
	}

	public virtual Type ComponentType
	{
		 get { } //Length: 8
	}

	private object DefaultValue
	{
		private get { } //Length: 800
	}

	private MethodInfo GetMethodValue
	{
		private get { } //Length: 1345
	}

	private bool IsExtender
	{
		private get { } //Length: 83
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 262
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 8
	}

	private MethodInfo ResetMethodValue
	{
		private get { } //Length: 607
	}

	private MethodInfo SetMethodValue
	{
		private get { } //Length: 1689
	}

	private MethodInfo ShouldSerializeMethodValue
	{
		private get { } //Length: 607
	}

	private static ReflectPropertyDescriptor() { }

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	public virtual bool CanResetValue(object component) { }

	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	internal Type ExtenderGetReceiverType() { }

	internal Type ExtenderGetType(IExtenderProvider provider) { }

	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	protected virtual void FillAttributes(IList attributes) { }

	private object get_AmbientValue() { }

	public virtual Type get_ComponentType() { }

	private object get_DefaultValue() { }

	private MethodInfo get_GetMethodValue() { }

	private bool get_IsExtender() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	private MethodInfo get_ResetMethodValue() { }

	private MethodInfo get_SetMethodValue() { }

	private MethodInfo get_ShouldSerializeMethodValue() { }

	public virtual object GetValue(object component) { }

	protected virtual void OnValueChanged(object component, EventArgs e) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

