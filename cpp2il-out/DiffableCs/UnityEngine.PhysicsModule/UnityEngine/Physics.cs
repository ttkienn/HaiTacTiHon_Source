namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
public class Physics
{
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		public ContactEventDelegate(object object, IntPtr method) { }

		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x10
	private static readonly Collision s_ReusableCollision; //Field offset: 0x18

	[NativeProperty("DefaultPhysicsSceneHandle", True, TargetType::Function (0), True)]
	public static PhysicsScene defaultPhysicsScene
	{
		 get { } //Length: 108
	}

	public static bool invokeCollisionCallbacks
	{
		 get { } //Length: 42
	}

	public static bool reuseCollisionCallbacks
	{
		 get { } //Length: 42
	}

	private static Physics() { }

	public static PhysicsScene get_defaultPhysicsScene() { }

	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	public static bool get_invokeCollisionCallbacks() { }

	public static bool get_reuseCollisionCallbacks() { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Component GetBodyByInstanceID(int instanceID) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[NativeName("RaycastAll")]
	[StaticAccessor("GetPhysicsManager().GetPhysicsQuery()", StaticAccessorType::Dot (0))]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

}

