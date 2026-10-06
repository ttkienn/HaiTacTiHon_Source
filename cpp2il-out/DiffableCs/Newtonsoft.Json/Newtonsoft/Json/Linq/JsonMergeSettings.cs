namespace Newtonsoft.Json.Linq;

public class JsonMergeSettings
{
	private MergeArrayHandling _mergeArrayHandling; //Field offset: 0x10
	private MergeNullValueHandling _mergeNullValueHandling; //Field offset: 0x14
	private StringComparison _propertyNameComparison; //Field offset: 0x18

	public MergeArrayHandling MergeArrayHandling
	{
		 get { } //Length: 191
		 set { } //Length: 99
	}

	public MergeNullValueHandling MergeNullValueHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public StringComparison PropertyNameComparison
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public JsonMergeSettings() { }

	public MergeArrayHandling get_MergeArrayHandling() { }

	public MergeNullValueHandling get_MergeNullValueHandling() { }

	public StringComparison get_PropertyNameComparison() { }

	public void set_MergeArrayHandling(MergeArrayHandling value) { }

	public void set_MergeNullValueHandling(MergeNullValueHandling value) { }

	public void set_PropertyNameComparison(StringComparison value) { }

}

