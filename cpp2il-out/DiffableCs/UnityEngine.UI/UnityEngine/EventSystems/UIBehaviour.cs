namespace UnityEngine.EventSystems;

public abstract class UIBehaviour : MonoBehaviour
{

	protected UIBehaviour() { }

	protected override void Awake() { }

	public override bool IsActive() { }

	public override bool IsDestroyed() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected override void OnCanvasGroupChanged() { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnDestroy() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnTransformParentChanged() { }

	protected override void Start() { }

}

