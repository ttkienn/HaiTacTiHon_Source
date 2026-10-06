namespace UnityEngine;

[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer
{

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	public int GetMeshes(out Mesh[] meshes) { }

}

