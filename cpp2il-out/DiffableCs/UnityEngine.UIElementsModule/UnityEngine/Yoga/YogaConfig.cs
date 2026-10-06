namespace UnityEngine.Yoga;

internal class YogaConfig
{
	internal static readonly YogaConfig Default; //Field offset: 0x0
	private IntPtr _ygConfig; //Field offset: 0x10
	private Logger _logger; //Field offset: 0x18

	internal IntPtr Handle
	{
		internal get { } //Length: 7
	}

	public float PointScaleFactor
	{
		 set { } //Length: 68
	}

	public bool UseWebDefaults
	{
		 get { } //Length: 52
		 set { } //Length: 67
	}

	private static YogaConfig() { }

	private YogaConfig(IntPtr ygConfig) { }

	public YogaConfig() { }

	protected virtual void Finalize() { }

	internal IntPtr get_Handle() { }

	public bool get_UseWebDefaults() { }

	public void set_PointScaleFactor(float value) { }

	public void set_UseWebDefaults(bool value) { }

}

