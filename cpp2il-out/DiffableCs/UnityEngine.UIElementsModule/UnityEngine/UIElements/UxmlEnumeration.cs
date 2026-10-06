namespace UnityEngine.UIElements;

public class UxmlEnumeration : UxmlTypeRestriction
{
	private List<String> m_Values; //Field offset: 0x10

	public IEnumerable<String> values
	{
		 get { } //Length: 7
		 set { } //Length: 85
	}

	public UxmlEnumeration() { }

	public virtual bool Equals(UxmlTypeRestriction other) { }

	public IEnumerable<String> get_values() { }

	public void set_values(IEnumerable<String> value) { }

}

