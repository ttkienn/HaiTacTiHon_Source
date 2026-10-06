namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase
{
	[DefaultMember("Item")]
	public sealed class DataSetRelationCollection : DataRelationCollection
	{
		private readonly DataSet _dataSet; //Field offset: 0x38
		private readonly ArrayList _relations; //Field offset: 0x40
		private DataRelation[] _delayLoadingRelations; //Field offset: 0x48

		public virtual DataRelation Item
		{
			 get { } //Length: 266
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 249
		}

		protected virtual ArrayList List
		{
			 get { } //Length: 5
		}

		internal DataSetRelationCollection(DataSet dataSet) { }

		protected virtual void AddCore(DataRelation relation) { }

		public virtual void Clear() { }

		public virtual DataRelation get_Item(int index) { }

		public virtual DataRelation get_Item(string name) { }

		protected virtual ArrayList get_List() { }

		protected virtual DataSet GetDataSet() { }

		protected virtual void RemoveCore(DataRelation relation) { }

	}

	[DefaultMember("Item")]
	public sealed class DataTableRelationCollection : DataRelationCollection
	{
		private readonly DataTable _table; //Field offset: 0x38
		private readonly ArrayList _relations; //Field offset: 0x40
		private readonly bool _fParentCollection; //Field offset: 0x48
		[CompilerGenerated]
		private CollectionChangeEventHandler RelationPropertyChanged; //Field offset: 0x50

		internal event CollectionChangeEventHandler RelationPropertyChanged
		{
			[CompilerGenerated]
			internal add { } //Length: 158
			[CompilerGenerated]
			internal remove { } //Length: 158
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 266
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 249
		}

		protected virtual ArrayList List
		{
			 get { } //Length: 5
		}

		internal DataTableRelationCollection(DataTable table, bool fParentCollection) { }

		[CompilerGenerated]
		internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		private void AddCache(DataRelation relation) { }

		protected virtual void AddCore(DataRelation relation) { }

		private void EnsureDataSet() { }

		public virtual DataRelation get_Item(int index) { }

		public virtual DataRelation get_Item(string name) { }

		protected virtual ArrayList get_List() { }

		protected virtual DataSet GetDataSet() { }

		[CompilerGenerated]
		internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		private void RemoveCache(DataRelation relation) { }

		protected virtual void RemoveCore(DataRelation relation) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private DataRelation _inTransition; //Field offset: 0x10
	private int _defaultNameIndex; //Field offset: 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x28
	private readonly int _objectID; //Field offset: 0x30

	public event CollectionChangeEventHandler CollectionChanged
	{
		 add { } //Length: 270
		 remove { } //Length: 270
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	internal int ObjectID
	{
		internal get { } //Length: 4
	}

	protected DataRelationCollection() { }

	public void Add(DataRelation relation) { }

	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	protected override void AddCore(DataRelation relation) { }

	internal string AssignName() { }

	public override void Clear() { }

	public override bool Contains(string name) { }

	public abstract DataRelation get_Item(int index) { }

	public abstract DataRelation get_Item(string name) { }

	internal int get_ObjectID() { }

	protected abstract DataSet GetDataSet() { }

	internal int InternalIndexOf(string name) { }

	private string MakeName(int index) { }

	protected override void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	protected override void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void RegisterName(string name) { }

	public void Remove(DataRelation relation) { }

	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	public void RemoveAt(int index) { }

	protected override void RemoveCore(DataRelation relation) { }

	internal void UnregisterName(string name) { }

}

