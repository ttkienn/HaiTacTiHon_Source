namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/UI Document")]
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
public sealed class UIDocument : MonoBehaviour
{
	internal const string k_RootStyleClassName = "unity-ui-document__root"; //Field offset: 0x0
	internal const string k_VisualElementNameSuffix = "-container"; //Field offset: 0x0
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	private static int s_CurrentUIDocumentCounter; //Field offset: 0x0
	internal readonly int m_UIDocumentCreationIndex; //Field offset: 0x20
	[SerializeField]
	private PanelSettings m_PanelSettings; //Field offset: 0x28
	private PanelSettings m_PreviousPanelSettings; //Field offset: 0x30
	[SerializeField]
	private UIDocument m_ParentUI; //Field offset: 0x38
	private UIDocumentList m_ChildrenContent; //Field offset: 0x40
	private List<UIDocument> m_ChildrenContentCopy; //Field offset: 0x48
	[SerializeField]
	private VisualTreeAsset sourceAsset; //Field offset: 0x50
	private VisualElement m_RootVisualElement; //Field offset: 0x58
	private int m_FirstChildInsertIndex; //Field offset: 0x60
	[SerializeField]
	private float m_SortingOrder; //Field offset: 0x64

	internal int firstChildInserIndex
	{
		internal get { } //Length: 4
	}

	public PanelSettings panelSettings
	{
		 get { } //Length: 7
		 set { } //Length: 716
	}

	public private UIDocument parentUI
	{
		 get { } //Length: 5
		private set { } //Length: 13
	}

	public VisualElement rootVisualElement
	{
		 get { } //Length: 7
	}

	public float sortingOrder
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public VisualTreeAsset visualTreeAsset
	{
		 get { } //Length: 7
		 set { } //Length: 37
	}

	private UIDocument() { }

	private void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	private void AddRootVisualElementToTree() { }

	internal void ApplySortingOrder() { }

	private void Awake() { }

	private UIDocument FindUIDocumentParent() { }

	internal int get_firstChildInserIndex() { }

	public PanelSettings get_panelSettings() { }

	public UIDocument get_parentUI() { }

	public VisualElement get_rootVisualElement() { }

	public float get_sortingOrder() { }

	public VisualTreeAsset get_visualTreeAsset() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnTransformChildrenChanged() { }

	private void OnTransformParentChanged() { }

	internal void ReactToHierarchyChanged() { }

	private void RecreateUI() { }

	private void RemoveChild(UIDocument child) { }

	private void RemoveFromHierarchy() { }

	internal void Reset() { }

	public void set_panelSettings(PanelSettings value) { }

	private void set_parentUI(UIDocument value) { }

	public void set_sortingOrder(float value) { }

	public void set_visualTreeAsset(VisualTreeAsset value) { }

	private void SetupFromHierarchy() { }

	private void SetupRootClassList() { }

}

