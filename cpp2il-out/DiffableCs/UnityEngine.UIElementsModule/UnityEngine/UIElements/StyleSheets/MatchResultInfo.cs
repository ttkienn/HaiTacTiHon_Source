namespace UnityEngine.UIElements.StyleSheets;

internal struct MatchResultInfo
{
	public readonly bool success; //Field offset: 0x0
	public readonly PseudoStates triggerPseudoMask; //Field offset: 0x4
	public readonly PseudoStates dependencyPseudoMask; //Field offset: 0x8

	public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }

}

