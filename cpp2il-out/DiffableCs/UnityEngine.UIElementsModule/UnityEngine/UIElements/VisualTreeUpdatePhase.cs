namespace UnityEngine.UIElements;

internal enum VisualTreeUpdatePhase
{
	ViewData = 0,
	Bindings = 1,
	Animation = 2,
	Styles = 3,
	Layout = 4,
	TransformClip = 5,
	Repaint = 6,
	Count = 7,
}

