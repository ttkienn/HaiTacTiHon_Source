namespace System.ComponentModel.Design;

public abstract class DesignerOptionService
{
	[DefaultMember("Item")]
	[Editor(null, "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[TypeConverter(typeof(DesignerOptionConverter))]
	internal sealed class DesignerOptionCollection : ICollection
	{
		private sealed class WrappedPropertyDescriptor : PropertyDescriptor
		{
			private object target; //Field offset: 0x88
			private PropertyDescriptor property; //Field offset: 0x90

			public virtual AttributeCollection Attributes
			{
				 get { } //Length: 45
			}

			public virtual Type ComponentType
			{
				 get { } //Length: 45
			}

			public virtual bool IsReadOnly
			{
				 get { } //Length: 45
			}

			public virtual Type PropertyType
			{
				 get { } //Length: 45
			}

			internal WrappedPropertyDescriptor(PropertyDescriptor property, object target) { }

			public virtual bool CanResetValue(object component) { }

			public virtual AttributeCollection get_Attributes() { }

			public virtual Type get_ComponentType() { }

			public virtual bool get_IsReadOnly() { }

			public virtual Type get_PropertyType() { }

			public virtual object GetValue(object component) { }

			public virtual void ResetValue(object component) { }

			public virtual void SetValue(object component, object value) { }

			public virtual bool ShouldSerializeValue(object component) { }

		}

		private DesignerOptionService _service; //Field offset: 0x10
		private string _name; //Field offset: 0x18
		private object _value; //Field offset: 0x20
		private ArrayList _children; //Field offset: 0x28
		private PropertyDescriptorCollection _properties; //Field offset: 0x30

		public override int Count
		{
			 get { } //Length: 55
		}

		public string Name
		{
			 get { } //Length: 5
		}

		public PropertyDescriptorCollection Properties
		{
			 get { } //Length: 1853
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 4
		}

		public override void CopyTo(Array array, int index) { }

		private void EnsurePopulated() { }

		public override int get_Count() { }

		public string get_Name() { }

		public PropertyDescriptorCollection get_Properties() { }

		public override IEnumerator GetEnumerator() { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

	}

	public sealed class DesignerOptionConverter : TypeConverter
	{
		private class OptionPropertyDescriptor : PropertyDescriptor
		{
			private DesignerOptionCollection _option; //Field offset: 0x88

			public virtual Type ComponentType
			{
				 get { } //Length: 32
			}

			public virtual bool IsReadOnly
			{
				 get { } //Length: 3
			}

			public virtual Type PropertyType
			{
				 get { } //Length: 32
			}

			internal OptionPropertyDescriptor(DesignerOptionCollection option) { }

			public virtual bool CanResetValue(object component) { }

			public virtual Type get_ComponentType() { }

			public virtual bool get_IsReadOnly() { }

			public virtual Type get_PropertyType() { }

			public virtual object GetValue(object component) { }

			public virtual void ResetValue(object component) { }

			public virtual void SetValue(object component, object value) { }

			public virtual bool ShouldSerializeValue(object component) { }

		}


		public DesignerOptionConverter() { }

		public virtual object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

		public virtual bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	}


	protected override void PopulateOptionCollection(DesignerOptionCollection options) { }

}

