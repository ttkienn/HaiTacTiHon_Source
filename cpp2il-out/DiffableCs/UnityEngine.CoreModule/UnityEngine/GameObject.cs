namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : object
{

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 51
	}

	public bool activeSelf
	{
		[NativeMethod(Name = "IsSelfActive")]
		 get { } //Length: 51
	}

	public int layer
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public GameObject(string name, Type[] components) { }

	public GameObject() { }

	public GameObject(string name) { }

	public T AddComponent() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name) { }

	[NativeMethod(Name = "IsActive")]
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "IsSelfActive")]
	public bool get_activeSelf() { }

	public int get_layer() { }

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	public Transform get_transform() { }

	public T GetComponent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInParent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	public T GetComponentInParent(bool includeInactive) { }

	public T[] GetComponents() { }

	public void GetComponents(List<T> results) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void set_layer(int value) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value) { }

	public bool TryGetComponent(out T component) { }

	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

}

