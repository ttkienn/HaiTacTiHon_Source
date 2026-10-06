namespace Unity.Services.Core;

internal static class UnityServicesBuilder
{
	public sealed class CreationDelegate : MulticastDelegate
	{

		public CreationDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string servicesId, AsyncCallback callback, object object) { }

		public override IUnityServices EndInvoke(IAsyncResult result) { }

		public override IUnityServices Invoke(string servicesId) { }

	}

	[CompilerGenerated]
	private static CreationDelegate <InstanceCreationDelegate>k__BackingField; //Field offset: 0x0

	internal static CreationDelegate InstanceCreationDelegate
	{
		[CompilerGenerated]
		internal get { } //Length: 54
		[CompilerGenerated]
		internal set { } //Length: 81
	}

	public static IUnityServices Create(string servicesId) { }

	[CompilerGenerated]
	internal static CreationDelegate get_InstanceCreationDelegate() { }

	[CompilerGenerated]
	internal static void set_InstanceCreationDelegate(CreationDelegate value) { }

}

