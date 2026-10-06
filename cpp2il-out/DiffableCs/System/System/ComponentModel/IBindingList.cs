namespace System.ComponentModel;

public interface IBindingList : IList, ICollection, IEnumerable
{

	public bool AllowEdit
	{
		 get { } //Length: 0
	}

	public bool AllowNew
	{
		 get { } //Length: 0
	}

	public bool AllowRemove
	{
		 get { } //Length: 0
	}

	public bool IsSorted
	{
		 get { } //Length: 0
	}

	public ListSortDirection SortDirection
	{
		 get { } //Length: 0
	}

	public PropertyDescriptor SortProperty
	{
		 get { } //Length: 0
	}

	public bool SupportsChangeNotification
	{
		 get { } //Length: 0
	}

	public bool SupportsSearching
	{
		 get { } //Length: 0
	}

	public bool SupportsSorting
	{
		 get { } //Length: 0
	}

	public void AddIndex(PropertyDescriptor property) { }

	public object AddNew() { }

	public void ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	public int Find(PropertyDescriptor property, object key) { }

	public bool get_AllowEdit() { }

	public bool get_AllowNew() { }

	public bool get_AllowRemove() { }

	public bool get_IsSorted() { }

	public ListSortDirection get_SortDirection() { }

	public PropertyDescriptor get_SortProperty() { }

	public bool get_SupportsChangeNotification() { }

	public bool get_SupportsSearching() { }

	public bool get_SupportsSorting() { }

	public void RemoveIndex(PropertyDescriptor property) { }

	public void RemoveSort() { }

}

