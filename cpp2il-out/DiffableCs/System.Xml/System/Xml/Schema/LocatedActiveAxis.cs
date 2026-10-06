namespace System.Xml.Schema;

internal class LocatedActiveAxis : ActiveAxis
{
	private int column; //Field offset: 0x28
	internal bool isMatched; //Field offset: 0x2C
	internal KeySequence Ks; //Field offset: 0x30

	internal int Column
	{
		internal get { } //Length: 4
	}

	internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column) { }

	internal int get_Column() { }

	internal void Reactivate(KeySequence ks) { }

}

