namespace UnityEngine.UI.CoroutineTween;

internal interface ITweenValue
{

	public float duration
	{
		 get { } //Length: 0
	}

	public bool ignoreTimeScale
	{
		 get { } //Length: 0
	}

	public float get_duration() { }

	public bool get_ignoreTimeScale() { }

	public void TweenValue(float floatPercentage) { }

	public bool ValidTarget() { }

}

