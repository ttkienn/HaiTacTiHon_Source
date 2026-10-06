namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		 set { } //Length: 66
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		 get { } //Length: 51
	}

	public bool loop
	{
		 set { } //Length: 66
	}

	public float volume
	{
		 set { } //Length: 67
	}

	[NativeName("IsPlayingScripting")]
	public bool get_isPlaying() { }

	[ExcludeFromDocs]
	public void Play() { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	public void set_clip(AudioClip value) { }

	public void set_loop(bool value) { }

	public void set_volume(float value) { }

	private void Stop(bool stopOneShots) { }

	public void Stop() { }

}

