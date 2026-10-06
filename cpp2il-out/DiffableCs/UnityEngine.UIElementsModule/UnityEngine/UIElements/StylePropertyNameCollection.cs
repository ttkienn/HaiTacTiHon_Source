namespace UnityEngine.UIElements;

public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	internal struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		private Enumerator<StylePropertyName> m_Enumerator; //Field offset: 0x0

		public override StylePropertyName Current
		{
			 get { } //Length: 65
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 97
		}

		internal Enumerator(Enumerator<StylePropertyName> enumerator) { }

		public override void Dispose() { }

		public override StylePropertyName get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal List<StylePropertyName> propertiesList; //Field offset: 0x0

	internal StylePropertyNameCollection(List<StylePropertyName> list) { }

	public Enumerator GetEnumerator() { }

	private override IEnumerator<StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

