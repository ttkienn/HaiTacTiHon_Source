namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Shadow", 80)]
public class Shadow : BaseMeshEffect
{
	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	[SerializeField]
	private Color m_EffectColor; //Field offset: 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; //Field offset: 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; //Field offset: 0x40

	public Color effectColor
	{
		 get { } //Length: 11
		 set { } //Length: 156
	}

	public Vector2 effectDistance
	{
		 get { } //Length: 19
		 set { } //Length: 321
	}

	public bool useGraphicAlpha
	{
		 get { } //Length: 5
		 set { } //Length: 153
	}

	protected Shadow() { }

	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	public Color get_effectColor() { }

	public Vector2 get_effectDistance() { }

	public bool get_useGraphicAlpha() { }

	public virtual void ModifyMesh(VertexHelper vh) { }

	public void set_effectColor(Color value) { }

	public void set_effectDistance(Vector2 value) { }

	public void set_useGraphicAlpha(bool value) { }

}

