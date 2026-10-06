namespace System.Collections;

public interface IDictionaryEnumerator : IEnumerator
{

	public DictionaryEntry Entry
	{
		 get { } //Length: 0
	}

	public object Key
	{
		 get { } //Length: 0
	}

	public object Value
	{
		 get { } //Length: 0
	}

	public DictionaryEntry get_Entry() { }

	public object get_Key() { }

	public object get_Value() { }

}

