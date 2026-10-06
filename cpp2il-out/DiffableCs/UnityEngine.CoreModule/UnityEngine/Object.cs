namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string name
	{
		 get { } //Length: 100
		 set { } //Length: 115
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(object obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(object target) { }

	public virtual bool Equals(object other) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	public static T FindObjectOfType() { }

	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	private static string GetName(object obj) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	public static T Instantiate(T original) { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static object Internal_CloneSingle(object data) { }

	private static bool IsNativeObjectAlive(object o) { }

	public static bool op_Equality(object x, object y) { }

	public static bool op_Implicit(object exists) { }

	public static bool op_Inequality(object x, object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	private static void SetName(object obj, string name) { }

	public virtual string ToString() { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(object obj) { }

}

