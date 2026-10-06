namespace System.Runtime.Remoting;

[ComVisible(True)]
public class SoapServices
{
	private class TypeInfo
	{
		public Hashtable Attributes; //Field offset: 0x10
		public Hashtable Elements; //Field offset: 0x18

		public TypeInfo() { }

	}

	private static Hashtable _xmlTypes; //Field offset: 0x0
	private static Hashtable _xmlElements; //Field offset: 0x8
	private static Hashtable _soapActions; //Field offset: 0x10
	private static Hashtable _soapActionsMethods; //Field offset: 0x18
	private static Hashtable _typeInfos; //Field offset: 0x20

	public static string XmlNsForClrTypeWithAssembly
	{
		 get { } //Length: 44
	}

	public static string XmlNsForClrTypeWithNs
	{
		 get { } //Length: 44
	}

	public static string XmlNsForClrTypeWithNsAndAssembly
	{
		 get { } //Length: 44
	}

	private static SoapServices() { }

	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	private static string EncodeNs(string ns) { }

	public static string get_XmlNsForClrTypeWithAssembly() { }

	public static string get_XmlNsForClrTypeWithNs() { }

	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	private static string GetAssemblyName(MethodBase mb) { }

	private static string GetNameKey(string name, string namspace) { }

	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	public static void PreLoad(Assembly assembly) { }

	public static void PreLoad(Type type) { }

	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

}

