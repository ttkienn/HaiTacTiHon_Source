namespace System;

internal class InvariantComparer : IComparer
{
	internal static readonly InvariantComparer Default; //Field offset: 0x0
	private CompareInfo m_compareInfo; //Field offset: 0x10

	private static InvariantComparer() { }

	internal InvariantComparer() { }

	public override int Compare(object a, object b) { }

}

