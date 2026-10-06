namespace UnityEngine.TextCore.Text;

public class TextStyle
{
	internal static TextStyle k_NormalStyle; //Field offset: 0x0
	[SerializeField]
	private string m_Name; //Field offset: 0x10
	[SerializeField]
	private int m_HashCode; //Field offset: 0x18
	[SerializeField]
	private string m_OpeningDefinition; //Field offset: 0x20
	[SerializeField]
	private string m_ClosingDefinition; //Field offset: 0x28
	[SerializeField]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[SerializeField]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38
	[SerializeField]
	internal UInt32[] m_OpeningTagUnicodeArray; //Field offset: 0x40
	[SerializeField]
	internal UInt32[] m_ClosingTagUnicodeArray; //Field offset: 0x48

	public int hashCode
	{
		 get { } //Length: 6
	}

	public UInt32[] styleClosingTagArray
	{
		 get { } //Length: 7
	}

	public UInt32[] styleOpeningTagArray
	{
		 get { } //Length: 7
	}

	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	public int get_hashCode() { }

	public UInt32[] get_styleClosingTagArray() { }

	public UInt32[] get_styleOpeningTagArray() { }

	public void RefreshStyle() { }

}

