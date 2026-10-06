namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
public sealed class RectTransformUtility
{
	private static readonly Vector3[] s_Corners; //Field offset: 0x0

	private static RectTransformUtility() { }

	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	private static Vector2 GetTransposed(Vector2 input) { }

	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

}

