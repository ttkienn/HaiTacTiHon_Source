namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(2)]
internal interface IGoogleLastKnownProductService
{

	public string LastKnownOldProductId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string LastKnownProductId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Nullable<GooglePlayReplacementMode> LastKnownReplacementMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_LastKnownOldProductId() { }

	public string get_LastKnownProductId() { }

	public Nullable<GooglePlayReplacementMode> get_LastKnownReplacementMode() { }

	public void set_LastKnownOldProductId(string value) { }

	public void set_LastKnownProductId(string value) { }

	public void set_LastKnownReplacementMode(Nullable<GooglePlayReplacementMode> value) { }

}

