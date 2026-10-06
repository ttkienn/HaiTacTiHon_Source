namespace System.Xml;

internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
{

	public bool DtdValidation
	{
		 get { } //Length: 0
	}

	public IValidationEventHandling ValidationEventHandling
	{
		 get { } //Length: 0
	}

	public bool get_DtdValidation() { }

	public IValidationEventHandling get_ValidationEventHandling() { }

}

