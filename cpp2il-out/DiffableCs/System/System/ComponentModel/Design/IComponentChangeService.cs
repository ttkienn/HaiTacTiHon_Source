namespace System.ComponentModel.Design;

public interface IComponentChangeService
{

	public void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue) { }

	public void OnComponentChanging(object component, MemberDescriptor member) { }

}

