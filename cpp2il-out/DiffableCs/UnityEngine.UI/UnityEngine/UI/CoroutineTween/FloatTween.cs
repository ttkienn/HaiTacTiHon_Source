namespace UnityEngine.UI.CoroutineTween;

internal struct FloatTween : ITweenValue
{
	internal class FloatTweenCallback : UnityEvent<Single>
	{

		public FloatTweenCallback() { }

	}

	private FloatTweenCallback m_Target; //Field offset: 0x0
	private float m_StartValue; //Field offset: 0x8
	private float m_TargetValue; //Field offset: 0xC
	private float m_Duration; //Field offset: 0x10
	private bool m_IgnoreTimeScale; //Field offset: 0x14

	public override float duration
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override bool ignoreTimeScale
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float startValue
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float targetValue
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public void AddOnChangedCallback(UnityAction<Single> callback) { }

	public override float get_duration() { }

	public override bool get_ignoreTimeScale() { }

	public float get_startValue() { }

	public float get_targetValue() { }

	public float GetDuration() { }

	public bool GetIgnoreTimescale() { }

	public void set_duration(float value) { }

	public void set_ignoreTimeScale(bool value) { }

	public void set_startValue(float value) { }

	public void set_targetValue(float value) { }

	public override void TweenValue(float floatPercentage) { }

	public override bool ValidTarget() { }

}

