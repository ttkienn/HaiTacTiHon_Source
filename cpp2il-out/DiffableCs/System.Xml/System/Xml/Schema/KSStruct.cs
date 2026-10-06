namespace System.Xml.Schema;

internal class KSStruct
{
	public int depth; //Field offset: 0x10
	public KeySequence ks; //Field offset: 0x18
	public LocatedActiveAxis[] fields; //Field offset: 0x20

	public KSStruct(KeySequence ks, int dim) { }

}

