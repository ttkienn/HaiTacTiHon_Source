namespace System.ComponentModel;

public sealed class TypeDescriptor
{
	private sealed class AttributeFilterCacheItem
	{
		private Attribute[] _filter; //Field offset: 0x10
		internal ICollection FilteredMembers; //Field offset: 0x18

		internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers) { }

		internal bool IsValid(Attribute[] filter) { }

	}

	private sealed class FilterCacheItem
	{
		private ITypeDescriptorFilterService _filterService; //Field offset: 0x10
		internal ICollection FilteredMembers; //Field offset: 0x18

		internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

		internal bool IsValid(ITypeDescriptorFilterService filterService) { }

	}

	private interface IUnimplemented
	{

	}

	private sealed class MemberDescriptorComparer : IComparer
	{
		public static readonly MemberDescriptorComparer Instance; //Field offset: 0x0

		private static MemberDescriptorComparer() { }

		public MemberDescriptorComparer() { }

		public override int Compare(object left, object right) { }

	}

	private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
	{
		private ICustomTypeDescriptor _primary; //Field offset: 0x10
		private ICustomTypeDescriptor _secondary; //Field offset: 0x18

		internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

		private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

		private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

		private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

		private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

		private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

		private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

		private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

		private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	}

	private sealed class TypeDescriptionNode : TypeDescriptionProvider
	{
		private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node; //Field offset: 0x0
			private object _instance; //Field offset: 0x8

			internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance) { }

			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		private struct DefaultTypeDescriptor : ICustomTypeDescriptor
		{
			private TypeDescriptionNode _node; //Field offset: 0x0
			private Type _objectType; //Field offset: 0x8
			private object _instance; //Field offset: 0x10

			internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance) { }

			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		internal TypeDescriptionNode Next; //Field offset: 0x20
		internal TypeDescriptionProvider Provider; //Field offset: 0x28

		internal TypeDescriptionNode(TypeDescriptionProvider provider) { }

		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

		public virtual IDictionary GetCache(object instance) { }

		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

		protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

		public virtual Type GetReflectionType(Type objectType, object instance) { }

		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	}

	[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private sealed class TypeDescriptorComObject
	{

	}

	private sealed class TypeDescriptorInterface
	{

	}

	private static WeakHashtable _providerTable; //Field offset: 0x0
	private static Hashtable _providerTypeTable; //Field offset: 0x8
	private static Hashtable _defaultProviders; //Field offset: 0x10
	private static WeakHashtable _associationTable; //Field offset: 0x18
	private static int _metadataVersion; //Field offset: 0x20
	private static int _collisionIndex; //Field offset: 0x24
	private static BooleanSwitch TraceDescriptor; //Field offset: 0x28
	private static readonly Guid[] _pipelineInitializeKeys; //Field offset: 0x30
	private static readonly Guid[] _pipelineMergeKeys; //Field offset: 0x38
	private static readonly Guid[] _pipelineFilterKeys; //Field offset: 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; //Field offset: 0x48
	private static object _internalSyncObject; //Field offset: 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; //Field offset: 0x58

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type ComObjectType
	{
		 get { } //Length: 89
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type InterfaceType
	{
		 get { } //Length: 89
	}

	internal static int MetadataVersion
	{
		internal get { } //Length: 78
	}

	private static TypeDescriptor() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	private static void CheckDefaultProvider(Type type) { }

	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	public static Type get_ComObjectType() { }

	public static Type get_InterfaceType() { }

	internal static int get_MetadataVersion() { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static object GetAssociation(Type type, object primary) { }

	public static AttributeCollection GetAttributes(Type componentType) { }

	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	internal static IDictionary GetCache(object instance) { }

	public static TypeConverter GetConverter(Type type) { }

	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	public static EventDescriptorCollection GetEvents(Type componentType) { }

	public static EventDescriptorCollection GetEvents(object component) { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	private static Type GetNodeForBaseType(Type searchType) { }

	public static PropertyDescriptorCollection GetProperties(object component) { }

	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public static Type GetReflectionType(Type type) { }

	private static TypeDescriptionNode NodeFor(Type type) { }

	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	private static TypeDescriptionNode NodeFor(object instance) { }

	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	private static void RaiseRefresh(Type type) { }

	public static void Refresh(Type type) { }

	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	public static void SortDescriptorArray(IList infos) { }

}

