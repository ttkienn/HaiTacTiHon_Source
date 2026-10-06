namespace UnityEngine.SceneManagement;

public class SceneManagerAPI
{
	private static SceneManagerAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static SceneManagerAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	internal static SceneManagerAPI ActiveAPI
	{
		internal get { } //Length: 167
	}

	public static SceneManagerAPI overrideAPI
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	private static SceneManagerAPI() { }

	protected private SceneManagerAPI() { }

	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	public static SceneManagerAPI get_overrideAPI() { }

	protected private override AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

}

