namespace System.Xml.Schema;

public class XmlSchemaInferenceException : XmlSchemaException
{

	protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context) { }

	public XmlSchemaInferenceException() { }

	internal XmlSchemaInferenceException(string res, string arg) { }

	internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

