namespace UnityEngine.UIElements;

internal class TemplateAsset : VisualElementAsset
{
	internal struct AttributeOverride
	{
		public string m_ElementName; //Field offset: 0x0
		public string m_AttributeName; //Field offset: 0x8
		public string m_Value; //Field offset: 0x10

	}

	[SerializeField]
	private string m_TemplateAlias; //Field offset: 0x70
	[SerializeField]
	private List<AttributeOverride> m_AttributeOverrides; //Field offset: 0x78
	[SerializeField]
	private List<SlotUsageEntry> m_SlotUsages; //Field offset: 0x80

	public List<AttributeOverride> attributeOverrides
	{
		 get { } //Length: 131
	}

	internal List<SlotUsageEntry> slotUsages
	{
		internal get { } //Length: 10
	}

	public List<AttributeOverride> get_attributeOverrides() { }

	internal List<SlotUsageEntry> get_slotUsages() { }

}

