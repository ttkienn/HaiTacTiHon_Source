namespace UnityEngine.UIElements;

[DefaultMember("Item")]
public class SortColumnDescriptions : ICollection<SortColumnDescription>, IEnumerable<SortColumnDescription>, IEnumerable
{
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[SerializeField]
	private readonly IList<SortColumnDescription> m_Descriptions; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action changed; //Field offset: 0x18

	internal event Action changed
	{
		[CompilerGenerated]
		internal add { } //Length: 158
		[CompilerGenerated]
		internal remove { } //Length: 158
	}

	public override int Count
	{
		 get { } //Length: 70
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 73
	}

	public SortColumnDescriptions() { }

	public override void Add(SortColumnDescription item) { }

	[CompilerGenerated]
	internal void add_changed(Action value) { }

	public override void Clear() { }

	public override bool Contains(SortColumnDescription item) { }

	public override void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override IEnumerator<SortColumnDescription> GetEnumerator() { }

	public void Insert(int index, SortColumnDescription desc) { }

	private void OnDescriptionChanged(SortColumnDescription desc) { }

	public override bool Remove(SortColumnDescription desc) { }

	[CompilerGenerated]
	internal void remove_changed(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

