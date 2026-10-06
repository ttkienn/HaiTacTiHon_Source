namespace System.Data;

internal sealed class DataError
{
	public struct ColumnError
	{
		internal DataColumn _column; //Field offset: 0x0
		internal string _error; //Field offset: 0x8

	}

	private string _rowError; //Field offset: 0x10
	private int _count; //Field offset: 0x18
	private ColumnError[] _errorList; //Field offset: 0x20

	internal bool HasErrors
	{
		internal get { } //Length: 43
	}

	internal string Text
	{
		internal get { } //Length: 5
		internal set { } //Length: 92
	}

	internal DataError() { }

	internal DataError(string rowError) { }

	internal void Clear(DataColumn column) { }

	internal void Clear() { }

	internal bool get_HasErrors() { }

	internal string get_Text() { }

	internal string GetColumnError(DataColumn column) { }

	internal DataColumn[] GetColumnsInError() { }

	internal int IndexOf(DataColumn column) { }

	internal void set_Text(string value) { }

	internal void SetColumnError(DataColumn column, string error) { }

	private void SetText(string errorText) { }

}

