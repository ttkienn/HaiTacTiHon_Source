namespace System.ComponentModel;

public class ArrayConverter : CollectionConverter
{
	private class ArrayPropertyDescriptor : SimplePropertyDescriptor
	{
		private readonly int _index; //Field offset: 0x98

		public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index) { }

		public virtual object GetValue(object instance) { }

		public virtual void SetValue(object instance, object value) { }

	}


	public ArrayConverter() { }

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

