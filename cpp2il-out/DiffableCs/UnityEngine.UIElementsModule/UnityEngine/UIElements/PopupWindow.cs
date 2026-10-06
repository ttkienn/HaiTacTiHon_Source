namespace UnityEngine.UIElements;

public class PopupWindow : TextElement
{
	internal class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string contentUssClassName; //Field offset: 0x8
	private VisualElement m_ContentContainer; //Field offset: 0x4A0

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 10
	}

	private static PopupWindow() { }

	public PopupWindow() { }

	public virtual VisualElement get_contentContainer() { }

}

