namespace UnityEngine;

public struct TextGenerationSettings
{
	public Font font; //Field offset: 0x0
	public Color color; //Field offset: 0x8
	public int fontSize; //Field offset: 0x18
	public float lineSpacing; //Field offset: 0x1C
	public bool richText; //Field offset: 0x20
	public float scaleFactor; //Field offset: 0x24
	public FontStyle fontStyle; //Field offset: 0x28
	public TextAnchor textAnchor; //Field offset: 0x2C
	public bool alignByGeometry; //Field offset: 0x30
	public bool resizeTextForBestFit; //Field offset: 0x31
	public int resizeTextMinSize; //Field offset: 0x34
	public int resizeTextMaxSize; //Field offset: 0x38
	public bool updateBounds; //Field offset: 0x3C
	public VerticalWrapMode verticalOverflow; //Field offset: 0x40
	public HorizontalWrapMode horizontalOverflow; //Field offset: 0x44
	public Vector2 generationExtents; //Field offset: 0x48
	public Vector2 pivot; //Field offset: 0x50
	public bool generateOutOfBounds; //Field offset: 0x58

	private bool CompareColors(Color left, Color right) { }

	private bool CompareVector2(Vector2 left, Vector2 right) { }

	public bool Equals(TextGenerationSettings other) { }

}

