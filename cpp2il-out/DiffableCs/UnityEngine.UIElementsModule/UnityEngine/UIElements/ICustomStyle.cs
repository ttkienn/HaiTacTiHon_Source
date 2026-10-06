namespace UnityEngine.UIElements;

public interface ICustomStyle
{

	public bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

	public bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

	public bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

	public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

	public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

	public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

	public bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

}

