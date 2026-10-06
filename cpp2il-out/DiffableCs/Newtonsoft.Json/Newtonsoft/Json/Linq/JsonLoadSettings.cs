namespace Newtonsoft.Json.Linq;

public class JsonLoadSettings
{
	private CommentHandling _commentHandling; //Field offset: 0x10
	private LineInfoHandling _lineInfoHandling; //Field offset: 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; //Field offset: 0x18

	public CommentHandling CommentHandling
	{
		 get { } //Length: 191
		 set { } //Length: 99
	}

	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public LineInfoHandling LineInfoHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public JsonLoadSettings() { }

	public CommentHandling get_CommentHandling() { }

	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

	public LineInfoHandling get_LineInfoHandling() { }

	public void set_CommentHandling(CommentHandling value) { }

	public void set_DuplicatePropertyNameHandling(DuplicatePropertyNameHandling value) { }

	public void set_LineInfoHandling(LineInfoHandling value) { }

}

