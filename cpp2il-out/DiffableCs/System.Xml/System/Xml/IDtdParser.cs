namespace System.Xml;

internal interface IDtdParser
{

	public IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	public IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

}

