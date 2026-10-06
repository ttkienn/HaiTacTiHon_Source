namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 51
	}

	public Component() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	public T GetComponent() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	public T GetComponentInParent() { }

	public void GetComponents(Type type, List<Component> results) { }

	public void GetComponents(List<T> results) { }

	public T[] GetComponents() { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

}

