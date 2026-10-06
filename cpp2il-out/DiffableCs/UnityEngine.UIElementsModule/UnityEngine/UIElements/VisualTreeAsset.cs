namespace UnityEngine.UIElements;

[HelpURL("UIE-VisualTree-landing")]
public class VisualTreeAsset : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public VisualElementAsset childVea; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <CloneSetupRecursively>b__0(SlotUsageEntry u) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass65_0
	{
		public VisualElementAsset asset; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <get_stylesheets>d__23 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private StyleSheet <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		private HashSet<StyleSheet> <sent>5__1; //Field offset: 0x30
		private Enumerator<VisualElementAsset> <>s__2; //Field offset: 0x38
		private VisualElementAsset <vea>5__3; //Field offset: 0x50
		private Enumerator<StyleSheet> <>s__4; //Field offset: 0x58
		private StyleSheet <stylesheet>5__5; //Field offset: 0x70
		private Enumerator<String> <>s__6; //Field offset: 0x78
		private string <stylesheetPath>5__7; //Field offset: 0x90
		private StyleSheet <stylesheet>5__8; //Field offset: 0x98

		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current
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
		public <get_stylesheets>d__23(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

		[DebuggerHidden]
		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_templateDependencies>d__19 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private VisualTreeAsset <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		private HashSet<VisualTreeAsset> <sent>5__1; //Field offset: 0x30
		private Enumerator<UsingEntry> <>s__2; //Field offset: 0x38
		private UsingEntry <entry>5__3; //Field offset: 0x60
		private VisualTreeAsset <vta>5__4; //Field offset: 0x78

		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current
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
		public <get_templateDependencies>d__19(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

		[DebuggerHidden]
		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct AssetEntry
	{
		[SerializeField]
		public string path; //Field offset: 0x0
		[SerializeField]
		public string typeFullName; //Field offset: 0x8
		[SerializeField]
		public object asset; //Field offset: 0x10
		private Type m_CachedType; //Field offset: 0x18

		public Type type
		{
			 get { } //Length: 154
		}

		public AssetEntry(string path, Type type, object asset) { }

		public Type get_type() { }

	}

	public struct SlotDefinition
	{
		[SerializeField]
		public string name; //Field offset: 0x0
		[SerializeField]
		public int insertionPointId; //Field offset: 0x8

	}

	public struct SlotUsageEntry
	{
		[SerializeField]
		public string slotName; //Field offset: 0x0
		[SerializeField]
		public int assetId; //Field offset: 0x8

	}

	public struct UsingEntry
	{
		internal static readonly IComparer<UsingEntry> comparer; //Field offset: 0x0
		[SerializeField]
		public string alias; //Field offset: 0x0
		[SerializeField]
		public string path; //Field offset: 0x8
		[SerializeField]
		public VisualTreeAsset asset; //Field offset: 0x10

		private static UsingEntry() { }

		public UsingEntry(string alias, string path) { }

	}

	private class UsingEntryComparer : IComparer<UsingEntry>
	{

		public UsingEntryComparer() { }

		public override int Compare(UsingEntry x, UsingEntry y) { }

	}

	public struct UxmlObjectEntry
	{
		[SerializeField]
		public int parentId; //Field offset: 0x0
		[SerializeField]
		public List<UxmlObjectAsset> uxmlObjectAssets; //Field offset: 0x8

		public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets) { }

	}

	internal static string LinkedVEAInTemplatePropertyName; //Field offset: 0x0
	private static readonly Dictionary<String, VisualElement> s_TemporarySlotInsertionPoints; //Field offset: 0x8
	[SerializeField]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; //Field offset: 0x19
	[SerializeField]
	private List<UsingEntry> m_Usings; //Field offset: 0x20
	[SerializeField]
	internal StyleSheet inlineSheet; //Field offset: 0x28
	[SerializeField]
	private List<VisualElementAsset> m_VisualElementAssets; //Field offset: 0x30
	[SerializeField]
	private List<TemplateAsset> m_TemplateAssets; //Field offset: 0x38
	[SerializeField]
	private List<UxmlObjectEntry> m_UxmlObjectEntries; //Field offset: 0x40
	[SerializeField]
	private List<Int32> m_UxmlObjectIds; //Field offset: 0x48
	[SerializeField]
	private List<AssetEntry> m_AssetEntries; //Field offset: 0x50
	[SerializeField]
	private List<SlotDefinition> m_Slots; //Field offset: 0x58
	[SerializeField]
	private int m_ContentContainerId; //Field offset: 0x60
	[SerializeField]
	private int m_ContentHash; //Field offset: 0x64

	internal int contentContainerId
	{
		internal get { } //Length: 6
		internal set { } //Length: 4
	}

	public int contentHash
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public internal bool importedWithErrors
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	public internal bool importedWithWarnings
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	internal List<SlotDefinition> slots
	{
		internal get { } //Length: 7
		internal set { } //Length: 13
	}

	public IEnumerable<StyleSheet> stylesheets
	{
		[IteratorStateMachine(typeof(<get_stylesheets>d__23))]
		 get { } //Length: 113
	}

	internal List<TemplateAsset> templateAssets
	{
		internal get { } //Length: 7
		internal set { } //Length: 13
	}

	public IEnumerable<VisualTreeAsset> templateDependencies
	{
		[IteratorStateMachine(typeof(<get_templateDependencies>d__19))]
		 get { } //Length: 868
	}

	internal List<UxmlObjectEntry> uxmlObjectEntries
	{
		internal get { } //Length: 5
	}

	internal List<Int32> uxmlObjectIds
	{
		internal get { } //Length: 5
	}

	internal List<VisualElementAsset> visualElementAssets
	{
		internal get { } //Length: 7
		internal set { } //Length: 13
	}

	private static VisualTreeAsset() { }

	public VisualTreeAsset() { }

	[CompilerGenerated]
	internal static VisualElement <Create>g__CreateError|65_0(ref <>c__DisplayClass65_0 unnamed_param_0) { }

	internal bool AssetEntryExists(string path, Type type) { }

	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<Int32, List`1<VisualElementAsset>> idToChildren, CreationContext context) { }

	internal void CloneTree(VisualElement target, Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverride> attributeOverrides) { }

	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	public void CloneTree(VisualElement target) { }

	public TemplateContainer CloneTree(string bindingPath) { }

	public TemplateContainer CloneTree() { }

	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	internal int get_contentContainerId() { }

	public int get_contentHash() { }

	public bool get_importedWithErrors() { }

	public bool get_importedWithWarnings() { }

	internal List<SlotDefinition> get_slots() { }

	[IteratorStateMachine(typeof(<get_stylesheets>d__23))]
	public IEnumerable<StyleSheet> get_stylesheets() { }

	internal List<TemplateAsset> get_templateAssets() { }

	[IteratorStateMachine(typeof(<get_templateDependencies>d__19))]
	public IEnumerable<VisualTreeAsset> get_templateDependencies() { }

	internal List<UxmlObjectEntry> get_uxmlObjectEntries() { }

	internal List<Int32> get_uxmlObjectIds() { }

	internal List<VisualElementAsset> get_visualElementAssets() { }

	internal T GetAsset(string path) { }

	internal int GetNextChildSerialNumber() { }

	internal UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	internal List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	public TemplateContainer Instantiate() { }

	public TemplateContainer Instantiate(string bindingPath) { }

	internal void RegisterAssetEntry(string path, Type type, object asset) { }

	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	internal void set_contentContainerId(int value) { }

	public void set_contentHash(int value) { }

	internal void set_importedWithErrors(bool value) { }

	internal void set_importedWithWarnings(bool value) { }

	internal void set_slots(List<SlotDefinition> value) { }

	internal void set_templateAssets(List<TemplateAsset> value) { }

	internal void set_visualElementAssets(List<VisualElementAsset> value) { }

	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

}

