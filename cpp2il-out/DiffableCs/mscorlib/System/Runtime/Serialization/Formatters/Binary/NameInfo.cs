namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameInfo
{
	internal string NIFullName; //Field offset: 0x10
	internal long NIobjectId; //Field offset: 0x18
	internal long NIassemId; //Field offset: 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; //Field offset: 0x28
	internal Type NItype; //Field offset: 0x30
	internal bool NIisSealed; //Field offset: 0x38
	internal bool NIisArray; //Field offset: 0x39
	internal bool NIisArrayItem; //Field offset: 0x3A
	internal bool NItransmitTypeOnObject; //Field offset: 0x3B
	internal bool NItransmitTypeOnMember; //Field offset: 0x3C
	internal bool NIisParentTypeOnObject; //Field offset: 0x3D
	internal InternalArrayTypeE NIarrayEnum; //Field offset: 0x40
	private bool NIsealedStatusChecked; //Field offset: 0x44

	public bool IsSealed
	{
		 get { } //Length: 53
	}

	public string NIname
	{
		 get { } //Length: 75
		 set { } //Length: 13
	}

	internal NameInfo() { }

	public bool get_IsSealed() { }

	public string get_NIname() { }

	internal void Init() { }

	public void set_NIname(string value) { }

}

