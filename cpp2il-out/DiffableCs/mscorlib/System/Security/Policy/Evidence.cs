namespace System.Security.Policy;

[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
public sealed class Evidence : ICollection, IEnumerable
{
	private class EvidenceEnumerator : IEnumerator
	{
		private IEnumerator currentEnum; //Field offset: 0x10
		private IEnumerator hostEnum; //Field offset: 0x18
		private IEnumerator assemblyEnum; //Field offset: 0x20

		public override object Current
		{
			 get { } //Length: 73
		}

		public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private bool _locked; //Field offset: 0x10
	private ArrayList hostEvidenceList; //Field offset: 0x18
	private ArrayList assemblyEvidenceList; //Field offset: 0x20

	[Obsolete]
	public override int Count
	{
		 get { } //Length: 103
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	public Evidence() { }

	[Obsolete]
	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public override object get_SyncRoot() { }

	[Obsolete]
	public override IEnumerator GetEnumerator() { }

}

