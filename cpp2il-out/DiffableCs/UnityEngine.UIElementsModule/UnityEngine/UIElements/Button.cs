namespace UnityEngine.UIElements;

public class Button : TextElement
{
	internal class UxmlFactory : UxmlFactory<Button, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private static readonly string NonEmptyString; //Field offset: 0x8
	private Clickable m_Clickable; //Field offset: 0x4A0

	public Clickable clickable
	{
		 get { } //Length: 10
		 set { } //Length: 124
	}

	private static Button() { }

	public Button() { }

	public Button(Action clickEvent) { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	public Clickable get_clickable() { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	public void set_clickable(Clickable value) { }

}

