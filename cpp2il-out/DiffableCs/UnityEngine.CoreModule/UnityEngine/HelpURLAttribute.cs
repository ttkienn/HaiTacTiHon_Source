namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[UsedByNativeCode]
public class HelpURLAttribute : Attribute
{
	internal readonly string m_Url; //Field offset: 0x10
	internal readonly bool m_Dispatcher; //Field offset: 0x18
	internal readonly string m_DispatchingFieldName; //Field offset: 0x20

	public HelpURLAttribute(string url) { }

}

