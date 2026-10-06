namespace System.Xml.Schema;

internal class AutoValidator : BaseValidator
{

	public virtual bool PreserveWhitespace
	{
		 get { } //Length: 3
	}

	public AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	public virtual void CompleteValidation() { }

	private ValidationType DetectValidationType() { }

	public virtual object FindId(string name) { }

	public virtual bool get_PreserveWhitespace() { }

	public virtual void Validate() { }

}

