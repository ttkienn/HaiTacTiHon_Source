namespace UnityEngine.UIElements.UIR;

internal enum CommandType
{
	Draw = 0,
	ImmediateCull = 1,
	Immediate = 2,
	PushView = 3,
	PopView = 4,
	PushScissor = 5,
	PopScissor = 6,
	PushRenderTexture = 7,
	PopRenderTexture = 8,
	BlitToPreviousRT = 9,
	PushDefaultMaterial = 10,
	PopDefaultMaterial = 11,
}

