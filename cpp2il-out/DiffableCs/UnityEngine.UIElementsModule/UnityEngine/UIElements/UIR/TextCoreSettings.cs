namespace UnityEngine.UIElements.UIR;

internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	public Color faceColor; //Field offset: 0x0
	public Color outlineColor; //Field offset: 0x10
	public float outlineWidth; //Field offset: 0x20
	public Color underlayColor; //Field offset: 0x24
	public Vector2 underlayOffset; //Field offset: 0x34
	public float underlaySoftness; //Field offset: 0x3C

	public virtual bool Equals(object obj) { }

	public override bool Equals(TextCoreSettings other) { }

	public virtual int GetHashCode() { }

}

