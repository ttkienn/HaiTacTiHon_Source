namespace UnityEngine.UIElements;

public class SortColumnDescription
{
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		public UxmlObjectFactory`1() { }

	}

	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		private readonly UxmlStringAttributeDescription m_ColumnName; //Field offset: 0x0
		private readonly UxmlIntAttributeDescription m_ColumnIndex; //Field offset: 0x0
		private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription; //Field offset: 0x0

		public UxmlObjectTraits`1() { }

		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[SerializeField]
	private int m_ColumnIndex; //Field offset: 0x10
	[SerializeField]
	private string m_ColumnName; //Field offset: 0x18
	[SerializeField]
	private SortDirection m_SortDirection; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Column <column>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<SortColumnDescription> changed; //Field offset: 0x30

	internal event Action<SortColumnDescription> changed
	{
		[CompilerGenerated]
		internal add { } //Length: 172
		[CompilerGenerated]
		internal remove { } //Length: 172
	}

	public internal Column column
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public int columnIndex
	{
		 get { } //Length: 191
		 set { } //Length: 36
	}

	public string columnName
	{
		 get { } //Length: 5
		 set { } //Length: 85
	}

	public SortDirection direction
	{
		 get { } //Length: 4
		 set { } //Length: 36
	}

	public SortColumnDescription() { }

	public SortColumnDescription(int columnIndex, SortDirection direction) { }

	public SortColumnDescription(string columnName, SortDirection direction) { }

	[CompilerGenerated]
	internal void add_changed(Action<SortColumnDescription> value) { }

	[CompilerGenerated]
	public Column get_column() { }

	public int get_columnIndex() { }

	public string get_columnName() { }

	public SortDirection get_direction() { }

	[CompilerGenerated]
	internal void remove_changed(Action<SortColumnDescription> value) { }

	[CompilerGenerated]
	internal void set_column(Column value) { }

	public void set_columnIndex(int value) { }

	public void set_columnName(string value) { }

	public void set_direction(SortDirection value) { }

}

