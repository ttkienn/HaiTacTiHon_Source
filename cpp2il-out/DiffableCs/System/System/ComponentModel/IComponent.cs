namespace System.ComponentModel;

[ComVisible(True)]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
[TypeConverter(typeof(ComponentConverter))]
public interface IComponent : IDisposable
{

	public ISite Site
	{
		 get { } //Length: 0
	}

	public ISite get_Site() { }

}

