namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
[RequiredByNativeCode]
public class VFXExpressionValues
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	private VFXExpressionValues() { }

	[RequiredByNativeCode]
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

}

