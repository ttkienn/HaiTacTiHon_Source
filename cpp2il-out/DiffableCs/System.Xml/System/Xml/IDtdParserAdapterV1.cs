namespace System.Xml;

internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
{

	public bool Namespaces
	{
		 get { } //Length: 0
	}

	public bool Normalization
	{
		 get { } //Length: 0
	}

	public bool V1CompatibilityMode
	{
		 get { } //Length: 0
	}

	public bool get_Namespaces() { }

	public bool get_Normalization() { }

	public bool get_V1CompatibilityMode() { }

}

