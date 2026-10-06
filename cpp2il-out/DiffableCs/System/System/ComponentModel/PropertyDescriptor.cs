namespace System.ComponentModel;

public abstract class PropertyDescriptor : MemberDescriptor
{
	private TypeConverter _converter; //Field offset: 0x60
	private Hashtable _valueChangedHandlers; //Field offset: 0x68
	private Object[] _editors; //Field offset: 0x70
	private Type[] _editorTypes; //Field offset: 0x78
	private int _editorCount; //Field offset: 0x80

	public abstract Type ComponentType
	{
		 get { } //Length: 0
	}

	public override TypeConverter Converter
	{
		 get { } //Length: 701
	}

	public abstract bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	protected PropertyDescriptor(string name, Attribute[] attrs) { }

	protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) { }

	public abstract bool CanResetValue(object component) { }

	protected object CreateInstance(Type type) { }

	public virtual bool Equals(object obj) { }

	protected virtual void FillAttributes(IList attributeList) { }

	public abstract Type get_ComponentType() { }

	public override TypeConverter get_Converter() { }

	public abstract bool get_IsReadOnly() { }

	public abstract Type get_PropertyType() { }

	public virtual int GetHashCode() { }

	protected virtual object GetInvocationTarget(Type type, object instance) { }

	protected Type GetTypeFromName(string typeName) { }

	public abstract object GetValue(object component) { }

	protected override void OnValueChanged(object component, EventArgs e) { }

	public abstract void ResetValue(object component) { }

	public abstract void SetValue(object component, object value) { }

	public abstract bool ShouldSerializeValue(object component) { }

}

