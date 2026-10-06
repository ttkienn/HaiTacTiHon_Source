namespace UnityEngine.UI;

public struct SpriteState : IEquatable<SpriteState>
{
	[SerializeField]
	private Sprite m_HighlightedSprite; //Field offset: 0x0
	[SerializeField]
	private Sprite m_PressedSprite; //Field offset: 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; //Field offset: 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; //Field offset: 0x18

	public Sprite disabledSprite
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Sprite highlightedSprite
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public Sprite pressedSprite
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Sprite selectedSprite
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public override bool Equals(SpriteState other) { }

	public Sprite get_disabledSprite() { }

	public Sprite get_highlightedSprite() { }

	public Sprite get_pressedSprite() { }

	public Sprite get_selectedSprite() { }

	public void set_disabledSprite(Sprite value) { }

	public void set_highlightedSprite(Sprite value) { }

	public void set_pressedSprite(Sprite value) { }

	public void set_selectedSprite(Sprite value) { }

}

