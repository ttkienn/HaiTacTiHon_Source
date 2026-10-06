namespace System.Linq.Expressions;

[DefaultMember("Item")]
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__18 : IEnumerator<Expression>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Expression <>2__current; //Field offset: 0x18
		public BlockExpressionList <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

		private override Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetEnumerator>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Expression System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly BlockExpression _block; //Field offset: 0x10
	private readonly Expression _arg0; //Field offset: 0x18

	public override int Count
	{
		 get { } //Length: 42
	}

	[ExcludeFromCodeCoverage]
	public override bool IsReadOnly
	{
		 get { } //Length: 39
	}

	public override Expression Item
	{
		 get { } //Length: 55
		[ExcludeFromCodeCoverage]
		 set { } //Length: 39
	}

	internal BlockExpressionList(BlockExpression provider, Expression arg0) { }

	[ExcludeFromCodeCoverage]
	public override void Add(Expression item) { }

	[ExcludeFromCodeCoverage]
	public override void Clear() { }

	public override bool Contains(Expression item) { }

	public override void CopyTo(Expression[] array, int index) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override Expression get_Item(int index) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__18))]
	public override IEnumerator<Expression> GetEnumerator() { }

	public override int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverage]
	public override void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverage]
	public override bool Remove(Expression item) { }

	[ExcludeFromCodeCoverage]
	public override void RemoveAt(int index) { }

	[ExcludeFromCodeCoverage]
	public override void set_Item(int index, Expression value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

