namespace System.ComponentModel;

[ComVisible(True)]
public abstract class MemberDescriptor
{
	private string name; //Field offset: 0x10
	private string displayName; //Field offset: 0x18
	private int nameHash; //Field offset: 0x20
	private AttributeCollection attributeCollection; //Field offset: 0x28
	private Attribute[] attributes; //Field offset: 0x30
	private Attribute[] originalAttributes; //Field offset: 0x38
	private bool attributesFiltered; //Field offset: 0x40
	private bool attributesFilled; //Field offset: 0x41
	private int metadataVersion; //Field offset: 0x44
	private string category; //Field offset: 0x48
	private string description; //Field offset: 0x50
	private object lockCookie; //Field offset: 0x58

	protected override Attribute[] AttributeArray
	{
		 get { } //Length: 36
		 set { } //Length: 193
	}

	public override AttributeCollection Attributes
	{
		 get { } //Length: 215
	}

	public override string DisplayName
	{
		 get { } //Length: 328
	}

	public override string Name
	{
		 get { } //Length: 67
	}

	protected override int NameHashCode
	{
		 get { } //Length: 4
	}

	protected MemberDescriptor(string name, Attribute[] attributes) { }

	protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	private void CheckAttributesValid() { }

	protected override AttributeCollection CreateAttributeCollection() { }

	public virtual bool Equals(object obj) { }

	protected override void FillAttributes(IList attributeList) { }

	private void FilterAttributesIfNeeded() { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	protected override Attribute[] get_AttributeArray() { }

	public override AttributeCollection get_Attributes() { }

	public override string get_DisplayName() { }

	public override string get_Name() { }

	protected override int get_NameHashCode() { }

	public virtual int GetHashCode() { }

	protected override object GetInvocationTarget(Type type, object instance) { }

	protected static ISite GetSite(object component) { }

	protected override void set_AttributeArray(Attribute[] value) { }

}

