namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack
{
	public T[] itemStack; //Field offset: 0x0
	public int index; //Field offset: 0x0
	private T m_DefaultItem; //Field offset: 0x0
	private int m_Capacity; //Field offset: 0x0
	private int m_RolloverSize; //Field offset: 0x0
	private int m_Count; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 6
	}

	public T current
	{
		 get { } //Length: 69
	}

	public TextProcessingStack`1(T[] stack) { }

	public TextProcessingStack`1(int capacity) { }

	public TextProcessingStack`1(int capacity, int rolloverSize) { }

	public void Add(T item) { }

	public void Clear() { }

	public T CurrentItem() { }

	public int get_Count() { }

	public T get_current() { }

	public T Peek() { }

	public T Pop() { }

	public void Push(T item) { }

	public T Remove() { }

	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }

	public void SetDefault(T item) { }

}

