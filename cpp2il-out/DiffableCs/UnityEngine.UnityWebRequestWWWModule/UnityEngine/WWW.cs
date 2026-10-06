namespace UnityEngine;

[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable
{
	private UnityWebRequest _uwr; //Field offset: 0x10

	public string error
	{
		 get { } //Length: 284
	}

	public bool isDone
	{
		 get { } //Length: 29
	}

	public virtual bool keepWaiting
	{
		 get { } //Length: 36
	}

	public string text
	{
		 get { } //Length: 327
	}

	public string url
	{
		 get { } //Length: 29
	}

	public WWW(string url) { }

	public override void Dispose() { }

	public string get_error() { }

	public bool get_isDone() { }

	public virtual bool get_keepWaiting() { }

	public string get_text() { }

	public string get_url() { }

	private bool WaitUntilDoneIfPossible() { }

}

