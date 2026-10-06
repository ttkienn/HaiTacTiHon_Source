namespace UnityEngine;

public abstract class CustomYieldInstruction : IEnumerator
{

	public override object Current
	{
		 get { } //Length: 5
	}

	public abstract bool keepWaiting
	{
		 get { } //Length: 0
	}

	protected CustomYieldInstruction() { }

	public override object get_Current() { }

	public abstract bool get_keepWaiting() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

