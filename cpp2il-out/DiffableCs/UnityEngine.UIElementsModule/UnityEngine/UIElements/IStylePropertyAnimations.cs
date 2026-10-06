namespace UnityEngine.UIElements;

internal interface IStylePropertyAnimations
{

	public int completedAnimationCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int runningAnimationCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void CancelAllAnimations() { }

	public void CancelAnimation(StylePropertyId id) { }

	public int get_completedAnimationCount() { }

	public int get_runningAnimationCount() { }

	public void GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	public void set_completedAnimationCount(int value) { }

	public void set_runningAnimationCount(int value) { }

	public bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	public void UpdateAnimation(StylePropertyId id) { }

}

